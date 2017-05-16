﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CitadelsApp.GameServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Service.Database")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/Service.Database")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CreatorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAvaivableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CitadelsApp.GameServiceReference.User[] PlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PlayersCountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CreatorId {
            get {
                return this.CreatorIdField;
            }
            set {
                if ((this.CreatorIdField.Equals(value) != true)) {
                    this.CreatorIdField = value;
                    this.RaisePropertyChanged("CreatorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAvaivable {
            get {
                return this.IsAvaivableField;
            }
            set {
                if ((this.IsAvaivableField.Equals(value) != true)) {
                    this.IsAvaivableField = value;
                    this.RaisePropertyChanged("IsAvaivable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CitadelsApp.GameServiceReference.User[] Players {
            get {
                return this.PlayersField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayersField, value) != true)) {
                    this.PlayersField = value;
                    this.RaisePropertyChanged("Players");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PlayersCount {
            get {
                return this.PlayersCountField;
            }
            set {
                if ((this.PlayersCountField.Equals(value) != true)) {
                    this.PlayersCountField = value;
                    this.RaisePropertyChanged("PlayersCount");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameServiceReference.IGameService")]
    public interface IGameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Login", ReplyAction="http://tempuri.org/IGameService/LoginResponse")]
        CitadelsApp.GameServiceReference.User Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Login", ReplyAction="http://tempuri.org/IGameService/LoginResponse")]
        System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.User> LoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Register", ReplyAction="http://tempuri.org/IGameService/RegisterResponse")]
        CitadelsApp.GameServiceReference.User Register(string login, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Register", ReplyAction="http://tempuri.org/IGameService/RegisterResponse")]
        System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.User> RegisterAsync(string login, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/CreateGame", ReplyAction="http://tempuri.org/IGameService/CreateGameResponse")]
        CitadelsApp.GameServiceReference.Game CreateGame(string gameTitle, int maxPlayers, int creatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/CreateGame", ReplyAction="http://tempuri.org/IGameService/CreateGameResponse")]
        System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.Game> CreateGameAsync(string gameTitle, int maxPlayers, int creatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetAvaivableGames", ReplyAction="http://tempuri.org/IGameService/GetAvaivableGamesResponse")]
        CitadelsApp.GameServiceReference.Game[] GetAvaivableGames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetAvaivableGames", ReplyAction="http://tempuri.org/IGameService/GetAvaivableGamesResponse")]
        System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.Game[]> GetAvaivableGamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/StartGame", ReplyAction="http://tempuri.org/IGameService/StartGameResponse")]
        CitadelsApp.GameServiceReference.Game StartGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/StartGame", ReplyAction="http://tempuri.org/IGameService/StartGameResponse")]
        System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.Game> StartGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/SelectRole", ReplyAction="http://tempuri.org/IGameService/SelectRoleResponse")]
        void SelectRole(int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/SelectRole", ReplyAction="http://tempuri.org/IGameService/SelectRoleResponse")]
        System.Threading.Tasks.Task SelectRoleAsync(int roleId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServiceChannel : CitadelsApp.GameServiceReference.IGameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameServiceClient : System.ServiceModel.ClientBase<CitadelsApp.GameServiceReference.IGameService>, CitadelsApp.GameServiceReference.IGameService {
        
        public GameServiceClient() {
        }
        
        public GameServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CitadelsApp.GameServiceReference.User Login(string login1, string password) {
            return base.Channel.Login(login1, password);
        }
        
        public System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.User> LoginAsync(string login, string password) {
            return base.Channel.LoginAsync(login, password);
        }
        
        public CitadelsApp.GameServiceReference.User Register(string login, string password, string email) {
            return base.Channel.Register(login, password, email);
        }
        
        public System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.User> RegisterAsync(string login, string password, string email) {
            return base.Channel.RegisterAsync(login, password, email);
        }
        
        public CitadelsApp.GameServiceReference.Game CreateGame(string gameTitle, int maxPlayers, int creatorId) {
            return base.Channel.CreateGame(gameTitle, maxPlayers, creatorId);
        }
        
        public System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.Game> CreateGameAsync(string gameTitle, int maxPlayers, int creatorId) {
            return base.Channel.CreateGameAsync(gameTitle, maxPlayers, creatorId);
        }
        
        public CitadelsApp.GameServiceReference.Game[] GetAvaivableGames() {
            return base.Channel.GetAvaivableGames();
        }
        
        public System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.Game[]> GetAvaivableGamesAsync() {
            return base.Channel.GetAvaivableGamesAsync();
        }
        
        public CitadelsApp.GameServiceReference.Game StartGame() {
            return base.Channel.StartGame();
        }
        
        public System.Threading.Tasks.Task<CitadelsApp.GameServiceReference.Game> StartGameAsync() {
            return base.Channel.StartGameAsync();
        }
        
        public void SelectRole(int roleId) {
            base.Channel.SelectRole(roleId);
        }
        
        public System.Threading.Tasks.Task SelectRoleAsync(int roleId) {
            return base.Channel.SelectRoleAsync(roleId);
        }
    }
}
