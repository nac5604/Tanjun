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

        public HeaderSelection()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.code.Clear();
            Save();

            foreach (TanjunProject.HeaderData hd in Program.currentProject.imports)
            {
                if (hd.imported)
                {
                    if (hd.type == "Standard Library")
                    {
                        Program.code.Add(String.Format("#include <{0}>\n", hd.headerName));
                    }
                    else
                    {
                        Program.code.Add(String.Format("#include \"{0}\"\n", hd.headerName));
                    }
                }
            }

            CodePreview codep = new CodePreview(Program.code, "Headers");
            codep.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "C++ Header Files|*.h";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!headers.Items.Contains(ofd.SafeFileName + " (Imported Library)"))
                {
                    AddToListWithChecks(Program.currentProject.imports, new TanjunProject.HeaderData { headerName = ofd.SafeFileName, type = "Imported Library" });
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
        }

        private void AddToListWithChecks(List<TanjunProject.HeaderData> list, TanjunProject.HeaderData obj)
        {
            if (list == null)
            {
                list = new List<TanjunProject.HeaderData>();
            }
            list.Add(obj);
        }

        private void HeaderSelection_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            this.Icon = Tanjun.Properties.Resources.icon;

            if (Program.currentProject.imports == null)
            {
                Program.currentProject.imports = new List<TanjunProject.HeaderData>();
            }

            foreach(TanjunProject.HeaderData hd in Program.currentProject.imports)
            {
                if (!headers.Items.Contains(String.Format("{0} ({1})", hd.headerName, hd.type)))
                {
                    headers.Items.Add(String.Format("{0} ({1})", hd.headerName, hd.type));
                }
                headers.SetItemChecked(headers.Items.IndexOf(String.Format("{0} ({1})", hd.headerName, hd.type)), hd.imported);
            }
        }

        private void HeaderSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Program.currentProject.imports.Clear();
            foreach (string s in headers.CheckedItems.OfType<String>().ToList())
            {
                TanjunProject.HeaderData hd = new TanjunProject.HeaderData();

                hd.headerName = s.Split(new string[] { " (" }, StringSplitOptions.None)[0];
                hd.type = s.Split(new string[] { " (" }, StringSplitOptions.None)[1].TrimStart(' ').Replace(')', '\0').Replace('(', '\0').TrimEnd('\0');
                hd.imported = headers.GetItemChecked(headers.Items.IndexOf(String.Format("{0} ({1})", hd.headerName, hd.type)));

                AddToListWithChecks(Program.currentProject.imports, hd);

            }
        }
    }
}
