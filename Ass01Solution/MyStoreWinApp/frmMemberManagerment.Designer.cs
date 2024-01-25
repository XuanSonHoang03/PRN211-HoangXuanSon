namespace MyStoreWinApp
{
    partial class frmMemberManagerment
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
			dgvListView = new System.Windows.Forms.DataGridView();
			btAdd = new System.Windows.Forms.Button();
			btDelete = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			btUpdate = new System.Windows.Forms.Button();
			label7 = new System.Windows.Forms.Label();
			cbSearch = new System.Windows.Forms.ComboBox();
			label8 = new System.Windows.Forms.Label();
			cbFilter = new System.Windows.Forms.ComboBox();
			btSort = new System.Windows.Forms.Button();
			tbID = new System.Windows.Forms.TextBox();
			tbCity = new System.Windows.Forms.TextBox();
			tbName = new System.Windows.Forms.TextBox();
			tbEmail = new System.Windows.Forms.TextBox();
			tbCountry = new System.Windows.Forms.TextBox();
			tbSearch = new System.Windows.Forms.TextBox();
			cbCityOrCountry = new System.Windows.Forms.ComboBox();
			button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)dgvListView).BeginInit();
			SuspendLayout();
			// 
			// dgvListView
			// 
			dgvListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvListView.Location = new System.Drawing.Point(12, 347);
			dgvListView.Name = "dgvListView";
			dgvListView.RowHeadersWidth = 51;
			dgvListView.RowTemplate.Height = 29;
			dgvListView.Size = new System.Drawing.Size(843, 308);
			dgvListView.TabIndex = 0;
			// 
			// btAdd
			// 
			btAdd.Location = new System.Drawing.Point(184, 187);
			btAdd.Name = "btAdd";
			btAdd.Size = new System.Drawing.Size(102, 38);
			btAdd.TabIndex = 1;
			btAdd.Text = "Add";
			btAdd.UseVisualStyleBackColor = true;
			btAdd.Click += btAdd_Click;
			// 
			// btDelete
			// 
			btDelete.Location = new System.Drawing.Point(371, 187);
			btDelete.Name = "btDelete";
			btDelete.Size = new System.Drawing.Size(97, 38);
			btDelete.TabIndex = 2;
			btDelete.Text = "Delete";
			btDelete.UseVisualStyleBackColor = true;
			btDelete.Click += btDelete_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(79, 29);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(80, 20);
			label1.TabIndex = 3;
			label1.Text = "MemberID";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(54, 85);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(105, 20);
			label2.TabIndex = 4;
			label2.Text = "MemberName";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(125, 136);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(34, 20);
			label3.TabIndex = 5;
			label3.Text = "City";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(470, 29);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(46, 20);
			label4.TabIndex = 6;
			label4.Text = "Email";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(456, 85);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(60, 20);
			label6.TabIndex = 8;
			label6.Text = "Country";
			// 
			// btUpdate
			// 
			btUpdate.Location = new System.Drawing.Point(578, 187);
			btUpdate.Name = "btUpdate";
			btUpdate.Size = new System.Drawing.Size(95, 38);
			btUpdate.TabIndex = 9;
			btUpdate.Text = "Update";
			btUpdate.UseVisualStyleBackColor = true;
			btUpdate.Click += btUpdate_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(50, 267);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(69, 20);
			label7.TabIndex = 10;
			label7.Text = "SearchBy";
			// 
			// cbSearch
			// 
			cbSearch.FormattingEnabled = true;
			cbSearch.Items.AddRange(new object[] { "ID", "Name" });
			cbSearch.Location = new System.Drawing.Point(125, 259);
			cbSearch.Name = "cbSearch";
			cbSearch.Size = new System.Drawing.Size(72, 28);
			cbSearch.TabIndex = 12;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(569, 267);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(58, 20);
			label8.TabIndex = 13;
			label8.Text = "FilterBy";
			// 
			// cbFilter
			// 
			cbFilter.FormattingEnabled = true;
			cbFilter.Items.AddRange(new object[] { "City", "Country" });
			cbFilter.Location = new System.Drawing.Point(638, 259);
			cbFilter.Name = "cbFilter";
			cbFilter.Size = new System.Drawing.Size(92, 28);
			cbFilter.TabIndex = 14;
			cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
			// 
			// btSort
			// 
			btSort.Location = new System.Drawing.Point(761, 312);
			btSort.Name = "btSort";
			btSort.Size = new System.Drawing.Size(94, 29);
			btSort.TabIndex = 15;
			btSort.Text = "DESC\r\n";
			btSort.UseVisualStyleBackColor = true;
			btSort.Click += btSort_Click;
			// 
			// tbID
			// 
			tbID.Location = new System.Drawing.Point(201, 27);
			tbID.Name = "tbID";
			tbID.Size = new System.Drawing.Size(170, 27);
			tbID.TabIndex = 16;
			// 
			// tbCity
			// 
			tbCity.Location = new System.Drawing.Point(201, 129);
			tbCity.Name = "tbCity";
			tbCity.Size = new System.Drawing.Size(170, 27);
			tbCity.TabIndex = 17;
			// 
			// tbName
			// 
			tbName.Location = new System.Drawing.Point(201, 78);
			tbName.Name = "tbName";
			tbName.Size = new System.Drawing.Size(170, 27);
			tbName.TabIndex = 18;
			// 
			// tbEmail
			// 
			tbEmail.Location = new System.Drawing.Point(560, 27);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new System.Drawing.Size(170, 27);
			tbEmail.TabIndex = 20;
			// 
			// tbCountry
			// 
			tbCountry.Location = new System.Drawing.Point(560, 85);
			tbCountry.Name = "tbCountry";
			tbCountry.Size = new System.Drawing.Size(170, 27);
			tbCountry.TabIndex = 21;
			// 
			// tbSearch
			// 
			tbSearch.Location = new System.Drawing.Point(215, 260);
			tbSearch.Name = "tbSearch";
			tbSearch.Size = new System.Drawing.Size(125, 27);
			tbSearch.TabIndex = 22;
			tbSearch.TextChanged += tbSearch_TextChanged;
			// 
			// cbCityOrCountry
			// 
			cbCityOrCountry.FormattingEnabled = true;
			cbCityOrCountry.Items.AddRange(new object[] { "City", "Country" });
			cbCityOrCountry.Location = new System.Drawing.Point(745, 259);
			cbCityOrCountry.Name = "cbCityOrCountry";
			cbCityOrCountry.Size = new System.Drawing.Size(92, 28);
			cbCityOrCountry.TabIndex = 23;
			cbCityOrCountry.SelectedIndexChanged += cbCityOrCountry_SelectedIndexChanged;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(636, 312);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(94, 29);
			button1.TabIndex = 24;
			button1.Text = "Load";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// frmMemberManagerment
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(867, 667);
			Controls.Add(button1);
			Controls.Add(cbCityOrCountry);
			Controls.Add(tbSearch);
			Controls.Add(tbCountry);
			Controls.Add(tbEmail);
			Controls.Add(tbName);
			Controls.Add(tbCity);
			Controls.Add(tbID);
			Controls.Add(btSort);
			Controls.Add(cbFilter);
			Controls.Add(label8);
			Controls.Add(cbSearch);
			Controls.Add(label7);
			Controls.Add(btUpdate);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btDelete);
			Controls.Add(btAdd);
			Controls.Add(dgvListView);
			Name = "frmMemberManagerment";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "frmMemberManagerment";
			Load += frmMemberManagerment_Load;
			((System.ComponentModel.ISupportInitialize)dgvListView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListView;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbCityOrCountry;
		private System.Windows.Forms.Button button1;
	}
}