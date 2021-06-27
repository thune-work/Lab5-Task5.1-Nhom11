using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Lab5_Task5._1_Nhom11
{
    public partial class CalculateHash : Form
    {
        public CalculateHash()
        {
            InitializeComponent();
        }

        //Button CLOSE
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            tbInput.Text = "aaa";
        }

        //Button CALCULATE
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch (cbInputType.SelectedItem.ToString())
            {
                case "Text string":
                    tbMD5.Text = text_MD5(tbInput.Text);
                    tbSHA1.Text = text_SHA1(tbInput.Text);
                    tbSHA256.Text = text_SHA256(tbInput.Text);
                    tbSHA384.Text = text_SHA384(tbInput.Text);
                    tbSHA512.Text = text_SHA512(tbInput.Text);
                    break;
                case "Hex string":
                    tbMD5.Text = hex_MD5(tbInput.Text);
                    tbSHA1.Text = hex_SHA1(tbInput.Text);
                    tbSHA256.Text = hex_SHA256(tbInput.Text);
                    tbSHA384.Text = hex_SHA384(tbInput.Text);
                    tbSHA512.Text = hex_SHA512(tbInput.Text);
                    break;
                case "File":
                    string filename = tbInput.Text;
                    //Console.WriteLine(file_MD5(filename));
                    tbMD5.Text = file_MD5(filename);
                    tbSHA1.Text = file_SHA1(filename);
                    tbSHA256.Text = file_SHA256(filename);
                    tbSHA384.Text = file_SHA384(filename);
                    tbSHA512.Text = file_SHA512(filename);
                    break;
            }
        }

        private string HexToString(string InputText)
        {
            byte[] bb = Enumerable.Range(0, InputText.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(InputText.Substring(x, 2), 16))
                     .ToArray();
            return System.Text.Encoding.ASCII.GetString(bb);
        }

        private string ByteToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }

        //TEXT
        private string text_MD5(string text)
        {
            MD5 md5 = MD5.Create();
            return ByteToString(md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text)));
        }

        private string text_SHA1(string text)
        {
            SHA1 sha1 = SHA1.Create();
            return ByteToString(sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text)));
        }

        private string text_SHA256(string text)
        {
            SHA256 sha256 = SHA256.Create();
            return ByteToString(sha256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text)));
        }

        private string text_SHA384(string text)
        {
            SHA384 sha384 = SHA384.Create();
            return ByteToString(sha384.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text)));
        }

        private string text_SHA512(string text)
        {
            SHA512 sha512 = SHA512.Create();
            return ByteToString(sha512.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text)));
        }

        //HEX
        private string hex_MD5(string s)
        {
            s = HexToString(s);
            return text_MD5(s);
        }

        private string hex_SHA1(string s)
        {
            s = HexToString(s);
            return text_SHA1(s);
        }

        private string hex_SHA256(string s)
        {
            s = HexToString(s);
            return text_SHA256(s);
        }

        private string hex_SHA384(string s)
        {
            s = HexToString(s);
            return text_SHA384(s);
        }

        private string hex_SHA512(string s)
        {
            s = HexToString(s);
            return text_SHA512(s);
        }

        //FILE
        private string file_MD5(string filename)
        {
            FileStream stream = File.OpenRead(filename);
            MD5 md5 = MD5.Create();
            string hash = ByteToString(md5.ComputeHash(stream));
            stream.Close();
            return hash;
        }

        private string file_SHA1(string filename)
        {
            FileStream stream = File.OpenRead(filename);
            SHA1 sha1 = SHA1.Create();
            string hash = ByteToString(sha1.ComputeHash(stream));
            stream.Close();
            return hash;
        }

        private string file_SHA256(string filename)
        {
            FileStream stream = File.OpenRead(filename);
            SHA256 sha256 = SHA256.Create();
            string hash = ByteToString(sha256.ComputeHash(stream));
            stream.Close();
            return hash;
        }

        private string file_SHA384(string filename)
        {
            FileStream stream = File.OpenRead(filename);
            SHA384 sha384 = SHA384.Create();
            string hash = ByteToString(sha384.ComputeHash(stream));
            stream.Close();
            return hash;
        }

        private string file_SHA512(string filename)
        {
            FileStream stream = File.OpenRead(filename);
            SHA512 sha512 = SHA512.Create();
            string hash = ByteToString(sha512.ComputeHash(stream));
            stream.Close();
            return hash;
        }

        //ComboBox CHANGE
        private void cbInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.Text = "";
            tbMD5.Text = "";
            tbSHA1.Text = "";
            tbSHA256.Text = "";
            tbSHA384.Text = "";
            tbSHA512.Text = "";
        }
    }
}
