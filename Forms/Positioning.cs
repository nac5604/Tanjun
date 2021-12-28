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
    public partial class Positioning : Form
    {
        // Declaring variables that store the values that we can bind to our listbox/textbox editing system.
        TanjunProject.ReplacementSprite spriteModelData = new TanjunProject.ReplacementSprite();
        TanjunProject.NewSprite newSprite = new TanjunProject.NewSprite();

        public Positioning()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previewCodeBtn_Click(object sender, EventArgs e)
        {
            // Compiling all the properties in this window into code.
            Program.code.Clear();
            Program.code.Add(String.Format("const SpriteData {0}SpriteData = {{", Program.currentProject.spriteName));
            Program.code.Add(String.Format("\n\tProfileId::{11}, {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}",
                                                                                newSprite.offsets.x,
                                                                                newSprite.offsets.y,
                                                                                newSprite.distancesToCenter.x,
                                                                                newSprite.distancesToCenter.y,
                                                                                newSprite.distancesToEdge.x,
                                                                                newSprite.distancesToEdge.y,
                                                                                newSprite._1C,
                                                                                newSprite._1E,
                                                                                newSprite._20,
                                                                                newSprite._22,
                                                                                newSprite.flags,
                                                                                Program.currentProject.spriteProfileID));
            Program.code.Add("\n};\n\n");

            Program.code.Add(String.Format("int {0}::onCreate() {{", Program.currentProject.spriteClassName));
            Program.code.Add(String.Format("\n\tSetupTextures_{0}(&bodyModel, 0);", Program.currentProject.spriteLightmapType));
            Program.code.Add("\n\tActivePhysics::Info HitBox;");
            Program.code.Add(String.Format("\n\tHitBox.xDistToCenter = {0};" +
                                   "\n\tHitBox.yDistToCenter = {1};" +
                                   "\n\tHitBox.xDistToEdge = {2};" +
                                   "\n\tHitBox.yDistToEdge = {3};" +
                                   "\n\tHitBox.catgeory1 = 0x{4};" +
                                   "\n\tHitBox.category2 = 0x{5};\n" +
                                   "\n\tthis->scale.x = {6};" +
                                   "\n\tthis->scale.y = {7};" +
                                   "\n\tthis->scale.z = {8};",
                                   spriteModelData.distancesToCenter.x,
                                   spriteModelData.distancesToCenter.y,
                                   spriteModelData.distancesToEdge.x,
                                   spriteModelData.distancesToEdge.y,
                                   Program.currentProject.category1,
                                   Program.currentProject.category2,
                                   spriteModelData.scale.x,
                                   spriteModelData.scale.y,
                                   spriteModelData.scale.z));

            Program.code.Add("\n\n\tthis->onExecute();" +
                     "\n\treturn true;");

            CodePreview codep = new CodePreview(Program.code, "Positioning and Categorization");
            codep.Show();
        }

        private void Positioning_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            this.Icon = Tanjun.Properties.Resources.icon;

            annexedPositioningGrp.Enabled = (Program.currentProject.spriteType == 1) ? true : false;
            category1Cmb.SelectedIndex = 0;
            lightmapCmb.SelectedIndex = 0;

            spriteModelData = Program.currentProject.replacementSprite;
            newSprite = Program.currentProject.newSprite;
        }

        private void modelPositioningLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            positioningValueTxt.ForeColor = SystemColors.WindowText;

            switch (modelPositioningLst.GetItemText(modelPositioningLst.SelectedItem))
            {
                case "Rect1: X Distance to Center":
                    positioningValueTxt.Text = spriteModelData.distancesToCenter.x.ToString();
                    break;
                case "Rect1: Y Distance to Center":
                    positioningValueTxt.Text = spriteModelData.distancesToCenter.y.ToString();
                    break;
                case "Rect2: X Distance to Edge":
                    positioningValueTxt.Text = spriteModelData.distancesToEdge.x.ToString();
                    break;
                case "Rect2: Y Distance to Edge":
                    positioningValueTxt.Text = spriteModelData.distancesToEdge.y.ToString();
                    break;
                case "Scale: X Axis":
                    positioningValueTxt.Text = spriteModelData.scale.x.ToString();
                    break;
                case "Scale: Y Axis":
                    positioningValueTxt.Text = spriteModelData.scale.y.ToString();
                    break;
                case "Scale: Z Axis":
                    positioningValueTxt.Text = spriteModelData.scale.z.ToString();
                    break;
            }
        }

        private void positioningValueTxt_KeyDown(object sender, KeyEventArgs e)
        {
            // Puts the edited value back into the list.
            if (modelPositioningLst.SelectedItems != null && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                
                switch (modelPositioningLst.GetItemText(modelPositioningLst.SelectedItem))
                {
                    case "Rect1: X Distance to Center":
                        spriteModelData.distancesToCenter.x = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                    case "Rect1: Y Distance to Center":
                        spriteModelData.distancesToCenter.y = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                    case "Rect2: X Distance to Edge":
                        spriteModelData.distancesToEdge.x = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                    case "Rect2: Y Distance to Edge":
                        spriteModelData.distancesToEdge.y = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                    case "Scale: X Axis":
                        spriteModelData.scale.x = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                    case "Scale: Y Axis":
                        spriteModelData.scale.y = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                    case "Scale: Z Axis":
                        spriteModelData.scale.z = Convert.ToDecimal(positioningValueTxt.Text);
                        break;
                }

                positioningValueTxt.ForeColor = Color.Green;
            }
        }

        private void annexedPositioningLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            annexedPositioningValueTxt.ForeColor = SystemColors.WindowText;

            switch (annexedPositioningLst.GetItemText(annexedPositioningLst.SelectedItem))
            {
                case "X Offset":
                    annexedPositioningValueTxt.Text = newSprite.offsets.x.ToString();
                    break;
                case "Y Offset":
                    annexedPositioningValueTxt.Text = newSprite.offsets.y.ToString();
                    break;
                case "Rect1: X Distance to Center":
                    annexedPositioningValueTxt.Text = newSprite.distancesToCenter.x.ToString();
                    break;
                case "Rect1: Y Distance to Center":
                    annexedPositioningValueTxt.Text = newSprite.distancesToCenter.y.ToString();
                    break;
                case "Rect2: X Distance to Edge":
                    annexedPositioningValueTxt.Text = newSprite.distancesToEdge.x.ToString();
                    break;
                case "Rect2: Y Distance to Edge":
                    annexedPositioningValueTxt.Text = newSprite.distancesToEdge.y.ToString();
                    break;
                case "Rect2: X Distance to Center":
                    annexedPositioningValueTxt.Text = newSprite.distancesToEdge.x.ToString();
                    break;
                case "Value of _1C":
                    annexedPositioningValueTxt.Text = newSprite._1C.ToString();
                    break;
                case "Value of _1E":
                    annexedPositioningValueTxt.Text = newSprite._1E.ToString();
                    break;
                case "Value of _20":
                    annexedPositioningValueTxt.Text = newSprite._20.ToString();
                    break;
                case "Value of _22":
                    annexedPositioningValueTxt.Text = newSprite._22.ToString();
                    break;
                case "Flags":
                    annexedPositioningValueTxt.Text = newSprite.flags.ToString();
                    break;
            }
        }

        private void annexedPositioningValueTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (annexedPositioningLst.SelectedItems != null && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                switch (annexedPositioningLst.GetItemText(annexedPositioningLst.SelectedItem))
                {
                    case "X Offset":
                        newSprite.offsets.x = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Y Offset":
                        newSprite.offsets.y = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Rect1: X Distance to Center":
                        newSprite.distancesToCenter.x = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Rect1: Y Distance to Center":
                        newSprite.distancesToCenter.y = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Rect2: X Distance to Edge":
                        newSprite.distancesToEdge.x = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Rect2: Y Distance to Edge":
                        newSprite.distancesToEdge.y = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Rect2: X Distance to Center":
                        newSprite.distancesToEdge.x = Convert.ToDecimal(annexedPositioningValueTxt.Text);
                        break;
                    case "Value of _1C":
                        newSprite._1C = Convert.ToInt32(annexedPositioningValueTxt.Text);
                        break;
                    case "Value of _1E":
                        newSprite._1E = Convert.ToInt32(annexedPositioningValueTxt.Text);
                        break;
                    case "Value of _20":
                        newSprite._20 = Convert.ToInt32(annexedPositioningValueTxt.Text);
                        break;
                    case "Value of _22":
                        newSprite._22 = Convert.ToInt32(annexedPositioningValueTxt.Text);
                        break;
                    case "Flags":
                        newSprite.flags = Convert.ToInt32(annexedPositioningValueTxt.Text);
                        break;
                }

                annexedPositioningValueTxt.ForeColor = Color.Green;
            }
        }

        private void Positioning_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.currentProject.replacementSprite = spriteModelData;
            Program.currentProject.newSprite = newSprite;
        }

        private void category1Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Making sure we get the proper integer when selecting an item from the dropdown.
            if (category1Cmb.SelectedIndex >= 2)
            {
                Program.currentProject.category1 = category1Cmb.SelectedIndex + 1;
            }
            else
            {
                Program.currentProject.category1 = category1Cmb.SelectedIndex;
            }

            if (category1Cmb.SelectedIndex == 5)
            {
                Program.currentProject.category1 = 6;
                Program.currentProject.category2 = 1;
            }
            else if (category1Cmb.SelectedIndex == 6)
            {
                Program.currentProject.category1 = 6;
                Program.currentProject.category2 = 2;
            }
        }

        private void category2Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lightmapCmb.Text == "Map Object")
            {
                Program.currentProject.spriteLightmapType = "MapObj";
            }
            else
            {
                Program.currentProject.spriteLightmapType = lightmapCmb.Text;
            }
        }
    }
}
