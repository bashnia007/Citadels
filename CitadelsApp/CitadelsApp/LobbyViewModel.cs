using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CitadelsApp.DAL;
using CitadelsApp.KindOfMagic;
using CommonLIbrary;

namespace CitadelsApp
{
    public class LobbyViewModel : PropertyChangedBase
    {
        public LobbyViewModel()
        {
        }
        

        public ObservableCollection<Game> Games { get; set; }

        private ICommand _refreshCommand;

        public async void GetGames()
        {
            var data = await ServiceProxy.GetAvaivableGames();
            Games = new ObservableCollection<Game>(data);
        }

        public ICommand RefreshCommand { get; set; }

        public async void CreateGame()
        {
            
        }
    }
}
