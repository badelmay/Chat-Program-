using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Giriş_Ekranı
{
    public partial class Form2 : Form
    {
        // Veritabanı bağlantı dizesini burada
        string baglantiDizesi = "Data Source=DESKTOP-LICDJFM\\SQLEXPRESS;Initial Catalog=KullaniciVeritabani;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Form1'e dönmek için
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcı adı veritabanındaki tabloya yerleştirilecek
            string kullaniciAdi = textBox1.Text;
            UpdateDatabase("KullaniciAdi", kullaniciAdi);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Telefon numarası veritabanındaki tabloya yerleştirilecek
            string telefonNumarasi = textBox4.Text;
            UpdateDatabase("TelefonNumarasi", telefonNumarasi);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Şifre veritabanındaki tabloya yerleştirilecek
            string sifre = textBox3.Text;
            UpdateDatabase("Sifre", sifre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tüm bilgileri veritabanındaki kayıta yerleştir
            string kullaniciAdi = textBox1.Text;
            string telefonNumarasi = textBox4.Text;
            string sifre = textBox3.Text;

            // Benzersiz bir ID oluştur
            int yeniID = GetUniqueID();

            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                try
                {
                    baglanti.Open();

                    // Tablo ve sütun adlarını kendi veritabanı yapınıza göre değiştirir
                    string sorgu = "INSERT INTO dbo.kullanici_bilgisi (ID, KullaniciAdi, TelefonNumarasi, Sifre) VALUES (@ID, @KullaniciAdi, @TelefonNumarasi, @Sifre)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ID", yeniID);
                        komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@TelefonNumarasi", telefonNumarasi);
                        komut.Parameters.AddWithValue("@Sifre", sifre);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            // Kayıt başarılıysa mesajı göster
                            MessageBox.Show("Kullanıcı bilgileri başarıyla kaydedildi! Yeni ID: " + yeniID.ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private int GetUniqueID()
        {
            // Bu metodunuzu kullanarak benzersiz bir ID oluşturabilirim
            // Burada örneğin, yeni bir GUID oluşturup onu integer'a çeviriyorum
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();
            return BitConverter.ToInt32(bytes, 0);
        }



        private void UpdateDatabase(string columnName, string value)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                try
                {
                    baglanti.Open();

                    // Tablo ve sütun adlarını kendi veritabanı yapıma göre değiştiriyorum
                    string sorgu = $"UPDATE dbo.kullanici_bilgisi SET {columnName} = @value";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@value", value);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            // Güncelleme başarılıysa mesajı göster
                            MessageBox.Show($"{columnName} başarıyla güncellendi!");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}