﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_CarInsurance_client.WCF_CarInsurance {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HistoryOfAccidents", Namespace="http://schemas.datacontract.org/2004/07/WCF_generowanie")]
    [System.SerializableAttribute()]
    public partial class HistoryOfAccidents : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionOfTheDamageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PenaltyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonalIdentityNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VinField;
        
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
        public string CarName {
            get {
                return this.CarNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CarNameField, value) != true)) {
                    this.CarNameField = value;
                    this.RaisePropertyChanged("CarName");
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
        public string DescriptionOfTheDamage {
            get {
                return this.DescriptionOfTheDamageField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionOfTheDamageField, value) != true)) {
                    this.DescriptionOfTheDamageField = value;
                    this.RaisePropertyChanged("DescriptionOfTheDamage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Info {
            get {
                return this.InfoField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoField, value) != true)) {
                    this.InfoField = value;
                    this.RaisePropertyChanged("Info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Penalty {
            get {
                return this.PenaltyField;
            }
            set {
                if ((this.PenaltyField.Equals(value) != true)) {
                    this.PenaltyField = value;
                    this.RaisePropertyChanged("Penalty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonalIdentityNumber {
            get {
                return this.PersonalIdentityNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalIdentityNumberField, value) != true)) {
                    this.PersonalIdentityNumberField = value;
                    this.RaisePropertyChanged("PersonalIdentityNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vin {
            get {
                return this.VinField;
            }
            set {
                if ((object.ReferenceEquals(this.VinField, value) != true)) {
                    this.VinField = value;
                    this.RaisePropertyChanged("Vin");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BasicInformation", Namespace="http://schemas.datacontract.org/2004/07/WCF_generowanie")]
    [System.SerializableAttribute()]
    public partial class BasicInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DiscountsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Identity_card_numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Name_surnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Personal_identity_numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Phone_numberField;
        
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
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Discounts {
            get {
                return this.DiscountsField;
            }
            set {
                if ((this.DiscountsField.Equals(value) != true)) {
                    this.DiscountsField = value;
                    this.RaisePropertyChanged("Discounts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identity_card_number {
            get {
                return this.Identity_card_numberField;
            }
            set {
                if ((object.ReferenceEquals(this.Identity_card_numberField, value) != true)) {
                    this.Identity_card_numberField = value;
                    this.RaisePropertyChanged("Identity_card_number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Info {
            get {
                return this.InfoField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoField, value) != true)) {
                    this.InfoField = value;
                    this.RaisePropertyChanged("Info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name_surname {
            get {
                return this.Name_surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.Name_surnameField, value) != true)) {
                    this.Name_surnameField = value;
                    this.RaisePropertyChanged("Name_surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Personal_identity_number {
            get {
                return this.Personal_identity_numberField;
            }
            set {
                if ((object.ReferenceEquals(this.Personal_identity_numberField, value) != true)) {
                    this.Personal_identity_numberField = value;
                    this.RaisePropertyChanged("Personal_identity_number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone_number {
            get {
                return this.Phone_numberField;
            }
            set {
                if ((object.ReferenceEquals(this.Phone_numberField, value) != true)) {
                    this.Phone_numberField = value;
                    this.RaisePropertyChanged("Phone_number");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PurchaseHistory", Namespace="http://schemas.datacontract.org/2004/07/WCF_generowanie")]
    [System.SerializableAttribute()]
    public partial class PurchaseHistory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BegindateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptioncarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionpackageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EnddateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameinsurerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Personal_identity_numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SavedateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VinField;
        
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
        public bool Active {
            get {
                return this.ActiveField;
            }
            set {
                if ((this.ActiveField.Equals(value) != true)) {
                    this.ActiveField = value;
                    this.RaisePropertyChanged("Active");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Begindate {
            get {
                return this.BegindateField;
            }
            set {
                if ((this.BegindateField.Equals(value) != true)) {
                    this.BegindateField = value;
                    this.RaisePropertyChanged("Begindate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descriptioncar {
            get {
                return this.DescriptioncarField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptioncarField, value) != true)) {
                    this.DescriptioncarField = value;
                    this.RaisePropertyChanged("Descriptioncar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descriptionpackage {
            get {
                return this.DescriptionpackageField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionpackageField, value) != true)) {
                    this.DescriptionpackageField = value;
                    this.RaisePropertyChanged("Descriptionpackage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Enddate {
            get {
                return this.EnddateField;
            }
            set {
                if ((this.EnddateField.Equals(value) != true)) {
                    this.EnddateField = value;
                    this.RaisePropertyChanged("Enddate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Info {
            get {
                return this.InfoField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoField, value) != true)) {
                    this.InfoField = value;
                    this.RaisePropertyChanged("Info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nameinsurer {
            get {
                return this.NameinsurerField;
            }
            set {
                if ((object.ReferenceEquals(this.NameinsurerField, value) != true)) {
                    this.NameinsurerField = value;
                    this.RaisePropertyChanged("Nameinsurer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Personal_identity_number {
            get {
                return this.Personal_identity_numberField;
            }
            set {
                if ((object.ReferenceEquals(this.Personal_identity_numberField, value) != true)) {
                    this.Personal_identity_numberField = value;
                    this.RaisePropertyChanged("Personal_identity_number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Savedate {
            get {
                return this.SavedateField;
            }
            set {
                if ((this.SavedateField.Equals(value) != true)) {
                    this.SavedateField = value;
                    this.RaisePropertyChanged("Savedate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vin {
            get {
                return this.VinField;
            }
            set {
                if ((object.ReferenceEquals(this.VinField, value) != true)) {
                    this.VinField = value;
                    this.RaisePropertyChanged("Vin");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF_CarInsurance.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveAccidents", ReplyAction="http://tempuri.org/IService1/SaveAccidentsResponse")]
        WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents SaveAccidents(WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents AllInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveAccidents", ReplyAction="http://tempuri.org/IService1/SaveAccidentsResponse")]
        System.Threading.Tasks.Task<WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents> SaveAccidentsAsync(WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents AllInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveBasicInformation", ReplyAction="http://tempuri.org/IService1/SaveBasicInformationResponse")]
        WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation SaveBasicInformation(WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation AllInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveBasicInformation", ReplyAction="http://tempuri.org/IService1/SaveBasicInformationResponse")]
        System.Threading.Tasks.Task<WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation> SaveBasicInformationAsync(WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation AllInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SavePurchaseHistory", ReplyAction="http://tempuri.org/IService1/SavePurchaseHistoryResponse")]
        WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory SavePurchaseHistory(WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory AllInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SavePurchaseHistory", ReplyAction="http://tempuri.org/IService1/SavePurchaseHistoryResponse")]
        System.Threading.Tasks.Task<WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory> SavePurchaseHistoryAsync(WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory AllInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadBasicInformation", ReplyAction="http://tempuri.org/IService1/ReadBasicInformationResponse")]
        System.Data.DataSet ReadBasicInformation(string personal_identity_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadBasicInformation", ReplyAction="http://tempuri.org/IService1/ReadBasicInformationResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ReadBasicInformationAsync(string personal_identity_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadPurchaseHistory", ReplyAction="http://tempuri.org/IService1/ReadPurchaseHistoryResponse")]
        System.Data.DataSet ReadPurchaseHistory(string personal_identity_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadPurchaseHistory", ReplyAction="http://tempuri.org/IService1/ReadPurchaseHistoryResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ReadPurchaseHistoryAsync(string personal_identity_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadHistoryOfAccidents", ReplyAction="http://tempuri.org/IService1/ReadHistoryOfAccidentsResponse")]
        System.Data.DataSet ReadHistoryOfAccidents(string personal_identity_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadHistoryOfAccidents", ReplyAction="http://tempuri.org/IService1/ReadHistoryOfAccidentsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ReadHistoryOfAccidentsAsync(string personal_identity_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBasicInformation", ReplyAction="http://tempuri.org/IService1/UpdateBasicInformationResponse")]
        string UpdateBasicInformation(int ID, string personal_identity_number, string identity_card_number, string address, string name_surname, float discounts, string phone_number, System.DateTime birthday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBasicInformation", ReplyAction="http://tempuri.org/IService1/UpdateBasicInformationResponse")]
        System.Threading.Tasks.Task<string> UpdateBasicInformationAsync(int ID, string personal_identity_number, string identity_card_number, string address, string name_surname, float discounts, string phone_number, System.DateTime birthday);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCF_CarInsurance_client.WCF_CarInsurance.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCF_CarInsurance_client.WCF_CarInsurance.IService1>, WCF_CarInsurance_client.WCF_CarInsurance.IService1 {
        
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
        
        public WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents SaveAccidents(WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents AllInfo) {
            return base.Channel.SaveAccidents(AllInfo);
        }
        
        public System.Threading.Tasks.Task<WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents> SaveAccidentsAsync(WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents AllInfo) {
            return base.Channel.SaveAccidentsAsync(AllInfo);
        }
        
        public WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation SaveBasicInformation(WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation AllInfo) {
            return base.Channel.SaveBasicInformation(AllInfo);
        }
        
        public System.Threading.Tasks.Task<WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation> SaveBasicInformationAsync(WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation AllInfo) {
            return base.Channel.SaveBasicInformationAsync(AllInfo);
        }
        
        public WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory SavePurchaseHistory(WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory AllInfo) {
            return base.Channel.SavePurchaseHistory(AllInfo);
        }
        
        public System.Threading.Tasks.Task<WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory> SavePurchaseHistoryAsync(WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory AllInfo) {
            return base.Channel.SavePurchaseHistoryAsync(AllInfo);
        }
        
        public System.Data.DataSet ReadBasicInformation(string personal_identity_number) {
            return base.Channel.ReadBasicInformation(personal_identity_number);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ReadBasicInformationAsync(string personal_identity_number) {
            return base.Channel.ReadBasicInformationAsync(personal_identity_number);
        }
        
        public System.Data.DataSet ReadPurchaseHistory(string personal_identity_number) {
            return base.Channel.ReadPurchaseHistory(personal_identity_number);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ReadPurchaseHistoryAsync(string personal_identity_number) {
            return base.Channel.ReadPurchaseHistoryAsync(personal_identity_number);
        }
        
        public System.Data.DataSet ReadHistoryOfAccidents(string personal_identity_number) {
            return base.Channel.ReadHistoryOfAccidents(personal_identity_number);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ReadHistoryOfAccidentsAsync(string personal_identity_number) {
            return base.Channel.ReadHistoryOfAccidentsAsync(personal_identity_number);
        }
        
        public string UpdateBasicInformation(int ID, string personal_identity_number, string identity_card_number, string address, string name_surname, float discounts, string phone_number, System.DateTime birthday) {
            return base.Channel.UpdateBasicInformation(ID, personal_identity_number, identity_card_number, address, name_surname, discounts, phone_number, birthday);
        }
        
        public System.Threading.Tasks.Task<string> UpdateBasicInformationAsync(int ID, string personal_identity_number, string identity_card_number, string address, string name_surname, float discounts, string phone_number, System.DateTime birthday) {
            return base.Channel.UpdateBasicInformationAsync(ID, personal_identity_number, identity_card_number, address, name_surname, discounts, phone_number, birthday);
        }
    }
}
