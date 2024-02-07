namespace AutomobileWinaApp
{
    partial class frmCarManagement
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
            tbID = new TextBox();
            label1 = new Label();
            btClose = new Button();
            dgvDisplay = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbManufacturer = new TextBox();
            tbName = new TextBox();
            tbYear = new TextBox();
            tbPrice = new TextBox();
            btNew = new Button();
            btLoad = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();
            // 
            // tbID
            // 
            tbID.Location = new Point(155, 52);
            tbID.Name = "tbID";
            tbID.Size = new Size(183, 27);
            tbID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "CarID";
            // 
            // btClose
            // 
            btClose.Location = new Point(349, 504);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 2;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(2, 271);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.ReadOnly = true;
            dgvDisplay.RowHeadersWidth = 51;
            dgvDisplay.RowTemplate.Height = 29;
            dgvDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisplay.Size = new Size(734, 208);
            dgvDisplay.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 106);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "CarName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 154);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 5;
            label3.Text = "Manufacturer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 59);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 109);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 7;
            label5.Text = "Release Year";
            // 
            // tbManufacturer
            // 
            tbManufacturer.Location = new Point(155, 147);
            tbManufacturer.Name = "tbManufacturer";
            tbManufacturer.Size = new Size(183, 27);
            tbManufacturer.TabIndex = 8;
            // 
            // tbName
            // 
            tbName.Location = new Point(155, 99);
            tbName.Name = "tbName";
            tbName.Size = new Size(183, 27);
            tbName.TabIndex = 9;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(507, 103);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(189, 27);
            tbYear.TabIndex = 10;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(507, 52);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(189, 27);
            tbPrice.TabIndex = 11;
            // 
            // btNew
            // 
            btNew.Location = new Point(349, 221);
            btNew.Name = "btNew";
            btNew.Size = new Size(94, 29);
            btNew.TabIndex = 12;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(171, 221);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(94, 29);
            btLoad.TabIndex = 13;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(538, 221);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 14;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 572);
            Controls.Add(btDelete);
            Controls.Add(btLoad);
            Controls.Add(btNew);
            Controls.Add(tbPrice);
            Controls.Add(tbYear);
            Controls.Add(tbName);
            Controls.Add(tbManufacturer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDisplay);
            Controls.Add(btClose);
            Controls.Add(label1);
            Controls.Add(tbID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbID;
        private Label label1;
        private Button btClose;
        private DataGridView dgvDisplay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbManufacturer;
        private TextBox tbName;
        private TextBox tbYear;
        private TextBox tbPrice;
        private Button btNew;
        private Button btLoad;
        private Button btDelete;
    }
}