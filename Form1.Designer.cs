namespace Modul1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(24, 47);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(500, 350);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput.TabIndex = 1;
            this.pbInput.TabStop = false;
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(554, 47);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 350);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 2;
            this.pbOutput.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLocation,
            this.pictureSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1078, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileLocation
            // 
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(105, 25);
            this.fileLocation.Text = "FileLocation";
            // 
            // pictureSize
            // 
            this.pictureSize.Name = "pictureSize";
            this.pictureSize.Size = new System.Drawing.Size(96, 25);
            this.pictureSize.Text = "PictureSize";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Location = new System.Drawing.Point(0, 390);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1078, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.tentangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaToolStripMenuItem,
            this.simpanToolStripMenuItem,
            this.keluarAplikasiToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bukaToolStripMenuItem
            // 
            this.bukaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bukaToolStripMenuItem.Image")));
            this.bukaToolStripMenuItem.Name = "bukaToolStripMenuItem";
            this.bukaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bukaToolStripMenuItem.Text = "Buka";
            this.bukaToolStripMenuItem.Click += new System.EventHandler(this.BukaToolStripMenuItem_Click_1);
            // 
            // simpanToolStripMenuItem
            // 
            this.simpanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("simpanToolStripMenuItem.Image")));
            this.simpanToolStripMenuItem.Name = "simpanToolStripMenuItem";
            this.simpanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.simpanToolStripMenuItem.Text = "Simpan Sebagai ...";
            this.simpanToolStripMenuItem.Click += new System.EventHandler(this.SimpanToolStripMenuItem_Click);
            // 
            // keluarAplikasiToolStripMenuItem
            // 
            this.keluarAplikasiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keluarAplikasiToolStripMenuItem.Image")));
            this.keluarAplikasiToolStripMenuItem.Name = "keluarAplikasiToolStripMenuItem";
            this.keluarAplikasiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.keluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi";
            this.keluarAplikasiToolStripMenuItem.Click += new System.EventHandler(this.KeluarAplikasiToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.brightnessToolStripMenuItem});
            this.colorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorsToolStripMenuItem.Image")));
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(103, 30);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.grayscaleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("grayscaleToolStripMenuItem.Image")));
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("averageToolStripMenuItem.Image")));
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.averageToolStripMenuItem.Text = "Average";
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lightnessToolStripMenuItem.Image")));
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lightnessToolStripMenuItem.Text = "Lightness";
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("luminanceToolStripMenuItem.Image")));
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.luminanceToolStripMenuItem.Text = "Luminance";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrasToolStripMenuItem});
            this.brightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("brightnessToolStripMenuItem.Image")));
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.BrightnessToolStripMenuItem_Click);
            // 
            // contrasToolStripMenuItem
            // 
            this.contrasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contrasToolStripMenuItem.Image")));
            this.contrasToolStripMenuItem.Name = "contrasToolStripMenuItem";
            this.contrasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.contrasToolStripMenuItem.Text = "Contras";
            this.contrasToolStripMenuItem.Click += new System.EventHandler(this.ContrasToolStripMenuItem_Click);
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            this.tentangToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.tentangToolStripMenuItem.Text = "Tentang";
            this.tentangToolStripMenuItem.Click += new System.EventHandler(this.TentangToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 444);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.pbInput);
            this.Name = "Form1";
            this.Text = "Garuda Image Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel fileLocation;
        private System.Windows.Forms.ToolStripStatusLabel pictureSize;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
    }
}

