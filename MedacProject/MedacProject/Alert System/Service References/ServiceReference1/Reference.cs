﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alert_System.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientDC", Namespace="http://schemas.datacontract.org/2004/07/WCFMedacService")]
    [System.SerializableAttribute()]
    public partial class PatientDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AllergiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Birthdate1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cc_biField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Lastname1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OthercontactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PatientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SnsField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Allergies {
            get {
                return this.AllergiesField;
            }
            set {
                if ((object.ReferenceEquals(this.AllergiesField, value) != true)) {
                    this.AllergiesField = value;
                    this.RaisePropertyChanged("Allergies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Birthdate")]
        public System.DateTime Birthdate1 {
            get {
                return this.Birthdate1Field;
            }
            set {
                if ((this.Birthdate1Field.Equals(value) != true)) {
                    this.Birthdate1Field = value;
                    this.RaisePropertyChanged("Birthdate1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cc_bi {
            get {
                return this.Cc_biField;
            }
            set {
                if ((this.Cc_biField.Equals(value) != true)) {
                    this.Cc_biField = value;
                    this.RaisePropertyChanged("Cc_bi");
                }
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
        public char Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Lastname")]
        public string Lastname1 {
            get {
                return this.Lastname1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Lastname1Field, value) != true)) {
                    this.Lastname1Field = value;
                    this.RaisePropertyChanged("Lastname1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Othercontact {
            get {
                return this.OthercontactField;
            }
            set {
                if ((this.OthercontactField.Equals(value) != true)) {
                    this.OthercontactField = value;
                    this.RaisePropertyChanged("Othercontact");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sns {
            get {
                return this.SnsField;
            }
            set {
                if ((this.SnsField.Equals(value) != true)) {
                    this.SnsField = value;
                    this.RaisePropertyChanged("Sns");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/WCFMedacService")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AllergiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CC_BIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Alert_System.ServiceReference1.Measurement[] MeasurementField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SNSField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Allergies {
            get {
                return this.AllergiesField;
            }
            set {
                if ((object.ReferenceEquals(this.AllergiesField, value) != true)) {
                    this.AllergiesField = value;
                    this.RaisePropertyChanged("Allergies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CC_BI {
            get {
                return this.CC_BIField;
            }
            set {
                if ((this.CC_BIField.Equals(value) != true)) {
                    this.CC_BIField = value;
                    this.RaisePropertyChanged("CC_BI");
                }
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
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
        public Alert_System.ServiceReference1.Measurement[] Measurement {
            get {
                return this.MeasurementField;
            }
            set {
                if ((object.ReferenceEquals(this.MeasurementField, value) != true)) {
                    this.MeasurementField = value;
                    this.RaisePropertyChanged("Measurement");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherContact {
            get {
                return this.OtherContactField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherContactField, value) != true)) {
                    this.OtherContactField = value;
                    this.RaisePropertyChanged("OtherContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SNS {
            get {
                return this.SNSField;
            }
            set {
                if ((this.SNSField.Equals(value) != true)) {
                    this.SNSField = value;
                    this.RaisePropertyChanged("SNS");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Measurement", Namespace="http://schemas.datacontract.org/2004/07/WCFMedacService")]
    [System.SerializableAttribute()]
    public partial class Measurement : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> BloodPressureMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> BloodPressureMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> HeartRateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> OxygenSaturationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Alert_System.ServiceReference1.Patient PatientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan TimeField;
        
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
        public System.Nullable<int> BloodPressureMax {
            get {
                return this.BloodPressureMaxField;
            }
            set {
                if ((this.BloodPressureMaxField.Equals(value) != true)) {
                    this.BloodPressureMaxField = value;
                    this.RaisePropertyChanged("BloodPressureMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> BloodPressureMin {
            get {
                return this.BloodPressureMinField;
            }
            set {
                if ((this.BloodPressureMinField.Equals(value) != true)) {
                    this.BloodPressureMinField = value;
                    this.RaisePropertyChanged("BloodPressureMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> HeartRate {
            get {
                return this.HeartRateField;
            }
            set {
                if ((this.HeartRateField.Equals(value) != true)) {
                    this.HeartRateField = value;
                    this.RaisePropertyChanged("HeartRate");
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
        public System.Nullable<int> OxygenSaturation {
            get {
                return this.OxygenSaturationField;
            }
            set {
                if ((this.OxygenSaturationField.Equals(value) != true)) {
                    this.OxygenSaturationField = value;
                    this.RaisePropertyChanged("OxygenSaturation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Alert_System.ServiceReference1.Patient Patient {
            get {
                return this.PatientField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientField, value) != true)) {
                    this.PatientField = value;
                    this.RaisePropertyChanged("Patient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ValidadePatient", ReplyAction="http://tempuri.org/IService1/ValidadePatientResponse")]
        Alert_System.ServiceReference1.PatientDC ValidadePatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ValidadePatient", ReplyAction="http://tempuri.org/IService1/ValidadePatientResponse")]
        System.Threading.Tasks.Task<Alert_System.ServiceReference1.PatientDC> ValidadePatientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegisterPatient", ReplyAction="http://tempuri.org/IService1/RegisterPatientResponse")]
        bool RegisterPatient(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegisterPatient", ReplyAction="http://tempuri.org/IService1/RegisterPatientResponse")]
        System.Threading.Tasks.Task<bool> RegisterPatientAsync(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePatient", ReplyAction="http://tempuri.org/IService1/UpdatePatientResponse")]
        void UpdatePatient(Alert_System.ServiceReference1.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePatient", ReplyAction="http://tempuri.org/IService1/UpdatePatientResponse")]
        System.Threading.Tasks.Task UpdatePatientAsync(Alert_System.ServiceReference1.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegisterMeasurement", ReplyAction="http://tempuri.org/IService1/RegisterMeasurementResponse")]
        bool RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegisterMeasurement", ReplyAction="http://tempuri.org/IService1/RegisterMeasurementResponse")]
        System.Threading.Tasks.Task<bool> RegisterMeasurementAsync(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMax", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMaxResponse")]
        int[] ViewBloodPressureMax(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMax", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMaxResponse")]
        System.Threading.Tasks.Task<int[]> ViewBloodPressureMaxAsync(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMin", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMinResponse")]
        int[] ViewBloodPressureMin(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMin", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMinResponse")]
        System.Threading.Tasks.Task<int[]> ViewBloodPressureMinAsync(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMaxthreedays", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMaxthreedaysResponse")]
        int[] ViewBloodPressureMaxthreedays(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMaxthreedays", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMaxthreedaysResponse")]
        System.Threading.Tasks.Task<int[]> ViewBloodPressureMaxthreedaysAsync(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMinthreedays", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMinthreedaysResponse")]
        int[] ViewBloodPressureMinthreedays(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewBloodPressureMinthreedays", ReplyAction="http://tempuri.org/IService1/ViewBloodPressureMinthreedaysResponse")]
        System.Threading.Tasks.Task<int[]> ViewBloodPressureMinthreedaysAsync(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewHearRate", ReplyAction="http://tempuri.org/IService1/ViewHearRateResponse")]
        int[] ViewHearRate(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewHearRate", ReplyAction="http://tempuri.org/IService1/ViewHearRateResponse")]
        System.Threading.Tasks.Task<int[]> ViewHearRateAsync(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewHearRatethreedays", ReplyAction="http://tempuri.org/IService1/ViewHearRatethreedaysResponse")]
        int[] ViewHearRatethreedays(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewHearRatethreedays", ReplyAction="http://tempuri.org/IService1/ViewHearRatethreedaysResponse")]
        System.Threading.Tasks.Task<int[]> ViewHearRatethreedaysAsync(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewOxygenSaturation", ReplyAction="http://tempuri.org/IService1/ViewOxygenSaturationResponse")]
        int[] ViewOxygenSaturation(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewOxygenSaturation", ReplyAction="http://tempuri.org/IService1/ViewOxygenSaturationResponse")]
        System.Threading.Tasks.Task<int[]> ViewOxygenSaturationAsync(int fk_sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewOxygenSaturationthreedays", ReplyAction="http://tempuri.org/IService1/ViewOxygenSaturationthreedaysResponse")]
        int[] ViewOxygenSaturationthreedays(int fk_sns, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ViewOxygenSaturationthreedays", ReplyAction="http://tempuri.org/IService1/ViewOxygenSaturationthreedaysResponse")]
        System.Threading.Tasks.Task<int[]> ViewOxygenSaturationthreedaysAsync(int fk_sns, System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Alert_System.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Alert_System.ServiceReference1.IService1>, Alert_System.ServiceReference1.IService1 {
        
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
        
        public Alert_System.ServiceReference1.PatientDC ValidadePatient(int id) {
            return base.Channel.ValidadePatient(id);
        }
        
        public System.Threading.Tasks.Task<Alert_System.ServiceReference1.PatientDC> ValidadePatientAsync(int id) {
            return base.Channel.ValidadePatientAsync(id);
        }
        
        public bool RegisterPatient(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact) {
            return base.Channel.RegisterPatient(firstname, lastname, phone, email, birthdate, cc_bi, sns, address, gender, allergies, height, othercontact);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterPatientAsync(string firstname, string lastname, int phone, string email, System.DateTime birthdate, int cc_bi, int sns, string address, char gender, string allergies, double height, int othercontact) {
            return base.Channel.RegisterPatientAsync(firstname, lastname, phone, email, birthdate, cc_bi, sns, address, gender, allergies, height, othercontact);
        }
        
        public void UpdatePatient(Alert_System.ServiceReference1.Patient patient) {
            base.Channel.UpdatePatient(patient);
        }
        
        public System.Threading.Tasks.Task UpdatePatientAsync(Alert_System.ServiceReference1.Patient patient) {
            return base.Channel.UpdatePatientAsync(patient);
        }
        
        public bool RegisterMeasurement(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns) {
            return base.Channel.RegisterMeasurement(bloodpressuremin, bloodpressuremax, hearrate, oxygensaturation, date, time, fk_sns);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterMeasurementAsync(int bloodpressuremin, int bloodpressuremax, int hearrate, int oxygensaturation, System.DateTime date, System.TimeSpan time, int fk_sns) {
            return base.Channel.RegisterMeasurementAsync(bloodpressuremin, bloodpressuremax, hearrate, oxygensaturation, date, time, fk_sns);
        }
        
        public int[] ViewBloodPressureMax(int fk_sns) {
            return base.Channel.ViewBloodPressureMax(fk_sns);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewBloodPressureMaxAsync(int fk_sns) {
            return base.Channel.ViewBloodPressureMaxAsync(fk_sns);
        }
        
        public int[] ViewBloodPressureMin(int fk_sns) {
            return base.Channel.ViewBloodPressureMin(fk_sns);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewBloodPressureMinAsync(int fk_sns) {
            return base.Channel.ViewBloodPressureMinAsync(fk_sns);
        }
        
        public int[] ViewBloodPressureMaxthreedays(int fk_sns, System.DateTime date) {
            return base.Channel.ViewBloodPressureMaxthreedays(fk_sns, date);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewBloodPressureMaxthreedaysAsync(int fk_sns, System.DateTime date) {
            return base.Channel.ViewBloodPressureMaxthreedaysAsync(fk_sns, date);
        }
        
        public int[] ViewBloodPressureMinthreedays(int fk_sns, System.DateTime date) {
            return base.Channel.ViewBloodPressureMinthreedays(fk_sns, date);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewBloodPressureMinthreedaysAsync(int fk_sns, System.DateTime date) {
            return base.Channel.ViewBloodPressureMinthreedaysAsync(fk_sns, date);
        }
        
        public int[] ViewHearRate(int fk_sns) {
            return base.Channel.ViewHearRate(fk_sns);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewHearRateAsync(int fk_sns) {
            return base.Channel.ViewHearRateAsync(fk_sns);
        }
        
        public int[] ViewHearRatethreedays(int fk_sns, System.DateTime date) {
            return base.Channel.ViewHearRatethreedays(fk_sns, date);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewHearRatethreedaysAsync(int fk_sns, System.DateTime date) {
            return base.Channel.ViewHearRatethreedaysAsync(fk_sns, date);
        }
        
        public int[] ViewOxygenSaturation(int fk_sns) {
            return base.Channel.ViewOxygenSaturation(fk_sns);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewOxygenSaturationAsync(int fk_sns) {
            return base.Channel.ViewOxygenSaturationAsync(fk_sns);
        }
        
        public int[] ViewOxygenSaturationthreedays(int fk_sns, System.DateTime date) {
            return base.Channel.ViewOxygenSaturationthreedays(fk_sns, date);
        }
        
        public System.Threading.Tasks.Task<int[]> ViewOxygenSaturationthreedaysAsync(int fk_sns, System.DateTime date) {
            return base.Channel.ViewOxygenSaturationthreedaysAsync(fk_sns, date);
        }
    }
}
