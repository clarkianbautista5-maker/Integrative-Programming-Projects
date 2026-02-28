namespace StudentGradeApp
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Namelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.appLabel = new System.Windows.Forms.Label();
            this.englishGrade = new System.Windows.Forms.TextBox();
            this.mathGrade = new System.Windows.Forms.TextBox();
            this.scienceGrade = new System.Windows.Forms.TextBox();
            this.filipinoGrade = new System.Windows.Forms.TextBox();
            this.historyGrade = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.showAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(93, 62);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(273, 20);
            this.txtboxName.TabIndex = 0;
            this.txtboxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Namelabel.Location = new System.Drawing.Point(26, 66);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(48, 16);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "English";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Math";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Science";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filipino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "History";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade";
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.ForeColor = System.Drawing.Color.Yellow;
            this.appLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.appLabel.Location = new System.Drawing.Point(152, 9);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(214, 20);
            this.appLabel.TabIndex = 9;
            this.appLabel.Text = "Student Grade Calculator";
            // 
            // englishGrade
            // 
            this.englishGrade.Location = new System.Drawing.Point(93, 138);
            this.englishGrade.Name = "englishGrade";
            this.englishGrade.Size = new System.Drawing.Size(100, 20);
            this.englishGrade.TabIndex = 10;
            // 
            // mathGrade
            // 
            this.mathGrade.Location = new System.Drawing.Point(93, 164);
            this.mathGrade.Name = "mathGrade";
            this.mathGrade.Size = new System.Drawing.Size(100, 20);
            this.mathGrade.TabIndex = 11;
            // 
            // scienceGrade
            // 
            this.scienceGrade.Location = new System.Drawing.Point(93, 190);
            this.scienceGrade.Name = "scienceGrade";
            this.scienceGrade.Size = new System.Drawing.Size(100, 20);
            this.scienceGrade.TabIndex = 12;
            // 
            // filipinoGrade
            // 
            this.filipinoGrade.Location = new System.Drawing.Point(93, 216);
            this.filipinoGrade.Name = "filipinoGrade";
            this.filipinoGrade.Size = new System.Drawing.Size(100, 20);
            this.filipinoGrade.TabIndex = 13;
            // 
            // historyGrade
            // 
            this.historyGrade.Location = new System.Drawing.Point(93, 242);
            this.historyGrade.Name = "historyGrade";
            this.historyGrade.Size = new System.Drawing.Size(100, 20);
            this.historyGrade.TabIndex = 14;
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.ForeColor = System.Drawing.Color.Black;
            this.resultButton.Location = new System.Drawing.Point(228, 304);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(95, 46);
            this.resultButton.TabIndex = 15;
            this.resultButton.Text = "Generate Average";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // showAverage
            // 
            this.showAverage.AutoSize = true;
            this.showAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAverage.ForeColor = System.Drawing.Color.White;
            this.showAverage.Location = new System.Drawing.Point(225, 171);
            this.showAverage.Name = "showAverage";
            this.showAverage.Size = new System.Drawing.Size(7, 13);
            this.showAverage.TabIndex = 16;
            this.showAverage.Text = "\r\n";
            this.showAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showAverage.Visible = false;
            this.showAverage.Click += new System.EventHandler(this.showAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.showAverage);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.historyGrade);
            this.Controls.Add(this.filipinoGrade);
            this.Controls.Add(this.scienceGrade);
            this.Controls.Add(this.mathGrade);
            this.Controls.Add(this.englishGrade);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.txtboxName);
            this.Name = "Form1";
            this.Text = "Student Grade Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.TextBox englishGrade;
        private System.Windows.Forms.TextBox mathGrade;
        private System.Windows.Forms.TextBox scienceGrade;
        private System.Windows.Forms.TextBox filipinoGrade;
        private System.Windows.Forms.TextBox historyGrade;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label showAverage;
    }
}

