using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CitadelsApp.Game.Views;
using CitadelsApp.KindOfMagic;

namespace CitadelsApp.Game.ViewModels
{
    public class GameViewModel : PropertyChangedBase
    {
        #region Privates

        //private GameServiceReference.Game _game;
        private int _userId;
        #endregion
        #region Properies
        public Window Window { get; set; }
        public object BottomMenu { get; set; }
        #endregion

        #region Constructors
        /*public GameViewModel(GameServiceReference.Game game, int userId)
        {
            _game = game;
            _userId = userId;
            Init();
        }*/
        #endregion

        #region Commands

        private RelayCommand _sendMessage;

        public ICommand SendMessage
            => _sendMessage ?? (_sendMessage = new RelayCommand(ExecuteSendMessage, CanExecuteSendMessage));

        private void ExecuteSendMessage(object param)
        {
            
        }

        private bool CanExecuteSendMessage(object param)
        {
            return true;
        }
        #endregion

        #region Members

        private void Init()
        {
            Window =  new GameUI {DataContext = this};
            BottomMenu = new BottomMenu {DataContext = this};
            Window.Show();
        }
        #endregion
    }
}
