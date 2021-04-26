
namespace MyRSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.lbKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btKey = new System.Windows.Forms.Button();
            this.lbFile = new System.Windows.Forms.Label();
            this.btFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.tsMakeKeys = new System.Windows.Forms.ToolStripButton();
            this.tsQuit = new System.Windows.Forms.ToolStripButton();
            this.mnMakeKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMakeKeys,
            this.mnQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMakeKeys,
            this.tsQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 246);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(13, 63);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(74, 21);
            this.rbEncrypt.TabIndex = 3;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(110, 63);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(75, 21);
            this.rbDecrypt.TabIndex = 4;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(12, 87);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(147, 17);
            this.lbKey.TabIndex = 5;
            this.lbKey.Text = "Select your Public key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(15, 108);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(504, 23);
            this.tbKey.TabIndex = 6;
            // 
            // btKey
            // 
            this.btKey.Location = new System.Drawing.Point(525, 108);
            this.btKey.Name = "btKey";
            this.btKey.Size = new System.Drawing.Size(75, 23);
            this.btKey.TabIndex = 7;
            this.btKey.Text = "Browse";
            this.btKey.UseVisualStyleBackColor = true;
            this.btKey.Click += new System.EventHandler(this.btKey_Click);
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(13, 138);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(101, 17);
            this.lbFile.TabIndex = 8;
            this.lbFile.Text = "Select your file";
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(526, 158);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 23);
            this.btFile.TabIndex = 10;
            this.btFile.Text = "Browse";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(16, 158);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(504, 23);
            this.tbFile.TabIndex = 9;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Image = global::MyRSA.Properties.Resources.VideoIcon20;
            this.btStart.Location = new System.Drawing.Point(212, 187);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(146, 48);
            this.btStart.TabIndex = 11;
            this.btStart.Text = " Start Encrypt";
            this.btStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tsMakeKeys
            // 
            this.tsMakeKeys.Image = global::MyRSA.Properties.Resources.DownloadIcon;
            this.tsMakeKeys.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMakeKeys.Name = "tsMakeKeys";
            this.tsMakeKeys.Size = new System.Drawing.Size(125, 32);
            this.tsMakeKeys.Text = "Make Keys";
            this.tsMakeKeys.Click += new System.EventHandler(this.tsMakeKeys_Click);
            // 
            // tsQuit
            // 
            this.tsQuit.Image = global::MyRSA.Properties.Resources.exit;
            this.tsQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuit.Name = "tsQuit";
            this.tsQuit.Size = new System.Drawing.Size(70, 32);
            this.tsQuit.Text = "Quit";
            // 
            // mnMakeKeys
            // 
            this.mnMakeKeys.Image = global::MyRSA.Properties.Resources.DownloadIcon;
            this.mnMakeKeys.Name = "mnMakeKeys";
            this.mnMakeKeys.Size = new System.Drawing.Size(130, 22);
            this.mnMakeKeys.Text = "Make Keys";
            this.mnMakeKeys.Click += new System.EventHandler(this.mnMakeKeys_Click);
            // 
            // mnQuit
            // 
            this.mnQuit.Image = global::MyRSA.Properties.Resources.exit;
            this.mnQuit.Name = "mnQuit";
            this.mnQuit.Size = new System.Drawing.Size(130, 22);
            this.mnQuit.Text = "Quit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 268);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.btKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.rbDecrypt);
            this.Controls.Add(this.rbEncrypt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "My RSA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnMakeKeys;
        private System.Windows.Forms.ToolStripMenuItem mnQuit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsMakeKeys;
        private System.Windows.Forms.ToolStripButton tsQuit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsStatus;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btKey;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btStart;
    }
}

