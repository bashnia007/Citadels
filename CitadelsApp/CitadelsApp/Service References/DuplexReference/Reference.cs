﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CitadelsApp.DuplexReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DuplexReference.IDuplexService", CallbackContract=typeof(CitadelsApp.DuplexReference.IDuplexServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IDuplexService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/SendMessage")]
        void SendMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/StartGame")]
        void StartGame();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/StartGame")]
        System.Threading.Tasks.Task StartGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/ConnectGame")]
        void ConnectGame(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/ConnectGame")]
        System.Threading.Tasks.Task ConnectGameAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/CreateGame")]
        void CreateGame(string login);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/CreateGame")]
        System.Threading.Tasks.Task CreateGameAsync(string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/RecieveMessage")]
        void RecieveMessage(string user, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/StartClientGame")]
        void StartClientGame();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexServiceChannel : CitadelsApp.DuplexReference.IDuplexService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DuplexServiceClient : System.ServiceModel.DuplexClientBase<CitadelsApp.DuplexReference.IDuplexService>, CitadelsApp.DuplexReference.IDuplexService {
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SendMessage(string message) {
            base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string message) {
            return base.Channel.SendMessageAsync(message);
        }
        
        public void StartGame() {
            base.Channel.StartGame();
        }
        
        public System.Threading.Tasks.Task StartGameAsync() {
            return base.Channel.StartGameAsync();
        }
        
        public void ConnectGame(string login) {
            base.Channel.ConnectGame(login);
        }
        
        public System.Threading.Tasks.Task ConnectGameAsync(string login) {
            return base.Channel.ConnectGameAsync(login);
        }
        
        public void CreateGame(string login) {
            base.Channel.CreateGame(login);
        }
        
        public System.Threading.Tasks.Task CreateGameAsync(string login) {
            return base.Channel.CreateGameAsync(login);
        }
    }
}
