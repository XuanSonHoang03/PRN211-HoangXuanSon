namespace frmCarManagement
{
    partial class frmCarManagement
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
            tbcarID = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            txtCarID = new TextBox();
            txtManufacturer = new TextBox();
            txtCarName = new TextBox();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            btLoad = new Button();
            btClose = new Button();
            btDelete = new Button();
            btNew = new Button();
            dgvCar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCar).BeginInit();
            SuspendLayout();
            // 
            // tbcarID
            // 
            tbcarID.AutoSize = true;
            tbcarID.Location = new Point(68, 47);
            tbcarID.Name = "tbcarID";
            tbcarID.Size = new Size(46, 20);
            tbcarID.TabIndex = 0;
            tbcarID.Text = "CarID";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(68, 174);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 1;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(68, 111);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(71, 20);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "CarName";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(453, 111);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 3;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(453, 47);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "Price";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(181, 40);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(125, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(181, 167);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(125, 27);
            txtManufacturer.TabIndex = 6;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(181, 104);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(125, 27);
            txtCarName.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(569, 104);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(125, 27);
            txtReleaseYear.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(569, 40);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 9;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(151, 245);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(94, 29);
            btLoad.TabIndex = 10;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(367, 521);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 11;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(569, 245);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 12;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(355, 245);
            btNew.Name = "btNew";
            btNew.Size = new Size(94, 29);
            btNew.TabIndex = 13;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // dgvCar
            // 
            dgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCar.Location = new Point(12, 316);
            dgvCar.Name = "dgvCar";
            dgvCar.RowHeadersWidth = 51;
            dgvCar.RowTemplate.Height = 29;
            dgvCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCar.Size = new Size(785, 188);
            dgvCar.TabIndex = 14;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 588);
            Controls.Add(dgvCar);
            Controls.Add(btNew);
            Controls.Add(btDelete);
            Controls.Add(btClose);
            Controls.Add(btLoad);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarID);
            Controls.Add(lbPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbCarName);
            Controls.Add(lbManufacturer);
            Controls.Add(tbcarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tbcarID;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbReleaseYear;
        private Label lbPrice;
        private TextBox txtCarID;
        private TextBox txtManufacturer;
        private TextBox txtCarName;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private Button btLoad;
        private Button btClose;
        private Button btDelete;
        private Button btNew;
        private DataGridView dgvCar;
    }
}
