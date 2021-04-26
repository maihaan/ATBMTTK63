using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace MyRSA
{
    public partial class Form1 : Form
    {
        BackgroundWorker bg;
        String key = "";
        String saveFilePath = "";
        int byteBlock = 128;
        RSACryptoServiceProvider rsa0 = new RSACryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();

            bg = new BackgroundWorker();
            bg.WorkerSupportsCancellation = true;
            bg.WorkerReportsProgress = true;
            bg.DoWork += Bg_DoWork;
            bg.ProgressChanged += Bg_ProgressChanged;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btStart.Image = Properties.Resources.VideoIcon20;
            btStart.Text = " Start";
            MessageBox.Show("Completed");
        }

        private void Bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsStatus.Value = e.ProgressPercentage;
            tsStatus.PerformStep();            
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {            
            int totalCount = 0;
            using(FileStream fs = new FileStream(tbFile.Text, FileMode.Open))
            {
                byte[] buffer = new byte[byteBlock];
                int count = fs.Read(buffer, 0, byteBlock);
                FileStream fsw = new FileStream(saveFilePath, FileMode.Append);                
                while (count > 0)
                {   
                    rsa0.FromXmlString(key);
                    byte[] result = new byte[count];
                    if(rbEncrypt.Checked)
                        result = MaHoa(buffer, rsa0.ExportParameters(false));
                    else
                        result = GiaiMa(buffer, rsa0.ExportParameters(true));
                    if (result != null)
                    {
                        fsw.Write(result, 0, result.Length);
                        bg.ReportProgress(totalCount);
                        totalCount++;                        
                    }
                    count = fs.Read(buffer, 0, byteBlock);
                }
                fsw.Close();
                fsw.Dispose();
            }
        }

        private void tsMakeKeys_Click(object sender, EventArgs e)
        {
            MakeKeys();
        }

        private void MakeKeys()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            var khoaRieng = rsa.ToXmlString(true);
            var khoaCongKhai = rsa.ToXmlString(false);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Save your RSA Public key";
            sd.Filter = "My RSA Public Key (*.mrsac) | *.mrsac";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, khoaCongKhai.ToString());
            }

            sd.Title = "Save your RSA Private key";
            sd.Filter = "My RSA Private Key (*.mrsar) | *.mrsar";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, khoaRieng.ToString());
            }
        }

        private void mnMakeKeys_Click(object sender, EventArgs e)
        {
            MakeKeys();
        }

        private byte[] MaHoa(byte[] data, RSAParameters para)
        {
            try
            {
                byte[] dataEncrypted;
                using(RSACryptoServiceProvider rs = new RSACryptoServiceProvider())
                {
                    rs.ImportParameters(para);
                    dataEncrypted = rs.Encrypt(data, false);
                    return dataEncrypted;
                }    
            }
            catch
            {
                return null;
            }
        }

        private byte[] GiaiMa(byte[] data, RSAParameters para)
        {
            try
            {
                byte[] dataEncrypted;
                using (RSACryptoServiceProvider rs = new RSACryptoServiceProvider())
                {
                    rs.ImportParameters(para);
                    dataEncrypted = rs.Decrypt(data, false);
                    return dataEncrypted;
                }
            }
            catch
            {
                return null;
            }
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEncrypt.Checked)
            {
                lbKey.Text = "Select your Public key";
                btStart.Text = "Start Encrypt";
                rbDecrypt.Checked = false;
            }    
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDecrypt.Checked)
            {
                lbKey.Text = "Select your Private key";
                btStart.Text = "Start Decrypt";
                rbEncrypt.Checked = false;
            }    
        }

        private void btKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (rbEncrypt.Checked)
            {
                od.Filter = "RSA Public Keys (*.mrsac) | *.mrsac";
                od.Title = "Select your RSA Public key";
            }
            else
            {
                od.Filter = "RSA Private Keys (*.mrsar) | *.mrsar";
                od.Title = "Select your RSA Private key";
            }
            if (od.ShowDialog() == DialogResult.OK)
                tbKey.Text = od.FileName;
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (rbEncrypt.Checked)
                od.Title = "Select file to Encrypt";
            else
                od.Title = "Select file to Decrypt";
            if (od.ShowDialog() == DialogResult.OK)
                tbFile.Text = od.FileName;
        }



        private void btStart_Click(object sender, EventArgs e)
        {
            if(!File.Exists(tbKey.Text))
            {
                MessageBox.Show("Your key does not exist!");
                return;
            }    

            if(!File.Exists(tbFile.Text))
            {
                MessageBox.Show("Your file does not exist!");
                return;
            }   
            
            try
            {
                StreamReader sr = new StreamReader(tbKey.Text);
                key = sr.ReadToEnd();
            }
            catch
            {
                MessageBox.Show("Key is in use! Close other program and try again");
                return;
            }

            SaveFileDialog sd = new SaveFileDialog();
            String fielExtention = Path.GetExtension(tbFile.Text);
            sd.Filter = fielExtention + " files (*" + fielExtention + ") | *" + fielExtention;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = sd.FileName;
                btStart.Image = Properties.Resources.Stop20;
                btStart.Text = " Stop";

                // Lay thong tin ban dau cua cong viec can thuc hien
                FileInfo fi = new FileInfo(tbFile.Text);
                long byteCount = fi.Length;
                tsStatus.Maximum = (int)(byteCount / byteBlock);

                bg.RunWorkerAsync();
            }
            else
                return;            
        }
    }
}
