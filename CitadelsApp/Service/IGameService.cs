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
        Game CreateGame(string gameTitle, int maxPlayers, int creatorId);

        [OperationContract]
        List<Game> GetAvaivableGames();

        [OperationContract]
        Game ConnectGame(int gameId, int userId);


        #region Временные методы

        [OperationContract]
        List<User> GetAllUsers();

        #endregion
    }
}