
namespace Tanjun
{
    partial class CodePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodePreview));
            this.codeTextbox = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextbox
            // 
            this.codeTextbox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeTextbox.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.codeTextbox.BackBrush = null;
            this.codeTextbox.CharHeight = 18;
            this.codeTextbox.CharWidth = 10;
            this.codeTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextbox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeTextbox.IsReplaceMode = false;
            this.codeTextbox.Location = new System.Drawing.Point(0, 0);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeTextbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeTextbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeTextbox.ServiceColors")));
            this.codeTextbox.Size = new System.Drawing.Size(800, 587);
            this.codeTextbox.TabIndex = 0;
            this.codeTextbox.Zoom = 100;
            this.codeTextbox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.codeTextbox_TextChanged_1);
            // 
            // CodePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.codeTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CodePreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Preview - {}";
            this.Load += new System.EventHandler(this.CodePreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeTextbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeTextbox;
    }
}