using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using Service.Database;
using Game = Service.Database.Game;

namespace Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class GameService : IGameService
    {
        public Game ConnectGame(int gameId, int userId)
        {
            using (var context = new DatabaseContext())
            {
                var game = context.Games.FirstOrDefault(g => g.Id == gameId);
                if(game == null) throw new Exception("Не найдена игра");
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if(user == null) throw new Exception("Не найден пользователь");
                game.Players.Add(user);
                context.SaveChanges();
            }
            return null;
        }

        public User Login(string login, string password)
        {
            using (var context = new DatabaseContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user != null) return user.Password == password ? user : null;
                user = context.Users.Add(new User
                {
                    Login = login,
                    Password = password
                });
                context.SaveChanges();
                return user;
            }
        }
        
        public Game CreateGame(string gameTitle, int maxPlayers, int creatorId)
        {
            var game = new Game
            {
                IsAvaivable = true,
                PlayersCount = maxPlayers,
                CreatorId = creatorId,
                Description = gameTitle,
                Players = new List<User>()
            };
            using (var context = new DatabaseContext())
            {
                var result = context.Games.Add(game);
                context.SaveChanges();
                return result;
            }
        }

        public List<Game> GetAvaivableGames()
        {
            using (var context = new DatabaseContext())
            {
                return context.Games.ToList();
            }
        }


        #region Временные методы

        public List<User> GetAllUsers()
        {
            using (var context = new DatabaseContext())
            {
                return context.Users.ToList();
            }
        }
        #endregion
    }
}