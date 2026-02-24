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
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var kategori in DepoVeri.KategoriliUrunler.Keys)
            {
                comboBox1.Items.Add(kategori);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            richTextBox1.ReadOnly = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliKategori = comboBox1.SelectedItem.ToString();

            richTextBox1.Clear();
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
            foreach (var urun in DepoVeri.KategoriliUrunler[seciliKategori])
            {
                foreach (var hareket in urun.Hareketler)
                {
                    richTextBox1.AppendText($"İşlem Tarihi: {hareket.Tarih.ToString("yyyy-MM-dd HH:mm:ss")}\n");
                    richTextBox1.AppendText($"Ürün Adı: {urun.Ad}\n");
                    richTextBox1.AppendText($"İşlem Türü: {hareket.IslemTuru}\n");
                    richTextBox1.AppendText($"Adet/Kg: {hareket.Adet}\n");
                    richTextBox1.AppendText($"Birim Fiyatı: {hareket.FiyatBirim}₺\n");

                    if (hareket.IslemTuru == "Alım")
                    {
                        richTextBox1.AppendText($"Toplam Maaliyet: {(hareket.Adet * hareket.FiyatBirim)}₺\n");
                    }
                    else if (hareket.IslemTuru == "Satım")
                    {
                        richTextBox1.AppendText($"Toplam Kazanç: {(hareket.Adet * hareket.FiyatBirim)}₺\n");
                    }

                    richTextBox1.AppendText("--------------------------------------\n");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
