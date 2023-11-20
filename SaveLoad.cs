using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virulence.Database;

namespace Virulence;
public static class SaveLoad
{
    public static bool SaveGame()
    {


        return false;
    }


    public static bool LoadGame(string saveName)
    {
        using var db = new DatabaseHandler();

        var player = db.Get("player", where: new()
        {
            (
            "saveName",
            saveName,
            DatabaseHandler.WhereClauseComparison.Equals,
            DatabaseHandler.WhereClauseCombiner.None
            )
        });
        return false;
    }
}
