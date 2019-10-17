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
    public partial class frmBrightness : Form
    {
        public frmBrightness()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void HscBrightness_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void HscContrast_ValueChanged(object sender, EventArgs e)
        {
            tbContrast.Text = HscContrast.Value.ToString();
        }

        private void HscBrightness_ValueChanged(object sender, EventArgs e)
        {
            tbBrightness.Text = HscBrightness.Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
