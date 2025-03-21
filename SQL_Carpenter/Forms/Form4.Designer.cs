namespace SQL_Carpenter.Forms
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txt_server_name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_user_name = new TextBox();
            txt_password = new TextBox();
            label5 = new Label();
            button1 = new Button();
            txt_db_name = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Set connection";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1101, 261);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 19);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Server Name";
            // 
            // txt_server_name
            // 
            txt_server_name.Location = new Point(422, 16);
            txt_server_name.Name = "txt_server_name";
            txt_server_name.Size = new Size(125, 27);
            txt_server_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(776, 19);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 5;
            label4.Text = "User";
            // 
            // txt_user_name
            // 
            txt_user_name.Location = new Point(621, 16);
            txt_user_name.Name = "txt_user_name";
            txt_user_name.Size = new Size(125, 27);
            txt_user_name.TabIndex = 6;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(852, 17);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1007, 19);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "DB Name";
            // 
            // button1
            // 
            button1.Location = new Point(1329, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_db_name
            // 
            txt_db_name.Location = new Point(1086, 17);
            txt_db_name.Name = "txt_db_name";
            txt_db_name.Size = new Size(125, 27);
            txt_db_name.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(1229, 335);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "INSERT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1329, 335);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 395);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_db_name);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txt_password);
            Controls.Add(txt_user_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_server_name);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txt_server_name;
        private Label label3;
        private Label label4;
        private TextBox txt_user_name;
        private TextBox txt_password;
        private Label label5;
        private Button button1;
        private TextBox txt_db_name;
        private Button button2;
        private Button button3;
    }
}