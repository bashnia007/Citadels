using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CitadelsApp.DAL;
using CitadelsApp.KindOfMagic;
using CitadelsApp.Login;

namespace CitadelsApp
{
    public class MainViewModel : PropertyChangedBase
    {
        #region Privates

        private Window _dialogWindow;
        #endregion
        #region Properties
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public object CurrentContent { get; set; }
        #endregion

        public MainViewModel()
        {
            _dialogWindow = new LoginWindow {DataContext = this};
            if (_dialogWindow.ShowDialog() != true)
            {
                Application.Current.MainWindow.Close();
            }
        }


        #region Commands

        #region LoginCommand
        private RelayCommand _loginCommand;
        public ICommand LoginCommand => _loginCommand ??
                                        (_loginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand));

        private void ExecuteLoginCommand(object param)
        {
            var user = ServiceProxy.Login(Login, Password);
            if (user != null)
            {
                _dialogWindow.Close();
                var lobbyViewModel = new LobbyViewModel();
                CurrentContent = new Lobby { DataContext = lobbyViewModel };
            }
        }

        private bool CanExecuteLoginCommand(object param)
        {
            return true;
        }
        #endregion

        #region RegisterCommand

        private RelayCommand _registerCommand;
        public ICommand RegisterCommand => _registerCommand ??
                                           (_registerCommand = new RelayCommand(ExecuteRegisterCommand, CanExecuteRegisterCommand));

        private void ExecuteRegisterCommand(object param)
        {
            var user = ServiceProxy.Register(Login, Password, Email);
        }

        private bool CanExecuteRegisterCommand(object param)
        {
            return true;
        }

        #endregion

        #endregion
    }
}
