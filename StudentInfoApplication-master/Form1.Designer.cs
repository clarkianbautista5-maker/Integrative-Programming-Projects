namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            this.lblStudentInformation = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstStudentNumber = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstFirstName = new System.Windows.Forms.ListBox();
            this.lstLastName = new System.Windows.Forms.ListBox();
            this.lblTotalStudentsCounter = new System.Windows.Forms.Label();
            this.lblNewStudentsCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentInformation
            // 
            this.lblStudentInformation.AutoSize = true;
            this.lblStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentInformation.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInformation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStudentInformation.Location = new System.Drawing.Point(12, 9);
            this.lblStudentInformation.Name = "lblStudentInformation";
            this.lblStudentInformation.Size = new System.Drawing.Size(234, 28);
            this.lblStudentInformation.TabIndex = 0;
            this.lblStudentInformation.Text = "Student Information";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(31, 209);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(174, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit ➤";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstStudentNumber
            // 
            this.lstStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstStudentNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudentNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstStudentNumber.FormattingEnabled = true;
            this.lstStudentNumber.ItemHeight = 15;
            this.lstStudentNumber.Location = new System.Drawing.Point(42, 280);
            this.lstStudentNumber.Name = "lstStudentNumber";
            this.lstStudentNumber.Size = new System.Drawing.Size(131, 154);
            this.lstStudentNumber.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(31, 170);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 23);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(31, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 23);
            this.txtLastName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudentID.Location = new System.Drawing.Point(31, 76);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(174, 23);
            this.txtStudentID.TabIndex = 5;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFirstname.Location = new System.Drawing.Point(27, 56);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(81, 19);
            this.lblFirstname.TabIndex = 6;
            this.lblFirstname.Text = "Student ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLastName.Location = new System.Drawing.Point(27, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 19);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(248, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(248, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(239, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Statistics";
            // 
            // lstFirstName
            // 
            this.lstFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstFirstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstFirstName.FormattingEnabled = true;
            this.lstFirstName.ItemHeight = 15;
            this.lstFirstName.Location = new System.Drawing.Point(179, 280);
            this.lstFirstName.Name = "lstFirstName";
            this.lstFirstName.Size = new System.Drawing.Size(131, 154);
            this.lstFirstName.TabIndex = 13;
            // 
            // lstLastName
            // 
            this.lstLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstLastName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.ItemHeight = 15;
            this.lstLastName.Location = new System.Drawing.Point(316, 280);
            this.lstLastName.Name = "lstLastName";
            this.lstLastName.Size = new System.Drawing.Size(131, 154);
            this.lstLastName.TabIndex = 14;
            // 
            // lblTotalStudentsCounter
            // 
            this.lblTotalStudentsCounter.AutoSize = true;
            this.lblTotalStudentsCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStudentsCounter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudentsCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalStudentsCounter.Location = new System.Drawing.Point(248, 94);
            this.lblTotalStudentsCounter.Name = "lblTotalStudentsCounter";
            this.lblTotalStudentsCounter.Size = new System.Drawing.Size(20, 23);
            this.lblTotalStudentsCounter.TabIndex = 15;
            this.lblTotalStudentsCounter.Text = "0";
            // 
            // lblNewStudentsCounter
            // 
            this.lblNewStudentsCounter.AutoSize = true;
            this.lblNewStudentsCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblNewStudentsCounter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStudentsCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNewStudentsCounter.Location = new System.Drawing.Point(248, 145);
            this.lblNewStudentsCounter.Name = "lblNewStudentsCounter";
            this.lblNewStudentsCounter.Size = new System.Drawing.Size(20, 23);
            this.lblNewStudentsCounter.TabIndex = 16;
            this.lblNewStudentsCounter.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(38, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student ID List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(312, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(175, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "First Name List";
            // 
            // btnClearRecords
            // 
            this.btnClearRecords.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearRecords.FlatAppearance.BorderSize = 0;
            this.btnClearRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRecords.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecords.ForeColor = System.Drawing.Color.White;
            this.btnClearRecords.Location = new System.Drawing.Point(156, 440);
            this.btnClearRecords.Name = "btnClearRecords";
            this.btnClearRecords.Size = new System.Drawing.Size(174, 23);
            this.btnClearRecords.TabIndex = 20;
            this.btnClearRecords.Text = "Clear Records";
            this.btnClearRecords.UseVisualStyleBackColor = false;
            this.btnClearRecords.Click += new System.EventHandler(this.btnClearRecords_Click);
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInfoApplication.Properties.Resources.c83746f1d5fe750cf438e7d1452208fb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 515);
            this.Controls.Add(this.btnClearRecords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNewStudentsCounter);
            this.Controls.Add(this.lblTotalStudentsCounter);
            this.Controls.Add(this.lstLastName);
            this.Controls.Add(this.lstFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lstStudentNumber);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStudentInformation);
            this.Name = "frmStudentInfo";
            this.Text = "Student Information Application";
            this.Load += new System.EventHandler(this.frmStudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInformation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstStudentNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstFirstName;
        private System.Windows.Forms.ListBox lstLastName;
        private System.Windows.Forms.Label lblTotalStudentsCounter;
        private System.Windows.Forms.Label lblNewStudentsCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearRecords;
    }
}

