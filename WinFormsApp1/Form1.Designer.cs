namespace WinFormsApp1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F);
            label1.Location = new Point(64, 94);
            label1.Name = "label1";
            label1.Size = new Size(52, 27);
            label1.TabIndex = 0;
            label1.Text = "公分";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F);
            label2.Location = new Point(174, 94);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 1;
            label2.Text = "公尺";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F);
            label3.Location = new Point(291, 94);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 2;
            label3.Text = "公里";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F);
            label4.Location = new Point(64, 201);
            label4.Name = "label4";
            label4.Size = new Size(52, 27);
            label4.TabIndex = 3;
            label4.Text = "英寸";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15F);
            label5.Location = new Point(174, 201);
            label5.Name = "label5";
            label5.Size = new Size(52, 27);
            label5.TabIndex = 4;
            label5.Text = "英尺";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 15F);
            label6.Location = new Point(303, 201);
            label6.Name = "label6";
            label6.Size = new Size(32, 27);
            label6.TabIndex = 5;
            label6.Text = "碼";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 15F);
            label7.Location = new Point(64, 29);
            label7.Name = "label7";
            label7.Size = new Size(0, 27);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 15F);
            label8.Location = new Point(64, 316);
            label8.Name = "label8";
            label8.Size = new Size(92, 27);
            label8.TabIndex = 7;
            label8.Text = "説明文字";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 15F);
            button1.Location = new Point(65, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 8;
            button1.Text = "清除";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 466);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}
