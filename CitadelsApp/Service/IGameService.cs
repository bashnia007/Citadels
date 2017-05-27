using System.Collections.Generic;
using System.ServiceModel;
using Service.Database;

namespace Service
{
    [ServiceContract(CallbackContract = typeof(IPlayerClient))]
    public interface IGameService
    {
        [OperationContract(IsOneWay = true)]
        void Login(string login, string password);
        /*[OperationContract]
        User Register(string login, string password, string email);
        [OperationContract]

        Game CreateGame(string gameTitle, int maxPlayers, int creatorId);
        [OperationContract]
        List<Game> GetAvaivableGames();

        [OperationContract]
        Game ConnectGame(int gameId, int userId);*/

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
        
    }
}