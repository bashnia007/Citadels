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
        List<Game> GetAvaivableGames();


        #region Временные методы

        [OperationContract]
        List<User> GetAllUsers();

        #endregion
    }
}