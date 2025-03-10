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
            txtCM = new Label();
            txtM = new Label();
            txtKM = new Label();
            txtIn = new Label();
            txtFt = new Label();
            txtYard = new Label();
            label7 = new Label();
            txtInfo = new Label();
            btnAllClear = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // txtCM
            // 
            txtCM.AutoSize = true;
            txtCM.Font = new Font("Microsoft YaHei UI", 15F);
            txtCM.Location = new Point(64, 94);
            txtCM.Name = "txtCM";
            txtCM.Size = new Size(52, 27);
            txtCM.TabIndex = 0;
            txtCM.Text = "公分";
            txtCM.Click += label1_Click;
            // 
            // txtM
            // 
            txtM.AutoSize = true;
            txtM.Font = new Font("Microsoft YaHei UI", 15F);
            txtM.Location = new Point(174, 94);
            txtM.Name = "txtM";
            txtM.Size = new Size(52, 27);
            txtM.TabIndex = 1;
            txtM.Text = "公尺";
            // 
            // txtKM
            // 
            txtKM.AutoSize = true;
            txtKM.Font = new Font("Microsoft YaHei UI", 15F);
            txtKM.Location = new Point(291, 94);
            txtKM.Name = "txtKM";
            txtKM.Size = new Size(52, 27);
            txtKM.TabIndex = 2;
            txtKM.Text = "公里";
            // 
            // txtIn
            // 
            txtIn.AutoSize = true;
            txtIn.Font = new Font("Microsoft YaHei UI", 15F);
            txtIn.Location = new Point(64, 201);
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(52, 27);
            txtIn.TabIndex = 3;
            txtIn.Text = "英寸";
            txtIn.Click += label4_Click;
            // 
            // txtFt
            // 
            txtFt.AutoSize = true;
            txtFt.Font = new Font("Microsoft YaHei UI", 15F);
            txtFt.Location = new Point(174, 201);
            txtFt.Name = "txtFt";
            txtFt.Size = new Size(52, 27);
            txtFt.TabIndex = 4;
            txtFt.Text = "英尺";
            txtFt.Click += label5_Click;
            // 
            // txtYard
            // 
            txtYard.AutoSize = true;
            txtYard.Font = new Font("Microsoft YaHei UI", 15F);
            txtYard.Location = new Point(303, 201);
            txtYard.Name = "txtYard";
            txtYard.Size = new Size(32, 27);
            txtYard.TabIndex = 5;
            txtYard.Text = "碼";
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
            // txtInfo
            // 
            txtInfo.AutoSize = true;
            txtInfo.Font = new Font("Microsoft YaHei UI", 15F);
            txtInfo.Location = new Point(64, 297);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(92, 27);
            txtInfo.TabIndex = 7;
            txtInfo.Text = "説明文字";
            // 
            // btnAllClear
            // 
            btnAllClear.Font = new Font("Microsoft YaHei UI", 15F);
            btnAllClear.Location = new Point(65, 27);
            btnAllClear.Name = "btnAllClear";
            btnAllClear.Size = new Size(123, 34);
            btnAllClear.TabIndex = 8;
            btnAllClear.Text = "清除";
            btnAllClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(291, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 246);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(86, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(291, 246);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 23);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(64, 345);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(359, 23);
            textBox7.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 466);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAllClear);
            Controls.Add(txtInfo);
            Controls.Add(label7);
            Controls.Add(txtYard);
            Controls.Add(txtFt);
            Controls.Add(txtIn);
            Controls.Add(txtKM);
            Controls.Add(txtM);
            Controls.Add(txtCM);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCM;
        private Label txtM;
        private Label txtKM;
        private Label txtIn;
        private Label txtFt;
        private Label txtYard;
        private Label label7;
        private Label txtInfo;
        private Button btnAllClear;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}
