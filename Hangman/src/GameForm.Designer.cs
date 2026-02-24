namespace Hangman
{
    partial class GameForm
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
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelWordLength = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelWrongLetters = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.labelWordDisplay = new System.Windows.Forms.Label();
            this.buttonReturnToStart = new System.Windows.Forms.Button();
            this.labelGameInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHangman.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(1059, 693);
            this.pictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHangman.TabIndex = 0;
            this.pictureBoxHangman.TabStop = false;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTimer.ForeColor = System.Drawing.Color.Black;
            this.labelTimer.Location = new System.Drawing.Point(800, 20);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 25);
            this.labelTimer.TabIndex = 0;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(800, 50);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 25);
            this.labelScore.TabIndex = 1;
            // 
            // labelWordLength
            // 
            this.labelWordLength.AutoSize = true;
            this.labelWordLength.BackColor = System.Drawing.Color.Transparent;
            this.labelWordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWordLength.ForeColor = System.Drawing.Color.Black;
            this.labelWordLength.Location = new System.Drawing.Point(20, 20);
            this.labelWordLength.Name = "labelWordLength";
            this.labelWordLength.Size = new System.Drawing.Size(0, 25);
            this.labelWordLength.TabIndex = 2;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.Color.Transparent;
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHint.ForeColor = System.Drawing.Color.Black;
            this.labelHint.Location = new System.Drawing.Point(20, 100);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(0, 20);
            this.labelHint.TabIndex = 3;
            // 
            // labelWrongLetters
            // 
            this.labelWrongLetters.AutoSize = true;
            this.labelWrongLetters.BackColor = System.Drawing.Color.Transparent;
            this.labelWrongLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWrongLetters.ForeColor = System.Drawing.Color.Black;
            this.labelWrongLetters.Location = new System.Drawing.Point(20, 280);
            this.labelWrongLetters.Name = "labelWrongLetters";
            this.labelWrongLetters.Size = new System.Drawing.Size(0, 20);
            this.labelWrongLetters.TabIndex = 4;
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGuess.Location = new System.Drawing.Point(24, 190);
            this.textBoxGuess.MaxLength = 1;
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(50, 30);
            this.textBoxGuess.TabIndex = 5;
            this.textBoxGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuess.Location = new System.Drawing.Point(86, 190);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(120, 30);
            this.buttonGuess.TabIndex = 6;
            this.buttonGuess.Text = "Tahmin Et";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEndGame.Location = new System.Drawing.Point(12, 390);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(180, 36);
            this.buttonEndGame.TabIndex = 7;
            this.buttonEndGame.Text = "Oyunu Bitir";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // labelWordDisplay
            // 
            this.labelWordDisplay.AutoSize = true;
            this.labelWordDisplay.BackColor = System.Drawing.Color.Transparent;
            this.labelWordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWordDisplay.ForeColor = System.Drawing.Color.Black;
            this.labelWordDisplay.Location = new System.Drawing.Point(20, 130);
            this.labelWordDisplay.Name = "labelWordDisplay";
            this.labelWordDisplay.Size = new System.Drawing.Size(0, 46);
            this.labelWordDisplay.TabIndex = 8;
            // 
            // buttonReturnToStart
            // 
            this.buttonReturnToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReturnToStart.Location = new System.Drawing.Point(12, 430);
            this.buttonReturnToStart.Name = "buttonReturnToStart";
            this.buttonReturnToStart.Size = new System.Drawing.Size(180, 36);
            this.buttonReturnToStart.TabIndex = 9;
            this.buttonReturnToStart.Text = "Başlangıca Dön";
            this.buttonReturnToStart.UseVisualStyleBackColor = true;
            this.buttonReturnToStart.Click += new System.EventHandler(this.buttonReturnToStart_Click);
            // 
            // labelGameInfo
            // 
            this.labelGameInfo.AutoSize = true;
            this.labelGameInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameInfo.ForeColor = System.Drawing.Color.Black;
            this.labelGameInfo.Location = new System.Drawing.Point(20, 10);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(0, 29);
            this.labelGameInfo.TabIndex = 10;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 693);
            this.Controls.Add(this.labelGameInfo);
            this.Controls.Add(this.buttonReturnToStart);
            this.Controls.Add(this.labelWordDisplay);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelWrongLetters);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelWordLength);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.pictureBoxHangman);
            this.Name = "GameForm";
            this.Text = "Adam Asmaca Oyunu";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelWordLength;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelWrongLetters;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Label labelWordDisplay;
        private System.Windows.Forms.Button buttonReturnToStart;
        private System.Windows.Forms.Label labelGameInfo;
    }
}