using System.Text;

namespace MattScerri.Fanatec.V3.PedalCurve
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("preAlpha build v0.0.6");
            sb.AppendLine();
            sb.AppendLine("USE AT YOUR OWN RISK!");
            sb.AppendLine();
            sb.AppendLine("MIT LICENSE");
            sb.AppendLine();
            sb.AppendLine("Copyright 2023 Matthew Scerri");
            sb.AppendLine();
            sb.AppendLine("Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:");
            sb.AppendLine();
            sb.AppendLine("The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.");
            sb.AppendLine();
            sb.AppendLine("THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.");
            sb.AppendLine();
            sb.AppendLine("----");
            sb.AppendLine();
            sb.AppendLine("Special Thanks to the TDi99Gaming community and zaid92 for testing on different devices - https://www.youtube.com/@Tdi99");
            sb.AppendLine();
            sb.AppendLine("----");
            sb.AppendLine();
            sb.AppendLine("If someone from Fanatec reads this, please add this functionality in your Control Panel to prevent atrocities like this software from having to exist.");
            sb.AppendLine();
            sb.AppendLine("This software uses the below software or libraries:");
            sb.AppendLine();
            sb.AppendLine("VigemClient by Benjamin Höglinger-Stelzer: https://github.com/ViGEm/ViGEmClient/blob/master/LICENSE");
            sb.AppendLine("Newtonsoft.Json by James Newton-King: https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md");
            sb.AppendLine("SharpDX by Alexandre Mutel: https://github.com/sharpdx/SharpDX/blob/master/LICENSE");
            sb.AppendLine("winforms-datavisualization by kirsan31, .NET Foundation and Contributors: https://github.com/kirsan31/winforms-datavisualization/blob/dev/LICENSE.TXT");

            tbAbout.Text = sb.ToString();

            tbAbout.ReadOnly = true;
        }
    }
}
