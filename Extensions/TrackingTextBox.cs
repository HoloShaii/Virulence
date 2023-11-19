using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virulence.Extensions;
public class TrackingTextBox : TextBox
{
    public TrackingTextBox() : base()
    {
    }

    private bool changed { get; set; }

    public void SetChanged(bool boolean = true)
    {
        if (InvokeRequired)
        {
            Invoke(() => changed = boolean);
        }
        else
        {
            changed = boolean;
        }
    }

    public bool GetChanged() => this.changed;

}
