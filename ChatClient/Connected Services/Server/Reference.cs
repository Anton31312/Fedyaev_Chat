﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Server {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatUser", Namespace="http://schemas.datacontract.org/2004/07/ChatLib")]
    [System.SerializableAttribute()]
    public partial class ChatUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsMessageExistField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastMessageDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMessageExist {
            get {
                return this.IsMessageExistField;
            }
            set {
                if ((this.IsMessageExistField.Equals(value) != true)) {
                    this.IsMessageExistField = value;
                    this.RaisePropertyChanged("IsMessageExist");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastMessageDate {
            get {
                return this.LastMessageDateField;
            }
            set {
                if ((this.LastMessageDateField.Equals(value) != true)) {
                    this.LastMessageDateField = value;
                    this.RaisePropertyChanged("LastMessageDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/ChatLib")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReceiverIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SendDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SenderIDField;
        
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
        public bool IsSender {
            get {
                return this.IsSenderField;
            }
            set {
                if ((this.IsSenderField.Equals(value) != true)) {
                    this.IsSenderField = value;
                    this.RaisePropertyChanged("IsSender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageContent {
            get {
                return this.MessageContentField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageContentField, value) != true)) {
                    this.MessageContentField = value;
                    this.RaisePropertyChanged("MessageContent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReceiverID {
            get {
                return this.ReceiverIDField;
            }
            set {
                if ((this.ReceiverIDField.Equals(value) != true)) {
                    this.ReceiverIDField = value;
                    this.RaisePropertyChanged("ReceiverID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SendDate {
            get {
                return this.SendDateField;
            }
            set {
                if ((this.SendDateField.Equals(value) != true)) {
                    this.SendDateField = value;
                    this.RaisePropertyChanged("SendDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SenderID {
            get {
                return this.SenderIDField;
            }
            set {
                if ((this.SenderIDField.Equals(value) != true)) {
                    this.SenderIDField = value;
                    this.RaisePropertyChanged("SenderID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Server.IMessageContract", CallbackContract=typeof(Client.Server.IMessageContractCallback))]
    public interface IMessageContract {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/Connect")]
        void Connect(Client.Server.ChatUser User, string Password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/Connect")]
        System.Threading.Tasks.Task ConnectAsync(Client.Server.ChatUser User, string Password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/Disconnect")]
        void Disconnect(Client.Server.ChatUser User);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/Disconnect")]
        System.Threading.Tasks.Task DisconnectAsync(Client.Server.ChatUser User);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/Message")]
        void Message(Client.Server.Message Msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/Message")]
        System.Threading.Tasks.Task MessageAsync(Client.Server.Message Msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageContract/GetMessages", ReplyAction="http://tempuri.org/IMessageContract/GetMessagesResponse")]
        Client.Server.Message[] GetMessages(int SenderID, int ReceiverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageContract/GetMessages", ReplyAction="http://tempuri.org/IMessageContract/GetMessagesResponse")]
        System.Threading.Tasks.Task<Client.Server.Message[]> GetMessagesAsync(int SenderID, int ReceiverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageContract/RequestConnected", ReplyAction="http://tempuri.org/IMessageContract/RequestConnectedResponse")]
        Client.Server.ChatUser[] RequestConnected();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageContract/RequestConnected", ReplyAction="http://tempuri.org/IMessageContract/RequestConnectedResponse")]
        System.Threading.Tasks.Task<Client.Server.ChatUser[]> RequestConnectedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageContract/GetLastMessage", ReplyAction="http://tempuri.org/IMessageContract/GetLastMessageResponse")]
        System.DateTime GetLastMessage(int SenderID, int ReceiverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageContract/GetLastMessage", ReplyAction="http://tempuri.org/IMessageContract/GetLastMessageResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetLastMessageAsync(int SenderID, int ReceiverID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageContractCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/GetMessage")]
        void GetMessage(Client.Server.Message Msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageContract/UpdateConnected")]
        void UpdateConnected(Client.Server.ChatUser[] Users);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageContractChannel : Client.Server.IMessageContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageContractClient : System.ServiceModel.DuplexClientBase<Client.Server.IMessageContract>, Client.Server.IMessageContract {
        
        public MessageContractClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MessageContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MessageContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageContractClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Connect(Client.Server.ChatUser User, string Password) {
            base.Channel.Connect(User, Password);
        }
        
        public System.Threading.Tasks.Task ConnectAsync(Client.Server.ChatUser User, string Password) {
            return base.Channel.ConnectAsync(User, Password);
        }
        
        public void Disconnect(Client.Server.ChatUser User) {
            base.Channel.Disconnect(User);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(Client.Server.ChatUser User) {
            return base.Channel.DisconnectAsync(User);
        }
        
        public void Message(Client.Server.Message Msg) {
            base.Channel.Message(Msg);
        }
        
        public System.Threading.Tasks.Task MessageAsync(Client.Server.Message Msg) {
            return base.Channel.MessageAsync(Msg);
        }
        
        public Client.Server.Message[] GetMessages(int SenderID, int ReceiverID) {
            return base.Channel.GetMessages(SenderID, ReceiverID);
        }
        
        public System.Threading.Tasks.Task<Client.Server.Message[]> GetMessagesAsync(int SenderID, int ReceiverID) {
            return base.Channel.GetMessagesAsync(SenderID, ReceiverID);
        }
        
        public Client.Server.ChatUser[] RequestConnected() {
            return base.Channel.RequestConnected();
        }
        
        public System.Threading.Tasks.Task<Client.Server.ChatUser[]> RequestConnectedAsync() {
            return base.Channel.RequestConnectedAsync();
        }
        
        public System.DateTime GetLastMessage(int SenderID, int ReceiverID) {
            return base.Channel.GetLastMessage(SenderID, ReceiverID);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetLastMessageAsync(int SenderID, int ReceiverID) {
            return base.Channel.GetLastMessageAsync(SenderID, ReceiverID);
        }
    }
}