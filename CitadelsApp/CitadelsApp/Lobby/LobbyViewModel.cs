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
        public ObservableCollection<OneWayReference.Game> Games { get; set; }
        public OneWayReference.Game NewGame { get; set; }
        public OneWayReference.Game SelectedGame { get; set; }
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
            var data = await Task.Run(() => ServiceProxy.GetAvaivableGames().ToList());
            Games = new ObservableCollection<OneWayReference.Game>(data);
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
            /*var game = await Task.Run(() => ServiceProxy.ConnectGame(SelectedGame.Id, _userId));
            if (game != null)
            {
                var gameViewModel = new GameViewModel();
                gameViewModel.Init();
            }*/

            await Task.Run(() =>
            {
                DuplexProxy.ConnectGame(_userId);
            });
            var gameViewModel = new GameViewModel();
            gameViewModel.Init();
        }

        private bool CanExecuteConnectCommand(object param)
        {
            return SelectedGame != null;
        }

        #endregion

        #region CreateGameCommand

        private RelayCommand _createGameCommand;
        public ICommand CreateGameCommand => _createGameCommand ?? 
                                             (_createGameCommand = new RelayCommand(ExecuteCreateGameCommand, CanExecuteCreateGameCommand));

        private async void ExecuteCreateGameCommand(object param)
        {
            NewGame = new OneWayReference.Game();
            _dialogWindow = new CreateGame { DataContext = this };
            if (_dialogWindow.ShowDialog() == true)
            {
                /*OneWayReference.Game game = null;
                await Task.Run(() =>
                {
                    game = ServiceProxy.CreateGame(NewGame.Description, NewGame.PlayersCount, _userId);
                });
                if (game != null)
                {
                    var gameViewModel = new GameViewModel();
                    gameViewModel.Init();
                }*/
                await Task.Run(() =>
                 {
                     DuplexProxy.CreateGame(_userId);
                 });
                var gameViewModel = new GameViewModel();
                gameViewModel.Init();
            }
            ExecuteRefreshCommand(param);
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
