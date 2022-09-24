namespace Fractals
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ktb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.startBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ictb = new System.Windows.Forms.TextBox();
            this.rctb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yntb = new System.Windows.Forms.TextBox();
            this.y0tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xntb = new System.Windows.Forms.TextBox();
            this.x0tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ktb);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.startBut);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.ictb);
            this.splitContainer1.Panel2.Controls.Add(this.rctb);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.yntb);
            this.splitContainer1.Panel2.Controls.Add(this.y0tb);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.xntb);
            this.splitContainer1.Panel2.Controls.Add(this.x0tb);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1158, 646);
            this.splitContainer1.SplitterDistance = 956;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ktb
            // 
            this.ktb.Location = new System.Drawing.Point(23, 253);
            this.ktb.Name = "ktb";
            this.ktb.Size = new System.Drawing.Size(70, 22);
            this.ktb.TabIndex = 14;
            this.ktb.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "K";
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(23, 292);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(161, 40);
            this.startBut.TabIndex = 12;
            this.startBut.Text = "Start";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Xn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "+i";
            // 
            // ictb
            // 
            this.ictb.Location = new System.Drawing.Point(114, 195);
            this.ictb.Name = "ictb";
            this.ictb.Size = new System.Drawing.Size(70, 22);
            this.ictb.TabIndex = 8;
            this.ictb.Text = "0,36";
            // 
            // rctb
            // 
            this.rctb.Location = new System.Drawing.Point(23, 195);
            this.rctb.Name = "rctb";
            this.rctb.Size = new System.Drawing.Size(70, 22);
            this.rctb.TabIndex = 7;
            this.rctb.Text = "0,36";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // yntb
            // 
            this.yntb.Location = new System.Drawing.Point(114, 125);
            this.yntb.Name = "yntb";
            this.yntb.Size = new System.Drawing.Size(70, 22);
            this.yntb.TabIndex = 5;
            this.yntb.Text = "1,0";
            // 
            // y0tb
            // 
            this.y0tb.Location = new System.Drawing.Point(23, 125);
            this.y0tb.Name = "y0tb";
            this.y0tb.Size = new System.Drawing.Size(70, 22);
            this.y0tb.TabIndex = 4;
            this.y0tb.Text = "-1,1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y0";
            // 
            // xntb
            // 
            this.xntb.Location = new System.Drawing.Point(114, 54);
            this.xntb.Name = "xntb";
            this.xntb.Size = new System.Drawing.Size(70, 22);
            this.xntb.TabIndex = 2;
            this.xntb.Text = "0,9";
            // 
            // x0tb
            // 
            this.x0tb.Location = new System.Drawing.Point(23, 54);
            this.x0tb.Name = "x0tb";
            this.x0tb.Size = new System.Drawing.Size(70, 22);
            this.x0tb.TabIndex = 1;
            this.x0tb.Text = "-0,9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 646);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ictb;
        private System.Windows.Forms.TextBox rctb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yntb;
        private System.Windows.Forms.TextBox y0tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xntb;
        private System.Windows.Forms.TextBox x0tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.TextBox ktb;
        private System.Windows.Forms.Label label8;
    }
}

