namespace Bautista_StudentGradeAnalyzer
{
    partial class studentgradefrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtPrelim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txtStudentNumber);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 294);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 207);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 41);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(160)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 31);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(160)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(106, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.txtStudentNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.ForeColor = System.Drawing.Color.White;
            this.txtStudentNumber.Location = new System.Drawing.Point(141, 50);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(245, 29);
            this.txtStudentNumber.TabIndex = 9;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(141, 80);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(245, 29);
            this.txtStudentName.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txtFinal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMidterm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrelim, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 77);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.txtFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.White;
            this.txtFinal.Location = new System.Drawing.Point(247, 25);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(117, 29);
            this.txtFinal.TabIndex = 10;
            // 
            // txtMidterm
            // 
            this.txtMidterm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.txtMidterm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidterm.ForeColor = System.Drawing.Color.White;
            this.txtMidterm.Location = new System.Drawing.Point(125, 25);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(116, 29);
            this.txtMidterm.TabIndex = 10;
            // 
            // txtPrelim
            // 
            this.txtPrelim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.txtPrelim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrelim.ForeColor = System.Drawing.Color.White;
            this.txtPrelim.Location = new System.Drawing.Point(3, 25);
            this.txtPrelim.Name = "txtPrelim";
            this.txtPrelim.Size = new System.Drawing.Size(116, 29);
            this.txtPrelim.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(247, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Final";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(125, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Midterm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "Prelim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // studentData
            // 
            this.studentData.AllowUserToAddRows = false;
            this.studentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(109)))), ((int)(((byte)(125)))));
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(160)))));
            this.studentData.Location = new System.Drawing.Point(24, 332);
            this.studentData.Name = "studentData";
            this.studentData.Size = new System.Drawing.Size(406, 150);
            this.studentData.TabIndex = 2;
            
            // 
            // studentgradefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(462, 512);
            this.Controls.Add(this.studentData);
            this.Controls.Add(this.panel1);
            this.Name = "studentgradefrm";
            this.Text = "Student Grade Analyzer";
            this.Load += new System.EventHandler(this.studentgradefrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtPrelim;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label6;
    }
}

