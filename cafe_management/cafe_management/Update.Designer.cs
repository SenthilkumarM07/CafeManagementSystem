namespace cafe_management
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.lblUpdateLogOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.cmbUpdateId = new System.Windows.Forms.ComboBox();
            this.lblUpdateId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtUpdateMailId = new System.Windows.Forms.TextBox();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.txtUpdatePhNumber = new System.Windows.Forms.TextBox();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblUpdatemailId = new System.Windows.Forms.Label();
            this.lblUpdateUserName = new System.Windows.Forms.Label();
            this.lblUpdatePhNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateLogOut
            // 
            this.lblUpdateLogOut.AutoSize = true;
            this.lblUpdateLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateLogOut.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdateLogOut.Location = new System.Drawing.Point(12, 495);
            this.lblUpdateLogOut.Name = "lblUpdateLogOut";
            this.lblUpdateLogOut.Size = new System.Drawing.Size(78, 24);
            this.lblUpdateLogOut.TabIndex = 0;
            this.lblUpdateLogOut.Text = "LogOut";
            this.lblUpdateLogOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnlSignUp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(100, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 508);
            this.panel1.TabIndex = 1;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlSignUp.Controls.Add(this.cmbUpdateId);
            this.pnlSignUp.Controls.Add(this.lblUpdateId);
            this.pnlSignUp.Controls.Add(this.btnUpdate);
            this.pnlSignUp.Controls.Add(this.txtUpdatePassword);
            this.pnlSignUp.Controls.Add(this.txtUpdateMailId);
            this.pnlSignUp.Controls.Add(this.txtUpdateUserName);
            this.pnlSignUp.Controls.Add(this.txtUpdatePhNumber);
            this.pnlSignUp.Controls.Add(this.lblUpdatePassword);
            this.pnlSignUp.Controls.Add(this.lblUpdatemailId);
            this.pnlSignUp.Controls.Add(this.lblUpdateUserName);
            this.pnlSignUp.Controls.Add(this.lblUpdatePhNumber);
            this.pnlSignUp.Location = new System.Drawing.Point(47, 130);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(314, 359);
            this.pnlSignUp.TabIndex = 1;
            // 
            // cmbUpdateId
            // 
            this.cmbUpdateId.FormattingEnabled = true;
            this.cmbUpdateId.Location = new System.Drawing.Point(150, 39);
            this.cmbUpdateId.Name = "cmbUpdateId";
            this.cmbUpdateId.Size = new System.Drawing.Size(128, 21);
            this.cmbUpdateId.TabIndex = 13;
            this.cmbUpdateId.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateId_SelectedIndexChanged);
            // 
            // lblUpdateId
            // 
            this.lblUpdateId.AutoSize = true;
            this.lblUpdateId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUpdateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUpdateId.Location = new System.Drawing.Point(39, 40);
            this.lblUpdateId.Name = "lblUpdateId";
            this.lblUpdateId.Size = new System.Drawing.Size(70, 20);
            this.lblUpdateId.TabIndex = 12;
            this.lblUpdateId.Text = " User_Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(90, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 36);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(150, 247);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(128, 20);
            this.txtUpdatePassword.TabIndex = 8;
            // 
            // txtUpdateMailId
            // 
            this.txtUpdateMailId.Location = new System.Drawing.Point(150, 138);
            this.txtUpdateMailId.Name = "txtUpdateMailId";
            this.txtUpdateMailId.Size = new System.Drawing.Size(128, 20);
            this.txtUpdateMailId.TabIndex = 8;
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Location = new System.Drawing.Point(150, 91);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(128, 20);
            this.txtUpdateUserName.TabIndex = 8;
            // 
            // txtUpdatePhNumber
            // 
            this.txtUpdatePhNumber.Location = new System.Drawing.Point(150, 190);
            this.txtUpdatePhNumber.Name = "txtUpdatePhNumber";
            this.txtUpdatePhNumber.Size = new System.Drawing.Size(128, 20);
            this.txtUpdatePhNumber.TabIndex = 8;
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUpdatePassword.Location = new System.Drawing.Point(39, 247);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(78, 20);
            this.lblUpdatePassword.TabIndex = 7;
            this.lblUpdatePassword.Text = "Password";
            // 
            // lblUpdatemailId
            // 
            this.lblUpdatemailId.AutoSize = true;
            this.lblUpdatemailId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUpdatemailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatemailId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUpdatemailId.Location = new System.Drawing.Point(38, 138);
            this.lblUpdatemailId.Name = "lblUpdatemailId";
            this.lblUpdatemailId.Size = new System.Drawing.Size(55, 20);
            this.lblUpdatemailId.TabIndex = 6;
            this.lblUpdatemailId.Text = "Mail Id";
            // 
            // lblUpdateUserName
            // 
            this.lblUpdateUserName.AutoSize = true;
            this.lblUpdateUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUpdateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUpdateUserName.Location = new System.Drawing.Point(38, 91);
            this.lblUpdateUserName.Name = "lblUpdateUserName";
            this.lblUpdateUserName.Size = new System.Drawing.Size(89, 20);
            this.lblUpdateUserName.TabIndex = 5;
            this.lblUpdateUserName.Text = "User Name";
            // 
            // lblUpdatePhNumber
            // 
            this.lblUpdatePhNumber.AutoSize = true;
            this.lblUpdatePhNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUpdatePhNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePhNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUpdatePhNumber.Location = new System.Drawing.Point(39, 188);
            this.lblUpdatePhNumber.Name = "lblUpdatePhNumber";
            this.lblUpdatePhNumber.Size = new System.Drawing.Size(88, 20);
            this.lblUpdatePhNumber.TabIndex = 5;
            this.lblUpdatePhNumber.Text = "Ph Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(146, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update User details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(595, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUpdateLogOut);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateId;
        private System.Windows.Forms.Label lblUpdateId;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateMailId;
        private System.Windows.Forms.TextBox txtUpdateUserName;
        private System.Windows.Forms.TextBox txtUpdatePhNumber;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblUpdatemailId;
        private System.Windows.Forms.Label lblUpdateUserName;
        private System.Windows.Forms.Label lblUpdatePhNumber;
    }
}