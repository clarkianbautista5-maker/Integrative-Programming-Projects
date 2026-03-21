namespace GuessWordApplication
{
    partial class frmGuessWord
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lstWrong = new System.Windows.Forms.ListBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblWrongGuess = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(64, 231);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(192, 29);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Location = new System.Drawing.Point(101, 287);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(120, 33);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.Black;
            this.lblWord.Location = new System.Drawing.Point(122, 136);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(56, 24);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "word";
            // 
            // lstWrong
            // 
            this.lstWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWrong.FormattingEnabled = true;
            this.lstWrong.ItemHeight = 18;
            this.lstWrong.Location = new System.Drawing.Point(311, 118);
            this.lstWrong.Name = "lstWrong";
            this.lstWrong.Size = new System.Drawing.Size(160, 202);
            this.lstWrong.TabIndex = 3;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.Transparent;
            this.lblTop.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Black;
            this.lblTop.Location = new System.Drawing.Point(120, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(226, 36);
            this.lblTop.TabIndex = 4;
            this.lblTop.Text = "Guess the word";
            // 
            // lblWrongGuess
            // 
            this.lblWrongGuess.AutoSize = true;
            this.lblWrongGuess.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongGuess.ForeColor = System.Drawing.Color.Black;
            this.lblWrongGuess.Location = new System.Drawing.Point(322, 91);
            this.lblWrongGuess.Name = "lblWrongGuess";
            this.lblWrongGuess.Size = new System.Drawing.Size(137, 24);
            this.lblWrongGuess.TabIndex = 5;
            this.lblWrongGuess.Text = "Wrong Guess";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(198, 384);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 33);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // frmGuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::GuessWordApplication.Properties.Resources.emerald_green_pokemon_game_map_9wtwfltdysyaa91k;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWrongGuess);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lstWrong);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Name = "frmGuessWord";
            this.Text = "Guess the word game";
            this.Load += new System.EventHandler(this.frmGuessWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.ListBox lstWrong;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblWrongGuess;
        private System.Windows.Forms.Button btnNewGame;
    }
}

