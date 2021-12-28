
namespace Tanjun
{
    partial class States
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(States));
            this.closeBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previewCodeBtn = new System.Windows.Forms.Button();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.statesLst = new UpdatingListbox();
            this.cms.SuspendLayout();
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
            this.explanationBtn.Text = "Explanation of States";
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
            this.title.Size = new System.Drawing.Size(93, 38);
            this.title.TabIndex = 14;
            this.title.Text = "States";
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteStateToolStripMenuItem,
            this.addStateToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(161, 52);
            // 
            // deleteStateToolStripMenuItem
            // 
            this.deleteStateToolStripMenuItem.Name = "deleteStateToolStripMenuItem";
            this.deleteStateToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteStateToolStripMenuItem.Text = "Delete State";
            this.deleteStateToolStripMenuItem.Click += new System.EventHandler(this.deleteStateToolStripMenuItem_Click);
            // 
            // addStateToolStripMenuItem
            // 
            this.addStateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.addStateToolStripMenuItem.Name = "addStateToolStripMenuItem";
            this.addStateToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.addStateToolStripMenuItem.Text = "Add State...";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // statesLst
            // 
            this.statesLst.ContextMenuStrip = this.cms;
            this.statesLst.FormattingEnabled = true;
            this.statesLst.HorizontalScrollbar = true;
            this.statesLst.ItemHeight = 20;
            this.statesLst.Location = new System.Drawing.Point(12, 72);
            this.statesLst.Name = "statesLst";
            this.statesLst.Size = new System.Drawing.Size(776, 344);
            this.statesLst.TabIndex = 21;
            // 
            // States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 455);
            this.ControlBox = false;
            this.Controls.Add(this.statesLst);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previewCodeBtn);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "States";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanjun";
            this.Load += new System.EventHandler(this.States_Load);
            this.cms.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem deleteStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private UpdatingListbox statesLst;
    }
}