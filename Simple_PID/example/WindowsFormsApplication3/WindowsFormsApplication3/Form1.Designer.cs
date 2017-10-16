namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Kp_textBox = new System.Windows.Forms.TextBox();
            this.Ki_textBox = new System.Windows.Forms.TextBox();
            this.Kd_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Output_label = new System.Windows.Forms.Label();
            this.dt_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SetPoint_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SetBtn
            // 
            this.SetBtn.Location = new System.Drawing.Point(328, 200);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(66, 47);
            this.SetBtn.TabIndex = 0;
            this.SetBtn.Text = "Set";
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "PID Lab";
            // 
            // Kp_textBox
            // 
            this.Kp_textBox.Location = new System.Drawing.Point(12, 112);
            this.Kp_textBox.Name = "Kp_textBox";
            this.Kp_textBox.Size = new System.Drawing.Size(100, 36);
            this.Kp_textBox.TabIndex = 4;
            this.Kp_textBox.Text = "0.5";
            this.Kp_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ki_textBox
            // 
            this.Ki_textBox.Location = new System.Drawing.Point(106, 112);
            this.Ki_textBox.Name = "Ki_textBox";
            this.Ki_textBox.Size = new System.Drawing.Size(100, 36);
            this.Ki_textBox.TabIndex = 5;
            this.Ki_textBox.Text = "0.5";
            this.Ki_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kd_textBox
            // 
            this.Kd_textBox.Location = new System.Drawing.Point(202, 112);
            this.Kd_textBox.Name = "Kd_textBox";
            this.Kd_textBox.Size = new System.Drawing.Size(100, 36);
            this.Kd_textBox.TabIndex = 6;
            this.Kd_textBox.Text = "0.1";
            this.Kd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(15, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Output:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Font = new System.Drawing.Font("PMingLiU", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Output_label.Location = new System.Drawing.Point(152, 383);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(25, 27);
            this.Output_label.TabIndex = 12;
            this.Output_label.Text = "0";
            // 
            // dt_textBox
            // 
            this.dt_textBox.Location = new System.Drawing.Point(257, 200);
            this.dt_textBox.Name = "dt_textBox";
            this.dt_textBox.Size = new System.Drawing.Size(43, 36);
            this.dt_textBox.TabIndex = 13;
            this.dt_textBox.Text = "0.1";
            this.dt_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "dt";
            // 
            // SetPoint_textBox
            // 
            this.SetPoint_textBox.Location = new System.Drawing.Point(12, 200);
            this.SetPoint_textBox.Name = "SetPoint_textBox";
            this.SetPoint_textBox.Size = new System.Drawing.Size(100, 36);
            this.SetPoint_textBox.TabIndex = 15;
            this.SetPoint_textBox.Text = "10";
            this.SetPoint_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Set Point (target)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(435, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 550);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SetPoint_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_textBox);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kd_textBox);
            this.Controls.Add(this.Ki_textBox);
            this.Controls.Add(this.Kp_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kp_textBox;
        private System.Windows.Forms.TextBox Ki_textBox;
        private System.Windows.Forms.TextBox Kd_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.TextBox dt_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SetPoint_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

