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
using Kargo.ORM.Entity;
using Kargo.ORM.Facade;
namespace KargoTakip__KatmanlıMimari__26Nisan2019
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri sil = new Musteri();//entity de ki
            sil.MusteriID = (int)textBox1.Tag;

            if (!Musteriler.Sil(sil))

                MessageBox.Show("Veriler Silinemedi....");


            dataGridView1.DataSource = Musteriler.Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Musteriler.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri ekle = new Musteri();//entity de ki
            ekle.MusteriAdSoyadı = textBox1.Text;
            ekle.Adres = textBox2.Text;
            ekle.Telefon = Convert.ToInt32(textBox3.Text);
            ekle.Mail = textBox4.Text;
            ekle.ÖdemeDurumu = textBox5.Text;
            ekle.ŞubeID = Convert.ToInt32(textBox6.Text);
            ekle.SevkiyatID = Convert.ToInt32(textBox7.Text);


            if (!Musteriler.Ekle(ekle))
            {
                MessageBox.Show("Veriler Eklenemedi....");

            }
            dataGridView1.DataSource = Musteriler.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["MusteriAdSoyadı"].Value.ToString();
            textBox1.Tag = satir.Cells["MusteriID"].Value;
            textBox2.Text = satir.Cells["Adres"].Value.ToString();
            textBox3.Text = satir.Cells["Telefon"].Value.ToString();
            textBox4.Text = satir.Cells["Mail"].Value.ToString();
            textBox5.Text = satir.Cells["ÖdemeDurumu"].Value.ToString();
            textBox6.Text = satir.Cells["ŞubeID"].Value.ToString();
            textBox7.Text = satir.Cells["SevkiyatID"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteri ekle = new Musteri();//entity de ki
            ekle.MusteriID =(int) textBox1.Tag;
            ekle.MusteriAdSoyadı = textBox1.Text;
            ekle.Adres = textBox2.Text;
            ekle.Telefon = Convert.ToInt32(textBox3.Text);
            ekle.Mail = textBox4.Text;
            ekle.ÖdemeDurumu = textBox5.Text;
            ekle.ŞubeID = Convert.ToInt32(textBox6.Text);
            ekle.SevkiyatID = Convert.ToInt32(textBox7.Text);


            if (!Musteriler.Güncelle(ekle))
            {
                MessageBox.Show("Veriler Eklenemedi....");

            }
            dataGridView1.DataSource = Musteriler.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form5 git = new Form5();
            git.Show();
            this.Hide();
        }
    }
}
