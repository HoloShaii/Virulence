using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virulence.Database;
using Virulence.Objects;

namespace Virulence;
public static class SaveLoad
{
    public static bool SaveGame()
    {

        return false;
    }


    public static bool LoadGame(this Game game, int playerId, string saveName)
    {
        Player loadedPlayer = new Player();
        using DatabaseHandler db = new DatabaseHandler();

        List<Object[]> player = db.Get("player", where: new()
        {
            (
                "id",
                playerId.ToString(),
                DatabaseHandler.WhereClauseComparison.Equals,
                DatabaseHandler.WhereClauseCombiner.And
            ),
            (
                "savename",
                saveName,
                DatabaseHandler.WhereClauseComparison.Equals,
                DatabaseHandler.WhereClauseCombiner.None
            )
        });
        if (!(player?.Any() ?? false)) return false;

        List<Int32> playerScavengers = db.Get("playerscavengers", where: new()
        {
            (
                "playerid",
                playerId.ToString(),
                DatabaseHandler.WhereClauseComparison.Equals,
                DatabaseHandler.WhereClauseCombiner.None
            )
        }).Select(x => (int)x[1]).ToList();

        if (playerScavengers?.Any() ?? false)
        {
            List<Object[]> scavengers = db.Get("scavengers", where: new()
            {
                (
                    "id",
                    string.Join("','", playerScavengers),
                    DatabaseHandler.WhereClauseComparison.In,
                    DatabaseHandler.WhereClauseCombiner.None
                )
            });


        }







        game.Player = loadedPlayer;
        return true;
    }
}
