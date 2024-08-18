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

namespace _28_12_2023
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGHV42N\\SQLEXPRESS02;Initial Catalog=furkan;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 4 || textBox2.TextLength < 4)

            {
                MessageBox.Show("Kullanıcı adı veya şifre çok kısa");

            }
            else
            {
                conn.Open();
                string girisveri = "SELECT * FROM login WHERE eposta='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'";
                cmd = new SqlCommand(girisveri, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    new Form1().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgileri yanlış!");
                }
                conn.Close();
            }
        }
    }
}
