namespace MyStoreWinApp
{
    partial class frmMember
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
            label1 = new System.Windows.Forms.Label();
            tbCity = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tbPassword = new System.Windows.Forms.TextBox();
            tbID = new System.Windows.Forms.TextBox();
            tbEmail = new System.Windows.Forms.TextBox();
            tbCountry = new System.Windows.Forms.TextBox();
            tbName = new System.Windows.Forms.TextBox();
            btCancel = new System.Windows.Forms.Button();
            btSaveInfo = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "MemberID";
            // 
            // tbCity
            // 
            tbCity.Location = new System.Drawing.Point(467, 113);
            tbCity.Name = "tbCity";
            tbCity.Size = new System.Drawing.Size(125, 27);
            tbCity.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(373, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(373, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(373, 120);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(95, 193);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(36, 124);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 20);
            label6.TabIndex = 6;
            label6.Text = "MemberName";
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(467, 53);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(125, 27);
            tbPassword.TabIndex = 7;
            // 
            // tbID
            // 
            tbID.Location = new System.Drawing.Point(163, 53);
            tbID.Name = "tbID";
            tbID.Size = new System.Drawing.Size(125, 27);
            tbID.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new System.Drawing.Point(163, 186);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new System.Drawing.Size(125, 27);
            tbEmail.TabIndex = 9;
            // 
            // tbCountry
            // 
            tbCountry.Location = new System.Drawing.Point(467, 179);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new System.Drawing.Size(125, 27);
            tbCountry.TabIndex = 10;
            // 
            // tbName
            // 
            tbName.Location = new System.Drawing.Point(163, 117);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(125, 27);
            tbName.TabIndex = 11;
            // 
            // btCancel
            // 
            btCancel.Location = new System.Drawing.Point(392, 286);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(94, 29);
            btCancel.TabIndex = 13;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btSaveInfo
            // 
            btSaveInfo.Location = new System.Drawing.Point(194, 286);
            btSaveInfo.Name = "btSaveInfo";
            btSaveInfo.Size = new System.Drawing.Size(94, 29);
            btSaveInfo.TabIndex = 14;
            btSaveInfo.Text = "Save";
            btSaveInfo.UseVisualStyleBackColor = true;
            btSaveInfo.Click += btSaveInfo_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(689, 351);
            Controls.Add(btSaveInfo);
            Controls.Add(btCancel);
            Controls.Add(tbName);
            Controls.Add(tbCountry);
            Controls.Add(tbEmail);
            Controls.Add(tbID);
            Controls.Add(tbPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbCity);
            Controls.Add(label1);
            Name = "frmMember";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMember";
            Load += frmMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSaveInfo;
    }
}