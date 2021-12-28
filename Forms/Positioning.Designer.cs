
namespace Tanjun
{
    partial class Positioning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Positioning));
            this.closeBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previewCodeBtn = new System.Windows.Forms.Button();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.annexedPositioningGrp = new System.Windows.Forms.GroupBox();
            this.annexedPositioningValueTxt = new System.Windows.Forms.TextBox();
            this.annexedPositioningLst = new System.Windows.Forms.ListBox();
            this.cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryValueTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.categorizationGrp = new System.Windows.Forms.GroupBox();
            this.lightmapCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category1Cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelPositioningGrp = new System.Windows.Forms.GroupBox();
            this.positioningValueTxt = new System.Windows.Forms.TextBox();
            this.modelPositioningLst = new System.Windows.Forms.ListBox();
            this.annexedPositioningGrp.SuspendLayout();
            this.cm.SuspendLayout();
            this.categorizationGrp.SuspendLayout();
            this.modelPositioningGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeBtn.Location = new System.Drawing.Point(351, 17);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 30);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextBtn.Location = new System.Drawing.Point(691, 421);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(97, 30);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // previewCodeBtn
            // 
            this.previewCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.previewCodeBtn.Location = new System.Drawing.Point(12, 421);
            this.previewCodeBtn.Name = "previewCodeBtn";
            this.previewCodeBtn.Size = new System.Drawing.Size(213, 30);
            this.previewCodeBtn.TabIndex = 17;
            this.previewCodeBtn.Text = "Preview Code Section";
            this.previewCodeBtn.UseVisualStyleBackColor = true;
            this.previewCodeBtn.Click += new System.EventHandler(this.previewCodeBtn_Click);
            // 
            // explanationBtn
            // 
            this.explanationBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.explanationBtn.Location = new System.Drawing.Point(454, 17);
            this.explanationBtn.Name = "explanationBtn";
            this.explanationBtn.Size = new System.Drawing.Size(334, 30);
            this.explanationBtn.TabIndex = 16;
            this.explanationBtn.Text = "Explanation of Positioning and Categorization";
            this.explanationBtn.UseVisualStyleBackColor = true;
            // 
            // sep
            // 
            this.sep.BackColor = System.Drawing.Color.DarkGray;
            this.sep.Location = new System.Drawing.Point(13, 55);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(775, 1);
            this.sep.TabIndex = 15;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(7, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 32);
            this.title.TabIndex = 14;
            this.title.Text = "Sprite Data";
            // 
            // annexedPositioningGrp
            // 
            this.annexedPositioningGrp.Controls.Add(this.annexedPositioningValueTxt);
            this.annexedPositioningGrp.Controls.Add(this.annexedPositioningLst);
            this.annexedPositioningGrp.Location = new System.Drawing.Point(403, 62);
            this.annexedPositioningGrp.Name = "annexedPositioningGrp";
            this.annexedPositioningGrp.Size = new System.Drawing.Size(385, 353);
            this.annexedPositioningGrp.TabIndex = 20;
            this.annexedPositioningGrp.TabStop = false;
            this.annexedPositioningGrp.Text = "Annexed Sprite Positioning";
            // 
            // annexedPositioningValueTxt
            // 
            this.annexedPositioningValueTxt.Location = new System.Drawing.Point(6, 320);
            this.annexedPositioningValueTxt.Name = "annexedPositioningValueTxt";
            this.annexedPositioningValueTxt.Size = new System.Drawing.Size(373, 27);
            this.annexedPositioningValueTxt.TabIndex = 23;
            this.annexedPositioningValueTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.annexedPositioningValueTxt_KeyDown);
            // 
            // annexedPositioningLst
            // 
            this.annexedPositioningLst.ContextMenuStrip = this.cm;
            this.annexedPositioningLst.FormattingEnabled = true;
            this.annexedPositioningLst.ItemHeight = 20;
            this.annexedPositioningLst.Items.AddRange(new object[] {
            "X Offset",
            "Y Offset",
            "Rect1: X Distance to Center",
            "Rect1: Y Distance to Center",
            "Rect2: X Distance to Edge",
            "Rect2: Y Distance to Edge",
            "Value of _1C",
            "Value of _1E",
            "Value of _20",
            "Value of _22",
            "Flags"});
            this.annexedPositioningLst.Location = new System.Drawing.Point(6, 30);
            this.annexedPositioningLst.Name = "annexedPositioningLst";
            this.annexedPositioningLst.Size = new System.Drawing.Size(373, 284);
            this.annexedPositioningLst.TabIndex = 1;
            this.annexedPositioningLst.SelectedIndexChanged += new System.EventHandler(this.annexedPositioningLst_SelectedIndexChanged);
            // 
            // cm
            // 
            this.cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editValueToolStripMenuItem});
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(154, 28);
            // 
            // editValueToolStripMenuItem
            // 
            this.editValueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryValueTextbox});
            this.editValueToolStripMenuItem.Name = "editValueToolStripMenuItem";
            this.editValueToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.editValueToolStripMenuItem.Text = "Edit Value...";
            // 
            // entryValueTextbox
            // 
            this.entryValueTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.entryValueTextbox.Name = "entryValueTextbox";
            this.entryValueTextbox.Size = new System.Drawing.Size(100, 27);
            // 
            // categorizationGrp
            // 
            this.categorizationGrp.Controls.Add(this.lightmapCmb);
            this.categorizationGrp.Controls.Add(this.label2);
            this.categorizationGrp.Controls.Add(this.category1Cmb);
            this.categorizationGrp.Controls.Add(this.label1);
            this.categorizationGrp.Location = new System.Drawing.Point(13, 62);
            this.categorizationGrp.Name = "categorizationGrp";
            this.categorizationGrp.Size = new System.Drawing.Size(384, 162);
            this.categorizationGrp.TabIndex = 21;
            this.categorizationGrp.TabStop = false;
            // 
            // lightmapCmb
            // 
            this.lightmapCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightmapCmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lightmapCmb.FormattingEnabled = true;
            this.lightmapCmb.Items.AddRange(new object[] {
            "Enemy",
            "Boss",
            "Player",
            "Item",
            "Map",
            "Map Object"});
            this.lightmapCmb.Location = new System.Drawing.Point(9, 110);
            this.lightmapCmb.Name = "lightmapCmb";
            this.lightmapCmb.Size = new System.Drawing.Size(370, 28);
            this.lightmapCmb.TabIndex = 23;
            this.lightmapCmb.SelectedIndexChanged += new System.EventHandler(this.category2Cmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sprite Lightmap Type";
            // 
            // category1Cmb
            // 
            this.category1Cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category1Cmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.category1Cmb.FormattingEnabled = true;
            this.category1Cmb.Items.AddRange(new object[] {
            "Player / Yoshi A",
            "Player / Yoshi B",
            "General Sprite",
            "Balloon",
            "Collectible / Coin",
            "Player Fireball",
            "Player Iceball"});
            this.category1Cmb.Location = new System.Drawing.Point(8, 46);
            this.category1Cmb.Name = "category1Cmb";
            this.category1Cmb.Size = new System.Drawing.Size(370, 28);
            this.category1Cmb.TabIndex = 22;
            this.category1Cmb.SelectedIndexChanged += new System.EventHandler(this.category1Cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sprite Category";
            // 
            // modelPositioningGrp
            // 
            this.modelPositioningGrp.Controls.Add(this.positioningValueTxt);
            this.modelPositioningGrp.Controls.Add(this.modelPositioningLst);
            this.modelPositioningGrp.Location = new System.Drawing.Point(13, 230);
            this.modelPositioningGrp.Name = "modelPositioningGrp";
            this.modelPositioningGrp.Size = new System.Drawing.Size(384, 185);
            this.modelPositioningGrp.TabIndex = 21;
            this.modelPositioningGrp.TabStop = false;
            this.modelPositioningGrp.Text = "Sprite Model Positioning";
            // 
            // positioningValueTxt
            // 
            this.positioningValueTxt.Location = new System.Drawing.Point(6, 152);
            this.positioningValueTxt.Name = "positioningValueTxt";
            this.positioningValueTxt.Size = new System.Drawing.Size(372, 27);
            this.positioningValueTxt.TabIndex = 22;
            this.positioningValueTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.positioningValueTxt_KeyDown);
            // 
            // modelPositioningLst
            // 
            this.modelPositioningLst.ContextMenuStrip = this.cm;
            this.modelPositioningLst.FormattingEnabled = true;
            this.modelPositioningLst.ItemHeight = 20;
            this.modelPositioningLst.Items.AddRange(new object[] {
            "Rect1: X Distance to Center",
            "Rect1: Y Distance to Center",
            "Rect2: X Distance to Edge",
            "Rect2: Y Distance to Edge",
            "Scale: X Axis",
            "Scale: Y Axis",
            "Scale: Z Axis"});
            this.modelPositioningLst.Location = new System.Drawing.Point(6, 22);
            this.modelPositioningLst.Name = "modelPositioningLst";
            this.modelPositioningLst.Size = new System.Drawing.Size(372, 124);
            this.modelPositioningLst.TabIndex = 0;
            this.modelPositioningLst.SelectedIndexChanged += new System.EventHandler(this.modelPositioningLst_SelectedIndexChanged);
            // 
            // Positioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.modelPositioningGrp);
            this.Controls.Add(this.categorizationGrp);
            this.Controls.Add(this.annexedPositioningGrp);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previewCodeBtn);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Positioning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanjun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Positioning_FormClosing);
            this.Load += new System.EventHandler(this.Positioning_Load);
            this.annexedPositioningGrp.ResumeLayout(false);
            this.annexedPositioningGrp.PerformLayout();
            this.cm.ResumeLayout(false);
            this.categorizationGrp.ResumeLayout(false);
            this.categorizationGrp.PerformLayout();
            this.modelPositioningGrp.ResumeLayout(false);
            this.modelPositioningGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previewCodeBtn;
        private System.Windows.Forms.Button explanationBtn;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox annexedPositioningGrp;
        private System.Windows.Forms.GroupBox categorizationGrp;
        private System.Windows.Forms.ComboBox lightmapCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox category1Cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox annexedPositioningLst;
        private System.Windows.Forms.GroupBox modelPositioningGrp;
        private System.Windows.Forms.ListBox modelPositioningLst;
        private System.Windows.Forms.ContextMenuStrip cm;
        private System.Windows.Forms.ToolStripMenuItem editValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox entryValueTextbox;
        private System.Windows.Forms.TextBox annexedPositioningValueTxt;
        private System.Windows.Forms.TextBox positioningValueTxt;
    }
}