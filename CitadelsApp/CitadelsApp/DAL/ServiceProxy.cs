﻿using System.Collections.Generic;
using System.Linq;
using CitadelsApp.OneWayReference;

namespace CitadelsApp.DAL
{
    public static class ServiceProxy
    {
        public static User Login(string login, string password)
        {
            using (var proxy = new GameServiceClient())
            {
                return proxy.Login(login, password);
            }
        }

        public static List<OneWayReference.Game> GetAvaivableGames()
        {
            using (var proxy = new GameServiceClient())
            {
                return proxy.GetAvaivableGames().ToList();
            }
        }

        public static OneWayReference.Game ConnectGame(int gameId, int userId)
        {
            using (var proxy = new GameServiceClient())
            {
                return proxy.ConnectGame(gameId, userId);
            }
        }

        public static OneWayReference.Game CreateGame(string gameTitle, int maxPlayers, int userId)
        {
            using (var proxy = new GameServiceClient())
            {
                return proxy.CreateGame(gameTitle, maxPlayers, userId);
            }
        }
    }
}
