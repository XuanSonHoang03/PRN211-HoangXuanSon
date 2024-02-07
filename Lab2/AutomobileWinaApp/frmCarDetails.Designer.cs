namespace AutomobileWinaApp
{
    partial class frmCarDetails
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
            btSave = new Button();
            lbcarID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btCancel = new Button();
            mtbYear = new MaskedTextBox();
            tbID = new TextBox();
            tbName = new TextBox();
            cbManufacturer = new ComboBox();
            mtbPrice = new MaskedTextBox();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.DialogResult = DialogResult.OK;
            btSave.Location = new Point(229, 341);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 1;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // lbcarID
            // 
            lbcarID.AutoSize = true;
            lbcarID.Location = new Point(91, 85);
            lbcarID.Name = "lbcarID";
            lbcarID.Size = new Size(46, 20);
            lbcarID.TabIndex = 4;
            lbcarID.Text = "CarID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 132);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "CarName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 185);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 6;
            label3.Text = "Manufacturer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 230);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 281);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "ReleaseYear";
            // 
            // btCancel
            // 
            btCancel.DialogResult = DialogResult.OK;
            btCancel.Location = new Point(370, 341);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 9;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // mtbYear
            // 
            mtbYear.Location = new Point(229, 274);
            mtbYear.Mask = "0000";
            mtbYear.Name = "mtbYear";
            mtbYear.Size = new Size(235, 27);
            mtbYear.TabIndex = 13;
            // 
            // tbID
            // 
            tbID.Location = new Point(229, 78);
            tbID.Name = "tbID";
            tbID.Size = new Size(235, 27);
            tbID.TabIndex = 14;
            // 
            // tbName
            // 
            tbName.Location = new Point(229, 125);
            tbName.Name = "tbName";
            tbName.Size = new Size(235, 27);
            tbName.TabIndex = 15;
            // 
            // cbManufacturer
            // 
            cbManufacturer.FormattingEnabled = true;
            cbManufacturer.Items.AddRange(new object[] { "Audi ", "BMW", "Ford", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
            cbManufacturer.Location = new Point(229, 177);
            cbManufacturer.Name = "cbManufacturer";
            cbManufacturer.Size = new Size(235, 28);
            cbManufacturer.TabIndex = 16;
            // 
            // mtbPrice
            // 
            mtbPrice.Location = new Point(229, 223);
            mtbPrice.Mask = "000000000";
            mtbPrice.Name = "mtbPrice";
            mtbPrice.Size = new Size(235, 27);
            mtbPrice.TabIndex = 17;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 459);
            Controls.Add(mtbPrice);
            Controls.Add(cbManufacturer);
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(mtbYear);
            Controls.Add(btCancel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbcarID);
            Controls.Add(btSave);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Label lbcarID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btCancel;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox mtbYear;
        private TextBox tbID;
        private TextBox tbName;
        private ComboBox cbManufacturer;
        private MaskedTextBox mtbPrice;
    }
}
