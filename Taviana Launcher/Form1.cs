using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace Taviana_Launcher
{
    public partial class Form1 : Form
    {
        public string errors;
        public string args;
        public bool hasError;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!hasError)
            {
                text_StatusLabel.Text = "Settings are valid!";
                text_StatusLabel.BackColor = Color.Green;
                text_StatusLabel.Left = ((text_StatusLabel.Parent.Width - text_StatusLabel.Width)/2);
                button_Action.Text = "Launch Taviana Epoch!";
            }
            else
            {
                text_StatusLabel.Text = "ERROR! Arma Reg Key Invalid";
                text_StatusLabel.BackColor = Color.Red;
                text_StatusLabel.Left = ((text_StatusLabel.Parent.Width - text_StatusLabel.Width) / 2);
                button_Action.Text = "Solve it!";
            }
        }

        private void appStart()
        {

        }

        private string ARMAPath(string key) {
            // The name of the key must include a valid root. 
            const string userRoot = "HKEY_LOCAL_MACHINE";
            string subkey = "SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA";
            string keyName = userRoot + "\\" + subkey;

            string mainPath = (String)Registry.GetValue(keyName, "main", "");
            string expPath = (String)Registry.GetValue(keyName, "DATA", "");

            subkey = "SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2";
            keyName = userRoot + "\\" + subkey;

            string ARMA2mainPath = (String)Registry.GetValue(keyName, "main", "");
            string ARMA2expPath = (String)Registry.GetValue(keyName, "DATA", "");

            string returned = "";

            if (key == "path")
            {
                returned = mainPath;
            }
            if (key == "exp")
            {
                returned = expPath;
            }
            if (key == "arma2path") {
                returned = ARMA2mainPath;
            }
            if (key == "arma2exp") {
                returned = ARMA2expPath;
            }

            return returned;

        }

        private void appChecks()
        {
            string main = ARMAPath("main");
            string exp = ARMAPath("exp");
            string _2main = ARMAPath("arma2main");
            string _2exp = ARMAPath("arma2exp");

            string errorList = "";

            if (main == "")
            {
                errorList = errorList + " | ARMA 2 OA Main Key cannot be found!";
            }
            if (exp == "")
            {
                errorList = errorList + " | ARMA 2 OA Expansion Key cannot be found!"; 
            }
            if (_2main == "")
            {
                errorList = errorList + " | ARMA 2 Main Key cannot be found!";
            }
            if (_2exp == "")
            {
                errorList = errorList + " | ARMA 2 Expansion Key cannot be found!";
            }
            errors = errorList;
            if (errorList == "")
            {

            }
            else
            {
                hasError = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.ausinsane.com/forums/index.php?/donate/");
        }

        private void button_Action_Click(object sender, EventArgs e)
        {
            if (button_Action.Text == "Launch Taviana Epoch!")
            {
                args = "-skipIntro -mod=@Taviana -noSplash -noFilePatching -world=empty -connect=103.18.206.95" + 
                    " -port=2322 \"-mod=" + ARMAPath("arma2path") + 
                    ";expansion;expansion\\beta;expansion\\beta\\expansion;@DayZ_Epoch\"" ;
                ProcessStartInfo proc = new ProcessStartInfo();
                //proc.UseShellExecute = true;
                //proc.Verb = "runas";
                proc.WorkingDirectory = ARMAPath("path");
                proc.FileName = ARMAPath("exp") + "\\beta\\" + "arma2oa.exe";
                proc.Arguments = args;
                Process.Start(proc);
            }

            if (button_Action.Text == "Solve it!")
            {
                
            }
        }

    }
}
