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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chckbox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n;
            if (int.TryParse(txtbox.Text, out n) && n > 0)
            {

                int[] lucasSeries = GenerateLucasSeries(n);

                listbox.Items.Clear();
                listbox.Items.AddRange(lucasSeries.Select(x => x.ToString()).ToArray());

                if (chckbox1.Checked)
                {
                    double average = lucasSeries.Average();
                    label4.Text = $"Average: {average:F2}";
                }
                else
                {
                    label4.Text = "";
                }
            }
        }

        private int[] GenerateLucasSeries(int n)
        {
            int[] series = new int[n];

            series[0] = 2;
            if (n > 1) series[1] = 1;

            for (int i = 2; i < n; i++)
            {
                series[i] = series[i - 1] + series[i - 2];
            }

            return series;
        }

        private void chckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox1.Checked == false)
            {
                label4.Text = "Average: 0.00";
            }
            if (chckbox1.Checked)
            {
                btn.Text = "Generate and Calculate";
            }
            else
            {
                btn.Text = "Generate";
            }
        }

        private void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chckbox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chckbox2.Checked == false)
            {
                label4.Text = "Average: 0.00";
            }
            
            if (chckbox2.Checked)
            {
                txtbox.Text = "10";
                txtbox.Enabled = false;

                int[] lucasSeries = new int[10];
                lucasSeries[0] = 2;
                lucasSeries[1] = 1;

                for (int i = 2; i < 10; i++)
                {
                    lucasSeries[i] = lucasSeries[i - 1] + lucasSeries[i - 2];
                }

                listbox.Items.Clear();
                foreach (int num in lucasSeries)
                {
                    listbox.Items.Add(num);
                }
            }
            else
            {
                txtbox.Text = "";
                txtbox.Enabled = true;
                listbox.Items.Clear();
            }
        }
    }
}
