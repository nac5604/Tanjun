
namespace Tanjun
{
    partial class ModelSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelSettings));
            this.closeBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previewCodeBtn = new System.Windows.Forms.Button();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.hasModelGrp = new System.Windows.Forms.GroupBox();
            this.hasAnimationGrp = new System.Windows.Forms.GroupBox();
            this.animCHR0NameTxt = new Tanjun.Control.PlaceholderTB();
            this.hasAnimationToggleBtn = new System.Windows.Forms.Button();
            this.modelMDL0NameTxt = new Tanjun.Control.PlaceholderTB();
            this.modelBRRESNameTxt = new Tanjun.Control.PlaceholderTB();
            this.modelArcNameTxt = new Tanjun.Control.PlaceholderTB();
            this.hasModelToggleBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.autoFillFieldsBtn = new System.Windows.Forms.Button();
            this.hasModelGrp.SuspendLayout();
            this.hasAnimationGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeBtn.Location = new System.Drawing.Point(472, 18);
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
            this.nextBtn.Location = new System.Drawing.Point(691, 422);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(97, 30);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // previewCodeBtn
            // 
            this.previewCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.previewCodeBtn.Location = new System.Drawing.Point(12, 422);
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
            this.explanationBtn.Location = new System.Drawing.Point(575, 18);
            this.explanationBtn.Name = "explanationBtn";
            this.explanationBtn.Size = new System.Drawing.Size(213, 30);
            this.explanationBtn.TabIndex = 16;
            this.explanationBtn.Text = "Explanation of Model Settings";
            this.explanationBtn.UseVisualStyleBackColor = true;
            // 
            // sep
            // 
            this.sep.BackColor = System.Drawing.Color.DarkGray;
            this.sep.Location = new System.Drawing.Point(13, 56);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(775, 1);
            this.sep.TabIndex = 15;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(209, 38);
            this.title.TabIndex = 14;
            this.title.Text = "Model Settings";
            // 
            // hasModelGrp
            // 
            this.hasModelGrp.Controls.Add(this.hasAnimationGrp);
            this.hasModelGrp.Controls.Add(this.modelMDL0NameTxt);
            this.hasModelGrp.Controls.Add(this.modelBRRESNameTxt);
            this.hasModelGrp.Controls.Add(this.modelArcNameTxt);
            this.hasModelGrp.Controls.Add(this.hasModelToggleBtn);
            this.hasModelGrp.Location = new System.Drawing.Point(13, 72);
            this.hasModelGrp.Name = "hasModelGrp";
            this.hasModelGrp.Size = new System.Drawing.Size(316, 221);
            this.hasModelGrp.TabIndex = 20;
            this.hasModelGrp.TabStop = false;
            // 
            // hasAnimationGrp
            // 
            this.hasAnimationGrp.Controls.Add(this.animCHR0NameTxt);
            this.hasAnimationGrp.Controls.Add(this.hasAnimationToggleBtn);
            this.hasAnimationGrp.Location = new System.Drawing.Point(6, 144);
            this.hasAnimationGrp.Name = "hasAnimationGrp";
            this.hasAnimationGrp.Size = new System.Drawing.Size(304, 71);
            this.hasAnimationGrp.TabIndex = 24;
            this.hasAnimationGrp.TabStop = false;
            // 
            // animCHR0NameTxt
            // 
            this.animCHR0NameTxt.Location = new System.Drawing.Point(6, 35);
            this.animCHR0NameTxt.Name = "animCHR0NameTxt";
            this.animCHR0NameTxt.PlaceHolderText = "Initial CHR0 Animation Name";
            this.animCHR0NameTxt.Size = new System.Drawing.Size(292, 27);
            this.animCHR0NameTxt.TabIndex = 21;
            // 
            // hasAnimationToggleBtn
            // 
            this.hasAnimationToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hasAnimationToggleBtn.Location = new System.Drawing.Point(6, -1);
            this.hasAnimationToggleBtn.Name = "hasAnimationToggleBtn";
            this.hasAnimationToggleBtn.Size = new System.Drawing.Size(188, 30);
            this.hasAnimationToggleBtn.TabIndex = 21;
            this.hasAnimationToggleBtn.Text = "Has Animation: {}";
            this.hasAnimationToggleBtn.UseVisualStyleBackColor = true;
            this.hasAnimationToggleBtn.Click += new System.EventHandler(this.hasAnimationToggleBtn_Click);
            // 
            // modelMDL0NameTxt
            // 
            this.modelMDL0NameTxt.Location = new System.Drawing.Point(6, 101);
            this.modelMDL0NameTxt.Name = "modelMDL0NameTxt";
            this.modelMDL0NameTxt.PlaceHolderText = "MDL0 Name";
            this.modelMDL0NameTxt.Size = new System.Drawing.Size(304, 27);
            this.modelMDL0NameTxt.TabIndex = 23;
            // 
            // modelBRRESNameTxt
            // 
            this.modelBRRESNameTxt.Location = new System.Drawing.Point(6, 68);
            this.modelBRRESNameTxt.Name = "modelBRRESNameTxt";
            this.modelBRRESNameTxt.PlaceHolderText = "BRRES Name";
            this.modelBRRESNameTxt.Size = new System.Drawing.Size(304, 27);
            this.modelBRRESNameTxt.TabIndex = 22;
            // 
            // modelArcNameTxt
            // 
            this.modelArcNameTxt.Location = new System.Drawing.Point(6, 35);
            this.modelArcNameTxt.Name = "modelArcNameTxt";
            this.modelArcNameTxt.PlaceHolderText = "ARC Name";
            this.modelArcNameTxt.Size = new System.Drawing.Size(304, 27);
            this.modelArcNameTxt.TabIndex = 21;
            // 
            // hasModelToggleBtn
            // 
            this.hasModelToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hasModelToggleBtn.Location = new System.Drawing.Point(6, -1);
            this.hasModelToggleBtn.Name = "hasModelToggleBtn";
            this.hasModelToggleBtn.Size = new System.Drawing.Size(188, 30);
            this.hasModelToggleBtn.TabIndex = 21;
            this.hasModelToggleBtn.Text = "Has Model: {}";
            this.hasModelToggleBtn.UseVisualStyleBackColor = true;
            this.hasModelToggleBtn.Click += new System.EventHandler(this.hasModelToggleBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backBtn.Location = new System.Drawing.Point(588, 422);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 30);
            this.backBtn.TabIndex = 21;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // autoFillFieldsBtn
            // 
            this.autoFillFieldsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoFillFieldsBtn.Location = new System.Drawing.Point(231, 422);
            this.autoFillFieldsBtn.Name = "autoFillFieldsBtn";
            this.autoFillFieldsBtn.Size = new System.Drawing.Size(213, 30);
            this.autoFillFieldsBtn.TabIndex = 22;
            this.autoFillFieldsBtn.Text = "Auto-Fill Fields";
            this.autoFillFieldsBtn.UseVisualStyleBackColor = true;
            this.autoFillFieldsBtn.Click += new System.EventHandler(this.autoFillFieldsBtn_Click);
            // 
            // ModelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.autoFillFieldsBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hasModelGrp);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previewCodeBtn);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelSettings_FormClosing);
            this.Load += new System.EventHandler(this.ModelSettings_Load);
            this.hasModelGrp.ResumeLayout(false);
            this.hasModelGrp.PerformLayout();
            this.hasAnimationGrp.ResumeLayout(false);
            this.hasAnimationGrp.PerformLayout();
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
        private System.Windows.Forms.GroupBox hasModelGrp;
        private System.Windows.Forms.Button hasModelToggleBtn;
        private Control.PlaceholderTB modelArcNameTxt;
        private System.Windows.Forms.GroupBox hasAnimationGrp;
        private Control.PlaceholderTB animCHR0NameTxt;
        private System.Windows.Forms.Button hasAnimationToggleBtn;
        private Control.PlaceholderTB modelMDL0NameTxt;
        private Control.PlaceholderTB modelBRRESNameTxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button autoFillFieldsBtn;
    }
}