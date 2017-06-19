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