using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Yemek Sipariş Programı";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            listsiparis.SelectionMode = SelectionMode.MultiExtended;
        }
        private void txtisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }
        private void texttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtisim.Text) ||
                string.IsNullOrWhiteSpace(texttel.Text) ||
                listyiyecek.SelectedItem == null ||
                listil.SelectedItem == null ||
                listilçe.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tarihSaat = DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " tarihli siparişiniz oluşturuldu.";

            
            listsiparis.Items.Add(tarihSaat);
            listsiparis.Items.Add("İsim: " + txtisim.Text);
            listsiparis.Items.Add("Telefon: " + texttel.Text);
            listsiparis.Items.Add("Ürün: " + listyiyecek.SelectedItem);
            listsiparis.Items.Add("Adet: " + numericUpDown1.Value);
            listsiparis.Items.Add("İl: " + listil.SelectedItem);
            listsiparis.Items.Add("İlçe: " + listilçe.SelectedItem);

            
            listsiparis.Items.Add("------------------------------");
            

            
            MessageBox.Show("Sipariş başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtisim.Text = "";
            texttel.Text = "";
            listyiyecek.SelectedItem = null;
            listil.SelectedItem = null;
            listilçe.SelectedItem = null;
            numericUpDown1.Value = 1;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtisim.Text) &
                 !string.IsNullOrWhiteSpace(texttel.Text) &
                 listyiyecek.SelectedItem != null &
                 listil.SelectedItem != null &
                 listilçe.SelectedItem != null)
            {
                button1.BackColor = Color.DarkGreen;
            }
            }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private bool selecting = false;
        private void listsiparis_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (selecting || listsiparis.SelectedItem == null) return;

            selecting = true;

            int selectedIndex = listsiparis.SelectedIndex;
            if (selectedIndex == 0 || listsiparis.Items[selectedIndex].ToString().StartsWith("----------------"))
            {
                selecting = false;
                return;
            }

            int startIndex = selectedIndex;
            while (startIndex > 0 && !listsiparis.Items[startIndex].ToString().Contains("tarihli siparişiniz"))
            {
                startIndex--;
            }

            int endIndex = startIndex;
            while (endIndex < listsiparis.Items.Count && !listsiparis.Items[endIndex].ToString().StartsWith("----------------"))
            {
                endIndex++;
            }

            listsiparis.ClearSelected();

            for (int i = startIndex; i <= endIndex; i++)
            {
                listsiparis.SetSelected(i, true);
            }

            selecting = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listsiparis.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir sipariş seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili siparişi silmek istediğinize emin misiniz?",
                                                  "Sipariş Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            int secilenIndex = listsiparis.SelectedIndex;
            int baslangicIndex = (secilenIndex / 7) * 7;
            int bitisIndex = baslangicIndex + 7;

            if (bitisIndex >= listsiparis.Items.Count)
            {
                bitisIndex = listsiparis.Items.Count - 1;
            }

            for (int i = bitisIndex; i >= baslangicIndex; i--)
            {
                listsiparis.Items.RemoveAt(i);
            }

            MessageBox.Show("Seçili sipariş başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.BackColor = Color.Red;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if(listsiparis.SelectedIndex!=-1)
            {
                button2.BackColor = Color.DarkRed;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        
    }
    
}
