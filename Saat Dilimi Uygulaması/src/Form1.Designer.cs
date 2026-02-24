namespace week4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Saat = new System.Windows.Forms.Label();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.list = new System.Windows.Forms.CheckedListBox();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btnDilimiEkle = new System.Windows.Forms.Button();
            this.btnDilimiGuncelle = new System.Windows.Forms.Button();
            this.btnDilimiSil = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.renkSecici = new System.Windows.Forms.ColorDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saatdegis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saat
            // 
            this.Saat.AutoSize = true;
            this.Saat.Location = new System.Drawing.Point(177, 162);
            this.Saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Saat.Name = "Saat";
            this.Saat.Size = new System.Drawing.Size(44, 16);
            this.Saat.TabIndex = 0;
            this.Saat.Text = "label1";
            
            // 
            // zamanlayici
            // 
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(702, 92);
            this.list.Margin = new System.Windows.Forms.Padding(4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(282, 208);
            this.list.TabIndex = 1;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // txtbox
            // 
            this.txtbox.AcceptsTab = true;
            this.txtbox.Location = new System.Drawing.Point(702, 55);
            this.txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(132, 22);
            this.txtbox.TabIndex = 3;
            
            // 
            // btnDilimiEkle
            // 
            this.btnDilimiEkle.Location = new System.Drawing.Point(578, 375);
            this.btnDilimiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDilimiEkle.Name = "btnDilimiEkle";
            this.btnDilimiEkle.Size = new System.Drawing.Size(120, 28);
            this.btnDilimiEkle.TabIndex = 5;
            this.btnDilimiEkle.Text = "Dilim Ekle";
            this.btnDilimiEkle.UseVisualStyleBackColor = true;
            this.btnDilimiEkle.Click += new System.EventHandler(this.btnDilimiEkle_Click_1);
            // 
            // btnDilimiGuncelle
            // 
            this.btnDilimiGuncelle.Location = new System.Drawing.Point(729, 375);
            this.btnDilimiGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDilimiGuncelle.Name = "btnDilimiGuncelle";
            this.btnDilimiGuncelle.Size = new System.Drawing.Size(120, 28);
            this.btnDilimiGuncelle.TabIndex = 6;
            this.btnDilimiGuncelle.Text = "Dilimi Güncelle";
            this.btnDilimiGuncelle.UseVisualStyleBackColor = true;
            this.btnDilimiGuncelle.Click += new System.EventHandler(this.btnDilimiGuncelle_Click_1);
            // 
            // btnDilimiSil
            // 
            this.btnDilimiSil.Location = new System.Drawing.Point(885, 375);
            this.btnDilimiSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnDilimiSil.Name = "btnDilimiSil";
            this.btnDilimiSil.Size = new System.Drawing.Size(120, 28);
            this.btnDilimiSil.TabIndex = 7;
            this.btnDilimiSil.Text = "Dilimi Sil";
            this.btnDilimiSil.UseVisualStyleBackColor = true;
            this.btnDilimiSil.Click += new System.EventHandler(this.btnDilimiSil_Click_1);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(431, 375);
            this.btnRenkDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(120, 28);
            this.btnRenkDegistir.TabIndex = 8;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UTC -12",
            "UTC -11",
            "UTC -10",
            "UTC -9",
            "UTC -8",
            "UTC -7",
            "UTC -6",
            "UTC -5",
            "UTC -4",
            "UTC -3",
            "UTC -2",
            "UTC -1",
            "UTC +0",
            "UTC +1",
            "UTC +2",
            "UTC +3",
            "UTC +4",
            "UTC +5",
            "UTC +6",
            "UTC +7",
            "UTC +8",
            "UTC +9",
            "UTC +10",
            "UTC +11",
            "UTC +12",
            "UTC +13",
            "UTC +14"});
            this.comboBox1.Location = new System.Drawing.Point(862, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(431, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 11;
            
            // 
            // saatdegis
            // 
            this.saatdegis.Location = new System.Drawing.Point(431, 315);
            this.saatdegis.Name = "saatdegis";
            this.saatdegis.Size = new System.Drawing.Size(126, 35);
            this.saatdegis.TabIndex = 12;
            this.saatdegis.Text = "saati arttır azalt";
            this.saatdegis.UseVisualStyleBackColor = true;
            this.saatdegis.Click += new System.EventHandler(this.saatdegis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.saatdegis);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnDilimiSil);
            this.Controls.Add(this.btnDilimiGuncelle);
            this.Controls.Add(this.btnDilimiEkle);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.list);
            this.Controls.Add(this.Saat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saat;
        private System.Windows.Forms.Timer zamanlayici;
        private System.Windows.Forms.CheckedListBox list;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btnDilimiEkle;
        private System.Windows.Forms.Button btnDilimiGuncelle;
        private System.Windows.Forms.Button btnDilimiSil;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.ColorDialog renkSecici;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button saatdegis;
    }
}

