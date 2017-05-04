using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitadelsApp.KindOfMagic;

namespace CitadelsApp
{
    public class MainViewModel : PropertyChangedBase
    {
        public object CurrentContent { get; set; }

        public MainViewModel()
        {
            var lobbyViewModel = new LobbyViewModel();
            CurrentContent = new Lobby {DataContext = lobbyViewModel};
        }
    }
}
