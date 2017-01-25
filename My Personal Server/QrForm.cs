using Newtonsoft.Json.Linq;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Personal_Server
{
    public partial class QrForm : Form
    {
        public QrForm(String url, String username, String password)
        {
            InitializeComponent();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            JObject serverInfoJson = new JObject(
                new JProperty("url", url), 
                new JProperty("username", username),
                new JProperty("password", password));
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(serverInfoJson.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrPictureBox.BackgroundImage = qrCodeImage;
        }
    }
}
