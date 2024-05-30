namespace Proyecto_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            btnAdd = new Button();
            txtPrice = new TextBox();
            lblName = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            lstvProducts = new ListView();
            columnProducts = new ColumnHeader();
            columnPrice = new ColumnHeader();
            columnTime = new ColumnHeader();
            btnRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDocx = new Button();
            DateCreatedNow = new DateTimePicker();
            label3 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            btnTxt = new Button();
            btnXslx = new Button();
            label5 = new Label();
            txtOrderName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(237, 284);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 40);
            txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Stencil", 10.2F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(32, 521);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 60);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(237, 394);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 40);
            txtPrice.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Constantia", 18F);
            lblName.Location = new Point(68, 291);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 37);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Constantia", 18F);
            lblPrice.Location = new Point(68, 399);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(90, 37);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(686, 582);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 38);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "...";
            // 
            // lstvProducts
            // 
            lstvProducts.BackColor = Color.MediumAquamarine;
            lstvProducts.Columns.AddRange(new ColumnHeader[] { columnProducts, columnPrice, columnTime });
            lstvProducts.Location = new Point(502, 235);
            lstvProducts.Name = "lstvProducts";
            lstvProducts.Size = new Size(462, 339);
            lstvProducts.TabIndex = 6;
            lstvProducts.UseCompatibleStateImageBehavior = false;
            lstvProducts.View = View.Details;
            // 
            // columnProducts
            // 
            columnProducts.Text = "Products";
            columnProducts.Width = 160;
            // 
            // columnPrice
            // 
            columnPrice.Text = "Price";
            columnPrice.Width = 110;
            // 
            // columnTime
            // 
            columnTime.Text = "Product entry time";
            columnTime.Width = 140;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Stencil", 10.2F);
            btnRemove.Location = new Point(235, 521);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(109, 60);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 11);
            label1.Name = "label1";
            label1.Size = new Size(559, 53);
            label1.TabIndex = 8;
            label1.Text = "Registration of Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1002, 256);
            label2.Name = "label2";
            label2.Size = new Size(188, 46);
            label2.TabIndex = 9;
            label2.Text = "Print Ticker";
            // 
            // btnDocx
            // 
            btnDocx.BackColor = Color.Blue;
            btnDocx.Location = new Point(1047, 310);
            btnDocx.Name = "btnDocx";
            btnDocx.Size = new Size(120, 50);
            btnDocx.TabIndex = 10;
            btnDocx.Text = "DOCX";
            btnDocx.UseVisualStyleBackColor = false;
            btnDocx.Click += btnDocx_Click;
            // 
            // DateCreatedNow
            // 
            DateCreatedNow.Location = new Point(854, 37);
            DateCreatedNow.Name = "DateCreatedNow";
            DateCreatedNow.Size = new Size(329, 27);
            DateCreatedNow.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 193);
            label3.Name = "label3";
            label3.Size = new Size(159, 49);
            label3.TabIndex = 14;
            label3.Text = "Product";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1114, 573);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 54);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_carrito_cmpras;
            pictureBox1.Location = new Point(644, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ticket_cmpras;
            pictureBox2.Location = new Point(1042, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 601);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 19;
            label4.Text = "Select the product and press this button";
            // 
            // btnTxt
            // 
            btnTxt.BackColor = SystemColors.AppWorkspace;
            btnTxt.Location = new Point(1047, 375);
            btnTxt.Name = "btnTxt";
            btnTxt.Size = new Size(120, 50);
            btnTxt.TabIndex = 20;
            btnTxt.Text = "TXT";
            btnTxt.UseVisualStyleBackColor = false;
            btnTxt.Click += btnTxt_Click;
            // 
            // btnXslx
            // 
            btnXslx.BackColor = Color.GreenYellow;
            btnXslx.Location = new Point(1047, 445);
            btnXslx.Name = "btnXslx";
            btnXslx.Size = new Size(120, 50);
            btnXslx.TabIndex = 21;
            btnXslx.Text = "XSLX";
            btnXslx.UseVisualStyleBackColor = false;
            btnXslx.Click += btnXslx_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 108);
            label5.Name = "label5";
            label5.Size = new Size(301, 49);
            label5.TabIndex = 22;
            label5.Text = "Name Of Order:";
            // 
            // txtOrderName
            // 
            txtOrderName.Location = new Point(344, 108);
            txtOrderName.Multiline = true;
            txtOrderName.Name = "txtOrderName";
            txtOrderName.Size = new Size(243, 49);
            txtOrderName.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1219, 624);
            Controls.Add(txtOrderName);
            Controls.Add(label5);
            Controls.Add(btnXslx);
            Controls.Add(btnTxt);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(DateCreatedNow);
            Controls.Add(btnDocx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(lstvProducts);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnAdd;
        private TextBox txtPrice;
        private Label lblName;
        private Label lblPrice;
        private Label lblTotal;
        private ListView lstvProducts;
        private ColumnHeader columnProducts;
        private ColumnHeader columnPrice;
        private Button btnRemove;
        private Label label1;
        private Label label2;
        private Button btnDocx;
        private DateTimePicker DateCreatedNow;
        private Label label3;
        private Button btnExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Button btnTxt;
        private Button btnXslx;
        private Label label5;
        private TextBox txtOrderName;
        private ColumnHeader columnTime;
    }
}
