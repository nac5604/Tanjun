
namespace Tanjun
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.basicSettingsBtn = new System.Windows.Forms.Button();
            this.modelSettingsBtn = new System.Windows.Forms.Button();
            this.positioningBtn = new System.Windows.Forms.Button();
            this.headerSelectionBtn = new System.Windows.Forms.Button();
            this.statesBtn = new System.Windows.Forms.Button();
            this.collisionsBtn = new System.Windows.Forms.Button();
            this.generateCPPBtn = new System.Windows.Forms.Button();
            this.openProjectBtn = new System.Windows.Forms.Button();
            this.saveProjectBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // basicSettingsBtn
            // 
            this.basicSettingsBtn.FlatAppearance.BorderSize = 0;
            this.basicSettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.basicSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicSettingsBtn.Image = global::Tanjun.Properties.Resources.icons8_project_setup_96;
            this.basicSettingsBtn.Location = new System.Drawing.Point(14, 126);
            this.basicSettingsBtn.Name = "basicSettingsBtn";
            this.basicSettingsBtn.Size = new System.Drawing.Size(112, 116);
            this.basicSettingsBtn.TabIndex = 4;
            this.tt.SetToolTip(this.basicSettingsBtn, "Basic Settings");
            this.basicSettingsBtn.UseVisualStyleBackColor = true;
            this.basicSettingsBtn.Click += new System.EventHandler(this.basicSettingsBtn_Click);
            // 
            // modelSettingsBtn
            // 
            this.modelSettingsBtn.FlatAppearance.BorderSize = 0;
            this.modelSettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modelSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelSettingsBtn.Image = global::Tanjun.Properties.Resources.icons8_mesh_96;
            this.modelSettingsBtn.Location = new System.Drawing.Point(132, 126);
            this.modelSettingsBtn.Name = "modelSettingsBtn";
            this.modelSettingsBtn.Size = new System.Drawing.Size(112, 116);
            this.modelSettingsBtn.TabIndex = 5;
            this.tt.SetToolTip(this.modelSettingsBtn, "Model Settings");
            this.modelSettingsBtn.UseVisualStyleBackColor = true;
            this.modelSettingsBtn.Click += new System.EventHandler(this.modelSettingsBtn_Click);
            // 
            // positioningBtn
            // 
            this.positioningBtn.FlatAppearance.BorderSize = 0;
            this.positioningBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.positioningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positioningBtn.Image = global::Tanjun.Properties.Resources.icons8_move_96;
            this.positioningBtn.Location = new System.Drawing.Point(250, 126);
            this.positioningBtn.Name = "positioningBtn";
            this.positioningBtn.Size = new System.Drawing.Size(112, 116);
            this.positioningBtn.TabIndex = 6;
            this.tt.SetToolTip(this.positioningBtn, "Positioning");
            this.positioningBtn.UseVisualStyleBackColor = true;
            this.positioningBtn.Click += new System.EventHandler(this.positioningBtn_Click);
            // 
            // headerSelectionBtn
            // 
            this.headerSelectionBtn.FlatAppearance.BorderSize = 0;
            this.headerSelectionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerSelectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerSelectionBtn.Image = global::Tanjun.Properties.Resources.icons8_paste_96;
            this.headerSelectionBtn.Location = new System.Drawing.Point(14, 248);
            this.headerSelectionBtn.Name = "headerSelectionBtn";
            this.headerSelectionBtn.Size = new System.Drawing.Size(112, 116);
            this.headerSelectionBtn.TabIndex = 7;
            this.tt.SetToolTip(this.headerSelectionBtn, "Header Selection");
            this.headerSelectionBtn.UseVisualStyleBackColor = true;
            this.headerSelectionBtn.Click += new System.EventHandler(this.headerSelectionBtn_Click);
            // 
            // statesBtn
            // 
            this.statesBtn.FlatAppearance.BorderSize = 0;
            this.statesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statesBtn.Image = global::Tanjun.Properties.Resources.icons8_rearrange_96;
            this.statesBtn.Location = new System.Drawing.Point(132, 248);
            this.statesBtn.Name = "statesBtn";
            this.statesBtn.Size = new System.Drawing.Size(112, 116);
            this.statesBtn.TabIndex = 8;
            this.tt.SetToolTip(this.statesBtn, "States");
            this.statesBtn.UseVisualStyleBackColor = true;
            this.statesBtn.Click += new System.EventHandler(this.statesBtn_Click);
            // 
            // collisionsBtn
            // 
            this.collisionsBtn.FlatAppearance.BorderSize = 0;
            this.collisionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.collisionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collisionsBtn.Image = global::Tanjun.Properties.Resources.icons8_ungroup_objects_96;
            this.collisionsBtn.Location = new System.Drawing.Point(250, 248);
            this.collisionsBtn.Name = "collisionsBtn";
            this.collisionsBtn.Size = new System.Drawing.Size(112, 116);
            this.collisionsBtn.TabIndex = 9;
            this.tt.SetToolTip(this.collisionsBtn, "Collisions");
            this.collisionsBtn.UseVisualStyleBackColor = true;
            this.collisionsBtn.Click += new System.EventHandler(this.collisionsBtn_Click);
            // 
            // generateCPPBtn
            // 
            this.generateCPPBtn.FlatAppearance.BorderSize = 0;
            this.generateCPPBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generateCPPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateCPPBtn.Image = global::Tanjun.Properties.Resources.icons8_cplusplus_a_general_purpose_descriptive_programming_computer_language_64;
            this.generateCPPBtn.Location = new System.Drawing.Point(250, 377);
            this.generateCPPBtn.Name = "generateCPPBtn";
            this.generateCPPBtn.Size = new System.Drawing.Size(112, 116);
            this.generateCPPBtn.TabIndex = 10;
            this.tt.SetToolTip(this.generateCPPBtn, "Generate C++ Code");
            this.generateCPPBtn.UseVisualStyleBackColor = true;
            this.generateCPPBtn.Click += new System.EventHandler(this.generateCPPBtn_Click);
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.FlatAppearance.BorderSize = 0;
            this.openProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProjectBtn.Image = global::Tanjun.Properties.Resources.icons8_open_document_96;
            this.openProjectBtn.Location = new System.Drawing.Point(14, 377);
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(112, 116);
            this.openProjectBtn.TabIndex = 11;
            this.tt.SetToolTip(this.openProjectBtn, "Import Project File");
            this.openProjectBtn.UseVisualStyleBackColor = true;
            this.openProjectBtn.Click += new System.EventHandler(this.openProjectBtn_Click);
            // 
            // saveProjectBtn
            // 
            this.saveProjectBtn.FlatAppearance.BorderSize = 0;
            this.saveProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProjectBtn.Image = global::Tanjun.Properties.Resources.icons8_save_close_96;
            this.saveProjectBtn.Location = new System.Drawing.Point(132, 377);
            this.saveProjectBtn.Name = "saveProjectBtn";
            this.saveProjectBtn.Size = new System.Drawing.Size(112, 116);
            this.saveProjectBtn.TabIndex = 12;
            this.tt.SetToolTip(this.saveProjectBtn, "Save Project File");
            this.saveProjectBtn.UseVisualStyleBackColor = true;
            this.saveProjectBtn.Click += new System.EventHandler(this.saveProjectBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(14, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(14, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 1);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tanjun.Properties.Resources.tanjun;
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tt
            // 
            this.tt.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveProjectBtn);
            this.Controls.Add(this.openProjectBtn);
            this.Controls.Add(this.generateCPPBtn);
            this.Controls.Add(this.collisionsBtn);
            this.Controls.Add(this.statesBtn);
            this.Controls.Add(this.headerSelectionBtn);
            this.Controls.Add(this.positioningBtn);
            this.Controls.Add(this.modelSettingsBtn);
            this.Controls.Add(this.basicSettingsBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button basicSettingsBtn;
        private System.Windows.Forms.Button modelSettingsBtn;
        private System.Windows.Forms.Button positioningBtn;
        private System.Windows.Forms.Button headerSelectionBtn;
        private System.Windows.Forms.Button statesBtn;
        private System.Windows.Forms.Button collisionsBtn;
        private System.Windows.Forms.Button generateCPPBtn;
        private System.Windows.Forms.Button openProjectBtn;
        private System.Windows.Forms.Button saveProjectBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tt;
    }
}