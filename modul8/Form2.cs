using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace modul8
{
    public partial class Form2 : Form
    {

        Form1 f1;

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap qr;
            string nama = f1.txtName.Text;
            string alamat = f1.txtAlamat.Text;
            string no_hp = f1.txtNo_handphone.Text;
            lb_qr.Text = GenerateQR(nama, alamat, no_hp, out qr);

            pb_qr.BackgroundImage = qr;
        }

        public static string GenerateQR(string nama, string alamat, string no_handphone)
        {
            string result = "#" + nama + alamat + no_handphone;
            return result;
        }

        public static string GenerateQR(string nama, string alamat, string no_handphone, out Bitmap bitmap)
        {
            string text = GenerateQR(nama, alamat, no_handphone);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            bitmap = qrCode.GetGraphic(7);
            return text;
        }



    }
}
