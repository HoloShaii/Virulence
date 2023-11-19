using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virulence.Objects;
public class World
{
    public int id { get; set; }
    public Point Origin { get; } = new Point(0, 0);
    public Dictionary<Point,Tile> tiles = new();
}
