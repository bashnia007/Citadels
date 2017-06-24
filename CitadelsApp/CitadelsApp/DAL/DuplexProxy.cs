using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CitadelsApp.DuplexReference;

namespace CitadelsApp.DAL
{
    public static class DuplexProxy
    {
        static InstanceContext context = new InstanceContext(new PlayerClient());
        static DuplexServiceClient duplexService = new DuplexServiceClient(context);
        static DuplexProxy()
        {
            //DuplexServiceClient duplexService = new DuplexServiceClient(context);
        }
        public static void CreateGame(int id)
        {
            //InstanceContext context = new InstanceContext(new PlayerClient());

            //using (DuplexServiceClient duplexService = new DuplexServiceClient(context))
            {
                duplexService.CreateGame(id);
            }
        }

        public static void ConnectGame(int id)
        {
            //var context = new InstanceContext(new PlayerClient());

            //using (var duplexService = new DuplexServiceClient(context))
            {
                duplexService.ConnectGame(id);
            }
        }

        public static void StartGame()
        {
            //var context = new InstanceContext(new PlayerClient());

            //using (var duplexService = new DuplexServiceClient(context))
            {
                duplexService.StartGame();
            }
        }
    }
}
