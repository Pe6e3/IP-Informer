using Svg;
using Svg.Transforms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IpInformer_WF.NET_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IpField.TextChanged += (s, e) => CheckValidIP(s);
            startBtn.Click += (s, e) => CheckIp();
            IpField.KeyDown += (s, e) => { if (e.KeyData == Keys.Return) CheckIp(); };
        }

        void CheckValidIP(object component)
        {
            if (component is TextBox textBox)
                if (Regex.IsMatch(textBox.Text, "[^0-9-.]"))
                {
                    textBox.Text = textBox.Text.Remove(textBox.TextLength - 1);
                    textBox.SelectionStart = textBox.TextLength;
                }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IpField.TextChanged -= (s, e_) => CheckValidIP(s);
        }

        async void CheckIp()
        {
            string line = "";
            flagPicture.BackgroundImage = null;
            using (WebClient wc = new WebClient())
                line = wc.DownloadString($"http://ipwho.is/{IpField.Text}?output=xml");


            string matchQuery = @"<ip>(?<Ip>.*?)</ip>(.*?)<country>(?<Country>.*?)</country>(.*?)<city>(?<City>.*?)</city>(.*?)<latitude>(?<Lat>.*?)</latitude>(.*?)<longitude>(?<Long>.*?)</longitude>(.*?)<img>(?<Flag>.*?)</img>";

            Match match = Regex.Match(line, matchQuery);


            dict["Ip"] = match.Groups["Ip"].ToString();
            dict["Country"] = match.Groups["Country"].ToString();
            dict["City"] = match.Groups["City"].ToString();
            dict["Lat"] = match.Groups["Lat"].ToString();
            dict["Long"] = match.Groups["Long"].ToString();
            dict["Flag"] = match.Groups["Flag"].ToString();

            Ip_field.Text = dict["Ip"];
            country_field.Text = dict["Country"];
            city_field.Text = dict["City"];
            lat_field.Text = dict["Lat"];
            long_field.Text = dict["Long"];
            mapBtn.Enabled = true;

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    string svgContent = webClient.DownloadString(dict["Flag"].ToString());

                    SvgDocument svgDocument = SvgDocument.FromSvg<SvgDocument>(svgContent);

                    int desiredWidth = 32;
                    int desiredHeight = 24;

                    // Масштабируем SVG-изображение до нужных размеров
                    svgDocument.Transforms = new SvgTransformCollection();
                    svgDocument.Transforms.Add(new SvgScale(desiredWidth / svgDocument.Width, desiredHeight / svgDocument.Height));

                    // Создаем растровое изображение с учетом масштаба
                    Bitmap bitmap = svgDocument.Draw();

                    flagPicture.BackgroundImage = bitmap;
                    flagPicture.Size = new Size(desiredWidth, desiredHeight);
                    flagPicture.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка. (Скорее всего введен несуществующий IP)");
            }



        }

        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            { "Ip", ""},
            { "Country", ""},
            { "City", ""},
            { "Lat", ""},
            { "Long", ""},
            { "Flag", ""},
        };

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mapBtn_Click(object sender, EventArgs e)
        {
            string mapUrl = $"https://www.google.com/maps/@{dict["Lat"]},{dict["Long"]},10.58z?entry=ttu";
            Process.Start(mapUrl);
            //browser.Url = new Uri(mapUrl);
        }
    }
}
