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
            this.Close();
        }

        private void spriteTypeLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.currentProject.spriteType = spriteTypeLst.SelectedIndex;

            spriteProfileIDTxt.Enabled = (Program.currentProject.spriteType == 1) ? true : false;
            spriteIDTxt.Enabled = (Program.currentProject.spriteType == 1) ? true : false;
        }

        private void BasicSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Program.currentProject.spriteName = spriteNameTxt.Text;
                Program.currentProject.spriteProfileID = spriteProfileIDTxt.Text;
                Program.currentProject.spriteID = spriteIDTxt.Text;
                Program.currentProject.spriteClassName = spriteClassNameTxt.Text;
                Program.currentProject.spriteBaseClassName = spriteBaseClassTxt.Text;
                Program.currentProject.spriteARCNameList = spriteARCNameListTxt.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private void BasicSettings_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            this.Icon = Tanjun.Properties.Resources.icon;

            spriteNameTxt.Text = Program.currentProject.spriteName;
            spriteProfileIDTxt.Text = Program.currentProject.spriteProfileID;
            spriteIDTxt.Text = Program.currentProject.spriteID;
            spriteClassNameTxt.Text = Program.currentProject.spriteClassName;
            spriteBaseClassTxt.Text = Program.currentProject.spriteBaseClassName;
            spriteARCNameListTxt.Text = Program.currentProject.spriteARCNameList;

            spriteTypeLst.SelectedIndex = Program.currentProject.spriteType;
        }
    }
}
