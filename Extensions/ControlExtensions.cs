using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Virulence.Extensions;
public static class ControlExtensions
{
    public static T GetLastControlInChain<T>(this Screen form, string chain) where T : Control
    {
        String[] names = chain.Split('>');
        if (names.Length == 0)
        {
            return null;
        }
        if (names.Length == 1)
        {
            return form.GetControl<T>(names[0]);
        }

        Control currentControl = null;

        for (int i = 0; i < names.Length; i++)
        {
            if (currentControl == null)
            {
                currentControl = form.GetControl<Control>(names[i]);
            }
            else
            {
                currentControl = currentControl.GetControl<Control>(names[i]);
            }
        }

        return (T)currentControl;
    }

    public static T GetControl<T>(this Screen form, string name) where T : Control => (T)form.Controls[name];
    public static T GetControl<T>(this Control control, string name) where T : Control => (T)control.Controls[name];
    public static void ShowHideControl(this Control control, bool show) => control.InvokeIfRequired(() => control.Visible = show);
    public static void SetControlText<T>(this T control, string text) where T : Control => control.InvokeIfRequired(() => control.Text = text);


    public static void SetProgressBar(this ProgressBar progressBar, int progress, int maxProgress)
    {
        progressBar.InvokeIfRequired(() =>
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = maxProgress;
            progressBar.Value = progress > maxProgress ? maxProgress : (progress < 0 ? 0 : progress);
        });
    }

    public static void InvokeIfRequired<T>(this T control, Action method) where T : Control
    {
        if (control.InvokeRequired)
        {
            control.Invoke(method);
        }
        else
        {
            method.Invoke();
        }
    }
}
