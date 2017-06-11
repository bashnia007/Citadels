using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [ServiceContract(CallbackContract = typeof(IPlayerClient))]
    public interface IDuplexService
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }
}
