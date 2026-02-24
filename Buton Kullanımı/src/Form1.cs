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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.haftaOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=name.Text +(" ")+surname.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string temp = name.Text;
            name.Text = surname.Text;
            surname.Text = temp;

            
            label1.Text = name.Text + " " + surname.Text;
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            label1.ForeColor = label1.ForeColor == Color.Red ? Color.Black : Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 15);
        }
    }
}
