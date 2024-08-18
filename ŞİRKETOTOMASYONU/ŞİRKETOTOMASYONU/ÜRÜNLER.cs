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
    public partial class ÜRÜNLER : Form
    {
        public ÜRÜNLER()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUN ", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ÜRÜNLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("insert into TBL_URUN (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYATI,SATISFIYATI) values ('"+TXTAD.Text+"','"+TXTMARKA.Text+"','"+TXTMODEL.Text+"','"+TXTYIL.Text+"','"+TXTADET.Text+"','"+TXTALIS.Text+"','"+TXTSATIS.Text+"')",bgl.baglanti());
            cm.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("update TBL_URUN set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYATI=@p6,SATISFIYATI=@p7 where ID=@p8", bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", TXTAD.Text);
            cm.Parameters.AddWithValue("@p2", TXTMARKA.Text);
            cm.Parameters.AddWithValue("@p3", TXTMODEL.Text);
            cm.Parameters.AddWithValue("@p4", TXTYIL.Text);
            cm.Parameters.AddWithValue("@p5", int.Parse(((TXTADET.Value).ToString())));
            cm.Parameters.AddWithValue("@p6", Decimal.Parse((TXTALIS.Text)));
            cm.Parameters.AddWithValue("@p7", Decimal.Parse((TXTSATIS.Text)));
            cm.Parameters.AddWithValue("@p8", txt.Text);

            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();
            if (basari == 1)
                MessageBox.Show("kayıt basarılı");
            else
                MessageBox.Show("kayıt basarısız");
            listele();
            TXTAD.Clear();
            TXTMARKA.Clear();
            TXTMODEL.Clear();
            TXTYIL.Clear();
            TXTALIS.Clear();
            TXTSATIS.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if ( txt.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("ALANI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SqlCommand komut = new SqlCommand("select * from TBL_URUN where ID = '" + txt.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("delete from TBL_URUN where ID = '" + txt.Text + "'", bgl.baglanti());
                    int basari = cm.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    if (basari == 1)
                        MessageBox.Show("ÜRÜN SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("ÜRÜN SİLİNMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("BÖYLE BİR ÜRÜN BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt.Clear();
            listele();
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXTMARKA.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTMODEL.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TXTYIL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TXTADET.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TXTALIS.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TXTSATIS.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
