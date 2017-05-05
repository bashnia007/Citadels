using System.Collections.Generic;
using System.ServiceModel;
using Service.Database;

namespace Service
{
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        void StartGame();
        [OperationContract]
        void Login(string login, string password);
        [OperationContract]
        void SelectRole(int roleId);
        [OperationContract]
        void CreateGame(string gameTitle, int maxPlayers, int creatorId);
        [OperationContract]
        List<Game> GetAvaivableGames();
    }
}