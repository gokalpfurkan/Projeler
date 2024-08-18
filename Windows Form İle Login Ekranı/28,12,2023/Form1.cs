using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _28_12_2023
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGHV42N\\SQLEXPRESS02;Initial Catalog=furkan;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }
        public void sirala(string text)
        {
            conn.Open();
            if (String.IsNullOrEmpty(text))
            {
                adapter = new SqlDataAdapter("SELECT * FROM urunler", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            else
            {
                adapter = new SqlDataAdapter("SELECT * FROM urunler WHERE urunadi LIKE '" + text + "%'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            conn.Close();
        }
        public void kayitlar()
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM login", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sirala(null);
            kayitlar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ekle = "INSERT INTO urunler(urunadi,urunfiyati,urunadedi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox8.Text + "')";
            cmd = new SqlCommand(ekle, conn);

            if (textBox1.TextLength < 1 || textBox8.TextLength < 1 || textBox2.TextLength < 1)
            {
                MessageBox.Show("Bilgiler boş!");
            }
            else
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                sirala(null);
                MessageBox.Show("Başarılı");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string guncelle = "UPDATE urunler SET urunfiyati='" + textBox2.Text + "',urunadedi='" + textBox8.Text + "' WHERE urunadi='" + textBox1.Text + "'";
            cmd = new SqlCommand(guncelle, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            sirala(null);
            MessageBox.Show("Kayıt güncellendi!", "Başarılı", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sirala(textBox8.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string silme = "DELETE FROM urunler WHERE id=" + dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView2.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seçim boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                cmd = new SqlCommand(silme, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                sirala(null);
                MessageBox.Show("Kayıt Silindi!", "Başarılı", MessageBoxButtons.OK);
            }
           
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string ekle = "INSERT INTO login(adi,soyadi,eposta,sifre) VALUES ('" + textBox4.Text.Split(' ')[0] + "','" + textBox4.Text.Split(' ')[1] + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd = new SqlCommand(ekle, conn);

            if (textBox4.TextLength < 1 || textBox6.TextLength < 1 || textBox7.TextLength < 1)
            {
                MessageBox.Show("Bilgiler boş!");
            }
            else
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                kayitlar();
                MessageBox.Show("Başarılı");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string silme = "DELETE FROM login WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView2.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seçim boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                cmd = new SqlCommand(silme, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                kayitlar();
                MessageBox.Show("Kayıt Silindi!", "Başarılı", MessageBoxButtons.OK);
            }
        }
    }

}
