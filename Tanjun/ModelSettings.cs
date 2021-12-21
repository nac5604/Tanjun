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
    public partial class ModelSettings : Form
    {

        List<string> code = new List<string>();
        public ModelSettings()
        {
            InitializeComponent();
        }

        private void explanationBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void previewCodeBtn_Click(object sender, EventArgs e)
        {
            CodePreview codep = new CodePreview(code, "Model Settings");
            codep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            HeaderSelection hs = new HeaderSelection();
            hs.ShowDialog();
            Close();
        }
    }
}
