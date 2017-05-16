using System.Collections.Generic;
using System.ServiceModel;
using Service.Database;

namespace Service
{
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        User Login(string login, string password);
        [OperationContract]
        User Register(string login, string password, string email);
        [OperationContract]

        Game CreateGame(string gameTitle, int maxPlayers, int creatorId);
        [OperationContract]
        List<Game> GetAvaivableGames();

        [OperationContract]
        Game StartGame();
        [OperationContract]
        void SelectRole(int roleId);
    }
}