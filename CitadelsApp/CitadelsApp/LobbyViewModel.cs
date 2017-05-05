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
        #region Properties
        public ObservableCollection<Game> Games { get; set; }
        #endregion

        #region Constructors
        public LobbyViewModel()
        {
        }
        #endregion

        #region Commands

        #region RefreshCommand
        private RelayCommand _refreshCommand;

        public ICommand RefreshCommand => _refreshCommand ??
                                          (_refreshCommand = new RelayCommand(ExecuteRefreshCommand, CanExecuteRefreshCommand));

        public async void ExecuteRefreshCommand(object param)
        {
            var data = await ServiceProxy.GetAvaivableGames();
            Games = new ObservableCollection<Game>(data);
        }

        private bool CanExecuteRefreshCommand(object param)
        {
            return true;
        }
        #endregion

        #region ConnectCommand

        private RelayCommand _connectCommand;
        public ICommand ConnectCommand => _connectCommand ?? 
                                          (_connectCommand = new RelayCommand(ExecuteConnectCommand, CanExecuteConnectCommand));

        private async void ExecuteConnectCommand(object param)
        {
            
        }

        private bool CanExecuteConnectCommand(object param)
        {
            return true;
        }

        #endregion

        #region CreateGameCommand

        private RelayCommand _createGameCommand;
        public ICommand CreateGameCommand => _createGameCommand ?? 
                                             (_createGameCommand = new RelayCommand(ExecuteCreateGameCommand, CanExecuteCreateGameCommand));

        private void ExecuteCreateGameCommand(object param)
        {
            
        }

        private bool CanExecuteCreateGameCommand(object param)
        {
            return true;
        }

        #endregion

        #endregion
    }
}
