﻿using System.Collections.Generic;
using System.Linq;
using Service.Database;
using Game = Service.Database.Game;

namespace Service
{
    public class GameService : IGameService
    {
        public Game StartGame()
        {
            return null;
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
        
        /*public List<Role> GetAvaivableRoles(int gameId)
        {
            return null;
        }*/

        public User Register(string login, string password, string email)
        {
            using (var context = new DatabaseContext())
            {
                var user = context.Users.Add(new User
                {
                    Login = login,
                    Password = password,
                    Email = email
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
    }
}