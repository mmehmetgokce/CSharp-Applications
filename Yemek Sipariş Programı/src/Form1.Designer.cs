namespace lab5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtisim = new System.Windows.Forms.TextBox();
            this.listyiyecek = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listil = new System.Windows.Forms.ListBox();
            this.listilçe = new System.Windows.Forms.ListBox();
            this.listsiparis = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texttel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(54, 92);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(164, 22);
            this.txtisim.TabIndex = 0;
            this.txtisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtisim_KeyPress);
            // 
            // listyiyecek
            // 
            this.listyiyecek.DisplayMember = "pizza";
            this.listyiyecek.FormattingEnabled = true;
            this.listyiyecek.ItemHeight = 16;
            this.listyiyecek.Items.AddRange(new object[] {
            "Pizza",
            "Hamburger",
            "Döner"});
            this.listyiyecek.Location = new System.Drawing.Point(461, 92);
            this.listyiyecek.Name = "listyiyecek";
            this.listyiyecek.Size = new System.Drawing.Size(120, 84);
            this.listyiyecek.TabIndex = 1;
            this.listyiyecek.ValueMember = "pizza";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(461, 214);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // listil
            // 
            this.listil.DisplayMember = "pizza";
            this.listil.FormattingEnabled = true;
            this.listil.ItemHeight = 16;
            this.listil.Items.AddRange(new object[] {
            "Eskişehir",
            "Bursa"});
            this.listil.Location = new System.Drawing.Point(54, 188);
            this.listil.Name = "listil";
            this.listil.Size = new System.Drawing.Size(164, 100);
            this.listil.TabIndex = 4;
            // 
            // listilçe
            // 
            this.listilçe.DisplayMember = "pizza";
            this.listilçe.FormattingEnabled = true;
            this.listilçe.ItemHeight = 16;
            this.listilçe.Items.AddRange(new object[] {
            "Tepebaşı",
            "Odunpazarı"});
            this.listilçe.Location = new System.Drawing.Point(251, 188);
            this.listilçe.Name = "listilçe";
            this.listilçe.Size = new System.Drawing.Size(164, 100);
            this.listilçe.TabIndex = 5;
            this.listilçe.ValueMember = "pizza";
            // 
            // listsiparis
            // 
            this.listsiparis.FormattingEnabled = true;
            this.listsiparis.ItemHeight = 16;
            this.listsiparis.Location = new System.Drawing.Point(630, 92);
            this.listsiparis.Name = "listsiparis";
            this.listsiparis.Size = new System.Drawing.Size(307, 196);
            this.listsiparis.TabIndex = 6;
            this.listsiparis.SelectedIndexChanged += new System.EventHandler(this.listsiparis_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(955, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sipariş Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşteri Ad-Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(247, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Müşteri Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(457, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yiyecekler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(457, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres İl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(247, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adres İlçe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(626, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Siparişlerim";
            // 
            // texttel
            // 
            this.texttel.Location = new System.Drawing.Point(251, 92);
            this.texttel.MaxLength = 11;
            this.texttel.Name = "texttel";
            this.texttel.Size = new System.Drawing.Size(164, 22);
            this.texttel.TabIndex = 15;
            this.texttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texttel_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(955, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sipariş Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1185, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.texttel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listsiparis);
            this.Controls.Add(this.listilçe);
            this.Controls.Add(this.listil);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listyiyecek);
            this.Controls.Add(this.txtisim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.ListBox listyiyecek;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listil;
        private System.Windows.Forms.ListBox listilçe;
        private System.Windows.Forms.ListBox listsiparis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

