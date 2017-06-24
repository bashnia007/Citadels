using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Service.Model;

namespace Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class DuplexService : IDuplexService
    {
        private Dictionary<IPlayerClient, int> _callbackUsers = new Dictionary<IPlayerClient, int>();
        public void SendMessage(string message)
        {

        }

        public void StartGame()
        {
            foreach (var user in _callbackUsers)
            {
                var client = user.Key;
                client?.StartClientGame();
            }
            DistributeWonders();
        }

        public void ConnectGame(int id)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IPlayerClient>();
            _callbackUsers.Add(callback, id);
        }

        public void CreateGame(int id)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IPlayerClient>();
            _callbackUsers.Add(callback, id);
        }

        public void DistributeWonders()
        {
            using (var context = new DbModel())
            {
                var wonders = context.Wonders.ToList();
                var rnd = new Random();
                foreach (var callbackUser in _callbackUsers)
                {
                    var wonder = wonders[rnd.Next(wonders.Count)];
                    wonders.Remove(wonder);
                    var player = context.Players.Add(new Player
                    {
                        UserId = callbackUser.Value,
                        GameId = 1,
                        WonderId = wonder.Id
                    });
                    context.SaveChanges();
                    
                    var client = callbackUser.Key;
                    client.CreatePlayer(player.Wonder);
                }
            }
        }
    }

    [DataContract]
    public class Test
    {
        [DataMember]
        public int TestId { get; set; }
    }
}
