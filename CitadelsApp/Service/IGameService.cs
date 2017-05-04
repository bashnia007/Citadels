using System.Collections.Generic;
using System.ServiceModel;
using CommonLIbrary;

namespace Service
{
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        void StartGame();
        [OperationContract]
        void Login(string username);
        [OperationContract]
        void SelectRole(int roleId);
        [OperationContract]
        List<Role> GetAvaivableRoles(int gameId);
        [OperationContract]
        void CreateGame(string gameTitle, int maxPlayers);
        [OperationContract]
        List<Game> GetAvaivableGames();
    }
}