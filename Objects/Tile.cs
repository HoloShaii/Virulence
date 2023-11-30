using BreakEternity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virulence.Objects;
public class Tile
{
    public static Dictionary<TileType, BigDouble> defaultEfficiencies = new()
    {
        { TileType.Unknown, 0 },
        { TileType.Headquarters, 0.1 },
        { TileType.Street, 1 },
        { TileType.Field, 0.4 },
        { TileType.Park, 0.7 },
    };

    public static Dictionary<TileType, string> defaultNames = new()
    {
        { TileType.Unknown, "<<UNKNOWN>>" },
        { TileType.Headquarters, "Headquarters" },
        { TileType.Street, "Street" },
        { TileType.Field, "Field" },
        { TileType.Park, "Park" },
    };

    public int id;
    public string name;
    public TileType type;
    public BigDouble scavengingEfficiency;

    public List<(Item item, BigDouble cost)> vendorStock;

    public Tile(TileType type, TileVendorType vendorType = TileVendorType.None)
    {
        name = defaultNames[type];
        scavengingEfficiency = defaultEfficiencies[type];
    }
}

public enum TileType
{
    Unknown,
    Headquarters,
    Street,
    Field,
    Park,
}

[Flags]
public enum TileVendorType
{
    None = 0,
    Default = 1,
}
