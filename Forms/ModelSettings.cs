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
        public ModelSettings()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previewCodeBtn_Click(object sender, EventArgs e)
        {
            Save();
            Program.code.Clear();

            if (Program.currentProject.spriteHasModel)
            {
                Program.code.Add(String.Format("int {0}::onCreate() {{",
                                               Program.currentProject.spriteClassName));
                Program.code.Add(String.Format("\n\tresFile.data = getResource(\"{0}\", \"g3d/{1}.brres\");",
                                               Program.currentProject.modelARCName,
                                               Program.currentProject.modelBRRESName));
                Program.code.Add(String.Format("\n\tnw4r::g3d::ResMdl mdl = this->resFile.GetResMdl(\"{0}\");",
                                               Program.currentProject.modelMDL0Name));

                if (Program.currentProject.spriteHasAnimation)
                {
                    Program.code.Add(String.Format("\n\tnw4r::g3d::ResAnmChr anmChr = this->resFile.GetResAnmChr(\"{0}\");",
                                               Program.currentProject.modelCHR0Name));
                }

                Program.code.Add("\n\n\tbodyModel.setup(mdl, &allocator, 0x224, 1, 0);");
                Program.code.Add(String.Format("\n\tSetupTextures_{0}(&bodyModel, 0);",
                                               Program.currentProject.spriteLightmapType));

                if (Program.currentProject.spriteHasAnimation)
                {
                    Program.code.Add("\n\tthis->animationChr.setup(mdl, anmChr, &this->allocator, 0);");
                    Program.code.Add(String.Format("\n\n\tbindAnimChr_and_setUpdateRate(\"{0}\", 1, 0.0, 1.0);",
                                                   Program.currentProject.modelCHR0Name));
                }

                Program.code.Add("\n\n\tthis->onExecute();\n\treturn true;\n}");
            }
            else
            {
                Program.code.Add("// No code. Try enabling a model for this sprite.");
            }

            CodePreview codep = new CodePreview(Program.code, "Model Settings");
            codep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            HeaderSelection hs = new HeaderSelection();
            hs.ShowDialog();
            Close();
        }

        private void ModelSettings_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            this.Icon = Tanjun.Properties.Resources.icon;

            hasModelToggleBtn.Text = (Program.currentProject.spriteHasModel) ? "Has Model: ✔️" : "Has Model: ❌";
            hasAnimationToggleBtn.Text = (Program.currentProject.spriteHasAnimation) ? "Has Animation: ✔️" : "Has Animation: ❌";
            modelArcNameTxt.Text = Program.currentProject.modelARCName;
            modelBRRESNameTxt.Text = Program.currentProject.modelBRRESName;
            modelMDL0NameTxt.Text = Program.currentProject.modelMDL0Name;
            animCHR0NameTxt.Text = Program.currentProject.modelCHR0Name;

            foreach (System.Windows.Forms.Control c in hasModelGrp.Controls)
            {
                c.Enabled = (c != hasModelToggleBtn) ? Program.currentProject.spriteHasModel : true;
            }

            foreach (System.Windows.Forms.Control c in hasAnimationGrp.Controls)
            {
                c.Enabled = (c != hasAnimationToggleBtn) ? Program.currentProject.spriteHasAnimation : true;
            }
        }

        private void hasModelToggleBtn_Click(object sender, EventArgs e)
        {
            hasModelToggleBtn.Text = (Program.currentProject.spriteHasModel) ? "Has Model: ❌" : "Has Model: ✔️";
            foreach (System.Windows.Forms.Control c in hasModelGrp.Controls)
            {
                c.Enabled = (c != hasModelToggleBtn) ? !c.Enabled : true;
            }
            Program.currentProject.spriteHasModel = !Program.currentProject.spriteHasModel;
        }

        private void hasAnimationToggleBtn_Click(object sender, EventArgs e)
        {
            hasAnimationToggleBtn.Text = (Program.currentProject.spriteHasAnimation) ? "Has Animation: ❌" : "Has Animation: ✔️";
            foreach (System.Windows.Forms.Control c in hasAnimationGrp.Controls)
            {
                c.Enabled = (c != hasAnimationToggleBtn) ? !c.Enabled : true;
            }
            Program.currentProject.spriteHasAnimation = !Program.currentProject.spriteHasAnimation;
        }

        private void ModelSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Program.currentProject.modelARCName = modelArcNameTxt.Text;
            Program.currentProject.modelBRRESName = modelBRRESNameTxt.Text;
            Program.currentProject.modelCHR0Name = animCHR0NameTxt.Text;
            Program.currentProject.modelMDL0Name = modelMDL0NameTxt.Text;
        }

        private void autoFillFieldsBtn_Click(object sender, EventArgs e)
        {
            modelArcNameTxt.Text = Program.currentProject.spriteName + "_arc";
            modelBRRESNameTxt.Text = Program.currentProject.spriteName + "_brres";
            modelMDL0NameTxt.Text = Program.currentProject.spriteName + "_mdl0";

            animCHR0NameTxt.Text = Program.currentProject.spriteName + "_chr0";
        }
    }
}
