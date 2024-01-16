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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btLogin = new System.Windows.Forms.Button();
            tbUsername = new System.Windows.Forms.TextBox();
            tbPasword = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(80, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btLogin
            // 
            btLogin.Location = new System.Drawing.Point(182, 210);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(94, 29);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new System.Drawing.Point(182, 63);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new System.Drawing.Size(180, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPasword
            // 
            tbPasword.Location = new System.Drawing.Point(182, 139);
            tbPasword.Name = "tbPasword";
            tbPasword.Size = new System.Drawing.Size(180, 27);
            tbPasword.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(463, 300);
            Controls.Add(tbPasword);
            Controls.Add(tbUsername);
            Controls.Add(btLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPasword;
    }
}
