using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = "Fiyatını giriniz.";
            textBox1.ForeColor = Color.Gray;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var kategori in DepoVeri.KategoriliUrunler.Keys)
            {
                comboBox1.Items.Add(kategori);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 1000;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliKategori = comboBox1.SelectedItem.ToString();
            listBox1.Items.Clear();

            if (DepoVeri.KategoriliUrunler.ContainsKey(seciliKategori))
            {
                foreach (var urun in DepoVeri.KategoriliUrunler[seciliKategori])
                {
                    if (seciliKategori == "Meyve" || seciliKategori == "Sebze")
                    {
                        listBox1.Items.Add($"{urun.Ad} - Stok: {urun.Stok} - Maaliyet(kg): {urun.AlisFiyat}₺");
                    }
                    else if (seciliKategori == "İçecek")
                    {
                        listBox1.Items.Add($"{urun.Ad} - Stok: {urun.Stok} - Maaliyet(adet): {urun.AlisFiyat}₺");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kategori ve ürün seçin.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal satisFiyati) || satisFiyati <= 0)
            {
                MessageBox.Show("Geçerli bir satış fiyatı girin.");
                return;
            }

            int adet = (int)numericUpDown1.Value;
            if (adet <= 0)
            {
                MessageBox.Show("Geçerli bir adet girin.");
                return;
            }

            string kategori = comboBox1.SelectedItem.ToString();
            int urunIndex = listBox1.SelectedIndex;
            var urun = DepoVeri.KategoriliUrunler[kategori][urunIndex];

            if (urun.Stok < adet)
            {
                MessageBox.Show("Yeterli stok yok!");
                return;
            }

            urun.Stok -= adet;

            urun.Hareketler.Add(new SatisKaydi
            {
                IslemTuru = "Satım",
                Tarih = DateTime.Now,
                Adet = adet,
                FiyatBirim = satisFiyati
            });

            comboBox1_SelectedIndexChanged(null, null);

            decimal toplamKazanilan = satisFiyati * adet;

            if (kategori == "Meyve" || kategori == "Sebze")
            {
                MessageBox.Show($"{adet} kg {urun.Ad} satıldı. Toplam kazanç: {toplamKazanilan}₺");
            }
            else
            {
                MessageBox.Show($"{adet} adet {urun.Ad} satıldı. Toplam kazanç: {toplamKazanilan}₺");
            }
            
            numericUpDown1.Value = 1;
            textBox1.Clear();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Fiyatını giriniz.";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Fiyatını giriniz.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Fiyatını giriniz.";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
