
namespace _10HandsOn_Inheritance
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

        private void InitializeComponent()
        {
            this.grpAdminInfo = new System.Windows.Forms.GroupBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInputId = new System.Windows.Forms.TextBox();
            this.txtInputPass = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpUpdatePass = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.grpAdminInfo.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.grpUpdatePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminInfo
            // 
            this.grpAdminInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.grpAdminInfo.Controls.Add(this.txtAdminName);
            this.grpAdminInfo.Controls.Add(this.txtUserId);
            this.grpAdminInfo.Controls.Add(this.label1);
            this.grpAdminInfo.Controls.Add(this.label2);
            this.grpAdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdminInfo.ForeColor = System.Drawing.Color.White;
            this.grpAdminInfo.Location = new System.Drawing.Point(12, 12);
            this.grpAdminInfo.Name = "grpAdminInfo";
            this.grpAdminInfo.Size = new System.Drawing.Size(360, 80);
            this.grpAdminInfo.TabIndex = 0;
            this.grpAdminInfo.TabStop = false;
            this.grpAdminInfo.Text = "Administrator Info";
            // 
            // txtAdminName
            // 
            this.txtAdminName.BackColor = System.Drawing.Color.LightYellow;
            this.txtAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.Location = new System.Drawing.Point(100, 22);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.ReadOnly = true;
            this.txtAdminName.Size = new System.Drawing.Size(245, 20);
            this.txtAdminName.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.LightYellow;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(100, 49);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(245, 20);
            this.txtUserId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID:";
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.txtInputId);
            this.grpLogin.Controls.Add(this.txtInputPass);
            this.grpLogin.Controls.Add(this.btnVerify);
            this.grpLogin.Controls.Add(this.lblResult);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.Color.White;
            this.grpLogin.Location = new System.Drawing.Point(12, 105);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(360, 120);
            this.grpLogin.TabIndex = 1;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Verify Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // txtInputId
            // 
            this.txtInputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputId.Location = new System.Drawing.Point(100, 19);
            this.txtInputId.Name = "txtInputId";
            this.txtInputId.Size = new System.Drawing.Size(245, 20);
            this.txtInputId.TabIndex = 1;
            // 
            // txtInputPass
            // 
            this.txtInputPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputPass.Location = new System.Drawing.Point(100, 45);
            this.txtInputPass.Name = "txtInputPass";
            this.txtInputPass.PasswordChar = '*';
            this.txtInputPass.Size = new System.Drawing.Size(245, 20);
            this.txtInputPass.TabIndex = 3;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(173, 71);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 25);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verify Login";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(6, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // grpUpdatePass
            // 
            this.grpUpdatePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.grpUpdatePass.Controls.Add(this.btnUpdateName);
            this.grpUpdatePass.Controls.Add(this.label5);
            this.grpUpdatePass.Controls.Add(this.txtNewPass);
            this.grpUpdatePass.Controls.Add(this.txtNewName);
            this.grpUpdatePass.Controls.Add(this.label6);
            this.grpUpdatePass.Controls.Add(this.btnUpdatePass);
            this.grpUpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdatePass.ForeColor = System.Drawing.Color.White;
            this.grpUpdatePass.Location = new System.Drawing.Point(12, 238);
            this.grpUpdatePass.Name = "grpUpdatePass";
            this.grpUpdatePass.Size = new System.Drawing.Size(360, 100);
            this.grpUpdatePass.TabIndex = 2;
            this.grpUpdatePass.TabStop = false;
            this.grpUpdatePass.Text = "Update Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(100, 45);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(160, 20);
            this.txtNewPass.TabIndex = 1;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.btnUpdatePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.Location = new System.Drawing.Point(270, 44);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePass.TabIndex = 2;
            this.btnUpdatePass.Text = "Update";
            this.btnUpdatePass.UseVisualStyleBackColor = false;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Name:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 95);
            this.listBox1.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 445);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(360, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.btnUpdateName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateName.Location = new System.Drawing.Point(270, 17);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateName.TabIndex = 2;
            this.btnUpdateName.Text = "Update";
            this.btnUpdateName.UseVisualStyleBackColor = false;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.Location = new System.Drawing.Point(100, 19);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(160, 20);
            this.txtNewName.TabIndex = 1;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(384, 488);
            this.Controls.Add(this.grpAdminInfo);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpUpdatePass);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.grpAdminInfo.ResumeLayout(false);
            this.grpAdminInfo.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpUpdatePass.ResumeLayout(false);
            this.grpUpdatePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputPass;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpUpdatePass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.TextBox txtNewName;
    }
}