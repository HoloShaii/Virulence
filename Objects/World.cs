using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virulence.Objects;
public class World
{
    public int id { get; set; }
    public static Point Origin { get; } = new Point(0, 0);
    public Dictionary<Point, Tile> tiles = new();

    public World()
    {
        tiles.Add(Origin, new(TileType.Headquarters)
        {
            id = 0,
        });
    }
}
