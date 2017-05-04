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
    }
}
