using System.Collections.Generic;
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
            using (WebClient wc = new WebClient())
            {
                line = wc.DownloadString("http://ipwho.is/" + IpField.Text + "?output=xml");
            }
            Match match = Regex.Match(line, "<country_code>(.*?)</country_code> ");

            dict["Ip"] = match.Groups[1].Value;
            dict["Country"] = match.Groups[1].Value;
            dict["City"] = match.Groups[1].Value;
            dict["Currency"] = match.Groups[1].Value;
            dict["Anonim"] = match.Groups[1].Value;
            dict["Proxy"] = match.Groups[1].Value;
            dict["VPN"] = match.Groups[1].Value;
            dict["TOR"] = match.Groups[1].Value;
            dict["Lat"] = match.Groups[1].Value;
            dict["Long"] = match.Groups[1].Value;

            outputLabel.Text = line;

        }

        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            { "Ip", ""},
            { "Country", ""},
            { "City", ""},
            { "Currency", ""},
            { "Anonim", ""},
            { "Proxy", ""},
            { "VPN", ""},
            { "TOR", ""},
            { "Lat", ""},
            { "Long", ""},

        };

    }
}
