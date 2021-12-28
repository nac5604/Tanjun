using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanjun
{
    public partial class States : Form
    {
        List<string> code = new List<string>();
        public States()
        {
            InitializeComponent();
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!statesLst.Items.Contains(toolStripTextBox1.Text))
                {
                    statesLst.Items.Add(toolStripTextBox1.Text);

                    if (Program.currentProject.spriteStates == null)
                    {
                        Program.currentProject.spriteStates = new List<string>();
                    }
                    Program.currentProject.spriteStates.Add(toolStripTextBox1.Text);

                    toolStripTextBox1.ForeColor = Color.Green;
                }
            }
        }

        private void deleteStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statesLst.SelectedItem != null)
            {
                statesLst.Items.Remove(statesLst.SelectedItem);
            }
        }

        private void previewCodeBtn_Click(object sender, EventArgs e)
        {
            string penis = "BasicClassName";

            code.Clear();
            code.Add("\nclass " + penis + " : public dEn_c {");
            code.Add("\npublic:");

            foreach (string str in statesLst.Items.OfType<string>().ToList())
            {
                code.Add(String.Format("\n\tDECLARE_STATE({0})", str));
            }

            code.Add("\n};");

            foreach (string str in statesLst.Items.OfType<string>().ToList())
            {
                code.Add(String.Format("\nCREATE_STATE({0}, {1})", penis, str));
            }

            foreach (string str in statesLst.Items.OfType<string>().ToList())
            {
                code.Add("\n\nvoid " + penis + "::beginState_" + str + "() { }");
                code.Add("\nvoid " + penis + "::executeState_" + str + "() { }");
                code.Add("\nvoid " + penis + "::endState_" + str + "() { }");
            }

            CodePreview codep = new CodePreview(code, "States");
            codep.Show();
        }

        private void States_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            this.Icon = Tanjun.Properties.Resources.icon;

            if (Program.currentProject.spriteStates != null)
            {
                foreach (string str in Program.currentProject.spriteStates)
                {
                    statesLst.Items.Add(str);
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (statesLst.Items.Contains(toolStripTextBox1.Text))
            {
               toolStripTextBox1.ForeColor = Color.Green;
            } else
            {
               toolStripTextBox1.ForeColor = SystemColors.WindowText;
            }
           
        }
    }
}
