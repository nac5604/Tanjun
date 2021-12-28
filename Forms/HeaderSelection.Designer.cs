
namespace Tanjun
{
    partial class HeaderSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderSelection));
            this.title = new System.Windows.Forms.Label();
            this.sep = new System.Windows.Forms.Panel();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.importHeaderBtn = new System.Windows.Forms.Button();
            this.headers = new System.Windows.Forms.CheckedListBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previewCodeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(233, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Header Selection";
            // 
            // sep
            // 
            this.sep.BackColor = System.Drawing.Color.DarkGray;
            this.sep.Location = new System.Drawing.Point(13, 55);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(775, 1);
            this.sep.TabIndex = 1;
            // 
            // explanationBtn
            // 
            this.explanationBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.explanationBtn.Location = new System.Drawing.Point(575, 18);
            this.explanationBtn.Name = "explanationBtn";
            this.explanationBtn.Size = new System.Drawing.Size(213, 30);
            this.explanationBtn.TabIndex = 2;
            this.explanationBtn.Text = "Explanation of Headers";
            this.explanationBtn.UseVisualStyleBackColor = true;
            // 
            // importHeaderBtn
            // 
            this.importHeaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.importHeaderBtn.Location = new System.Drawing.Point(232, 424);
            this.importHeaderBtn.Name = "importHeaderBtn";
            this.importHeaderBtn.Size = new System.Drawing.Size(213, 30);
            this.importHeaderBtn.TabIndex = 3;
            this.importHeaderBtn.Text = "Import Custom Header File";
            this.importHeaderBtn.UseVisualStyleBackColor = true;
            this.importHeaderBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // headers
            // 
            this.headers.CheckOnClick = true;
            this.headers.FormattingEnabled = true;
            this.headers.Items.AddRange(new object[] {
            "common.h (Standard Library)",
            "sfx.h (Standard Library)",
            "game.h (Standard Library)",
            "g3dhax.h (Standard Library)",
            "stage.h (Standard Library)",
            "boss.h (Imported Library)"});
            this.headers.Location = new System.Drawing.Point(13, 62);
            this.headers.Name = "headers";
            this.headers.Size = new System.Drawing.Size(775, 356);
            this.headers.TabIndex = 4;
            this.headers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.headers_ItemCheck);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextBtn.Location = new System.Drawing.Point(691, 424);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(97, 30);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previewCodeBtn
            // 
            this.previewCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.previewCodeBtn.Location = new System.Drawing.Point(13, 424);
            this.previewCodeBtn.Name = "previewCodeBtn";
            this.previewCodeBtn.Size = new System.Drawing.Size(213, 30);
            this.previewCodeBtn.TabIndex = 6;
            this.previewCodeBtn.Text = "Preview Code Section";
            this.previewCodeBtn.UseVisualStyleBackColor = true;
            this.previewCodeBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeBtn.Location = new System.Drawing.Point(472, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 30);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // HeaderSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.previewCodeBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.headers);
            this.Controls.Add(this.importHeaderBtn);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HeaderSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanjun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeaderSelection_FormClosing);
            this.Load += new System.EventHandler(this.HeaderSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Button explanationBtn;
        private System.Windows.Forms.Button importHeaderBtn;
        private System.Windows.Forms.CheckedListBox headers;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previewCodeBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

