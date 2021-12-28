using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanjun
{
    public partial class CodePreview : Form
    {
        Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        Style RedStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);
        Style MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        Style BoldStyle = new TextStyle(null, null, FontStyle.Bold);
        Style BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

        public CodePreview(List<string> codeInput, string title)
        {
            InitializeComponent();
            this.Text = "Code Preview - " + title;
            if (codeInput != null)
            {
                foreach (string s in codeInput)
                {
                    codeTextbox.Text += s;
                }
            }
        }

        private void CodePreview_Load(object sender, EventArgs e)
        {
            this.Icon = Tanjun.Properties.Resources.icon;
        }
        private void codeTextbox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Rough C++ Syntax highlighting (Sort of).
            // Credit to zbooa on GitHub issues.
            // All-Caps made by me.

            // Strings
            e.ChangedRange.SetStyle(GreenStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");

            // Comments
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);

            // Class Names
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");

            // All-Caps
            e.ChangedRange.SetStyle(MagentaStyle, @"\b([A-Z]+_[A-Z]+)");

            // Numbers
            e.ChangedRange.SetStyle(RedStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");

            // Types
            e.ChangedRange.SetStyle(BlueStyle, @"\b[A-Z]([A-Z0-9]*[a-z][a-z0-9]*[A-Z]|[a-z0-9]*[A-Z][A-Z0-9]*[a-z])[A-Za-z0-9]*\b");
            e.ChangedRange.SetStyle(BlueStyle, @"\b(LRESULT|CString|String|WORD|DWORD|TCHAR|BYTE|BOOL|unsigned|signed|int|bool|char|short|long|float|double|string|wchar|wchar_t|__int8|__int16|__int32|__int64|struct|class|enum|interface|if|else|switch|case|break|defalut|return|true|false|for|do|while|continue|goto|new|list|map|using|namespace|private|protected|public|const|delete|cout|cin|void)\b");

            // Conditions
            e.ChangedRange.SetStyle(BlueStyle, @"#\b(include|pragma|if|else|elif|ifndef|ifdef|endif|undef|define|line|error)\b|__[^>]*__", RegexOptions.Singleline);

            // <> Brackets
            e.ChangedRange.SetStyle(RedStyle, @"<[^>]*>", RegexOptions.Singleline);

            // * 
            e.ChangedRange.SetStyle(RedStyle, @"\*", RegexOptions.Singleline);

            // Folding Markers
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("{", "}");
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");
        }
    }
}
