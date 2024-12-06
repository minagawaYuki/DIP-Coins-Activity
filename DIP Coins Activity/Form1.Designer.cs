namespace DIP_Coins_Activity
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalCoinCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Peso5Count = new System.Windows.Forms.Label();
            this.Peso1Count = new System.Windows.Forms.Label();
            this.Cent25Count = new System.Windows.Forms.Label();
            this.Cent10Count = new System.Windows.Forms.Label();
            this.Cent5Count = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.countToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(835, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.countToolStripMenuItem.Text = "Count";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.countToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(429, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 439);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL COINS :";
            // 
            // TotalCoinCount
            // 
            this.TotalCoinCount.AutoSize = true;
            this.TotalCoinCount.Location = new System.Drawing.Point(193, 528);
            this.TotalCoinCount.Name = "TotalCoinCount";
            this.TotalCoinCount.Size = new System.Drawing.Size(11, 16);
            this.TotalCoinCount.TabIndex = 5;
            this.TotalCoinCount.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "COUNT FOR EACH ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "5 Peso :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "1 Peso :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 644);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "25 Cents :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "10 Cents :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "5 Cents :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "TOTAL VALUE :";
            // 
            // Peso5Count
            // 
            this.Peso5Count.AutoSize = true;
            this.Peso5Count.Location = new System.Drawing.Point(528, 568);
            this.Peso5Count.Name = "Peso5Count";
            this.Peso5Count.Size = new System.Drawing.Size(11, 16);
            this.Peso5Count.TabIndex = 13;
            this.Peso5Count.Text = "-";
            // 
            // Peso1Count
            // 
            this.Peso1Count.AutoSize = true;
            this.Peso1Count.Location = new System.Drawing.Point(528, 605);
            this.Peso1Count.Name = "Peso1Count";
            this.Peso1Count.Size = new System.Drawing.Size(11, 16);
            this.Peso1Count.TabIndex = 14;
            this.Peso1Count.Text = "-";
            // 
            // Cent25Count
            // 
            this.Cent25Count.AutoSize = true;
            this.Cent25Count.Location = new System.Drawing.Point(528, 644);
            this.Cent25Count.Name = "Cent25Count";
            this.Cent25Count.Size = new System.Drawing.Size(11, 16);
            this.Cent25Count.TabIndex = 15;
            this.Cent25Count.Text = "-";
            // 
            // Cent10Count
            // 
            this.Cent10Count.AutoSize = true;
            this.Cent10Count.Location = new System.Drawing.Point(759, 568);
            this.Cent10Count.Name = "Cent10Count";
            this.Cent10Count.Size = new System.Drawing.Size(11, 16);
            this.Cent10Count.TabIndex = 16;
            this.Cent10Count.Text = "-";
            // 
            // Cent5Count
            // 
            this.Cent5Count.AutoSize = true;
            this.Cent5Count.Location = new System.Drawing.Point(759, 605);
            this.Cent5Count.Name = "Cent5Count";
            this.Cent5Count.Size = new System.Drawing.Size(11, 16);
            this.Cent5Count.TabIndex = 17;
            this.Cent5Count.Text = "-";
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.Location = new System.Drawing.Point(193, 591);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(11, 16);
            this.TotalValue.TabIndex = 18;
            this.TotalValue.Text = "-";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 712);
            this.Controls.Add(this.TotalValue);
            this.Controls.Add(this.Cent5Count);
            this.Controls.Add(this.Cent10Count);
            this.Controls.Add(this.Cent25Count);
            this.Controls.Add(this.Peso1Count);
            this.Controls.Add(this.Peso5Count);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalCoinCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalCoinCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Peso5Count;
        private System.Windows.Forms.Label Peso1Count;
        private System.Windows.Forms.Label Cent25Count;
        private System.Windows.Forms.Label Cent10Count;
        private System.Windows.Forms.Label Cent5Count;
        private System.Windows.Forms.Label TotalValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

