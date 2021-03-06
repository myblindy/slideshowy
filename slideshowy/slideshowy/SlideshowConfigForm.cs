﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using slideshowy.Properties;

namespace slideshowy
{
    public partial class SlideshowConfigForm : Form
    {
        private readonly string[] ImageFileExtensions =
            new[] { ".png", ".jpg", ".gif", ".bmp", ".emf", ".exif", ".jpeg", ".png", ".tiff", ".wmf", ".ico" };

        public SlideshowConfigForm()
        {
            InitializeComponent();

            txtPeriod.Text = Settings.Default.Period.ToString("0.##");
            if (Settings.Default.Folders != null)
                lstFolders.Items.AddRange(Settings.Default.Folders.Cast<string>().ToArray());
        }

        private double? Period
        {
            get
            {
                double period;
                return double.TryParse(txtPeriod.Text, out period) && period > 0 ? period : new double?();
            }
        }

        private void FrmSlideshowConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Folders = new System.Collections.Specialized.StringCollection();
            Settings.Default.Folders.AddRange(lstFolders.Items.Cast<string>().ToArray());
            Settings.Default.Period = Period ?? 5;
            Settings.Default.Save();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK && !lstFolders.Items.Cast<string>().Contains(FolderBrowser.SelectedPath))
                lstFolders.Items.Add(FolderBrowser.SelectedPath);
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.SelectedIndex >= 0)
                lstFolders.Items.RemoveAt(lstFolders.SelectedIndex);
        }

        private void txtPeriod_Validating(object sender, CancelEventArgs e) =>
            errorProvider1.SetError(txtPeriod, (e.Cancel = !Period.HasValue) ? "Please enter a number" : "");



        private void btnRun_Click(object sender, EventArgs e)
        {
            if (lstFolders.Items.Count == 0 || !Period.HasValue)
                return;

            var folders = lstFolders.Items.Cast<string>().ToArray();
            var files = new List<string>();

            var thread = new Thread(() =>
            {
                try
                {
                    var folderqueue = new Queue<string>(folders);
                    while (folderqueue.Any())
                    {
                        var path = folderqueue.Dequeue();

                        Win32API.WIN32_FIND_DATA ffd;
                        var hfind = Win32API.FindFirstFile(path + "\\*", out ffd);

                        if (hfind != Win32API.INVALID_HANDLE_VALUE)
                            do
                            {
                                if (ffd.dwFileAttributes.HasFlag(FileAttributes.Directory))
                                    folderqueue.Enqueue(Path.Combine(path, ffd.cFileName));
                                else
                                    lock (files)
                                        files.Add(Path.Combine(path, ffd.cFileName));
                            } while (Win32API.FindNextFile(hfind, out ffd));
                    }
                }
                catch (ThreadAbortException)
                {
                }
            })
            { Name = "File search thread" };
            thread.Start();
            Thread.Sleep(300);                              // give the searcher a bit of time to find some files

            //// find the folders
            //var folders = lstFolders.Items.Cast<string>()
            //    .SelectMany(path => Directory.GetDirectories(path, "*", SearchOption.AllDirectories).Concat(Enumerable.Repeat(path, 1)));

            //// gather the files
            //var files = folders
            //    .SelectMany(path => Directory.GetFiles(path))
            //    .Where(file => ImageFileExtensions.Any(ext => Path.GetExtension(file).Equals(ext, StringComparison.CurrentCultureIgnoreCase)))
            //    .ToArray();

            // and show the slideshow player
            new SlideshowForm(files, Period.Value).ShowDialog();

            thread.Abort();
        }
    }
}
