
namespace MD5
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDLCanMa = new System.Windows.Forms.TextBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.tbKQMaHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKQGiaiMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(13, 30);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(475, 20);
            this.tbMatKhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDLCanMa
            // 
            this.tbDLCanMa.Location = new System.Drawing.Point(13, 74);
            this.tbDLCanMa.Multiline = true;
            this.tbDLCanMa.Name = "tbDLCanMa";
            this.tbDLCanMa.Size = new System.Drawing.Size(475, 51);
            this.tbDLCanMa.TabIndex = 3;
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(13, 132);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btMaHoa.TabIndex = 4;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(13, 234);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 7;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // tbKQMaHoa
            // 
            this.tbKQMaHoa.Location = new System.Drawing.Point(13, 176);
            this.tbKQMaHoa.Multiline = true;
            this.tbKQMaHoa.Name = "tbKQMaHoa";
            this.tbKQMaHoa.Size = new System.Drawing.Size(475, 51);
            this.tbKQMaHoa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả mã hóa";
            // 
            // tbKQGiaiMa
            // 
            this.tbKQGiaiMa.Location = new System.Drawing.Point(10, 277);
            this.tbKQGiaiMa.Multiline = true;
            this.tbKQGiaiMa.Name = "tbKQGiaiMa";
            this.tbKQGiaiMa.Size = new System.Drawing.Size(475, 51);
            this.tbKQGiaiMa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả giải mã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 346);
            this.Controls.Add(this.tbKQGiaiMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.tbKQMaHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.tbDLCanMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDLCanMa;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.TextBox tbKQMaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKQGiaiMa;
        private System.Windows.Forms.Label label4;
    }
}

