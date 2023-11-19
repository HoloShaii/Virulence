using BreakEternity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virulence.Objects;

namespace Virulence;
public class Game
{
    private Screen gameForm;
    private int gameTickInterval = 50;
    public bool ShuttingDown;
    public GameLog Log;
    public ScavengerDisplay ScavengerDisplay;
    public Player Player;
    public World World;

    public Game(Screen gameForm)
    {
        this.gameForm = gameForm;
        this.Log = new GameLog();
        this.ScavengerDisplay = new ScavengerDisplay();
        this.World = new World();
        this.Player = new Player();
    }

    public void PreGame()
    {
        Player.AddScavenger();



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
    private List<BigDouble> scavengerFundsList = new();
    private List<Scavenger> scavengersToRemove = new();
    public void ScavengerLoop()
    {
        scavengerFundsList.Clear();
        scavengersToRemove.Clear();

        Player.Scavengers.ForEach(x => x.Age = x.Age.plus(1));
        Player.Scavengers.RemoveAll(x => x.Age > x.LifeSpan);

        scavengerFundsList.AddRange(Player.Scavengers.Select(x => x.ReturnCalculatedFundsPerTick()));
        BigDouble scavengerFunds = new(0);
        scavengerFundsList.ForEach(x => scavengerFunds = scavengerFunds.add(x));
        Player.funds = Player.funds.add(scavengerFunds);
    }

    public void VisualLoop()
    {
        GameLogLoop();
        CurrenciesDisplayLoop();
        ScavengerDisplayLoop();
    }

    public void GameLogLoop()
    {
        if (Log.Changed)
        {
            gameForm.SetControlText(gameForm.GetControl<Label>("lblLogPageNumber"), String.Format("{0}/{1}", Log.PageNumber, Log.MaxPageNumber));
            gameForm.SetControlText(gameForm.GetControl<TextBox>("txtGameLog"), Log.GetLogText());
        }
    }

    public void CurrenciesDisplayLoop()
    {
        
    }

    public void ScavengerDisplayLoop()
    {
        if (ScavengerDisplay.NeedsUpdate)
        {
            ScavengerDisplay.UpdateScavengers(Player.Scavengers);
        }
        if (ScavengerDisplay.Changed)
        {
            var names = ScavengerDisplay.GetScavengerNames();
            for (int i = 1; i <= 6; i++)
            {
                var controlNameChain = "grpScavengers>grpScavenger" + i.ToString();
                if (i <= names.Length)
                {
                    gameForm.SetControlText(gameForm.GetLastControlInChain<GroupBox>(controlNameChain), names[i - 1]);
                    gameForm.GetLastControlInChain<GroupBox>(controlNameChain).ShowHideControl(true);
                }
                else
                {
                    gameForm.GetLastControlInChain<GroupBox>(controlNameChain).ShowHideControl(false);
                }
            }
        }
    }

}
