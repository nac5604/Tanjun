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
            code.Add("\n\tHitBox.bitfield1 = 0x04F;");
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
            Application.Exit();
        }

        private void copyBitfieldValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ConvertBitfieldValueToString(GenerateBitField2Value()));
        }
    }
}