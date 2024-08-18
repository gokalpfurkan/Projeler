using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ŞİRKETOTOMASYONU
{
    public partial class MUSTERILER : Form
    {
        public MUSTERILER()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERI ", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void illistesi()
        {
            SqlCommand cm = new SqlCommand("select sehir from iller ", bgl.baglanti());
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                TXTIL.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }







        private void MUSTERILER_Load(object sender, EventArgs e)
        {
            listele();
            illistesi();
        }

        private void TXTIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTILCE.Items.Clear();
            SqlCommand cm = new SqlCommand("select ilce from ilceler where sehir=@p1 ",bgl.baglanti());
            cm.Parameters.AddWithValue("@p1",TXTIL.SelectedIndex +1);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                TXTILCE.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTAD.Text == string.Empty)
                hata = 1;
            if (TXTSOYAD.Text == string.Empty)
                hata = 1;
            if (TXTELEFON.Text == string.Empty)
                hata = 1;
            if (TXTC.Text == string.Empty)
                hata = 1;
            if (TXTMAİL.Text == string.Empty)
                hata = 1;
            if (TXTIL.Text == string.Empty)
                hata = 1;
            if (TXTILCE.Text == string.Empty)
                hata = 1;
            if (TXTADRES.Text == string.Empty)
                hata = 1;
            if (TXTVERGI.Text == string.Empty)
                hata = 1;
            if(hata==1)
                MessageBox.Show("BÜTÜN ALANLARI DOLDUR","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                SqlCommand cm= new SqlCommand("insert into TBL_MUSTERI(AD,SOYAD,TELEFON,TC,MAİL,İL,İLÇE,ADRES,VERGİDAİRESİ)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
                cm.Parameters.AddWithValue("@P1",TXTAD.Text);
                cm.Parameters.AddWithValue("@P2", TXTSOYAD.Text);
                cm.Parameters.AddWithValue("@P3", TXTELEFON.Text);
                cm.Parameters.AddWithValue("@P4", TXTC.Text);
                cm.Parameters.AddWithValue("@P5", TXTMAİL.Text);
                cm.Parameters.AddWithValue("@P6", TXTIL.Text);
                cm.Parameters.AddWithValue("@P7", TXTILCE.Text);
                cm.Parameters.AddWithValue("@P8", TXTADRES.Text);
                cm.Parameters.AddWithValue("@P9", TXTVERGI.Text);
                int basari =cm.ExecuteNonQuery();
                if (basari == 1)
                    MessageBox.Show("KAYIT EKLENDİ", "MESAJ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                
                    MessageBox.Show("KAYIT EKLENEMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listele();
            TXTAD.Clear();
            TXTSOYAD.Clear();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXTSOYAD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTELEFON.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TXTC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TXTMAİL.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TXTIL.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TXTILCE.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TXTADRES.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            TXTVERGI.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txt.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("ALANLARI DOLDURUN","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                SqlCommand cm = new SqlCommand("select * from TBL_MUSTERI where ID=@p1",bgl.baglanti());
                cm.Parameters.AddWithValue("@p1", txt.Text);
                cm.ExecuteNonQuery();
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand km = new SqlCommand("delete  from TBL_MUSTERI where ID=@p1", bgl.baglanti());
                    km.Parameters.AddWithValue("@p1", txt.Text);
                    int basari = km.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    if (basari == 1)
                        MessageBox.Show("MÜŞTERİ SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("MÜŞTERİ SİLİNEMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("MÜŞTERİ BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
            txt.Clear();
            listele();
        }
    }
}
