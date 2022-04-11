namespace ptb2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kq = new System.Windows.Forms.Button();
            this.btn_resfesh = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.Lb_kq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_kq1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(188, 46);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(119, 23);
            this.txt_a.TabIndex = 1;
            this.txt_a.Text = "0";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(188, 94);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(119, 23);
            this.txt_b.TabIndex = 3;
            this.txt_b.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số b";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(188, 140);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(119, 23);
            this.txt_c.TabIndex = 5;
            this.txt_c.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hệ số c";
            // 
            // btn_kq
            // 
            this.btn_kq.Location = new System.Drawing.Point(83, 205);
            this.btn_kq.Name = "btn_kq";
            this.btn_kq.Size = new System.Drawing.Size(75, 23);
            this.btn_kq.TabIndex = 6;
            this.btn_kq.Text = "Kết quả";
            this.btn_kq.UseVisualStyleBackColor = true;
            this.btn_kq.Click += new System.EventHandler(this.btn_kq_Click);
            // 
            // btn_resfesh
            // 
            this.btn_resfesh.Location = new System.Drawing.Point(222, 205);
            this.btn_resfesh.Name = "btn_resfesh";
            this.btn_resfesh.Size = new System.Drawing.Size(75, 23);
            this.btn_resfesh.TabIndex = 7;
            this.btn_resfesh.Text = "Resfresh";
            this.btn_resfesh.UseVisualStyleBackColor = true;
            this.btn_resfesh.Click += new System.EventHandler(this.btn_resfesh_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(348, 205);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Lb_kq
            // 
            this.Lb_kq.AutoSize = true;
            this.Lb_kq.Location = new System.Drawing.Point(188, 264);
            this.Lb_kq.Name = "Lb_kq";
            this.Lb_kq.Size = new System.Drawing.Size(0, 15);
            this.Lb_kq.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "  ";
            // 
            // lb_kq1
            // 
            this.lb_kq1.AutoSize = true;
            this.lb_kq1.Location = new System.Drawing.Point(276, 355);
            this.lb_kq1.Name = "lb_kq1";
            this.lb_kq1.Size = new System.Drawing.Size(0, 15);
            this.lb_kq1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lb_kq1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lb_kq);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_resfesh);
            this.Controls.Add(this.btn_kq);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kq;
        private System.Windows.Forms.Button btn_resfesh;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label Lb_kq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_kq1;
    }
}
