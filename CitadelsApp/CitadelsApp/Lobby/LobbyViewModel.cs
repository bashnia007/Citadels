using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CitadelsApp.AdditionalWindows;
using CitadelsApp.DAL;
using CitadelsApp.Game.ViewModels;
using CitadelsApp.GameServiceReference;
using CitadelsApp.KindOfMagic;

namespace CitadelsApp
{
    public class LobbyViewModel : PropertyChangedBase
    {
        #region Privates

        private Window _dialogWindow;
        private int _userId;
        #endregion
        #region Properties
        /*public ObservableCollection<GameServiceReference.Game> Games { get; set; }
        public GameServiceReference.Game NewGame { get; set; }
        public GameServiceReference.Game SelectedGame { get; set; }*/
        #endregion

        #region Constructors
        public LobbyViewModel(int userId)
        {
            _userId = userId;
            Init();
        }
        #endregion

        #region Commands

        #region RefreshCommand
        private RelayCommand _refreshCommand;

        public ICommand RefreshCommand => _refreshCommand ??
                                          (_refreshCommand = new RelayCommand(ExecuteRefreshCommand, CanExecuteRefreshCommand));

        public async void ExecuteRefreshCommand(object param)
        {
            /*
            var data = await ServiceProxy.GetAvaivableGames();
            Games = new ObservableCollection<GameServiceReference.Game>(data);*/
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
            /*GameServiceReference.Game game = null;
            await Task.Run(() =>
            {
                game = ServiceProxy.Connect(SelectedGame.Id, _userId);
            });
            if (game != null)
            {
                var gameViewModel = new GameViewModel(game, _userId);
            }*/
        }

        private bool CanExecuteConnectCommand(object param)
        {
            return true;
            //return SelectedGame != null;
        }

        #endregion

        #region CreateGameCommand

        private RelayCommand _createGameCommand;
        public ICommand CreateGameCommand => _createGameCommand ?? 
                                             (_createGameCommand = new RelayCommand(ExecuteCreateGameCommand, CanExecuteCreateGameCommand));

        private async void ExecuteCreateGameCommand(object param)
        {
            /*
            NewGame = new GameServiceReference.Game();
            _dialogWindow = new CreateGame { DataContext = this };
            if (_dialogWindow.ShowDialog() == true)
            {
                GameServiceReference.Game game = null;
                await Task.Run(() =>
                {
                    game = ServiceProxy.CreateGame(NewGame.Description, NewGame.PlayersCount, _userId);
                });
                if (game != null)
                {
                    var gameViewModel = new GameViewModel(game, _userId);
                }
            }
            ExecuteRefreshCommand(param);*/
        }

        private bool CanExecuteCreateGameCommand(object param)
        {
            return true;
        }

        #endregion

        #region SaveDialogCommand

        private RelayCommand _saveDialogCommand;
        public ICommand SaveDialogCommand => _saveDialogCommand ?? 
                                            (_saveDialogCommand = new RelayCommand(ExecuteSaveDialogCommand, CanExecuteSaveDialogCommand));

        private void ExecuteSaveDialogCommand(object param)
        {
            if (_dialogWindow != null)
            {
                _dialogWindow.DialogResult = true;
                _dialogWindow.Close();
            }
        }

        private bool CanExecuteSaveDialogCommand(object param)
        {
            return true;
        }
        #endregion

        #endregion

        #region Members

        private void Init()
        {
            ExecuteRefreshCommand(null);
        }
        #endregion
    }
}
