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
            label3 = new Label();
            txt_DDL_dataBaseName = new TextBox();
            btnCreateDB = new Button();
            dataGridView1 = new DataGridView();
            btnDeleteDB = new Button();
            label9 = new Label();
            btnModifyDB = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 63);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Database Name";
            // 
            // txt_DDL_dataBaseName
            // 
            txt_DDL_dataBaseName.Location = new Point(165, 63);
            txt_DDL_dataBaseName.Name = "txt_DDL_dataBaseName";
            txt_DDL_dataBaseName.Size = new Size(125, 27);
            txt_DDL_dataBaseName.TabIndex = 8;
            // 
            // btnCreateDB
            // 
            btnCreateDB.Location = new Point(165, 112);
            btnCreateDB.Name = "btnCreateDB";
            btnCreateDB.Size = new Size(125, 29);
            btnCreateDB.TabIndex = 9;
            btnCreateDB.Text = "Create DB";
            btnCreateDB.UseVisualStyleBackColor = true;
            btnCreateDB.Click += btnCreateDB_Click;
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
            // btnDeleteDB
            // 
            btnDeleteDB.Location = new Point(1340, 344);
            btnDeleteDB.Name = "btnDeleteDB";
            btnDeleteDB.Size = new Size(94, 29);
            btnDeleteDB.TabIndex = 18;
            btnDeleteDB.Text = "Delete DB";
            btnDeleteDB.UseVisualStyleBackColor = true;
            btnDeleteDB.Click += btnDeleteDB_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 22);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 19;
            label9.Text = "Database Creation";
            // 
            // btnModifyDB
            // 
            btnModifyDB.Location = new Point(1226, 344);
            btnModifyDB.Name = "btnModifyDB";
            btnModifyDB.Size = new Size(94, 29);
            btnModifyDB.TabIndex = 20;
            btnModifyDB.Text = "Modify DB";
            btnModifyDB.UseVisualStyleBackColor = true;
            btnModifyDB.Click += btnModifyDB_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 395);
            Controls.Add(btnModifyDB);
            Controls.Add(label9);
            Controls.Add(btnDeleteDB);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreateDB);
            Controls.Add(txt_DDL_dataBaseName);
            Controls.Add(label3);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txt_DDL_dataBaseName;
        private Button btnCreateDB;
        private DataGridView dataGridView1;
        private Button btnDeleteDB;
        private Label label9;
        private Button btnModifyDB;
    }
}