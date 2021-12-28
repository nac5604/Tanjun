using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanjun
{
    public partial class MainForm : Form
    {
        Dictionary<string, string> forms = new Dictionary<string, string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Tanjun.Properties.Resources.icon;
        }

        private void basicSettingsBtn_Click(object sender, EventArgs e)
        {
            BasicSettings form = new BasicSettings();
            form.Show();
        }

        private void modelSettingsBtn_Click(object sender, EventArgs e)
        {
            ModelSettings form = new ModelSettings();
            form.Show();
        }

        private void positioningBtn_Click(object sender, EventArgs e)
        {
            Positioning form = new Positioning();
            form.Show();
        }

        private void headerSelectionBtn_Click(object sender, EventArgs e)
        {
            HeaderSelection form = new HeaderSelection();
            form.Show();
        }

        private void statesBtn_Click(object sender, EventArgs e)
        {
            States form = new States();
            form.Show();
        }

        private void collisionsBtn_Click(object sender, EventArgs e)
        {
            Collisions form = new Collisions();
            form.Show();
        }

        private void openProjectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TJ Files|*.tj";
            ofd.Title = "Open a Tanjun project file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Program.currentProject = FileHelper.DeserializeModels(ofd.FileName);
                Program.currentFile = ofd.FileName;
            }
        }

        private void saveProjectBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TJ Files|*.tj";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileHelper.SerializeModels(sfd.FileName, Program.currentProject);
                Program.currentFile = sfd.FileName;
            }
        }

        private void generateCPPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileHelper.GenerateCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }
    }
}
