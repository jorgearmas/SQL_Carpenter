namespace SQL_Carpenter.Forms
{
    partial class Form3
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
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Create table in DB:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Table Name";
            // 
            // button1
            // 
            button1.Location = new Point(159, 258);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 4;
            button1.Text = "Add Field";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(311, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 299);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 8;
            label5.Text = "Field Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "INT", "VARCHAR(50)", "DATE" });
            comboBox1.Location = new Point(159, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 11;
            label4.Text = "Field Type";
            // 
            // button2
            // 
            button2.Location = new Point(311, 353);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 12;
            button2.Text = "Create Table";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 128);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 13;
            label6.Text = "Primary Key Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 9);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 15;
            label7.Text = "Fields Added:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(830, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 299);
            dataGridView1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(1315, 353);
            button3.Name = "button3";
            button3.Size = new Size(115, 29);
            button3.TabIndex = 17;
            button3.Text = "Delete Table";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.MenuHighlight;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Info;
            label8.Location = new Point(830, 357);
            label8.Name = "label8";
            label8.Size = new Size(455, 17);
            label8.TabIndex = 18;
            label8.Text = "Deleting a table will result in loss of complete information stored in the table";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 395);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button2;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label8;
    }
}