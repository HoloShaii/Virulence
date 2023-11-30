using BreakEternity;

namespace Virulence.Objects;
public class Player
{
    public int id;
    public string saveName;
    public int worldId; 
    public int ManualScavengerIndex = 0;
    public BigDouble credits = new(0);
    public Dictionary<string, BigDouble> otherCurrencies = new();
    public BigDouble Humans = new(2);
    public List<Scavenger> Scavengers = new();
    public List<Rescuer> rescuers = new();
    public List<Soldier> infantry = new();

    public void AddScavenger(string name = "")
    {
        if (Humans > 0)
        {
            Humans = Humans.minus(1);
            var id = Scavengers.Count > 0 ? Scavengers.Max(x => x.id) + 1 : 0;
            Scavenger scavenger = new()
            {
                id = id,
                Name = string.IsNullOrWhiteSpace(name) ? GetRandomName() : name,
                Age = 0,
                LifeSpan = Constants.RNG.Next(45000, 89000),
                EfficiencyMulti = 1,
                CreditsPerGameTick = Constants.RNG.Next(4, 9) * 0.01
            };

            Scavengers.Add(scavenger);
        }
    }

    public void AddOtherCurrency(string name, BigDouble amount)
    {
        if (!otherCurrencies.ContainsKey(name))
        {
            otherCurrencies.Add(name, amount);
        }
        else
        {
            otherCurrencies[name] += amount;
        }
    }

    public void SetScavengerManual(int id = 0)
    {
        if (Scavengers.Count == 0)
        {
            ManualScavengerIndex = 0;
            return;
        }
        Scavengers.ForEach(x => x.Manual = false);
        Scavenger scav = Scavengers.FirstOrDefault(x => x.id == id);
        scav ??= Scavengers.First();
        ManualScavengerIndex = scav.id;
        scav.Manual = true;
    }

    private string GetRandomName() => Constants.FirstNames[Constants.RNG.Next(0, Constants.FirstNames.Count)];
}
