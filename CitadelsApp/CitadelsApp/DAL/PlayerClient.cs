using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitadelsApp.GameServiceReference;

namespace CitadelsApp.DAL
{
    public class PlayerClient : IGameServiceCallback
    {
        public void RecieveMessage(string user, string message)
        {
        }

        public void GetLoginUser(User user)
        {

        }

        public void GetRegisterUser(User user)
        {
        }
    }
}
