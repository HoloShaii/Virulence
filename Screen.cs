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
    }

    private void btnExit_Click(Object sender, EventArgs e)
    {
        Game.ShuttingDown = true;
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
