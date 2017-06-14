using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using CitadelsApp.DAL;
using CitadelsApp.DuplexReference;
using CitadelsApp.KindOfMagic;
using CitadelsApp.Login;
using CitadelsApp.OneWayReference;
using User = CitadelsApp.OneWayReference.User;

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
        public Visibility IncorrectAuth { get; set; }
        public DuplexServiceClient DuplexService { get; set; }
        public GameServiceClient RequestService { get; set; }
        #endregion

        public MainViewModel()
        {
            InitChannel();
            _dialogWindow = new LoginWindow {DataContext = this};
            IncorrectAuth = Visibility.Collapsed;
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

        private async void ExecuteLoginCommand(object param)
        {
            var users = await Task.Run(() => RequestService.GetAllUsers().ToList());
            IncorrectAuth = Visibility.Collapsed;
            User user = null;
            await Task.Run(() =>
            {
                user = RequestService.Login(Login, Password);
            });
            if (user != null)
            {
                _dialogWindow.DialogResult = true;
                _dialogWindow.Close();
                var lobbyViewModel = new LobbyViewModel(user.Id);
                CurrentContent = new Lobby { DataContext = lobbyViewModel };
            }
            else
            {
                IncorrectAuth = Visibility.Visible;
            }
        }

        private bool CanExecuteLoginCommand(object param)
        {
            return !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password);
        }
        #endregion

        #endregion

        #region Members

        private void InitChannel()
        {
            InstanceContext context = new InstanceContext(new PlayerClient());
            DuplexService = new DuplexServiceClient(context);
            
            RequestService = new GameServiceClient();
        }
        #endregion
    }
}
