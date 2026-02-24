using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> saatDilimleri = new Dictionary<string, int>(); 
        private int seciliSaatFarki = 0; 
        private Color kullaniciRenk = Color.Black; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = int.MinValue; 
            numericUpDown1.Maximum = int.MaxValue;

            zamanlayici.Interval = 1000; 
            zamanlayici.Tick += zamanlayici_Tick;
            zamanlayici.Start();

            btnDilimiGuncelle.Enabled = false;
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            
            DateTime mevcutSaat = DateTime.Now.AddHours(seciliSaatFarki);
            Saat.Text = mevcutSaat.ToString("HH:mm:ss");

            // Saatin rengini belirleme
            if (mevcutSaat.Hour >= 8 && mevcutSaat.Hour < 20)
                Saat.ForeColor = kullaniciRenk;
            else
                Saat.ForeColor = Color.Black;
        }

        private void btnDilimiEkle_Click_1(object sender, EventArgs e)
        {
            string dilimAdi = txtbox.Text; 
            string secilenSaatDilimi = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(dilimAdi) && !saatDilimleri.ContainsKey(dilimAdi) && !string.IsNullOrEmpty(secilenSaatDilimi))
            {
                
                int saatFarki = SaatFarkiHesapla(secilenSaatDilimi);

                
                saatDilimleri.Add(dilimAdi, saatFarki);

                
                list.Items.Add($"{dilimAdi} (GMT {saatFarki:+#;-#;0})");

               
                comboBox1.Items.Add(dilimAdi);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir saat dilimi adı girin veya ComboBox'tan bir saat dilimi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int SaatFarkiHesapla(string saatDilimi)
        {
            
            if (saatDilimi.StartsWith("UTC"))
            {
                string farkStr = saatDilimi.Substring(4).Trim(); 
                if (int.TryParse(farkStr, out int saatFarki))
                {
                    return saatFarki;
                }
            }
            return 0; 
        }

        private void btnDilimiGuncelle_Click_1(object sender, EventArgs e)
        {
            if (list.SelectedIndex != -1) 
            {
                
                string secilenDilim = list.SelectedItem.ToString().Split(' ')[0];

                if (comboBox1.SelectedItem != null)
                {
                    string secilenComboBoxDilim = comboBox1.SelectedItem.ToString();
                    if (saatDilimleri.ContainsKey(secilenComboBoxDilim))
                    {
                        int yeniSaatFarki = saatDilimleri[secilenComboBoxDilim];

                        saatDilimleri[secilenDilim] = yeniSaatFarki;

                       
                        int index = list.SelectedIndex;
                        list.Items[index] = $"{secilenDilim} (GMT {yeniSaatFarki:+#;-#;0})";

                        
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == secilenDilim)
                            {
                                comboBox1.Items[i] = secilenDilim;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnDilimiSil_Click_1(object sender, EventArgs e)
        {
            while (list.CheckedItems.Count > 0)
            {
                string secilenDilim = list.CheckedItems[0].ToString().Split(' ')[0];
                list.Items.Remove(list.CheckedItems[0]);
                saatDilimleri.Remove(secilenDilim);
                comboBox1.Items.Remove(secilenDilim);
            }
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            if (renkSecici.ShowDialog() == DialogResult.OK)
            {
                kullaniciRenk = renkSecici.Color;
                Saat.ForeColor = kullaniciRenk;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string secilenDilimi = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(secilenDilimi) && saatDilimleri.ContainsKey(secilenDilimi))
            {
                
                int saatFarki = saatDilimleri[secilenDilimi];

                
                DateTime utcPlus3Saat = DateTime.UtcNow.AddHours(3);

               
                DateTime yeniSaat = utcPlus3Saat.AddHours(saatFarki);

                int saat = yeniSaat.Hour % 24;

                
                int gunFarki = yeniSaat.Hour / 24;

                
                DateTime yeniTarih = utcPlus3Saat.AddDays(gunFarki).AddHours(saatFarki % 24);

                dateTimePicker1.Value = new DateTime(
                    yeniTarih.Year,
                    yeniTarih.Month,
                    yeniTarih.Day,
                    saat,
                    yeniSaat.Minute,
                    yeniSaat.Second
                );

                
                Saat.Text = yeniSaat.ToString("HH:mm:ss");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            zamanlayici.Stop(); 
            seciliSaatFarki = (int)(dateTimePicker1.Value - DateTime.Now).TotalHours;
            zamanlayici.Start(); 
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedItem != null)
            {
                string secilenDilim = list.SelectedItem.ToString().Split(' ')[0];
                if (saatDilimleri.ContainsKey(secilenDilim))
                {
                    seciliSaatFarki = saatDilimleri[secilenDilim];
                    btnDilimiGuncelle.Enabled = true;
                }
            }
            else
            {
                btnDilimiGuncelle.Enabled = false;
            }
        }

        private void saatdegis_Click(object sender, EventArgs e)
        {
            
            DateTime utcPlus3Saat = DateTime.UtcNow.AddHours(3); 

            int saatFarki = (int)numericUpDown1.Value;

            DateTime yeniSaat = utcPlus3Saat.AddHours(saatFarki);

            
            int saat = yeniSaat.Hour % 24;

            
            int gunFarki = yeniSaat.Hour / 24; 

            
            DateTime yeniTarih = utcPlus3Saat.AddDays(gunFarki).AddHours(saatFarki % 24);

           
            dateTimePicker1.Value = new DateTime(
                yeniTarih.Year,
                yeniTarih.Month,
                yeniTarih.Day,
                saat,
                yeniSaat.Minute,
                yeniSaat.Second
            );

            
            Saat.Text = yeniSaat.ToString("HH:mm:ss");
        }



    }
}