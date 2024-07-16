namespace WinFormsApp4
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
            richTextBox1 = new RichTextBox();
            to = new RichTextBox();
            tc = new RichTextBox();
            b1 = new Button();
            b3 = new Button();
            b2 = new Button();
            b0 = new Button();
            b7 = new Button();
            b4 = new Button();
            b6 = new Button();
            b5 = new Button();
            b8 = new Button();
            b9 = new Button();
            ba = new Button();
            ti = new TextBox();
            bw = new Button();
            bd = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(715, 130);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "Enter your PIN";
            // 
            // to
            // 
            to.Location = new Point(348, 172);
            to.Name = "to";
            to.Size = new Size(399, 105);
            to.TabIndex = 4;
            to.Text = "";
            to.TextChanged += to_TextChanged;
            // 
            // tc
            // 
            tc.Location = new Point(348, 312);
            tc.Name = "tc";
            tc.Size = new Size(399, 59);
            tc.TabIndex = 5;
            tc.Text = "";
            // 
            // b1
            // 
            b1.Location = new Point(32, 172);
            b1.Name = "b1";
            b1.Size = new Size(74, 46);
            b1.TabIndex = 6;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b3
            // 
            b3.Location = new Point(231, 172);
            b3.Name = "b3";
            b3.Size = new Size(74, 46);
            b3.TabIndex = 7;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.Location = new Point(135, 172);
            b2.Name = "b2";
            b2.Size = new Size(74, 46);
            b2.TabIndex = 8;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b0
            // 
            b0.Location = new Point(32, 382);
            b0.Name = "b0";
            b0.Size = new Size(74, 46);
            b0.TabIndex = 9;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // b7
            // 
            b7.Location = new Point(32, 312);
            b7.Name = "b7";
            b7.Size = new Size(74, 46);
            b7.TabIndex = 10;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b4
            // 
            b4.Location = new Point(32, 247);
            b4.Name = "b4";
            b4.Size = new Size(74, 46);
            b4.TabIndex = 11;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b6
            // 
            b6.Location = new Point(231, 247);
            b6.Name = "b6";
            b6.Size = new Size(74, 46);
            b6.TabIndex = 12;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.Location = new Point(135, 247);
            b5.Name = "b5";
            b5.Size = new Size(74, 46);
            b5.TabIndex = 13;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b8
            // 
            b8.Location = new Point(135, 312);
            b8.Name = "b8";
            b8.Size = new Size(74, 46);
            b8.TabIndex = 14;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(231, 312);
            b9.Name = "b9";
            b9.Size = new Size(74, 46);
            b9.TabIndex = 15;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // ba
            // 
            ba.Location = new Point(135, 382);
            ba.Name = "ba";
            ba.Size = new Size(170, 46);
            ba.TabIndex = 16;
            ba.Text = "ans";
            ba.UseVisualStyleBackColor = true;
            ba.Click += ba_Click;
            // 
            // ti
            // 
            ti.Location = new Point(180, 23);
            ti.Name = "ti";
            ti.Size = new Size(125, 27);
            ti.TabIndex = 17;
            // 
            // bw
            // 
            bw.Location = new Point(348, 391);
            bw.Name = "bw";
            bw.Size = new Size(190, 29);
            bw.TabIndex = 18;
            bw.Text = "Withdraw";
            bw.UseVisualStyleBackColor = true;
            bw.Click += bw_Click;
            // 
            // bd
            // 
            bd.Location = new Point(557, 391);
            bd.Name = "bd";
            bd.Size = new Size(190, 29);
            bd.TabIndex = 19;
            bd.Text = "Deposit";
            bd.UseVisualStyleBackColor = true;
            bd.Click += bd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bd);
            Controls.Add(bw);
            Controls.Add(ti);
            Controls.Add(ba);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b5);
            Controls.Add(b6);
            Controls.Add(b4);
            Controls.Add(b7);
            Controls.Add(b0);
            Controls.Add(b2);
            Controls.Add(b3);
            Controls.Add(b1);
            Controls.Add(tc);
            Controls.Add(to);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox to;
        private RichTextBox tc;
        private Button b1;
        private Button b3;
        private Button b2;
        private Button b0;
        private Button b7;
        private Button b4;
        private Button b6;
        private Button b5;
        private Button b8;
        private Button b9;
        private Button ba;
        private TextBox ti;
        private Button bw;
        private Button bd;
    }
}
