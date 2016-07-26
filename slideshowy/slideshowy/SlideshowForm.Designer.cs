namespace slideshowy
{
    partial class SlideshowForm
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.SlideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Black;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(282, 253);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseDown);
            // 
            // SlideshowTimer
            // 
            this.SlideshowTimer.Enabled = true;
            this.SlideshowTimer.Tick += new System.EventHandler(this.SlideshowTimer_Tick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.Transparent;
            this.lblPath.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.Green;
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 18);
            this.lblPath.TabIndex = 2;
            // 
            // SlideshowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SlideshowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SlideshowForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SlideshowForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Timer SlideshowTimer;
        private System.Windows.Forms.Label lblPath;
    }
}