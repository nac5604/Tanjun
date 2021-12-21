using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanjun
{
    public partial class BasicSettings : Form
    {
        List<string> code = new List<string>();

        public BasicSettings()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Contains(" "))
            {
                txt.Text = txt.Text.Replace(" ", String.Empty);
            }

            code.Clear();
            code.Add(String.Format("const char* {0} [] = { \"{1}\", NULL };", "ArcNameList", "ArcName"));
        }

        private void autoFillFieldsBtn_Click(object sender, EventArgs e)
        {
            if (spriteNameTxt.Text != String.Empty)
            {
                spriteProfileIDTxt.Text = spriteNameTxt.Text + "Profile";
                spriteIDTxt.Text = spriteNameTxt.Text;
                spriteClassNameTxt.Text = "da" + spriteNameTxt.Text + "_c";
                spriteARCNameListTxt.Text = spriteNameTxt.Text + "NameList";
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void previewCodeBtn_Click(object sender, EventArgs e)
        {
            List<string> code = new List<string>();
        }

        private void BasicSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void BasicSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
