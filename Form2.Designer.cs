namespace Modul1
{
    partial class frmBrightness
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hscBrightness = new System.Windows.Forms.HScrollBar();
            this.hscContrast = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrast";
            // 
            // hscBrightness
            // 
            this.hscBrightness.Location = new System.Drawing.Point(105, 13);
            this.hscBrightness.Maximum = 127;
            this.hscBrightness.Minimum = -127;
            this.hscBrightness.Name = "hscBrightness";
            this.hscBrightness.Size = new System.Drawing.Size(331, 26);
            this.hscBrightness.TabIndex = 2;
            this.hscBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscBrightness_Scroll);
            this.hscBrightness.ValueChanged += new System.EventHandler(this.HscBrightness_ValueChanged);
            // 
            // hscContrast
            // 
            this.hscContrast.Location = new System.Drawing.Point(105, 48);
            this.hscContrast.Maximum = 127;
            this.hscContrast.Minimum = -127;
            this.hscContrast.Name = "hscContrast";
            this.hscContrast.Size = new System.Drawing.Size(331, 26);
            this.hscContrast.TabIndex = 3;
            this.hscContrast.ValueChanged += new System.EventHandler(this.HscContrast_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmBrightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hscContrast);
            this.Controls.Add(this.hscBrightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBrightness";
            this.Text = "Brightness dan Contrast";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hscBrightness;
        private System.Windows.Forms.HScrollBar hscContrast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}