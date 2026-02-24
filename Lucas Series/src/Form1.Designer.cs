namespace WindowsFormsApp1
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.chckbox1 = new System.Windows.Forms.CheckBox();
            this.chckbox2 = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(61, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 16);
            this.lbl.TabIndex = 0;
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(64, 79);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(235, 22);
            this.txtbox.TabIndex = 1;
            this.txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_KeyPress);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(64, 130);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(235, 212);
            this.listbox.TabIndex = 2;
            // 
            // chckbox1
            // 
            this.chckbox1.AutoSize = true;
            this.chckbox1.Location = new System.Drawing.Point(356, 130);
            this.chckbox1.Name = "chckbox1";
            this.chckbox1.Size = new System.Drawing.Size(18, 17);
            this.chckbox1.TabIndex = 3;
            this.chckbox1.UseVisualStyleBackColor = true;
            this.chckbox1.CheckedChanged += new System.EventHandler(this.chckbox1_CheckedChanged);
            // 
            // chckbox2
            // 
            this.chckbox2.AutoSize = true;
            this.chckbox2.Location = new System.Drawing.Point(356, 174);
            this.chckbox2.Name = "chckbox2";
            this.chckbox2.Size = new System.Drawing.Size(18, 17);
            this.chckbox2.TabIndex = 4;
            this.chckbox2.UseVisualStyleBackColor = true;
            this.chckbox2.CheckedChanged += new System.EventHandler(this.chckbox2_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(356, 282);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(166, 44);
            this.btn.TabIndex = 5;
            this.btn.Text = "Generate";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(318, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "LUCAS SERIES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calculate only first 10 values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Calculate Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.chckbox2);
            this.Controls.Add(this.chckbox1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.CheckBox chckbox1;
        private System.Windows.Forms.CheckBox chckbox2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

