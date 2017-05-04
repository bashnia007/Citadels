using System.Collections.Generic;
using CommonLIbrary;

namespace Service
{
    public class GameService : IGameService
    {
        public List<Game> Games = new List<Game>();
        public void StartGame()
        {
            
        }

        public void Login(string username)
        {
            
        }

        public void SelectRole(int roleId)
        {
            
        }

        public List<Role> GetAvaivableRoles(int gameId)
        {
            return null;
        }

        public void CreateGame(string gameTitle, int maxPlayers)
        {
            var game = new Game
            {
                IsAvaivable = true,
                Name = gameTitle,
                MaxPlayersCount = maxPlayers,
                Players = new List<Player>()
            };
            Games.Add(game);
        }

        public List<Game> GetAvaivableGames()
        {
            CreateGame("123", 5);
            CreateGame("qqq", 7);
            return Games;
        }
    }
}