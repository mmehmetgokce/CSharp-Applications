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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
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
                MessageBox.Show("Lütfen bir kategori ve ürün seçin.");
                return;
            }

            string seciliKategori = comboBox1.SelectedItem.ToString();
            int secilenIndex = listBox1.SelectedIndex;
            int eklenecekAdet = (int)numericUpDown1.Value;

            if (eklenecekAdet <= 0)
            {
                MessageBox.Show("Lütfen pozitif bir sayı girin.");
                return;
            }

            var urun = DepoVeri.KategoriliUrunler[seciliKategori][secilenIndex];

            urun.Stok += eklenecekAdet;

            urun.Hareketler.Add(new SatisKaydi
            {
                IslemTuru = "Alım",
                Tarih = DateTime.Now,
                Adet = eklenecekAdet,
                FiyatBirim = urun.AlisFiyat
            });

            comboBox1_SelectedIndexChanged(null, null);

            string kategori = comboBox1.SelectedItem.ToString();

            if (kategori == "Meyve" || kategori == "Sebze")
            {
                MessageBox.Show($"{eklenecekAdet} kg {urun.Ad} stoğa eklendi.");
            }
            else 
            {
                MessageBox.Show($"{eklenecekAdet} adet {urun.Ad} stoğa eklendi.");
            }

            numericUpDown1.Value = 1;

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
