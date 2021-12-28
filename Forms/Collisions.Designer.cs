
namespace Tanjun
{
    partial class Collisions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collisions));
            this.closeBtn = new System.Windows.Forms.Button();
            this.previewCodeBtn = new System.Windows.Forms.Button();
            this.explanationBtn = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.collisionsLst = new System.Windows.Forms.CheckedListBox();
            this.copyBitfieldValue = new System.Windows.Forms.Button();
            this.checkAllBtn = new System.Windows.Forms.Button();
            this.uncheckAllBtn = new System.Windows.Forms.Button();
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
            this.explanationBtn.Text = "Explanation of Collisions";
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
            this.title.Size = new System.Drawing.Size(136, 38);
            this.title.TabIndex = 14;
            this.title.Text = "Collisions";
            // 
            // collisionsLst
            // 
            this.collisionsLst.CheckOnClick = true;
            this.collisionsLst.FormattingEnabled = true;
            this.collisionsLst.Items.AddRange(new object[] {
            "Unknown 1",
            "Fireball",
            "Iceball",
            "Invincibility Star",
            "Unknown 2",
            "Slide",
            "Unknown 3",
            "Ground Pound",
            "Slapping Grate",
            "Rolling Object",
            "Penguin Slide",
            "Spin",
            "Unknown 4",
            "Propeller Shroom Spiraling Down",
            "Fire Explosion",
            "Yoshi Eating",
            "Yoshi Lick",
            "Cannon",
            "Lift Up",
            "Throwing Hammer",
            "Yoshi Fireball",
            "Yoshi Iceball"});
            this.collisionsLst.Location = new System.Drawing.Point(13, 104);
            this.collisionsLst.Name = "collisionsLst";
            this.collisionsLst.Size = new System.Drawing.Size(776, 312);
            this.collisionsLst.TabIndex = 20;
            this.collisionsLst.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.collisionsLst_ItemCheck);
            // 
            // copyBitfieldValue
            // 
            this.copyBitfieldValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copyBitfieldValue.Location = new System.Drawing.Point(231, 422);
            this.copyBitfieldValue.Name = "copyBitfieldValue";
            this.copyBitfieldValue.Size = new System.Drawing.Size(213, 30);
            this.copyBitfieldValue.TabIndex = 21;
            this.copyBitfieldValue.Text = "Copy Bitfield2 Value";
            this.copyBitfieldValue.UseVisualStyleBackColor = true;
            this.copyBitfieldValue.Click += new System.EventHandler(this.copyBitfieldValue_Click);
            // 
            // checkAllBtn
            // 
            this.checkAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkAllBtn.Location = new System.Drawing.Point(12, 68);
            this.checkAllBtn.Name = "checkAllBtn";
            this.checkAllBtn.Size = new System.Drawing.Size(100, 30);
            this.checkAllBtn.TabIndex = 22;
            this.checkAllBtn.Text = "Check All";
            this.checkAllBtn.UseVisualStyleBackColor = true;
            this.checkAllBtn.Click += new System.EventHandler(this.checkAllBtn_Click);
            // 
            // uncheckAllBtn
            // 
            this.uncheckAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uncheckAllBtn.Location = new System.Drawing.Point(118, 68);
            this.uncheckAllBtn.Name = "uncheckAllBtn";
            this.uncheckAllBtn.Size = new System.Drawing.Size(100, 30);
            this.uncheckAllBtn.TabIndex = 23;
            this.uncheckAllBtn.Text = "Uncheck All";
            this.uncheckAllBtn.UseVisualStyleBackColor = true;
            this.uncheckAllBtn.Click += new System.EventHandler(this.uncheckAllBtn_Click);
            // 
            // Collisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.ControlBox = false;
            this.Controls.Add(this.uncheckAllBtn);
            this.Controls.Add(this.checkAllBtn);
            this.Controls.Add(this.copyBitfieldValue);
            this.Controls.Add(this.collisionsLst);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.previewCodeBtn);
            this.Controls.Add(this.explanationBtn);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Collisions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanjun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Collisions_FormClosing);
            this.Load += new System.EventHandler(this.Collisions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button previewCodeBtn;
        private System.Windows.Forms.Button explanationBtn;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckedListBox collisionsLst;
        private System.Windows.Forms.Button copyBitfieldValue;
        private System.Windows.Forms.Button checkAllBtn;
        private System.Windows.Forms.Button uncheckAllBtn;
    }
}