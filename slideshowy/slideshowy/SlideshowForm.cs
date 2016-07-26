using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slideshowy
{
    public partial class SlideshowForm : Form
    {
        private string[] Files;
        private Random Random = new Random();

        public SlideshowForm(string[] files, double period)
        {
            InitializeComponent();

            lblPath.Parent = Picture;

            Files = files;
            SlideshowTimer.Interval = (int)(period * 1000);
            SlideshowTimer_Tick(SlideshowTimer, EventArgs.Empty);
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e) => NextImage();

        private void NextImage()
        {
            Image img = null;
            string imgpath = null;
            int cnt = 0;

            // load the next image
            if (Files.Any())
                do
                {
                    imgpath = Files[Random.Next(Files.Length)];
                    try
                    {
                        img = Image.FromFile(imgpath);
                    }
                    catch { }
                } while (img == null && cnt++ < 10);

            Picture.Image = img;
            lblPath.Text = img == null ? "Could not find an image to load" : imgpath;
        }

        private void SlideshowForm_Load(object sender, EventArgs e)
        {
            var screen = Screen.FromControl(this);
            Location = screen.Bounds.Location;
            Size = screen.Bounds.Size;
        }

        private void SlideshowForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SlideshowTimer.Enabled = false;
                NextImage();
                SlideshowTimer.Enabled = true;
            }
        }
    }
}
