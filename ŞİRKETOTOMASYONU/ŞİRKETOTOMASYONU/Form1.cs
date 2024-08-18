using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new ÜRÜNLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new MUSTERILER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }
    }
}
