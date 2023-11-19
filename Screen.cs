using System.Windows.Forms;

#if DEBUG
using System.Runtime.InteropServices;
#endif

namespace Virulence;
public partial class Screen : Form
{
#if DEBUG
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool AllocConsole();
#endif

    public Game Game { get; set; }
    public Screen()
    {
        InitializeComponent();
#if DEBUG
        AllocConsole();
#endif
    }

    //Events

    private void Form1_Show(Object sender, EventArgs e)
    {
        Game = new Game(this);
#if DEBUG
        try
        {
            Game.PreGame();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
#else
        Game.PreGame();
#endif
        //Thread t = new Thread(Game.KickStart);
        //t.Start();
    }

    private void btnExit_Click(Object sender, EventArgs e)
    {
        Game.ShuttingDown = true;
    }

    public void SetControlText<T>(T control, string text) where T : Control
    {
        if (InvokeRequired)
        {
            Invoke(() => control.Text = text);
        }
        else
        {
            control.Text = text;
        }
    }

    private void btnNextPage_Click(Object sender, EventArgs e)
    {
        Game.Log.NextPage();
    }

    private void btnPrevPage_Click(Object sender, EventArgs e)
    {
        Game.Log.PreviousPage();
    }
}

public static class ControlExtensions
{
    public static T GetLastControlInChain<T>(this Screen form, string chain) where T : Control
    {
        var names = chain.Split('>');
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
                currentControl = form.GetControl<T>(names[i]);
            }
            else
            {
                currentControl = currentControl.GetControl<T>(names[i]);
            }
        }

        return (T)currentControl;
    }

    public static T GetControl<T>(this Screen form, string name) where T : Control
    {
        return (T)form.Controls[name];
    }
    public static T GetControl<T>(this Control control, string name) where T : Control
    {
        return (T)control.Controls[name];
    }

    public static void ShowHideControl(this Control control, bool show)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(() => control.Visible = show);
        }
        else
        {
            control.Visible = show;
        }
    }
}
