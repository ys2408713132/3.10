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
            q = new Label();
            o = new Label();
            p = new Label();
            i = new Label();
            u = new Label();
            y = new Label();
            label7 = new Label();
            yt = new Label();
            btnAllClear = new Button();
            txtCM = new TextBox();
            txtM = new TextBox();
            txtKM = new TextBox();
            txtIn = new TextBox();
            txtFt = new TextBox();
            txtYard = new TextBox();
            txtInfo = new TextBox();
            SuspendLayout();
            // 
            // q
            // 
            q.AutoSize = true;
            q.Font = new Font("Microsoft YaHei UI", 15F);
            q.Location = new Point(64, 94);
            q.Name = "q";
            q.Size = new Size(52, 27);
            q.TabIndex = 0;
            q.Text = "公分";
            q.Click += label1_Click;
            // 
            // o
            // 
            o.AutoSize = true;
            o.Font = new Font("Microsoft YaHei UI", 15F);
            o.Location = new Point(174, 94);
            o.Name = "o";
            o.Size = new Size(52, 27);
            o.TabIndex = 1;
            o.Text = "公尺";
            // 
            // p
            // 
            p.AutoSize = true;
            p.Font = new Font("Microsoft YaHei UI", 15F);
            p.Location = new Point(291, 94);
            p.Name = "p";
            p.Size = new Size(52, 27);
            p.TabIndex = 2;
            p.Text = "公里";
            // 
            // i
            // 
            i.AutoSize = true;
            i.Font = new Font("Microsoft YaHei UI", 15F);
            i.Location = new Point(64, 201);
            i.Name = "i";
            i.Size = new Size(52, 27);
            i.TabIndex = 3;
            i.Text = "英寸";
            i.Click += label4_Click;
            // 
            // u
            // 
            u.AutoSize = true;
            u.Font = new Font("Microsoft YaHei UI", 15F);
            u.Location = new Point(174, 201);
            u.Name = "u";
            u.Size = new Size(52, 27);
            u.TabIndex = 4;
            u.Text = "英尺";
            u.Click += label5_Click;
            // 
            // y
            // 
            y.AutoSize = true;
            y.Font = new Font("Microsoft YaHei UI", 15F);
            y.Location = new Point(303, 201);
            y.Name = "y";
            y.Size = new Size(32, 27);
            y.TabIndex = 5;
            y.Text = "碼";
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
            // yt
            // 
            yt.AutoSize = true;
            yt.Font = new Font("Microsoft YaHei UI", 15F);
            yt.Location = new Point(64, 297);
            yt.Name = "yt";
            yt.Size = new Size(92, 27);
            yt.TabIndex = 7;
            yt.Text = "説明文字";
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
            // txtCM
            // 
            txtCM.Location = new Point(64, 152);
            txtCM.Name = "txtCM";
            txtCM.Size = new Size(86, 23);
            txtCM.TabIndex = 9;
            txtCM.KeyUp += txtCM_KeyUp;
            // 
            // txtM
            // 
            txtM.Location = new Point(174, 152);
            txtM.Name = "txtM";
            txtM.Size = new Size(86, 23);
            txtM.TabIndex = 10;
            txtM.KeyUp += txtM_KeyUp;
            // 
            // txtKM
            // 
            txtKM.Location = new Point(291, 152);
            txtKM.Name = "txtKM";
            txtKM.Size = new Size(86, 23);
            txtKM.TabIndex = 11;
            // 
            // txtIn
            // 
            txtIn.Location = new Point(64, 246);
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(86, 23);
            txtIn.TabIndex = 12;
            // 
            // txtFt
            // 
            txtFt.Location = new Point(174, 246);
            txtFt.Name = "txtFt";
            txtFt.Size = new Size(86, 23);
            txtFt.TabIndex = 13;
            // 
            // txtYard
            // 
            txtYard.Location = new Point(291, 246);
            txtYard.Name = "txtYard";
            txtYard.Size = new Size(86, 23);
            txtYard.TabIndex = 14;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(64, 345);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(359, 23);
            txtInfo.TabIndex = 15;
            txtInfo.TextChanged += txtInfo_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 466);
            Controls.Add(txtInfo);
            Controls.Add(txtYard);
            Controls.Add(txtFt);
            Controls.Add(txtIn);
            Controls.Add(txtKM);
            Controls.Add(txtM);
            Controls.Add(txtCM);
            Controls.Add(btnAllClear);
            Controls.Add(yt);
            Controls.Add(label7);
            Controls.Add(y);
            Controls.Add(u);
            Controls.Add(i);
            Controls.Add(p);
            Controls.Add(o);
            Controls.Add(q);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label q;
        private Label o;
        private Label p;
        private Label i;
        private Label u;
        private Label y;
        private Label label7;
        private Label yt;
        private Button btnAllClear;
        private TextBox txtCM;
        private TextBox txtM;
        private TextBox txtKM;
        private TextBox txtIn;
        private TextBox txtFt;
        private TextBox txtYard;
        private TextBox txtInfo;
    }
}
