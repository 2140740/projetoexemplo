﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyHealth.ServiceMyHealth {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLayer")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PatientIDField;
        
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
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PatientID {
            get {
                return this.PatientIDField;
            }
            set {
                if ((this.PatientIDField.Equals(value) != true)) {
                    this.PatientIDField = value;
                    this.RaisePropertyChanged("PatientID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMyHealth.IServiceHealth")]
    public interface IServiceHealth {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/ValidadePatient", ReplyAction="http://tempuri.org/IServiceHealth/ValidadePatientResponse")]
        MyHealth.ServiceMyHealth.Patient ValidadePatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/ValidadePatient", ReplyAction="http://tempuri.org/IServiceHealth/ValidadePatientResponse")]
        System.Threading.Tasks.Task<MyHealth.ServiceMyHealth.Patient> ValidadePatientAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceHealthChannel : MyHealth.ServiceMyHealth.IServiceHealth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceHealthClient : System.ServiceModel.ClientBase<MyHealth.ServiceMyHealth.IServiceHealth>, MyHealth.ServiceMyHealth.IServiceHealth {
        
        public ServiceHealthClient() {
        }
        
        public ServiceHealthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceHealthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHealthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHealthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyHealth.ServiceMyHealth.Patient ValidadePatient(int id) {
            return base.Channel.ValidadePatient(id);
        }
        
        public System.Threading.Tasks.Task<MyHealth.ServiceMyHealth.Patient> ValidadePatientAsync(int id) {
            return base.Channel.ValidadePatientAsync(id);
        }
    }
}