namespace cafe_management
{
    partial class Admin_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_page));
            this.lblAdminLogOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnAdminShowAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdminSearchId = new System.Windows.Forms.Label();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.txtAdminSearchId = new System.Windows.Forms.TextBox();
            this.btnAdminUpdateItems = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.txtAdminDeleteId = new System.Windows.Forms.TextBox();
            this.lblAdminDeleteId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminLogOut
            // 
            this.lblAdminLogOut.AutoSize = true;
            this.lblAdminLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAdminLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogOut.ForeColor = System.Drawing.Color.Blue;
            this.lblAdminLogOut.Location = new System.Drawing.Point(38, 535);
            this.lblAdminLogOut.Name = "lblAdminLogOut";
            this.lblAdminLogOut.Size = new System.Drawing.Size(78, 24);
            this.lblAdminLogOut.TabIndex = 1;
            this.lblAdminLogOut.Text = "LogOut";
            this.lblAdminLogOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvAdmin);
            this.panel1.Controls.Add(this.btnAdminShowAll);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAdminUpdateItems);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblAdminLogOut);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(29, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 606);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(404, 66);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(540, 464);
            this.dgvAdmin.TabIndex = 21;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick_1);
            // 
            // btnAdminShowAll
            // 
            this.btnAdminShowAll.BackColor = System.Drawing.Color.White;
            this.btnAdminShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdminShowAll.Location = new System.Drawing.Point(593, 546);
            this.btnAdminShowAll.Name = "btnAdminShowAll";
            this.btnAdminShowAll.Size = new System.Drawing.Size(153, 42);
            this.btnAdminShowAll.TabIndex = 17;
            this.btnAdminShowAll.Text = "ShowAll";
            this.btnAdminShowAll.UseVisualStyleBackColor = false;
            this.btnAdminShowAll.Click += new System.EventHandler(this.btnAdminShowAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(164, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(515, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "User Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblAdminSearchId);
            this.panel3.Controls.Add(this.btnAdminSearch);
            this.panel3.Controls.Add(this.txtAdminSearchId);
            this.panel3.Location = new System.Drawing.Point(42, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 134);
            this.panel3.TabIndex = 18;
            // 
            // lblAdminSearchId
            // 
            this.lblAdminSearchId.AutoSize = true;
            this.lblAdminSearchId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAdminSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminSearchId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdminSearchId.Location = new System.Drawing.Point(48, 18);
            this.lblAdminSearchId.Name = "lblAdminSearchId";
            this.lblAdminSearchId.Size = new System.Drawing.Size(29, 24);
            this.lblAdminSearchId.TabIndex = 14;
            this.lblAdminSearchId.Text = "ID";
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.BackColor = System.Drawing.Color.White;
            this.btnAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdminSearch.Location = new System.Drawing.Point(87, 80);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(107, 30);
            this.btnAdminSearch.TabIndex = 16;
            this.btnAdminSearch.Text = "Search";
            this.btnAdminSearch.UseVisualStyleBackColor = false;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // txtAdminSearchId
            // 
            this.txtAdminSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminSearchId.Location = new System.Drawing.Point(124, 23);
            this.txtAdminSearchId.Multiline = true;
            this.txtAdminSearchId.Name = "txtAdminSearchId";
            this.txtAdminSearchId.Size = new System.Drawing.Size(135, 24);
            this.txtAdminSearchId.TabIndex = 15;
            // 
            // btnAdminUpdateItems
            // 
            this.btnAdminUpdateItems.BackColor = System.Drawing.Color.White;
            this.btnAdminUpdateItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUpdateItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdminUpdateItems.Location = new System.Drawing.Point(140, 431);
            this.btnAdminUpdateItems.Name = "btnAdminUpdateItems";
            this.btnAdminUpdateItems.Size = new System.Drawing.Size(146, 66);
            this.btnAdminUpdateItems.TabIndex = 17;
            this.btnAdminUpdateItems.Text = "Update Items";
            this.btnAdminUpdateItems.UseVisualStyleBackColor = false;
            this.btnAdminUpdateItems.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnAdminDelete);
            this.panel2.Controls.Add(this.txtAdminDeleteId);
            this.panel2.Controls.Add(this.lblAdminDeleteId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(42, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 115);
            this.panel2.TabIndex = 11;
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.BackColor = System.Drawing.Color.White;
            this.btnAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdminDelete.Location = new System.Drawing.Point(87, 65);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(107, 30);
            this.btnAdminDelete.TabIndex = 13;
            this.btnAdminDelete.Text = "Delete";
            this.btnAdminDelete.UseVisualStyleBackColor = false;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // txtAdminDeleteId
            // 
            this.txtAdminDeleteId.Location = new System.Drawing.Point(124, 17);
            this.txtAdminDeleteId.Multiline = true;
            this.txtAdminDeleteId.Name = "txtAdminDeleteId";
            this.txtAdminDeleteId.Size = new System.Drawing.Size(135, 24);
            this.txtAdminDeleteId.TabIndex = 12;
            // 
            // lblAdminDeleteId
            // 
            this.lblAdminDeleteId.AutoSize = true;
            this.lblAdminDeleteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAdminDeleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDeleteId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdminDeleteId.Location = new System.Drawing.Point(48, 17);
            this.lblAdminDeleteId.Name = "lblAdminDeleteId";
            this.lblAdminDeleteId.Size = new System.Drawing.Size(29, 24);
            this.lblAdminDeleteId.TabIndex = 11;
            this.lblAdminDeleteId.Text = "ID";
            this.lblAdminDeleteId.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, -20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(140, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 22;
            this.button1.Text = "Account Settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1003, 622);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_page";
            this.Text = "Admin_page";
            this.Load += new System.EventHandler(this.Admin_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdminLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdminDeleteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAdminSearchId;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.TextBox txtAdminSearchId;
        private System.Windows.Forms.Button btnAdminUpdateItems;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.TextBox txtAdminDeleteId;
        private System.Windows.Forms.Button btnAdminShowAll;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button button1;
    }
}