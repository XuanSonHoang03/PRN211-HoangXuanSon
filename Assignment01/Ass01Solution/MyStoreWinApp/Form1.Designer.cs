namespace MyStoreWinApp
{
    partial class frmLogin
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
            label1 = new Label();
            tbUsername = new TextBox();
            btLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            tbPassword = new TextBox();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 65);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Role";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(247, 122);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(215, 27);
            tbUsername.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(247, 262);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(118, 44);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 196);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(247, 189);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(215, 27);
            tbPassword.TabIndex = 5;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "User" });
            cbRole.Location = new Point(247, 63);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(151, 28);
            cbRole.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 365);
            Controls.Add(cbRole);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btLogin);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private Button btLogin;
        private Label label2;
        private Label label3;
        private TextBox tbPassword;
        private ComboBox cbRole;
    }
}
