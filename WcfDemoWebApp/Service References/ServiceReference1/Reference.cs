﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemoWebApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int isbnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string publisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public string author {
            get {
                return this.authorField;
            }
            set {
                if ((object.ReferenceEquals(this.authorField, value) != true)) {
                    this.authorField = value;
                    this.RaisePropertyChanged("author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int isbn {
            get {
                return this.isbnField;
            }
            set {
                if ((this.isbnField.Equals(value) != true)) {
                    this.isbnField = value;
                    this.RaisePropertyChanged("isbn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pages {
            get {
                return this.pagesField;
            }
            set {
                if ((this.pagesField.Equals(value) != true)) {
                    this.pagesField = value;
                    this.RaisePropertyChanged("pages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string publisher {
            get {
                return this.publisherField;
            }
            set {
                if ((object.ReferenceEquals(this.publisherField, value) != true)) {
                    this.publisherField = value;
                    this.RaisePropertyChanged("publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
    [System.SerializableAttribute()]
    public partial class ExceptionMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorMessageOfActionField;
        
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
        public string errorMessageOfAction {
            get {
                return this.errorMessageOfActionField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageOfActionField, value) != true)) {
                    this.errorMessageOfActionField = value;
                    this.RaisePropertyChanged("errorMessageOfAction");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfDemoWebApp.ServiceReference1.ExceptionMessage), Action="http://tempuri.org/IService1/GetBooksExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
        WcfDemoWebApp.ServiceReference1.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        System.Threading.Tasks.Task<WcfDemoWebApp.ServiceReference1.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertBook", ReplyAction="http://tempuri.org/IService1/InsertBookResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfDemoWebApp.ServiceReference1.ExceptionMessage), Action="http://tempuri.org/IService1/InsertBookExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
        void InsertBook(WcfDemoWebApp.ServiceReference1.Book newBook);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertBook", ReplyAction="http://tempuri.org/IService1/InsertBookResponse")]
        System.Threading.Tasks.Task InsertBookAsync(WcfDemoWebApp.ServiceReference1.Book newBook);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfDemoWebApp.ServiceReference1.ExceptionMessage), Action="http://tempuri.org/IService1/DeleteBookExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
        void DeleteBook(int StudentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        System.Threading.Tasks.Task DeleteBookAsync(int StudentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfDemoWebApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfDemoWebApp.ServiceReference1.IService1>, WcfDemoWebApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfDemoWebApp.ServiceReference1.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<WcfDemoWebApp.ServiceReference1.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public void InsertBook(WcfDemoWebApp.ServiceReference1.Book newBook) {
            base.Channel.InsertBook(newBook);
        }
        
        public System.Threading.Tasks.Task InsertBookAsync(WcfDemoWebApp.ServiceReference1.Book newBook) {
            return base.Channel.InsertBookAsync(newBook);
        }
        
        public void DeleteBook(int StudentId) {
            base.Channel.DeleteBook(StudentId);
        }
        
        public System.Threading.Tasks.Task DeleteBookAsync(int StudentId) {
            return base.Channel.DeleteBookAsync(StudentId);
        }
    }
}
