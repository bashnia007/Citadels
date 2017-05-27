using System.ServiceModel;
using Service.Database;

namespace Service
{
    [ServiceContract]
    public interface IPlayerClient
    {
        [OperationContract(IsOneWay = true)]
        void RecieveMessage(string user, string message);

        [OperationContract(IsOneWay = true)]
        void GetLoginUser(User user);

        [OperationContract(IsOneWay = true)]
        void GetRegisterUser(User user);
    }
}