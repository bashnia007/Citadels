using System.Collections.Generic;
using System.ServiceModel;
using Service.Model;

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