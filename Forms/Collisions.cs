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
    public partial class Collisions : Form
    {
        List<string> code = new List<string>();
        public Collisions()
        {
            InitializeComponent();
        }

        private void previewCodeBtn_Click(object sender, EventArgs e)
        {
            code.Clear();
            uint bf2v = GenerateBitField2Value();
            code.Add("int DebugClassName::onCreate() {");
            code.Add("\n\tActivePhysics::Info Hitbox;");
            code.Add("\n\tHitBox.bitfield1 = 0x4F;");
            code.Add(String.Format("\n\tHitBox.bitfield2 = {0};", ConvertBitfieldValueToString(bf2v)));
            code.Add("\n\n\treturn true;");
            code.Add("\n}");

            CodePreview codep = new CodePreview(code, "Collisions");
            codep.Show();
        }

        private uint GenerateBitField2Value()
        {
            bool[] bits = new bool[collisionsLst.Items.Count];
            uint bitfield2Value = 0xFFC00000;

            for (int i = 0; i < collisionsLst.Items.Count; i++)
            {
                bits[i] = collisionsLst.GetItemChecked(i);
            }

            for (int i = 0; i < bits.Length; i++)
            {
                bitfield2Value |= (bits[i] ? 1u : 0u) << i;
            }

            return bitfield2Value;
        }

        private string ConvertBitfieldValueToString(uint str)
        {
            return "0x" + str.ToString("X");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyBitfieldValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ConvertBitfieldValueToString(GenerateBitField2Value()));
        }

        private void Collisions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.currentProject.bitField2 = ConvertBitfieldValueToString(GenerateBitField2Value());

            foreach (string str in collisionsLst.CheckedItems.OfType<String>().ToList())
            {
                if (Program.currentProject.collisions == null)
                {
                    Program.currentProject.collisions = new List<string>();
                }
                Program.currentProject.collisions.Add(str);
            }
        }

        private void Collisions_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            this.Icon = Tanjun.Properties.Resources.icon;

            if (Program.currentProject.collisions != null)
            {
                foreach (string str in Program.currentProject.collisions)
                {
                    collisionsLst.SetItemChecked(collisionsLst.Items.IndexOf(str), true);
                }
            }
        }

        private void checkAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < collisionsLst.Items.Count; i++)
            {
                collisionsLst.SetItemChecked(i, true);
            }
        }

        private void uncheckAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < collisionsLst.Items.Count; i++)
            {
                collisionsLst.SetItemChecked(i, false);
            }
        }

        private void collisionsLst_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}