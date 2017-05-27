using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitadelsApp.GameServiceReference;

namespace CitadelsApp.DAL
{
    public static class ServiceProxy
    {/*
        public static async Task<List<GameServiceReference.Game>> GetAvaivableGames()
        {
            using (var proxy = new GameServiceClient())
            {
                var data = await proxy.GetAvaivableGamesAsync();
                return data.ToList();
            }
        }

        public static GameServiceReference.Game CreateGame(string gameTitle, int maxPlayers, int creatorId)
        {
            using (var proxy = new GameServiceClient())
            {
                return proxy.CreateGame(gameTitle, maxPlayers, creatorId);
            }
        }

        public static GameServiceReference.Game Connect(int gameId, int userId)
        {
            using (var proxy = new GameServiceClient())
            {
                return proxy.ConnectGame(gameId, userId);
            }
        }

        public static User Login(string login, string password)
        {
            using (var proxy = new GameServiceClient())
            {
                var user = proxy.Login(login, password);
                return user;
            }
        }

        public static User Register(string login, string password, string email)
        {
            using (var proxy = new GameServiceClient())
            {
                var user = proxy.Register(login, password, email);
                return user;
            }
        }*/
    }
}
