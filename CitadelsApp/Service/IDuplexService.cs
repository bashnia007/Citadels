using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Service.Model;

namespace Service
{

    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IPlayerClient))]
    public interface IDuplexService
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);

        [OperationContract(IsOneWay = true)]
        void StartGame();

        [OperationContract(IsOneWay = true)]
        void ConnectGame(int id);

        [OperationContract(IsOneWay = true)]
        void CreateGame(int id);
    }
}
