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
    public BigDouble Age { get; set; }
    public BigDouble LifeSpan { get; set; }
    public BigDouble EfficiencyMulti { get; set; } = 1;
    public BigDouble FundsPerGameTick { get; set; }

    public BigDouble ReturnCalculatedFundsPerTick() 
    {
        BigDouble funds = FundsPerGameTick;
        funds = funds.multiply(EfficiencyMulti);
        return funds;
    }
}
