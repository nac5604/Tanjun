using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace Tanjun
{
    public partial class HeaderSelection : Form
    {
        List<string> code = new List<string>();
        List<string> imported = new List<string>();

        public HeaderSelection()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CodePreview codep = new CodePreview(code, "Headers");
            codep.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "C++ Header Files|*.h";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!headers.Items.Contains(ofd.SafeFileName + " (Imported Library)") || !headers.Items.Contains(ofd.SafeFileName + " (Local Library)"))
                {
                    imported.Add(ofd.SafeFileName);
                    headers.Items.Add(ofd.SafeFileName + " (Imported Library)");
                    headers.SetItemChecked(headers.Items.IndexOf(ofd.SafeFileName + " (Imported Library)"), true);
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ModelSettings ms = new ModelSettings();
            ms.ShowDialog();
            Close();
        }

        private void headers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Bunch of crap to fix Microsoft's shitty CheckedListBox events.
            CheckedListBox clb = (CheckedListBox)sender;
            clb.ItemCheck -= headers_ItemCheck;
            clb.SetItemCheckState(e.Index, e.NewValue);
            clb.ItemCheck += headers_ItemCheck;

            if (code.Count != 0)
            {
                code.Clear();
            }

            foreach (string s in headers.CheckedItems.OfType<String>().ToList())
            {
                if (s.Contains("(Standard Library)"))
                {
                    code.Add(String.Format("#include <{0}>\n", s.Split(new string[] { " (Standard Library)" }, StringSplitOptions.None)[0]));
                }
                else if (s.Contains("(Local Library)"))
                {
                    code.Add(String.Format("#include \"{0}\"\n", s.Split(new string[] { " (Local Library)" }, StringSplitOptions.None)[0]));
                }
                else if (s.Contains("(Imported Library)"))
                {
                    code.Add(String.Format("#include \"{0}\"\n", s.Split(new string[] { " (Imported Library)" }, StringSplitOptions.None)[0]));
                }

            }
        }

        private void HeaderSelection_Load(object sender, EventArgs e)
        {
            
        }

        private void HeaderSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
