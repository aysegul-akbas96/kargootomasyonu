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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["ŞubeAdı"].Value.ToString();
            textBox1.Tag = satir.Cells["ŞubeID"].Value;
            textBox2.Text = satir.Cells["Şubeİl"].Value.ToString();
            textBox3.Text = satir.Cells["Şubeİlçe"].Value.ToString();
            textBox4.Text = satir.Cells["TeslimDurumu"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Şubeler.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Şube ekle = new Şube();//entity de ki
            ekle.ŞubeAdı = textBox1.Text;
            ekle.Şubeİl = textBox2.Text;
            ekle.Şubeİlçe = textBox3.Text;
            ekle.TeslimDurumu = textBox4.Text;


            if (!Şubeler.Ekle(ekle))
            {
                MessageBox.Show("Veriler Eklenemedi....");

            }
            dataGridView1.DataSource =Şubeler.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Şube sil = new Şube();
            sil.ŞubeID = (int)textBox1.Tag;
            if (!Şubeler.Sil(sil))
            {
                MessageBox.Show("Veriler Silinemedi....");

            }
            dataGridView1.DataSource = Şubeler.Listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Şube yenile= new Şube();//entity de ki
            yenile.ŞubeID = (int)textBox1.Tag;
            yenile.ŞubeAdı = textBox1.Text;
            yenile.Şubeİl = textBox2.Text;
            yenile.Şubeİlçe = textBox3.Text;
            yenile.TeslimDurumu = textBox4.Text;


            if (!Şubeler.Güncelle(yenile))
            {
                MessageBox.Show("Veriler Güncellenemedi....");

            }
            dataGridView1.DataSource = Şubeler.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form5 git = new Form5();
            git.Show();
            this.Hide();
        }
    }
}
