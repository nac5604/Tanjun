
namespace Tanjun
{
    partial class BasicSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicSettings));
            this.sep = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.autoFillFieldsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spriteTypeLst = new System.Windows.Forms.ComboBox();
            this.spriteARCNameListTxt = new Tanjun.Control.PlaceholderTB();
            this.spriteBaseClassTxt = new Tanjun.Control.PlaceholderTB();
            this.spriteClassNameTxt = new Tanjun.Control.PlaceholderTB();
            this.spriteIDTxt = new Tanjun.Control.PlaceholderTB();
            this.spriteProfileIDTxt = new Tanjun.Control.PlaceholderTB();
            this.spriteNameTxt = new Tanjun.Control.PlaceholderTB();
            this.SuspendLayout();
            // 
            // sep
            // 
            this.sep.BackColor = System.Drawing.Color.DarkGray;
            this.sep.Location = new System.Drawing.Point(13, 55);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(775, 1);
            this.sep.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(191, 38);
            this.title.TabIndex = 2;
            this.title.Text = "Basic Settings";
            // 
            // explanationBtn
            // 
            this.explanationBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.explanationBtn.Location = new System.Drawing.Point(575, 17);
            this.explanationBtn.Name = "explanationBtn";
            this.explanationBtn.Size = new System.Drawing.Size(213, 30);
            this.explanationBtn.TabIndex = 4;
            this.explanationBtn.Text = "Explanation of Basic Settings";
            this.explanationBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeBtn.Location = new System.Drawing.Point(472, 17);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 30);
            this.closeBtn.TabIndex = 13;
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
            this.nextBtn.TabIndex = 12;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // autoFillFieldsBtn
            // 
            this.autoFillFieldsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoFillFieldsBtn.Location = new System.Drawing.Point(12, 421);
            this.autoFillFieldsBtn.Name = "autoFillFieldsBtn";
            this.autoFillFieldsBtn.Size = new System.Drawing.Size(213, 30);
            this.autoFillFieldsBtn.TabIndex = 14;
            this.autoFillFieldsBtn.Text = "Auto-Fill Fields";
            this.autoFillFieldsBtn.UseVisualStyleBackColor = true;
            this.autoFillFieldsBtn.Click += new System.EventHandler(this.autoFillFieldsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sprite Type:";
            // 
            // spriteTypeLst
            // 
            this.spriteTypeLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spriteTypeLst.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.spriteTypeLst.FormattingEnabled = true;
            this.spriteTypeLst.Items.AddRange(new object[] {
            "Replacement Sprite",
            "New Sprite"});
            this.spriteTypeLst.Location = new System.Drawing.Point(12, 290);
            this.spriteTypeLst.Name = "spriteTypeLst";
            this.spriteTypeLst.Size = new System.Drawing.Size(290, 28);
            this.spriteTypeLst.TabIndex = 16;
            this.spriteTypeLst.SelectedIndexChanged += new System.EventHandler(this.spriteTypeLst_SelectedIndexChanged);
            // 
            // spriteARCNameListTxt
            // 
            this.spriteARCNameListTxt.Location = new System.Drawing.Point(12, 227);
            this.spriteARCNameListTxt.Name = "spriteARCNameListTxt";
            this.spriteARCNameListTxt.PlaceHolderText = "ARC Name List";
            this.spriteARCNameListTxt.Size = new System.Drawing.Size(290, 27);
            this.spriteARCNameListTxt.TabIndex = 10;
            this.spriteARCNameListTxt.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // spriteBaseClassTxt
            // 
            this.spriteBaseClassTxt.Location = new System.Drawing.Point(12, 194);
            this.spriteBaseClassTxt.Name = "spriteBaseClassTxt";
            this.spriteBaseClassTxt.PlaceHolderText = "Sprite Base Class";
            this.spriteBaseClassTxt.Size = new System.Drawing.Size(290, 27);
            this.spriteBaseClassTxt.TabIndex = 9;
            this.spriteBaseClassTxt.Text = "dEn_c";
            this.spriteBaseClassTxt.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // spriteClassNameTxt
            // 
            this.spriteClassNameTxt.Location = new System.Drawing.Point(12, 161);
            this.spriteClassNameTxt.Name = "spriteClassNameTxt";
            this.spriteClassNameTxt.PlaceHolderText = "Sprite Class Name";
            this.spriteClassNameTxt.Size = new System.Drawing.Size(290, 27);
            this.spriteClassNameTxt.TabIndex = 8;
            this.spriteClassNameTxt.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // spriteIDTxt
            // 
            this.spriteIDTxt.Location = new System.Drawing.Point(12, 128);
            this.spriteIDTxt.Name = "spriteIDTxt";
            this.spriteIDTxt.PlaceHolderText = "Sprite ID";
            this.spriteIDTxt.Size = new System.Drawing.Size(290, 27);
            this.spriteIDTxt.TabIndex = 7;
            this.spriteIDTxt.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // spriteProfileIDTxt
            // 
            this.spriteProfileIDTxt.Location = new System.Drawing.Point(12, 95);
            this.spriteProfileIDTxt.Name = "spriteProfileIDTxt";
            this.spriteProfileIDTxt.PlaceHolderText = "Sprite Profile ID";
            this.spriteProfileIDTxt.Size = new System.Drawing.Size(290, 27);
            this.spriteProfileIDTxt.TabIndex = 6;
            this.spriteProfileIDTxt.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // spriteNameTxt
            // 
            this.spriteNameTxt.Location = new System.Drawing.Point(12, 62);
            this.spriteNameTxt.Name = "spriteNameTxt";
            this.spriteNameTxt.PlaceHolderText = "Sprite Name";
            this.spriteNameTxt.Size = new System.Drawing.Size(290, 27);
            this.spriteNameTxt.TabIndex = 5;
            this.spriteNameTxt.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // BasicSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.spriteTypeLst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoFillFieldsBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.spriteARCNameListTxt);
            this.Controls.Add(this.spriteBaseClassTxt);
            this.Controls.Add(this.spriteClassNameTxt);
            this.Controls.Add(this.spriteIDTxt);
            this.Controls.Add(this.spriteProfileIDTxt);
            this.Controls.Add(this.spriteNameTxt);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasicSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanjun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicSettings_FormClosing);
            this.Load += new System.EventHandler(this.BasicSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button explanationBtn;
        private Control.PlaceholderTB spriteNameTxt;
        private Control.PlaceholderTB spriteProfileIDTxt;
        private Control.PlaceholderTB spriteIDTxt;
        private Control.PlaceholderTB spriteClassNameTxt;
        private Control.PlaceholderTB spriteBaseClassTxt;
        private Control.PlaceholderTB spriteARCNameListTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button autoFillFieldsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox spriteTypeLst;
    }
}