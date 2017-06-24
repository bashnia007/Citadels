using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CitadelsApp.DuplexReference;

namespace CitadelsApp.DAL
{
    public class PlayerClient : IDuplexServiceCallback
    {
        public void RecieveMessage(string user, string message)
        {
        }

        public void StartClientGame()
        {
            //MessageBox.Show("Игра началась!");
        }

        public void CreatePlayer(Wonder wonder)
        {
            MessageBox.Show("Я получил чудо: " + wonder.Name);
        }
    }
}
