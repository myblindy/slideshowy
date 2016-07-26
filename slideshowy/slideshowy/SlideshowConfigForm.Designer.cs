namespace slideshowy
{
    partial class SlideshowConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideshowConfigForm));
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFolders
            // 
            this.lstFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.IntegralHeight = false;
            this.lstFolders.ItemHeight = 16;
            this.lstFolders.Location = new System.Drawing.Point(12, 29);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(483, 269);
            this.lstFolders.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slideshow Folders:";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.Location = new System.Drawing.Point(501, 29);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(107, 50);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFolder.Location = new System.Drawing.Point(501, 85);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(107, 50);
            this.btnRemoveFolder.TabIndex = 3;
            this.btnRemoveFolder.Text = "Remove Folder";
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Period (in sec):";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetIconAlignment(this.txtPeriod, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtPeriod.Location = new System.Drawing.Point(501, 235);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(107, 22);
            this.txtPeriod.TabIndex = 5;
            this.txtPeriod.Text = "5";
            this.txtPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.txtPeriod_Validating);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(501, 263);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(107, 35);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.ShowNewFolderButton = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SlideshowConfigForm
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 310);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnRemoveFolder);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFolders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SlideshowConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slideshow Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSlideshowConfig_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

