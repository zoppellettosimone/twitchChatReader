using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchChatReader
{
    public partial class TwitchForm : Form
    {
        public TwitchForm()
        {
            InitializeComponent();
        }

        private void UserBotton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if(channelTextBox.Text.TrimStart().TrimEnd().Length > 0)
            {
                string fileTemplate = File.ReadAllText("..\\..\\..\\..\\..\\indexTemplate.js");
                string newText = fileTemplate.Replace("@TextToChange", channelTextBox.Text.TrimStart().TrimEnd());

                File.WriteAllText("..\\..\\..\\..\\..\\" + channelTextBox.Text.TrimStart().TrimEnd().ToLower() + ".js", newText);

                string textForBat = "cd ..\ncd ..\ncd ..\ncd ..\ncd ..\nnode " + channelTextBox.Text.ToLower() + ".js";

                File.WriteAllText("..\\..\\..\\..\\..\\" + channelTextBox.Text.TrimStart().TrimEnd().ToLower() + ".bat", textForBat);

                Process.Start("..\\..\\..\\..\\..\\" + channelTextBox.Text.TrimStart().TrimEnd().ToLower() + ".bat");
            }
        }
    }
}
