using BreakEternity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virulence.Objects;
public class Scavenger
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int LifeSpan { get; set; }
    public BigDouble EfficiencyMulti { get; set; } = 1;
    public BigDouble CreditsPerGameTick { get; set; }
    public Point Location { get; set; } = World.Origin;
    public bool Manual { get; set; } = false;

    public BigDouble ReturnCalculatedCreditsPerTick(BigDouble tileScavengingEfficiency) 
    {
        BigDouble credits = CreditsPerGameTick;
        credits = credits.multiply(EfficiencyMulti);
        credits = credits.multiply(tileScavengingEfficiency);
        return credits;
    }
}
