﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alert_Sytem.ServiceMyHealthAlert {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMyHealthAlert.IServiceHealth")]
    public interface IServiceHealth {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/ValidadePatient", ReplyAction="http://tempuri.org/IServiceHealth/ValidadePatientResponse")]
        MyHealth.ServiceMyHealth.Patient ValidadePatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/ValidadePatient", ReplyAction="http://tempuri.org/IServiceHealth/ValidadePatientResponse")]
        System.Threading.Tasks.Task<MyHealth.ServiceMyHealth.Patient> ValidadePatientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/RegisterPatient", ReplyAction="http://tempuri.org/IServiceHealth/RegisterPatientResponse")]
        void RegisterPatient(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/RegisterPatient", ReplyAction="http://tempuri.org/IServiceHealth/RegisterPatientResponse")]
        System.Threading.Tasks.Task RegisterPatientAsync(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/RegisterMeasurement", ReplyAction="http://tempuri.org/IServiceHealth/RegisterMeasurementResponse")]
        void RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHealth/RegisterMeasurement", ReplyAction="http://tempuri.org/IServiceHealth/RegisterMeasurementResponse")]
        System.Threading.Tasks.Task RegisterMeasurementAsync(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceHealthChannel : Alert_Sytem.ServiceMyHealthAlert.IServiceHealth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceHealthClient : System.ServiceModel.ClientBase<Alert_Sytem.ServiceMyHealthAlert.IServiceHealth>, Alert_Sytem.ServiceMyHealthAlert.IServiceHealth {
        
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
        
        public void RegisterPatient(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact) {
            base.Channel.RegisterPatient(firstname, lastname, phone, email, birthdate, cc_bi, sns, address, gender, allergies, height, othercontact);
        }
        
        public System.Threading.Tasks.Task RegisterPatientAsync(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact) {
            return base.Channel.RegisterPatientAsync(firstname, lastname, phone, email, birthdate, cc_bi, sns, address, gender, allergies, height, othercontact);
        }
        
        public void RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns) {
            base.Channel.RegisterMeasurement(bloodpressuremin, bloodpressuremax, hearrate, oxygensaturation, date, time, fk_sns);
        }
        
        public System.Threading.Tasks.Task RegisterMeasurementAsync(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns) {
            return base.Channel.RegisterMeasurementAsync(bloodpressuremin, bloodpressuremax, hearrate, oxygensaturation, date, time, fk_sns);
        }
    }
}
