using System.Collections.Generic;
using System.Linq;
using CommonLIbrary;
using Service.Database;
using Game = Service.Database.Game;

namespace Service
{
    public class GameService : IGameService
    {
        public void StartGame()
        {
            
        }

        public User Login(string login, string password)
        {
            using (var context = new DatabaseContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
                return user;
            }
        }

        public void SelectRole(int roleId)
        {
            
        }
        
        public List<Role> GetAvaivableRoles(int gameId)
        {
            return null;
        }

        public User CreateUser(string login, string password)
        {
            using (var context = new DatabaseContext())
            {
                var user = context.Users.Add(new User
                {
                    Login = login,
                    Password = password
                });
                context.SaveChanges();
                return user;
            }
        }

        public void CreateGame(string gameTitle, int maxPlayers, int creatorId)
        {
            var game = new Game
            {
                IsAvaivable = true,
                PlayersCount = maxPlayers,
                CreatorId = creatorId,
                Players = new List<User>()
            };
            using (var context = new DatabaseContext())
            {
                context.Games.Add(game);
                context.SaveChanges();
            }
        }

        public List<Game> GetAvaivableGames()
        {
            using (var context = new DatabaseContext())
            {
                return context.Games.ToList();
            }
        }
    }
}