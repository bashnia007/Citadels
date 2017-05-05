using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitadelsApp.GameServiceReference;
using CommonLIbrary;

namespace CitadelsApp.DAL
{
    public static class ServiceProxy
    {
        public static async Task<List<Game>> GetAvaivableGames()
        {
            using (var proxy = new GameServiceClient())
            {
                var data = await proxy.GetAvaivableGamesAsync();
                return data.ToList();
            }
        }

        public static async Task CreateGame(string gameTitle, int maxPlayers)
        {
            using (var proxy = new GameServiceClient())
            {
                await proxy.CreateGameAsync(gameTitle, maxPlayers);
            }
        }

        public static async Task Connect()
        {
            using (var proxy = new GameServiceClient())
            {
            }
        }
    }
}
