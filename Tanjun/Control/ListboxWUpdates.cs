using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

public class UpdatingListbox : ListBox
{
    public UpdatingListbox()
    {
    }

    private const int LB_ADDSTRING = 0x180;
    private const int LB_DELETESTRING = 0x182;

    protected override void WndProc(ref Message message)
    {
        if (message.Msg == LB_ADDSTRING)
            ItemsAdded?.Invoke(this, EventArgs.Empty);
        else if (message.Msg == LB_DELETESTRING)
            ItemsRemoved?.Invoke(this, EventArgs.Empty);
        base.WndProc(ref message);
    }

    public event EventHandler ItemsAdded;
    public event EventHandler ItemsRemoved;
}