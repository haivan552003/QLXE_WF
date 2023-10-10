namespace QLXE_WF
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            dvProduct = new DataGridView();
            menuStrip1 = new MenuStrip();
            productToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            txtPrice = new TextBox();
            txtDes = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            lblUserName = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvProduct).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dvProduct
            // 
            dvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProduct.Location = new Point(12, 107);
            dvProduct.Name = "dvProduct";
            dvProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dvProduct.RowTemplate.Height = 29;
            dvProduct.Size = new Size(776, 156);
            dvProduct.TabIndex = 0;
            dvProduct.CellClick += dvProduct_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(52, 24);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtDes);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 112);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(418, 26);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 11;
            label3.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(532, 19);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(227, 30);
            txtPrice.TabIndex = 3;
            // 
            // txtDes
            // 
            txtDes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDes.Location = new Point(532, 55);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(227, 30);
            txtDes.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(418, 62);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 12;
            label4.Text = "Description:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(126, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 30);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 13;
            label2.Text = "Name:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(126, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(227, 30);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 14;
            label1.Text = "ID:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(136, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 48);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MidnightBlue;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(265, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 48);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(544, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 48);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(340, 51);
            label6.Name = "label6";
            label6.Size = new Size(121, 31);
            label6.TabIndex = 14;
            label6.Text = "PRODUCT";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(89, 78);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(28, 23);
            lblUserName.TabIndex = 14;
            lblUserName.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 78);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 15;
            label7.Text = "Account:";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(dvProduct);
            Controls.Add(menuStrip1);
            Controls.Add(lblUserName);
            Controls.Add(label6);
            MainMenuStrip = menuStrip1;
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dvProduct).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtPass;
        private TextBox txtAge;
        private Label label5;
        private Label label3;
        private TextBox txtDes;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label6;
        private Label lblUserName;
        private Label label7;
        private TextBox txtPrice;
    }
}