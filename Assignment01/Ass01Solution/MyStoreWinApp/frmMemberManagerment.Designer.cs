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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox7 = new TextBox();
            button4 = new Button();
            label8 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(720, 501);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(774, 130);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "MemberID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(897, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(774, 512);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(774, 192);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 4;
            label2.Text = "MemberName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(774, 253);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(774, 309);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(774, 367);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 7;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(774, 421);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 8;
            label6.Text = "Country";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(897, 414);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(897, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(897, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(897, 246);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(179, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(897, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(179, 27);
            textBox6.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(897, 548);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1013, 512);
            button3.Name = "button3";
            button3.Size = new Size(94, 40);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(419, 18);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 16;
            label7.Text = "Search(ID, Name)";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(419, 50);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(179, 27);
            textBox7.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(628, 35);
            button4.Name = "button4";
            button4.Size = new Size(94, 42);
            button4.TabIndex = 18;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 18);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 19;
            label8.Text = "Filter(City, Country)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "City", "Country" });
            comboBox1.Location = new Point(23, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            // 
            // button5
            // 
            button5.Location = new Point(197, 35);
            button5.Name = "button5";
            button5.Size = new Size(94, 42);
            button5.TabIndex = 21;
            button5.Text = "Filter";
            button5.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 625);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmMemberManagerment";
            Text = "frmMemberManagerment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox7;
        private Button button4;
        private Label label8;
        private ComboBox comboBox1;
        private Button button5;
    }
}