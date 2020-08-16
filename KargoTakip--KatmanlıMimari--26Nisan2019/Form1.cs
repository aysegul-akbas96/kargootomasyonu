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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Araçlar.Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           Arac ekle = new Arac();//entity de ki
            ekle.AraçTürü = textBox2.Text;
            ekle.AraçKapasitesi= Convert.ToInt32(textBox3.Text);
            ekle.AraçŞoförü = textBox4.Text;

     
            if (!Araçlar.Ekle(ekle))
            {
                MessageBox.Show("Veriler Eklenemedi....");

            }
            dataGridView1.DataSource = Araçlar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arac sil = new Arac();//entity de ki
            sil.AraçID = Convert.ToInt32(textBox1.Text);

            if (!Araçlar.Sil(sil))
            
                MessageBox.Show("Veriler Silinemedi....");

            
            dataGridView1.DataSource = Araçlar.Listele();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["AraçID"].Value.ToString();
            textBox2.Text = satir.Cells["AraçTürü"].Value.ToString();
            textBox3.Text = satir.Cells["AraçKapasitesi"].Value.ToString();
            textBox4.Text = satir.Cells["AraçŞoförü"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arac yenile = new Arac();//entity de ki
            yenile.AraçID = Convert.ToInt32(textBox1.Text);
            yenile.AraçTürü = textBox2.Text;
            yenile.AraçKapasitesi=Convert.ToInt32(textBox3.Text);
            yenile.AraçŞoförü = textBox4.Text;

            if (!Araçlar.Güncelle(yenile))
                MessageBox.Show("Veriler Güncellenemedi....");


            dataGridView1.DataSource = Araçlar.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form5 git = new Form5();
            git.Show();
            this.Hide();
        }
    }
}
