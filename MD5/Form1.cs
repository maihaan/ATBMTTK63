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

namespace MD5
{
    public partial class Form1 : Form
    {
        byte[] temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            String matKhau = tbMatKhau.Text;
            String dlCanMa = tbDLCanMa.Text;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] key = md5.ComputeHash(Encoding.ASCII.GetBytes(matKhau));
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = key;
            trip.Padding = PaddingMode.PKCS7;
            trip.Mode = CipherMode.ECB;
            ICryptoTransform tran = trip.CreateEncryptor();
            byte[] ketQua = tran.TransformFinalBlock(Encoding.ASCII.GetBytes(dlCanMa), 0, dlCanMa.Length);
            temp = ketQua;
            tbKQMaHoa.Text = Encoding.ASCII.GetString(ketQua);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            String matKhau = tbMatKhau.Text;
            String dlCanMa = tbKQMaHoa.Text;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] key = md5.ComputeHash(Encoding.ASCII.GetBytes(matKhau));
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = key;
            trip.Padding = PaddingMode.PKCS7;
            trip.Mode = CipherMode.ECB;
            ICryptoTransform tran = trip.CreateDecryptor();
            byte[] ketQua = tran.TransformFinalBlock(temp, 0, temp.Length);

            tbKQGiaiMa.Text = Encoding.ASCII.GetString(ketQua);
        }
    }
}
