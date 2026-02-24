using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            if (radioButton1.Checked) {
                textBox2.Text = "1";
            }
            textBox1.KeyPress += textBox1_KeyPress;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)) 
            {
                e.Handled = true; 
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "";
            lbl2.Text = "";
            textBox2.Text="";
            if (radioButton1.Checked)
            {
                cipher.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                cipher.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            string encryptedMessage = "";
            if (string.IsNullOrEmpty(textBox1.Text)&&radioButton1.Checked==false&&radioButton3.Checked==false)
            {
                MessageBox.Show("Lütfen bir metin giriniz ve seçenek seçiniz!");
                return;
            }
            if ( radioButton1.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Lütfen bir seçenek seçiniz!");
                return;
            }


            if (radioButton1.Checked || radioButton3.Checked)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Lütfen bir metin giriniz!");
                    return;
                }

                int shift = 0;
                GetShiftValue(out shift); 

                EncryptText(textBox1.Text, shift, out encryptedMessage, ref success);

                
                if (success)
                {
                    lbl1.Text = "SUCCESS";
                    lbl1.BackColor = Color.Green;
                    lbl2.Text = encryptedMessage;
                }
                else
                {
                    lbl1.Text = "FAILED";
                    lbl1.BackColor = Color.Red;
                    lbl2.Text = "fail";
                }
            }
        }

        
        private void GetShiftValue(out int shift)
        {
            shift = 0;
            if (radioButton1.Checked)
            {
                if (!int.TryParse(textBox2.Text, out shift))
                {
                    shift = 1;
                }
            }
            else if (radioButton3.Checked)
            {
                shift = 3;
            }
        }

        
        private void EncryptText(string input, int shift, out string encryptedMessage, ref bool success)
        {
            StringBuilder encryptedBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                    char encryptedChar = (char)(baseChar + (ch - baseChar + shift) % 26);
                    encryptedBuilder.Append(encryptedChar);
                }
                else if (char.IsDigit(ch))
                {
                    int originalNumber = ch - '0';
                    int newNumber = (originalNumber + shift) ;
                    encryptedBuilder.Append(newNumber.ToString());
                }
                else
                {
                    char encryptedChar = (char)(ch + shift);
                    encryptedBuilder.Append(encryptedChar);
                }
            }

            encryptedMessage = encryptedBuilder.ToString();
            success = true;
        }

    }
}

