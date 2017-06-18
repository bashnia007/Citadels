using System.ServiceModel;
using Service.Database;

namespace Service
{
    /// <summary>
    /// Интерфейс, описывающий методы, которые сервис может вызывать на клиенте
    /// </summary>
    [ServiceContract]
    public interface IPlayerClient
    {
        /// <summary>
        /// Метод получения сообщения
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        [OperationContract(IsOneWay = true)]
        void RecieveMessage(string user, string message);

        /// <summary>
        /// Метод, запускающий игру
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void StartClientGame();
    }
}