
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previewCodeBtn = new System.Windows.Forms.Button();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.hasModelGrp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.placeholderTB1 = new Tanjun.Control.PlaceholderTB();
            this.placeholderTB2 = new Tanjun.Control.PlaceholderTB();
            this.placeholderTB3 = new Tanjun.Control.PlaceholderTB();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.placeholderTB6 = new Tanjun.Control.PlaceholderTB();
            this.button2 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.hasModelGrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.explanationBtn.Click += new System.EventHandler(this.explanationBtn_Click);
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
            this.hasModelGrp.Controls.Add(this.groupBox1);
            this.hasModelGrp.Controls.Add(this.placeholderTB3);
            this.hasModelGrp.Controls.Add(this.placeholderTB2);
            this.hasModelGrp.Controls.Add(this.placeholderTB1);
            this.hasModelGrp.Controls.Add(this.button1);
            this.hasModelGrp.Location = new System.Drawing.Point(13, 72);
            this.hasModelGrp.Name = "hasModelGrp";
            this.hasModelGrp.Size = new System.Drawing.Size(316, 344);
            this.hasModelGrp.TabIndex = 20;
            this.hasModelGrp.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(6, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Has Model: {}";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // placeholderTB1
            // 
            this.placeholderTB1.Location = new System.Drawing.Point(6, 35);
            this.placeholderTB1.Name = "placeholderTB1";
            this.placeholderTB1.PlaceHolderText = "ARC Name";
            this.placeholderTB1.Size = new System.Drawing.Size(304, 27);
            this.placeholderTB1.TabIndex = 21;
            // 
            // placeholderTB2
            // 
            this.placeholderTB2.Location = new System.Drawing.Point(6, 68);
            this.placeholderTB2.Name = "placeholderTB2";
            this.placeholderTB2.PlaceHolderText = "BRRES Name";
            this.placeholderTB2.Size = new System.Drawing.Size(304, 27);
            this.placeholderTB2.TabIndex = 22;
            // 
            // placeholderTB3
            // 
            this.placeholderTB3.Location = new System.Drawing.Point(6, 101);
            this.placeholderTB3.Name = "placeholderTB3";
            this.placeholderTB3.PlaceHolderText = "MDL0 Name";
            this.placeholderTB3.Size = new System.Drawing.Size(304, 27);
            this.placeholderTB3.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.placeholderTB6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(6, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 71);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // placeholderTB6
            // 
            this.placeholderTB6.Location = new System.Drawing.Point(6, 35);
            this.placeholderTB6.Name = "placeholderTB6";
            this.placeholderTB6.PlaceHolderText = "Initial CHR0 Animation Name";
            this.placeholderTB6.Size = new System.Drawing.Size(292, 27);
            this.placeholderTB6.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(6, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "Has Animation: {}";
            this.button2.UseVisualStyleBackColor = true;
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
            // ModelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hasModelGrp);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previewCodeBtn);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.hasModelGrp.ResumeLayout(false);
            this.hasModelGrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private Control.PlaceholderTB placeholderTB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Control.PlaceholderTB placeholderTB6;
        private System.Windows.Forms.Button button2;
        private Control.PlaceholderTB placeholderTB3;
        private Control.PlaceholderTB placeholderTB2;
        private System.Windows.Forms.Button backBtn;
    }
}