using System.Windows.Forms;
using Virulence.Extensions;
using Virulence.Controls;
using Virulence.Objects;

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


        dpadScavengerMovement.BtnUp.Click += BtnUp_Click;
        dpadScavengerMovement.BtnRight.Click += BtnRight_Click;
        dpadScavengerMovement.BtnDown.Click += BtnDown_Click;
        dpadScavengerMovement.BtnLeft.Click += BtnLeft_Click;
    }

    //Events

    private void Form1_Show(Object sender, EventArgs e)
    {
        Game = new Game(this);
        Game.PreGame();

        btnExit.Location = new Point(1817, 1006);
    }

    private void btnExit_Click(Object sender, EventArgs e)
    {
        Game.ShuttingDown = true;
    }

    private void btnLogNextPage_Click(Object sender, EventArgs e)
    {
        Game.Log.NextPage();
    }

    private void btnLogPrevPage_Click(Object sender, EventArgs e)
    {
        Game.Log.PreviousPage();
    }

    private void btnScavengerDisplayNextPage_Click(Object sender, EventArgs e)
    {
        Game.ScavengerDisplay.NextPage();
    }

    private void btnScavengerDisplayPrevPage_Click(Object sender, EventArgs e)
    {
        Game.ScavengerDisplay.PreviousPage();
    }

    private void BtnLeft_Click(Object sender, EventArgs e)
    {
        var scav = Game.Player.Scavengers.FirstOrDefault(x => x.Manual);
        if (scav == null) return;

        var newLocation = scav.Location;
        newLocation.X -= 1;

        if (Game.World.tiles.ContainsKey(newLocation))
        {
            scav.Location = newLocation;
        }
        else
        {
            //WorldGen
            Game.World.tiles.Add(newLocation, new(TileType.Street)
            {
                id = -1
            });

            scav.Location = newLocation;
        }
        Game.ScavengerDisplay.Changed = true;
    }

    private void BtnDown_Click(Object sender, EventArgs e)
    {
        var scav = Game.Player.Scavengers.FirstOrDefault(x => x.Manual);
        if (scav == null) return;

        var newLocation = scav.Location;
        newLocation.Y += 1;

        if (Game.World.tiles.ContainsKey(newLocation))
        {
            scav.Location = newLocation;
        }
        else
        {
            //WorldGen
            Game.World.tiles.Add(newLocation, new(TileType.Street)
            {
                id = -1
            });

            scav.Location = newLocation;
        }
        Game.ScavengerDisplay.Changed = true;
    }

    private void BtnRight_Click(Object sender, EventArgs e)
    {
        var scav = Game.Player.Scavengers.FirstOrDefault(x => x.Manual);
        if (scav == null) return;

        var newLocation = scav.Location;
        newLocation.X += 1;

        if (Game.World.tiles.ContainsKey(newLocation))
        {
            scav.Location = newLocation;
        }
        else
        {
            //WorldGen
            Game.World.tiles.Add(newLocation, new(TileType.Street)
            {
                id = -1
            });

            scav.Location = newLocation;
        }
        Game.ScavengerDisplay.Changed = true;
    }

    private void BtnUp_Click(Object sender, EventArgs e)
    {
        var scav = Game.Player.Scavengers.FirstOrDefault(x => x.Manual);
        if (scav == null) return;

        var newLocation = scav.Location;
        newLocation.Y -= 1;

        if (Game.World.tiles.ContainsKey(newLocation))
        {
            scav.Location = newLocation;
        }
        else
        {
            //WorldGen
            Game.World.tiles.Add(newLocation, new(TileType.Street)
            {
                id = -1
            });

            scav.Location = newLocation;
        }
        Game.ScavengerDisplay.Changed = true;
    }

    private void btnPrevScavenger_Click(Object sender, EventArgs e)
    {
        if (Game.Player.Scavengers.Count == 0) return;
        var index = Game.Player.ManualScavengerIndex;

        Game.Player.SetScavengerManual(index - 1 < 0 ? 0 : index - 1);
        Game.ScavengerDisplay.Changed = true;
    }

    private void btnNextScavenger_Click(Object sender, EventArgs e)
    {
        if (Game.Player.Scavengers.Count == 0) return;
        var index = Game.Player.ManualScavengerIndex;
        var maxIndex = Game.Player.Scavengers.Count - 1;

        Game.Player.SetScavengerManual(index + 1 > maxIndex ? maxIndex : index + 1);
        Game.ScavengerDisplay.Changed = true;
    }
}
