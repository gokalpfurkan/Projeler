using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySonKısım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            // label1.Text = db.TBLNOTLAR.Where(x => x.ORTALAMA < 50).
            // Max(y => y.ORTALAMA).ToString();      Kalan Öğrenciler Arasında En Yüksek Ortalamalı Öğrenci

            // label1.Text=db.TBLNOTLAR.Min(x=>x.SINAV1).ToString();    Min Kullanım

            //label1.Text= db.TBLNOTLAR.Max(x=>x.ORTALAMA).ToString();   Max Kullanım

            //var degeler = db.TBLOGRENCI.OrderBy(x=>x.SEHIR).GroupBy(x=>x.SEHIR)
            //    .Select(z=>new { Şehir =z.Key, Toplam=z.Count() });
            //dataGridView1.DataSource = degeler.ToList();

            //label1.Text = db.TBLURUN.Count().ToString();
            //label1.Text= db.TBLURUN.Sum(x=> x.STOK).ToString();
            //label1.Text = db.TBLURUN.Count(x=>x.AD == "BUZDOLABI").ToString();
            //label1.Text = db.TBLURUN.Average(x=>x.FIYAT).ToString();
            //label1.Text = db.TBLURUN.Where(x => x.AD == "BUZDOLABI").Average(y => y.FIYAT).ToString();
            //label1.Text = (from x in db.TBLURUN
            //             orderby x.STOK ascending
            //               select x.AD).First();
            dataGridView1.DataSource = db.Kulupler().ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLOGRENCI.OrderBy(x => x.SEHIR).GroupBy(y => y.SEHIR).Select(z => new
            {
                sehır = z.Key,
                toplam = z.Count()
            }).OrderByDescending(s => s.toplam);
            dataGridView1 .DataSource = degerler.ToList();

        }
    }
}
