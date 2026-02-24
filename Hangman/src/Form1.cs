using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
            LoadDifficulties();
            LoadTimes();
        }

        private void LoadCategories()
        {
            comboCategory.Items.AddRange(new string[] { "Hayvanlar", "Meyveler", "Ülkeler" });
            comboCategory.SelectedIndex = 0;
        }

        private void LoadDifficulties()
        {
            comboDifficulty.Items.AddRange(new string[] { "Kolay", "Orta", "Zor" });
            comboDifficulty.SelectedIndex = 0;
        }

        private void LoadTimes()
        {
            comboTime.Items.AddRange(new string[] { "60 saniye", "90 saniye", "120 saniye" });
            comboTime.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboCategory.SelectedItem.ToString();
            string selectedDifficulty = comboDifficulty.SelectedItem.ToString();
            string selectedTime = comboTime.SelectedItem.ToString();

            int timeInSeconds = int.Parse(selectedTime.Split(' ')[0]);
            int maxWrongAttempts = selectedDifficulty == "Kolay" ? 11 : (selectedDifficulty == "Orta" ? 9 : 7);

            GameForm gameForm = new GameForm(selectedCategory, timeInSeconds, maxWrongAttempts, selectedDifficulty);
            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }
    }
}
