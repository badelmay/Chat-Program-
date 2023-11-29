using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giriş_Ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kullanıcı adı ve şifre kontrolü
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Kullanıcı adı veya şifre yanlış");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // PictureBox tıklandığında yapılacak işlemler
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Etiket tıklandığında yapılacak işlemler
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Form2 nesnesine geçiş yapar
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcı adı TextBox'ı metin değiştiğinde yapılacak işlemler
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Şifre TextBox'ı metin değiştiğinde yapılacak işlemler
            
        }
    }
}
