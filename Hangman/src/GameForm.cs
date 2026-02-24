using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Hangman
{
    public partial class GameForm : Form
    {
        private Dictionary<string, (string[] words, string[] hints)> categories = new Dictionary<string, (string[] words, string[] hints)>
        {
            ["Hayvanlar"] = (
                new string[] { "ASLAN", "KAPLAN", "FİL", "ZEBRA", "ZÜRAFA", "PENGUEN", "KARTAL", "YILAN", "KÖPEK", "KEDİ", 
                             "MAYMUN", "PANDA", "KOALA", "KANGURU", "TİMSAH", "KAPLUMBAĞA", "TAVŞAN", "KURT", "AYI", "KURBAĞA" },
                new string[] { "Ormanların kralı", "Çizgili büyük kedi", "Uzun hortumlu hayvan", "Siyah beyaz çizgili", "Uzun boyunlu", 
                             "Kutuplarda yaşar", "Gökyüzünün hakimi", "Sürüngen", "İnsanın en iyi dostu", "Evcil hayvan", 
                             "Ağaçlarda yaşar", "Bambu yiyen", "Okaliptüs yiyen", "Keseli hayvan", "Sürüngen", 
                             "Kabuklu hayvan", "Uzun kulaklı", "Sürü halinde yaşar", "Ormanların güçlüsü", "Suda ve karada yaşar" }
            ),
            ["Meyveler"] = (
                new string[] { "ELMA", "ARMUT", "MUZ", "PORTAKAL", "MANDALİNA", "KİRAZ", "ÇİLEK", "KARPUZ", "KAVUN", "ÜZÜM", 
                             "ŞEFTALİ", "KAYISI", "İNCİR", "ANANAS", "MANGO", "LİMON", "GREYFURT", "BÖĞÜRTLEN", "AHUDUDU", "KİVİ" },
                new string[] { "Kırmızı veya yeşil olabilir", "Sulu ve tatlı", "Sarı ve uzun", "Turuncu narenciye", "Küçük turuncu", 
                             "Kırmızı küçük meyve", "Kırmızı ve çekirdekli", "Yaz meyvesi", "Sarı ve sulu", "Salkım halinde", 
                             "Tüylü kabuklu", "Turuncu küçük", "Mor veya yeşil", "Tropik meyve", "Tropik meyve", 
                             "Ekşi narenciye", "Acı narenciye", "Mor küçük meyve", "Kırmızı küçük meyve", "Kahverengi tüylü" }
            ),
            ["Ülkeler"] = (
                new string[] { "TÜRKİYE", "ALMANYA", "FRANSA", "İTALYA", "İSPANYA", "İNGİLTERE", "RUSYA", "ÇİN", "JAPONYA", "BREZİLYA", 
                             "ARJANTİN", "MISIR", "HİNDİSTAN", "KANADA", "MEKSİKA", "AVUSTRALYA", "YUNANİSTAN", "HOLLANDA", "BELÇİKA", "İSVEÇ" },
                new string[] { "İstanbul'u olan ülke", "Otomobil ülkesi", "Eyfel kulesi", "Pizza ülkesi", "Boğa güreşi", 
                             "Kraliyet ailesi", "En büyük ülke", "En kalabalık ülke", "Teknoloji ülkesi", "Amazon ormanları", 
                             "Tango dansı", "Piramitler", "Bollywood", "Akçaağaç şurubu", "Tacos", 
                             "Kangurular", "Antik Yunan", "Tulip", "Çikolata", "Kuzey ışıkları" }
            )
        };

        private string selectedWord;
        private string hint;
        private char[] guessedWord;
        private List<char> wrongGuesses = new List<char>();
        private int score = 100;
        private int wrongAttempts = 0;
        private int maxWrongAttempts;
        private int remainingTime;
        private Timer gameTimer;
        private string difficulty;
        private string category;
        private int timeInSeconds;

        public GameForm(string category, int timeInSeconds, int maxWrongAttempts, string difficulty)
        {
            InitializeComponent();
            this.category = category;
            this.timeInSeconds = timeInSeconds;
            this.difficulty = difficulty;
            this.maxWrongAttempts = maxWrongAttempts;
            
            // Rastgele kelime seç
            Random random = new Random();
            int index = random.Next(categories[category].words.Length);
            this.selectedWord = categories[category].words[index].ToUpper(new CultureInfo("tr-TR"));
            this.hint = categories[category].hints[index];
            
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHangman.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHangman.Width = pictureBoxHangman.Width / 3;
            pictureBoxHangman.Height = pictureBoxHangman.Height / 3;
            textBoxGuess.KeyPress += TextBoxGuess_KeyPress;
            SetupTimer();
            labelGameInfo.Text = $"Kategori: {category} | Zorluk: {difficulty} | Süre: {timeInSeconds} sn";
        }

        private void SetupTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            if (remainingTime <= 0)
            {
                GameOver("Süre bitti!");
            }
            UpdateDisplay();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            guessedWord = new char[selectedWord.Length];
            for (int i = 0; i < selectedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            wrongGuesses.Clear();
            score = 100;
            wrongAttempts = 0;

            remainingTime = timeInSeconds;
            labelTimer.Text = $"Kalan Süre: {remainingTime} saniye";
            gameTimer.Start();
            UpdateDisplay();
        }

        private void GameOver(string message)
        {
            gameTimer.Stop();
            this.BackColor = Color.Red;
            MessageBox.Show($"Oyun Bitti! {message}\nDoğru kelime: {selectedWord}", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void UpdateDisplay()
        {
            labelWordLength.Text = $"Kelime Uzunluğu: {selectedWord.Length} harf";
            labelHint.Text = $"İpucu: {hint}";
            labelWrongLetters.Text = "Yanlış Tahminler: " + string.Join(", ", wrongGuesses);
            labelScore.Text = $"Puan: {score}";
            labelWordDisplay.Text = string.Join(" ", guessedWord);
            labelTimer.Text = $"Kalan Süre: {remainingTime} saniye";
            labelWordLength.Text = $"Kategori: {category} - Zorluk: {difficulty} - {selectedWord.Length} harf";

            string imagePath;
            switch (difficulty)
            {
                case "Kolay":
                    switch (wrongAttempts)
                    {
                        case 0:
                            imagePath = Path.Combine(Application.StartupPath, "tower-1.png");
                            break;
                        case 1:
                            imagePath = Path.Combine(Application.StartupPath, "tower-2.png");
                            break;
                        case 2:
                            imagePath = Path.Combine(Application.StartupPath, "tower-3.png");
                            break;
                        case 3:
                            imagePath = Path.Combine(Application.StartupPath, "tower-4.png");
                            break;
                        case 4:
                            imagePath = Path.Combine(Application.StartupPath, "tower-5.png");
                            break;
                        case 5:
                            imagePath = Path.Combine(Application.StartupPath, "tower-6.png");
                            break;
                        case 6:
                            imagePath = Path.Combine(Application.StartupPath, "tower-7.png");
                            break;
                        case 7:
                            imagePath = Path.Combine(Application.StartupPath, "tower-8.png");
                            break;
                        case 8:
                            imagePath = Path.Combine(Application.StartupPath, "tower-9.png");
                            break;
                        case 9:
                            imagePath = Path.Combine(Application.StartupPath, "tower-10.png");
                            break;
                        case 10:
                            imagePath = Path.Combine(Application.StartupPath, "tower-11.png");
                            break;
                        case 11:
                            imagePath = Path.Combine(Application.StartupPath, "tower-12.png");
                            break;
                        default:
                            imagePath = Path.Combine(Application.StartupPath, "tower-12.png");
                            break;
                    }
                    break;
                case "Orta":
                    switch (wrongAttempts)
                    {
                        case 0:
                            imagePath = Path.Combine(Application.StartupPath, "man-01.jpg");
                            break;
                        case 1:
                            imagePath = Path.Combine(Application.StartupPath, "man-02.jpg");
                            break;
                        case 2:
                            imagePath = Path.Combine(Application.StartupPath, "man-03.jpg");
                            break;
                        case 3:
                            imagePath = Path.Combine(Application.StartupPath, "man-04.jpg");
                            break;
                        case 4:
                            imagePath = Path.Combine(Application.StartupPath, "man-05.jpg");
                            break;
                        case 5:
                            imagePath = Path.Combine(Application.StartupPath, "man-06.jpg");
                            break;
                        case 6:
                            imagePath = Path.Combine(Application.StartupPath, "man-07.jpg");
                            break;
                        case 7:
                            imagePath = Path.Combine(Application.StartupPath, "man-08.jpg");
                            break;
                        case 8:
                            imagePath = Path.Combine(Application.StartupPath, "man-09.jpg");
                            break;
                        case 9:
                            imagePath = Path.Combine(Application.StartupPath, "man-10.jpg");
                            break;
                        default:
                            imagePath = Path.Combine(Application.StartupPath, "man-10.jpg");
                            break;
                    }
                    break;
                case "Zor":
                    switch (wrongAttempts)
                    {
                        case 0:
                            imagePath = Path.Combine(Application.StartupPath, "adam-1.jpg");
                            break;
                        case 1:
                            imagePath = Path.Combine(Application.StartupPath, "adam-2.jpg");
                            break;
                        case 2:
                            imagePath = Path.Combine(Application.StartupPath, "adam-3.jpg");
                            break;
                        case 3:
                            imagePath = Path.Combine(Application.StartupPath, "adam-4.jpg");
                            break;
                        case 4:
                            imagePath = Path.Combine(Application.StartupPath, "adam-5.jpg");
                            break;
                        case 5:
                            imagePath = Path.Combine(Application.StartupPath, "adam-6.jpg");
                            break;
                        case 6:
                            imagePath = Path.Combine(Application.StartupPath, "adam-7.jpg");
                            break;
                        default:
                            imagePath = Path.Combine(Application.StartupPath, "adam-7.jpg");
                            break;
                    }
                    break;
                default:
                    imagePath = Path.Combine(Application.StartupPath, "adam-1.jpg");
                    break;
            }

            if (System.IO.File.Exists(imagePath))
            {
                pictureBoxHangman.Image = Image.FromFile(imagePath);
            }
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (textBoxGuess.Text.Length == 0)
            {
                MessageBox.Show("Lütfen bir harf girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!char.IsLetter(textBoxGuess.Text[0]))
            {
                MessageBox.Show("Lütfen sadece harf giriniz! (Sayı veya özel karakter kullanmayınız)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxGuess.Clear();
                return;
            }

            char guess = textBoxGuess.Text.ToUpper(new CultureInfo("tr-TR"))[0];
            textBoxGuess.Clear();

            if (wrongGuesses.Contains(guess) || guessedWord.Contains(guess))
            {
                MessageBox.Show("Bu harfi zaten tahmin ettiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;

            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    guessedWord[i] = selectedWord[i];
                    found = true;
                }
            }

            if (found)
            {
                if (!guessedWord.Contains('_'))
                {
                    gameTimer.Stop();
                    this.BackColor = Color.Green;
                    MessageBox.Show("Tebrikler, kazandınız!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                wrongGuesses.Add(guess);
                score -= 10;
                wrongAttempts++;

                if (wrongAttempts >= maxWrongAttempts)
                {
                    UpdateDisplay();
                    GameOver("Yanlış tahmin hakkınız bitti!");
                }
            }

            UpdateDisplay();
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyundan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gameTimer.Stop();
                Application.Exit();
            }
        }

        private void buttonReturnToStart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Başlangıç ekranına dönmek istediğinize emin misiniz?", 
                "Başlangıca Dön", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                gameTimer.Stop();
                this.Close();
            }
        }

        private void TextBoxGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harflere izin ver
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
