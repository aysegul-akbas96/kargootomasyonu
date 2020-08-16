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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["SAdı"].Value.ToString();
            textBox1.Tag = satir.Cells["SevkiyatID"].Value;
            textBox2.Text = satir.Cells["SAlınanNokta"].Value.ToString();
            textBox3.Text = satir.Cells["SUlaşılacakNokta"].Value.ToString();
            textBox4.Text = satir.Cells["Mesafe"].Value.ToString();
            textBox5.Text = satir.Cells["MesafeTutarı"].Value.ToString();
            textBox6.Text = satir.Cells["SevkiyatTarihi"].Value.ToString();
            textBox7.Text = satir.Cells["AraçID"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sevkiyatlar.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sevkiyat ekle = new Sevkiyat();//entity de ki
            ekle.SAdı = textBox1.Text;
            ekle.SAlınanNokta = textBox2.Text;
            ekle.SUlaşılacakNokta = textBox3.Text;
            ekle.Mesafe =Convert.ToInt32(textBox4.Text);
            ekle.MesafeTutarı = Convert.ToDecimal(textBox5.Text);
            ekle.SevkiyatTarihi = textBox6.Text;
            ekle.AraçID = Convert.ToInt32(textBox7.Text);


            if (!Sevkiyatlar.Ekle(ekle))
            {
                MessageBox.Show("Veriler Eklenemedi....");

            }
            dataGridView1.DataSource = Sevkiyatlar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sevkiyat sil = new Sevkiyat();//entity de ki
            sil.SevkiyatID = (int)textBox1.Tag;

            if (!Sevkiyatlar.Sil(sil))

                MessageBox.Show("Veriler Silinemedi....");


            dataGridView1.DataSource = Sevkiyatlar.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sevkiyat yenile = new Sevkiyat();//entity de ki
            yenile.SevkiyatID = (int)textBox1.Tag;
            yenile.SAdı = textBox1.Text;
            yenile.SAlınanNokta = textBox2.Text;
            yenile.SUlaşılacakNokta = textBox3.Text;
            yenile.Mesafe = Convert.ToInt32(textBox4.Text);
            yenile.MesafeTutarı = Convert.ToDecimal(textBox5.Text);
            yenile.SevkiyatTarihi = textBox6.Text;
            yenile.AraçID = Convert.ToInt32(textBox7.Text);


            if (!Sevkiyatlar.Güncelle(yenile))
            
                MessageBox.Show("Veriler Güncellenemedi....");

            
            dataGridView1.DataSource = Sevkiyatlar.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 git = new Form5();
            git.Show();
            this.Hide();
        }
    }
}
