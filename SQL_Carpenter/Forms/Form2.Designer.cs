namespace SQL_Carpenter.Forms
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_DDL_serverName = new TextBox();
            txt_DDL_userName = new TextBox();
            txt_DDL_password = new TextBox();
            txt_DDL_dataBaseName = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Set Connection";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 64);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Server Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 289);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Database Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 110);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 155);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txt_DDL_serverName
            // 
            txt_DDL_serverName.Location = new Point(166, 64);
            txt_DDL_serverName.Name = "txt_DDL_serverName";
            txt_DDL_serverName.Size = new Size(125, 27);
            txt_DDL_serverName.TabIndex = 5;
            // 
            // txt_DDL_userName
            // 
            txt_DDL_userName.Location = new Point(166, 110);
            txt_DDL_userName.Name = "txt_DDL_userName";
            txt_DDL_userName.Size = new Size(125, 27);
            txt_DDL_userName.TabIndex = 6;
            // 
            // txt_DDL_password
            // 
            txt_DDL_password.Location = new Point(166, 155);
            txt_DDL_password.Name = "txt_DDL_password";
            txt_DDL_password.Size = new Size(125, 27);
            txt_DDL_password.TabIndex = 7;
            // 
            // txt_DDL_dataBaseName
            // 
            txt_DDL_dataBaseName.Location = new Point(166, 289);
            txt_DDL_dataBaseName.Name = "txt_DDL_dataBaseName";
            txt_DDL_dataBaseName.Size = new Size(125, 27);
            txt_DDL_dataBaseName.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(166, 338);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 9;
            button1.Text = "Create DB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(333, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1101, 306);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(166, 202);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 11;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1340, 344);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Delete DB";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 248);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 19;
            label9.Text = "Name Database";
            // 
            // button4
            // 
            button4.Location = new Point(1226, 344);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 20;
            button4.Text = "Modify DB";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 395);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txt_DDL_dataBaseName);
            Controls.Add(txt_DDL_password);
            Controls.Add(txt_DDL_userName);
            Controls.Add(txt_DDL_serverName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_DDL_serverName;
        private TextBox txt_DDL_userName;
        private TextBox txt_DDL_password;
        private TextBox txt_DDL_dataBaseName;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label9;
        private Button button4;
    }
}