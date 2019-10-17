using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BukaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BukaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            if (DialogResult.OK == bukaFile.ShowDialog()) {
                this.pbInput.Image = new Bitmap(bukaFile.FileName);
                string location = bukaFile.FileName;
                var imageWidth = this.pbInput.Image.Width;
                var imageHeight = this.pbInput.Image.Height;

                fileLocation.Text = $"Picture Location : {location}";
                pictureSize.Text = $"Picture Size : {imageWidth} x {imageHeight}";
            }
        }

        private void SimpanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null) {
                MessageBox.Show("Tidak Ada citra yang akan disimpan");
            } else {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan File Citra";
                simpanFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == simpanFile.ShowDialog())
                    this.pbOutput.Image.Save(simpanFile.FileName);
            }
        }

        private void KeluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitracs.keBrightness(copy);
            this.pbOutput.Image = copy;
        }

        private void ContrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitracs.keBrightness(copy);
            this.pbOutput.Image = copy;
        }

        private void TentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tentang form2 = new Tentang();
            form2.Show();
        }
    }
}
