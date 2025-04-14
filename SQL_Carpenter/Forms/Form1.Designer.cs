namespace SQL_Carpenter
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnPassword = new TextBox();
            btnUserName = new TextBox();
            btnServerName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 4);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(414, 31);
            button1.Name = "button1";
            button1.Size = new Size(275, 117);
            button1.TabIndex = 1;
            button1.Text = "DDL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button2.Location = new Point(414, 183);
            button2.Name = "button2";
            button2.Size = new Size(275, 117);
            button2.TabIndex = 2;
            button2.Text = "DML";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 18);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 3;
            label2.Text = "Set Connection";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnPassword);
            panel1.Controls.Add(btnUserName);
            panel1.Controls.Add(btnServerName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 269);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 202);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 148);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 90);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 7;
            label3.Text = "Server Name:";
            // 
            // btnPassword
            // 
            btnPassword.Location = new Point(174, 199);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(125, 27);
            btnPassword.TabIndex = 6;
            // 
            // btnUserName
            // 
            btnUserName.Location = new Point(174, 148);
            btnUserName.Name = "btnUserName";
            btnUserName.Size = new Size(125, 27);
            btnUserName.TabIndex = 5;
            // 
            // btnServerName
            // 
            btnServerName.Location = new Point(174, 90);
            btnServerName.Name = "btnServerName";
            btnServerName.Size = new Size(125, 27);
            btnServerName.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 395);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox btnPassword;
        private TextBox btnUserName;
        private TextBox btnServerName;
    }
}
