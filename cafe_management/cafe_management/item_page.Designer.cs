namespace cafe_management
{
    partial class item_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageDelete = new System.Windows.Forms.Button();
            this.btnManageEdit = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.txtManageItemsPrice = new System.Windows.Forms.TextBox();
            this.txtManageItemsName = new System.Windows.Forms.TextBox();
            this.txtManageItemsNumber = new System.Windows.Forms.TextBox();
            this.txtManageItemsCategory = new System.Windows.Forms.ComboBox();
            this.lblManageItemsName = new System.Windows.Forms.Label();
            this.lblManageItemsPrice = new System.Windows.Forms.Label();
            this.lblManageItemsNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblManageLogOut = new System.Windows.Forms.Label();
            this.btnManageItemBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnManageDelete);
            this.panel1.Controls.Add(this.btnManageEdit);
            this.panel1.Controls.Add(this.btnManageAdd);
            this.panel1.Controls.Add(this.txtManageItemsPrice);
            this.panel1.Controls.Add(this.txtManageItemsName);
            this.panel1.Controls.Add(this.txtManageItemsNumber);
            this.panel1.Controls.Add(this.txtManageItemsCategory);
            this.panel1.Controls.Add(this.lblManageItemsName);
            this.panel1.Controls.Add(this.lblManageItemsPrice);
            this.panel1.Controls.Add(this.lblManageItemsNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 527);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(22, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 440);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lists";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageDelete
            // 
            this.btnManageDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDelete.ForeColor = System.Drawing.Color.White;
            this.btnManageDelete.Location = new System.Drawing.Point(201, 332);
            this.btnManageDelete.Name = "btnManageDelete";
            this.btnManageDelete.Size = new System.Drawing.Size(77, 31);
            this.btnManageDelete.TabIndex = 14;
            this.btnManageDelete.Text = "Delete";
            this.btnManageDelete.UseVisualStyleBackColor = false;
            this.btnManageDelete.Click += new System.EventHandler(this.btnManageDelete_Click);
            // 
            // btnManageEdit
            // 
            this.btnManageEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEdit.ForeColor = System.Drawing.Color.White;
            this.btnManageEdit.Location = new System.Drawing.Point(114, 332);
            this.btnManageEdit.Name = "btnManageEdit";
            this.btnManageEdit.Size = new System.Drawing.Size(71, 31);
            this.btnManageEdit.TabIndex = 13;
            this.btnManageEdit.Text = "Edit";
            this.btnManageEdit.UseVisualStyleBackColor = false;
            this.btnManageEdit.Click += new System.EventHandler(this.btnManageEdit_Click);
            // 
            // btnManageAdd
            // 
            this.btnManageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdd.ForeColor = System.Drawing.Color.White;
            this.btnManageAdd.Location = new System.Drawing.Point(22, 332);
            this.btnManageAdd.Name = "btnManageAdd";
            this.btnManageAdd.Size = new System.Drawing.Size(72, 31);
            this.btnManageAdd.TabIndex = 12;
            this.btnManageAdd.Text = "Add";
            this.btnManageAdd.UseVisualStyleBackColor = false;
            this.btnManageAdd.Click += new System.EventHandler(this.btnManageAdd_Click);
            // 
            // txtManageItemsPrice
            // 
            this.txtManageItemsPrice.Location = new System.Drawing.Point(153, 267);
            this.txtManageItemsPrice.Multiline = true;
            this.txtManageItemsPrice.Name = "txtManageItemsPrice";
            this.txtManageItemsPrice.Size = new System.Drawing.Size(134, 26);
            this.txtManageItemsPrice.TabIndex = 11;
            // 
            // txtManageItemsName
            // 
            this.txtManageItemsName.Location = new System.Drawing.Point(153, 161);
            this.txtManageItemsName.Multiline = true;
            this.txtManageItemsName.Name = "txtManageItemsName";
            this.txtManageItemsName.Size = new System.Drawing.Size(134, 27);
            this.txtManageItemsName.TabIndex = 10;
            // 
            // txtManageItemsNumber
            // 
            this.txtManageItemsNumber.Location = new System.Drawing.Point(153, 109);
            this.txtManageItemsNumber.Multiline = true;
            this.txtManageItemsNumber.Name = "txtManageItemsNumber";
            this.txtManageItemsNumber.Size = new System.Drawing.Size(134, 26);
            this.txtManageItemsNumber.TabIndex = 9;
            // 
            // txtManageItemsCategory
            // 
            this.txtManageItemsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManageItemsCategory.FormattingEnabled = true;
            this.txtManageItemsCategory.Items.AddRange(new object[] {
            "Food",
            "Cool Drinks",
            "Fresh Juice",
            "Hot Drinks",
            "Desserts",
            "snacks",
            "Gravy"});
            this.txtManageItemsCategory.Location = new System.Drawing.Point(83, 212);
            this.txtManageItemsCategory.Name = "txtManageItemsCategory";
            this.txtManageItemsCategory.Size = new System.Drawing.Size(102, 24);
            this.txtManageItemsCategory.TabIndex = 8;
            this.txtManageItemsCategory.Text = "Category";
            this.txtManageItemsCategory.SelectedIndexChanged += new System.EventHandler(this.txtManageItemsCategory_SelectedIndexChanged);
            // 
            // lblManageItemsName
            // 
            this.lblManageItemsName.AutoSize = true;
            this.lblManageItemsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageItemsName.Location = new System.Drawing.Point(18, 161);
            this.lblManageItemsName.Name = "lblManageItemsName";
            this.lblManageItemsName.Size = new System.Drawing.Size(101, 24);
            this.lblManageItemsName.TabIndex = 7;
            this.lblManageItemsName.Text = "Item Name";
            // 
            // lblManageItemsPrice
            // 
            this.lblManageItemsPrice.AutoSize = true;
            this.lblManageItemsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageItemsPrice.Location = new System.Drawing.Point(18, 267);
            this.lblManageItemsPrice.Name = "lblManageItemsPrice";
            this.lblManageItemsPrice.Size = new System.Drawing.Size(93, 24);
            this.lblManageItemsPrice.TabIndex = 6;
            this.lblManageItemsPrice.Text = "Item Price";
            // 
            // lblManageItemsNumber
            // 
            this.lblManageItemsNumber.AutoSize = true;
            this.lblManageItemsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageItemsNumber.Location = new System.Drawing.Point(18, 109);
            this.lblManageItemsNumber.Name = "lblManageItemsNumber";
            this.lblManageItemsNumber.Size = new System.Drawing.Size(119, 24);
            this.lblManageItemsNumber.TabIndex = 5;
            this.lblManageItemsNumber.Text = "Item Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(380, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manage Items";
            // 
            // lblManageLogOut
            // 
            this.lblManageLogOut.AutoSize = true;
            this.lblManageLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageLogOut.ForeColor = System.Drawing.Color.Blue;
            this.lblManageLogOut.Location = new System.Drawing.Point(12, 493);
            this.lblManageLogOut.Name = "lblManageLogOut";
            this.lblManageLogOut.Size = new System.Drawing.Size(72, 24);
            this.lblManageLogOut.TabIndex = 2;
            this.lblManageLogOut.Text = "LogOut";
            // 
            // btnManageItemBack
            // 
            this.btnManageItemBack.BackColor = System.Drawing.Color.White;
            this.btnManageItemBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageItemBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageItemBack.Location = new System.Drawing.Point(16, 412);
            this.btnManageItemBack.Name = "btnManageItemBack";
            this.btnManageItemBack.Size = new System.Drawing.Size(82, 34);
            this.btnManageItemBack.TabIndex = 15;
            this.btnManageItemBack.Text = "Back";
            this.btnManageItemBack.UseVisualStyleBackColor = false;
            this.btnManageItemBack.Click += new System.EventHandler(this.btnManageItemBack_Click);
            // 
            // item_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(909, 535);
            this.Controls.Add(this.btnManageItemBack);
            this.Controls.Add(this.lblManageLogOut);
            this.Controls.Add(this.panel1);
            this.Name = "item_page";
            this.Text = "item_page";
            this.Load += new System.EventHandler(this.item_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageLogOut;
        private System.Windows.Forms.Label lblManageItemsName;
        private System.Windows.Forms.Label lblManageItemsPrice;
        private System.Windows.Forms.Label lblManageItemsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManageDelete;
        private System.Windows.Forms.Button btnManageEdit;
        private System.Windows.Forms.Button btnManageAdd;
        private System.Windows.Forms.TextBox txtManageItemsPrice;
        private System.Windows.Forms.TextBox txtManageItemsName;
        private System.Windows.Forms.TextBox txtManageItemsNumber;
        private System.Windows.Forms.ComboBox txtManageItemsCategory;
        private System.Windows.Forms.Button btnManageItemBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}