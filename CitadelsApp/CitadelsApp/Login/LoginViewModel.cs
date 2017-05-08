using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CitadelsApp.DAL;
using CitadelsApp.KindOfMagic;

namespace CitadelsApp.Login
{
    public class LoginViewModel : PropertyChangedBase
    {
        #region Properties
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Window View { get; set; }
        public Regex EmailRegex { get; set; }
        #endregion

        #region Constructors

        public LoginViewModel()
        {
        }
        #endregion

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
                View.Close();
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

        #region Members
        
        #endregion
    }
}
