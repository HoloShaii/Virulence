using BreakEternity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virulence.Controls;
using Virulence.Displays;
using Virulence.Extensions;
using Virulence.Objects;

namespace Virulence;
public class Game
{
    private Screen gameForm;
    public static int gameTickInterval = 50;
    public static int ticksPerSecond = 1000 / gameTickInterval;
    public bool ShuttingDown;
    public GameLog Log;
    public ScavengerDisplay ScavengerDisplay;
    public CurrenciesDisplay CurrenciesDisplay;
    public Player Player;
    public World World;

    public Game(Screen gameForm)
    {
        this.gameForm = gameForm;
        this.Log = new GameLog();
        this.ScavengerDisplay = new ScavengerDisplay();
        this.CurrenciesDisplay = new CurrenciesDisplay();
        this.World = new World();
        this.Player = new Player();
    }

    public void PreGame()
    {

        //this.LoadGame(1, "test");

        Player.AddScavenger();
        Player.AddScavenger();
        Player.AddScavenger();
        Player.SetScavengerManual(0);


        Thread thread = new Thread(StartGame);
        thread.Start();
    }

    public void StartGame()
    {
        Stopwatch s = new();
        s.Start();
        while (!ShuttingDown)
        {
            GameLoop();
            VisualLoop();
            while (s.ElapsedMilliseconds < gameTickInterval)
            {
                Thread.Sleep(0);
                Application.DoEvents();
            }
            s.Restart();
        }

        Environment.Exit(0);
    }

    public void GameLoop()
    {
        ScavengerLoop();
    }
    private List<BigDouble> scavengerCreditsList = new();
    private List<Scavenger> scavengersToRemove = new();
    public void ScavengerLoop()
    {
        scavengerCreditsList.Clear();
        scavengersToRemove.Clear();

        Player.Scavengers.ForEach(x => x.Age += 1);
        if (Player.Scavengers.Any(x => x.Age > x.LifeSpan))
        {
            Player.Scavengers.RemoveAll(x => x.Age > x.LifeSpan);
            ScavengerDisplay.NeedsUpdate = true;
        }

        scavengerCreditsList.AddRange(Player.Scavengers.Select(x => x.ReturnCalculatedCreditsPerTick(World.tiles[x.Location].scavengingEfficiency)));
        BigDouble scavengerCredits = new(0);
        scavengerCreditsList.ForEach(x => scavengerCredits = scavengerCredits.add(x));
        Player.credits = Player.credits.add(scavengerCredits);
    }

    public void VisualLoop()
    {
        CreditsDisplayLoop();
        GameLogLoop();
        CurrenciesDisplayLoop();
        ScavengerDisplayLoop();
    }

    public void CreditsDisplayLoop()
    {
        gameForm.GetControl<Label>("lblCredits").SetControlText(String.Format("{0}: {1}", "Credits", Player.credits.toStringWithdecPlaces(1)));
    }

    public void GameLogLoop()
    {
        if (Log.Changed)
        {
            gameForm.GetControl<Label>("lblLogPageNumber").SetControlText(String.Format("{0}/{1}", Log.PageNumber, Log.MaxPageNumber));
            gameForm.GetControl<TextBox>("txtGameLog").SetControlText(Log.GetLogText());
        }
    }

    public void CurrenciesDisplayLoop()
    {
        if (CurrenciesDisplay.NeedsUpdate)
        {
            CurrenciesDisplay.UpdateCurrencies(Player.otherCurrencies);
        }
        if (CurrenciesDisplay.Changed)
        {
            gameForm.GetControl<TextBox>("txtOtherCurrencies").SetControlText(CurrenciesDisplay.GetCurrenciesText());
        }
    }

    public void ScavengerDisplayLoop()
    {
        if (ScavengerDisplay.NeedsUpdate)
        {
            ScavengerDisplay.UpdateScavengers(Player.Scavengers);
        }
        if (ScavengerDisplay.Changed)
        {
            gameForm.GetControl<Label>("lblScavengerDisplayPageNumber").SetControlText(String.Format("{0}/{1}", ScavengerDisplay.PageNumber, ScavengerDisplay.MaxPageNumber));
            String[] names = ScavengerDisplay.GetScavengerNames();
            BigDouble[] creditsPerSecond = ScavengerDisplay.GetScavengerCreditsPerSecond(World);
            String[] locations = ScavengerDisplay.GetScavengerLocations(World);
            String[] coordinates = ScavengerDisplay.GetScavengerCoordinates();
            String[] manual = ScavengerDisplay.GetScavengerManual();
            for (int i = 1; i <= 6; i++)
            {
                String controlNameChain = "grpScavengers>grpScavenger{0}{1}{2}";
                String controlNameChainNames = string.Format(controlNameChain, i, "", "");
                String controlNameChainCreditsPerSecond = string.Format(controlNameChain, i, ">lblCreditsScavenger", i);
                String controlNameChainLocation = string.Format(controlNameChain, i, ">lblLocationScavenger", i);
                String controlNameChainCoordinates = string.Format(controlNameChain, i, ">lblCoordinatesScavenger", i);
                String controlNameChainManual = string.Format(controlNameChain, i, ">lblManualScavenger", i);

                if (i <= names.Length)
                {
                    gameForm.GetLastControlInChain<GroupBox>(controlNameChainNames).SetControlText(names[i - 1]);
                    gameForm.GetLastControlInChain<Label>(controlNameChainCreditsPerSecond).SetControlText($"Credits per second: {creditsPerSecond[i - 1].toStringWithdecPlaces(2)}");
                    gameForm.GetLastControlInChain<Label>(controlNameChainLocation).SetControlText(locations[i - 1]);
                    gameForm.GetLastControlInChain<Label>(controlNameChainCoordinates).SetControlText(coordinates[i - 1]);
                    gameForm.GetLastControlInChain<Label>(controlNameChainManual).SetControlText(manual[i - 1]);


                    gameForm.GetLastControlInChain<GroupBox>(controlNameChainNames).ShowHideControl(true);
                    gameForm.GetLastControlInChain<Label>(controlNameChainCreditsPerSecond).ShowHideControl(true);
                    gameForm.GetLastControlInChain<Label>(controlNameChainLocation).ShowHideControl(true);
                    gameForm.GetLastControlInChain<Label>(controlNameChainCoordinates).ShowHideControl(true);
                    gameForm.GetLastControlInChain<Label>(controlNameChainManual).ShowHideControl(true);
                }
                else
                {
                    gameForm.GetLastControlInChain<GroupBox>(controlNameChainNames).ShowHideControl(false);
                    gameForm.GetLastControlInChain<Label>(controlNameChainCreditsPerSecond).ShowHideControl(false);
                    gameForm.GetLastControlInChain<Label>(controlNameChainLocation).ShowHideControl(false);
                    gameForm.GetLastControlInChain<Label>(controlNameChainCoordinates).ShowHideControl(false);
                    gameForm.GetLastControlInChain<Label>(controlNameChainManual).ShowHideControl(false);
                }

            }
            ScavengerDisplay.Changed = false;
        }

        Int32[] ages = ScavengerDisplay.GetScavengerAges();
        Int32[] lifespans = ScavengerDisplay.GetScavengerLifespans();
        for (int i = 1; i <= 6; i++)
        {
            String controlNameChainAges = "grpScavengers>grpScavenger" + i.ToString() + ">prgrsScavenger" + i.ToString();
            if (i <= ages.Length)
            {
                gameForm.GetLastControlInChain<ProgressBar>(controlNameChainAges).SetProgressBar(lifespans[i - 1] - ages[i - 1], lifespans[i - 1]);
                gameForm.GetLastControlInChain<ProgressBar>(controlNameChainAges).ShowHideControl(true);
            }
            else
            {
                gameForm.GetLastControlInChain<ProgressBar>(controlNameChainAges).ShowHideControl(false);
            }
        }
    }

}
