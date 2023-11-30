using BreakEternity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Virulence.Objects;

namespace Virulence.Displays;
public class ScavengerDisplay
{
    private List<Scavenger[]> ScavengerDisplayList = new();
    
    private int _pageNumber = 1;
    public int PageNumber
    {
        get => _pageNumber;
        set
        {
            if (value < 1)
            {
                _pageNumber = 1;
                return;
            }
            if (value > ScavengerDisplayList.Count)
            {
                _pageNumber = ScavengerDisplayList.Count;
                return;
            }

            _pageNumber = value;
        }
    }
    public int MaxPageNumber => ScavengerDisplayList.Count;
    public bool Changed = true;
    public bool NeedsUpdate = true;

    public void UpdateScavengers(List<Scavenger> scavengers)
    {
        ScavengerDisplayList.Clear();
        ScavengerDisplayList.AddRange(scavengers.Chunk(6));
        if (ScavengerDisplayList.Count == 0) ScavengerDisplayList.Add(Array.Empty<Scavenger>());
        NeedsUpdate = false;
        Changed = true;
    }

    public string[] GetScavengerNames() => ScavengerDisplayList[_pageNumber - 1].Select(x => x.Name).ToArray();
    public int[] GetScavengerAges() => ScavengerDisplayList[_pageNumber - 1].Select(x => x.Age).ToArray();
    public int[] GetScavengerLifespans() => ScavengerDisplayList[_pageNumber - 1].Select(x => x.LifeSpan).ToArray();
    public BigDouble[] GetScavengerCreditsPerSecond(World world) => ScavengerDisplayList[_pageNumber - 1].Select(x => x.ReturnCalculatedCreditsPerTick(world.tiles[x.Location].scavengingEfficiency).multiply(Game.ticksPerSecond)).ToArray();
    public string[] GetScavengerLocations(World world) => ScavengerDisplayList[_pageNumber - 1].Select(x => world.tiles[x.Location].name).ToArray();
    public string[] GetScavengerCoordinates() => ScavengerDisplayList[_pageNumber - 1].Select(x => $"({x.Location.X}, {x.Location.Y})").ToArray();
    public string[] GetScavengerManual() => ScavengerDisplayList[_pageNumber - 1].Select(x => x.Manual ? "Manual" : "").ToArray();

    public void NextPage()
    {
        PageNumber++;
        Changed = true;
    }

    public void PreviousPage()
    {
        PageNumber--;
        Changed = true;
    }
}
