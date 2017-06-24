using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Service.Database;
using Service.DataBaseModel;

namespace Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class DuplexService : IDuplexService
    {
        private Dictionary<IPlayerClient, string> _users = new Dictionary<IPlayerClient, string>();
        public void SendMessage(string message)
        {

        }

        public void StartGame()
        {
            foreach (var user in _users)
            {
                var client = user.Key;
                client?.StartClientGame();
                DistributeWonders();
            }
        }

        public void ConnectGame(string login)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IPlayerClient>();
            _users.Add(callback, login);
            using (var context = new DatabaseContext())
            {
                //var game = context.Games.FirstOrDefault(g => g.Description == "Пробная игра");
            }
        }

        public void CreateGame(string login)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IPlayerClient>();
            _users.Add(callback, login);
            /*using (var context = new DatabaseContext())
            {
                var game = context.Games.Add(new Game
                {
                    CreatorId = 1,
                    IsAvaivable = true,
                    Description = "Пробная игра",
                    PlayersCount = 4,
                    Players = new List<User>()
                });
                context.SaveChanges();
            }*/
        }

        public void DistributeWonders()
        {
            using (var context = new DatabaseModel())
            {
                var wonders = context.Wonders.ToList();
                foreach (var user in _users)
                {
                    
                }
            }
        }
    }
}
