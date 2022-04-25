﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbPlc.WEBMVCUI.DbReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
    [System.SerializableAttribute()]
    public partial class ResponseError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DbReference.DbPlcWeb")]
    public interface DbPlcWeb {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllArea", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GetAllAreaResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GetAllArea();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllArea", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllAreaResponse")]
        System.Threading.Tasks.Task<string> GetAllAreaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllWorkCenterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GetAllWorkCenterResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GetAllWorkCenter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllWorkCenterResponse")]
        System.Threading.Tasks.Task<string> GetAllWorkCenterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllPlc", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllPlcResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GetAllPlcResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GetAllPlc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllPlc", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllPlcResponse")]
        System.Threading.Tasks.Task<string> GetAllPlcAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GelAllPlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/GelAllPlcTagResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GelAllPlcTagResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GelAllPlcTag();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GelAllPlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/GelAllPlcTagResponse")]
        System.Threading.Tasks.Task<string> GelAllPlcTagAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllWorkCenterDto", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllWorkCenterDtoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GetAllWorkCenterDtoResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GetAllWorkCenterDto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllWorkCenterDto", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllWorkCenterDtoResponse")]
        System.Threading.Tasks.Task<string> GetAllWorkCenterDtoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllPlcDto", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllPlcDtoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GetAllPlcDtoResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GetAllPlcDto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllPlcDto", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllPlcDtoResponse")]
        System.Threading.Tasks.Task<string> GetAllPlcDtoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllPlcTagDto", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllPlcTagDtoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/GetAllPlcTagDtoResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        string GetAllPlcTagDto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/GetAllPlcTagDto", ReplyAction="http://tempuri.org/DbPlcWeb/GetAllPlcTagDtoResponse")]
        System.Threading.Tasks.Task<string> GetAllPlcTagDtoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddArea", ReplyAction="http://tempuri.org/DbPlcWeb/AddAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/AddAreaResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool AddArea(DbPlc.EntityFramework.Entity.Area area);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddArea", ReplyAction="http://tempuri.org/DbPlcWeb/AddAreaResponse")]
        System.Threading.Tasks.Task<bool> AddAreaAsync(DbPlc.EntityFramework.Entity.Area area);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/AddWorkCenterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/AddWorkCenterResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool AddWorkCenter(DbPlc.EntityFramework.Entity.WorkCenter workCenter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/AddWorkCenterResponse")]
        System.Threading.Tasks.Task<bool> AddWorkCenterAsync(DbPlc.EntityFramework.Entity.WorkCenter workCenter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddPlc", ReplyAction="http://tempuri.org/DbPlcWeb/AddPlcResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/AddPlcResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool AddPlc(DbPlc.EntityFramework.Entity.Plc plc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddPlc", ReplyAction="http://tempuri.org/DbPlcWeb/AddPlcResponse")]
        System.Threading.Tasks.Task<bool> AddPlcAsync(DbPlc.EntityFramework.Entity.Plc plc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddPlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/AddPlcTagResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/AddPlcTagResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool AddPlcTag(DbPlc.EntityFramework.Entity.PlcTag plcTag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/AddPlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/AddPlcTagResponse")]
        System.Threading.Tasks.Task<bool> AddPlcTagAsync(DbPlc.EntityFramework.Entity.PlcTag plcTag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeleteArea", ReplyAction="http://tempuri.org/DbPlcWeb/DeleteAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/DeleteAreaResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool DeleteArea(DbPlc.EntityFramework.Entity.Area area);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeleteArea", ReplyAction="http://tempuri.org/DbPlcWeb/DeleteAreaResponse")]
        System.Threading.Tasks.Task<bool> DeleteAreaAsync(DbPlc.EntityFramework.Entity.Area area);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeleteWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/DeleteWorkCenterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/DeleteWorkCenterResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool DeleteWorkCenter(DbPlc.EntityFramework.Entity.WorkCenter workCenter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeleteWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/DeleteWorkCenterResponse")]
        System.Threading.Tasks.Task<bool> DeleteWorkCenterAsync(DbPlc.EntityFramework.Entity.WorkCenter workCenter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeletePlc", ReplyAction="http://tempuri.org/DbPlcWeb/DeletePlcResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/DeletePlcResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool DeletePlc(DbPlc.EntityFramework.Entity.Plc plc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeletePlc", ReplyAction="http://tempuri.org/DbPlcWeb/DeletePlcResponse")]
        System.Threading.Tasks.Task<bool> DeletePlcAsync(DbPlc.EntityFramework.Entity.Plc plc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeletePlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/DeletePlcTagResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/DeletePlcTagResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool DeletePlcTag(DbPlc.EntityFramework.Entity.PlcTag plcTag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/DeletePlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/DeletePlcTagResponse")]
        System.Threading.Tasks.Task<bool> DeletePlcTagAsync(DbPlc.EntityFramework.Entity.PlcTag plcTag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdateArea", ReplyAction="http://tempuri.org/DbPlcWeb/UpdateAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/UpdateAreaResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool UpdateArea(DbPlc.EntityFramework.Entity.Area area);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdateArea", ReplyAction="http://tempuri.org/DbPlcWeb/UpdateAreaResponse")]
        System.Threading.Tasks.Task<bool> UpdateAreaAsync(DbPlc.EntityFramework.Entity.Area area);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdateWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/UpdateWorkCenterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/UpdateWorkCenterResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool UpdateWorkCenter(DbPlc.EntityFramework.Entity.WorkCenter workCenter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdateWorkCenter", ReplyAction="http://tempuri.org/DbPlcWeb/UpdateWorkCenterResponse")]
        System.Threading.Tasks.Task<bool> UpdateWorkCenterAsync(DbPlc.EntityFramework.Entity.WorkCenter workCenter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdatePlc", ReplyAction="http://tempuri.org/DbPlcWeb/UpdatePlcResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/UpdatePlcResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool UpdatePlc(DbPlc.EntityFramework.Entity.Plc plc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdatePlc", ReplyAction="http://tempuri.org/DbPlcWeb/UpdatePlcResponse")]
        System.Threading.Tasks.Task<bool> UpdatePlcAsync(DbPlc.EntityFramework.Entity.Plc plc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdatePlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/UpdatePlcTagResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/UpdatePlcTagResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool UpdatePlcTag(DbPlc.EntityFramework.Entity.PlcTag plcTag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/UpdatePlcTag", ReplyAction="http://tempuri.org/DbPlcWeb/UpdatePlcTagResponse")]
        System.Threading.Tasks.Task<bool> UpdatePlcTagAsync(DbPlc.EntityFramework.Entity.PlcTag plcTag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/Login", ReplyAction="http://tempuri.org/DbPlcWeb/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DbPlc.WEBMVCUI.DbReference.ResponseError), Action="http://tempuri.org/DbPlcWeb/LoginResponseErrorFault", Name="ResponseError", Namespace="http://schemas.datacontract.org/2004/07/DbPlc.Service")]
        bool Login([System.ServiceModel.MessageParameterAttribute(Name="login")] DbPlc.EntityFramework.Entity.Login login1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DbPlcWeb/Login", ReplyAction="http://tempuri.org/DbPlcWeb/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(DbPlc.EntityFramework.Entity.Login login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DbPlcWebChannel : DbPlc.WEBMVCUI.DbReference.DbPlcWeb, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DbPlcWebClient : System.ServiceModel.ClientBase<DbPlc.WEBMVCUI.DbReference.DbPlcWeb>, DbPlc.WEBMVCUI.DbReference.DbPlcWeb {
        
        public DbPlcWebClient() {
        }
        
        public DbPlcWebClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DbPlcWebClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbPlcWebClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbPlcWebClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAllArea() {
            return base.Channel.GetAllArea();
        }
        
        public System.Threading.Tasks.Task<string> GetAllAreaAsync() {
            return base.Channel.GetAllAreaAsync();
        }
        
        public string GetAllWorkCenter() {
            return base.Channel.GetAllWorkCenter();
        }
        
        public System.Threading.Tasks.Task<string> GetAllWorkCenterAsync() {
            return base.Channel.GetAllWorkCenterAsync();
        }
        
        public string GetAllPlc() {
            return base.Channel.GetAllPlc();
        }
        
        public System.Threading.Tasks.Task<string> GetAllPlcAsync() {
            return base.Channel.GetAllPlcAsync();
        }
        
        public string GelAllPlcTag() {
            return base.Channel.GelAllPlcTag();
        }
        
        public System.Threading.Tasks.Task<string> GelAllPlcTagAsync() {
            return base.Channel.GelAllPlcTagAsync();
        }
        
        public string GetAllWorkCenterDto() {
            return base.Channel.GetAllWorkCenterDto();
        }
        
        public System.Threading.Tasks.Task<string> GetAllWorkCenterDtoAsync() {
            return base.Channel.GetAllWorkCenterDtoAsync();
        }
        
        public string GetAllPlcDto() {
            return base.Channel.GetAllPlcDto();
        }
        
        public System.Threading.Tasks.Task<string> GetAllPlcDtoAsync() {
            return base.Channel.GetAllPlcDtoAsync();
        }
        
        public string GetAllPlcTagDto() {
            return base.Channel.GetAllPlcTagDto();
        }
        
        public System.Threading.Tasks.Task<string> GetAllPlcTagDtoAsync() {
            return base.Channel.GetAllPlcTagDtoAsync();
        }
        
        public bool AddArea(DbPlc.EntityFramework.Entity.Area area) {
            return base.Channel.AddArea(area);
        }
        
        public System.Threading.Tasks.Task<bool> AddAreaAsync(DbPlc.EntityFramework.Entity.Area area) {
            return base.Channel.AddAreaAsync(area);
        }
        
        public bool AddWorkCenter(DbPlc.EntityFramework.Entity.WorkCenter workCenter) {
            return base.Channel.AddWorkCenter(workCenter);
        }
        
        public System.Threading.Tasks.Task<bool> AddWorkCenterAsync(DbPlc.EntityFramework.Entity.WorkCenter workCenter) {
            return base.Channel.AddWorkCenterAsync(workCenter);
        }
        
        public bool AddPlc(DbPlc.EntityFramework.Entity.Plc plc) {
            return base.Channel.AddPlc(plc);
        }
        
        public System.Threading.Tasks.Task<bool> AddPlcAsync(DbPlc.EntityFramework.Entity.Plc plc) {
            return base.Channel.AddPlcAsync(plc);
        }
        
        public bool AddPlcTag(DbPlc.EntityFramework.Entity.PlcTag plcTag) {
            return base.Channel.AddPlcTag(plcTag);
        }
        
        public System.Threading.Tasks.Task<bool> AddPlcTagAsync(DbPlc.EntityFramework.Entity.PlcTag plcTag) {
            return base.Channel.AddPlcTagAsync(plcTag);
        }
        
        public bool DeleteArea(DbPlc.EntityFramework.Entity.Area area) {
            return base.Channel.DeleteArea(area);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAreaAsync(DbPlc.EntityFramework.Entity.Area area) {
            return base.Channel.DeleteAreaAsync(area);
        }
        
        public bool DeleteWorkCenter(DbPlc.EntityFramework.Entity.WorkCenter workCenter) {
            return base.Channel.DeleteWorkCenter(workCenter);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteWorkCenterAsync(DbPlc.EntityFramework.Entity.WorkCenter workCenter) {
            return base.Channel.DeleteWorkCenterAsync(workCenter);
        }
        
        public bool DeletePlc(DbPlc.EntityFramework.Entity.Plc plc) {
            return base.Channel.DeletePlc(plc);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePlcAsync(DbPlc.EntityFramework.Entity.Plc plc) {
            return base.Channel.DeletePlcAsync(plc);
        }
        
        public bool DeletePlcTag(DbPlc.EntityFramework.Entity.PlcTag plcTag) {
            return base.Channel.DeletePlcTag(plcTag);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePlcTagAsync(DbPlc.EntityFramework.Entity.PlcTag plcTag) {
            return base.Channel.DeletePlcTagAsync(plcTag);
        }
        
        public bool UpdateArea(DbPlc.EntityFramework.Entity.Area area) {
            return base.Channel.UpdateArea(area);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAreaAsync(DbPlc.EntityFramework.Entity.Area area) {
            return base.Channel.UpdateAreaAsync(area);
        }
        
        public bool UpdateWorkCenter(DbPlc.EntityFramework.Entity.WorkCenter workCenter) {
            return base.Channel.UpdateWorkCenter(workCenter);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateWorkCenterAsync(DbPlc.EntityFramework.Entity.WorkCenter workCenter) {
            return base.Channel.UpdateWorkCenterAsync(workCenter);
        }
        
        public bool UpdatePlc(DbPlc.EntityFramework.Entity.Plc plc) {
            return base.Channel.UpdatePlc(plc);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePlcAsync(DbPlc.EntityFramework.Entity.Plc plc) {
            return base.Channel.UpdatePlcAsync(plc);
        }
        
        public bool UpdatePlcTag(DbPlc.EntityFramework.Entity.PlcTag plcTag) {
            return base.Channel.UpdatePlcTag(plcTag);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePlcTagAsync(DbPlc.EntityFramework.Entity.PlcTag plcTag) {
            return base.Channel.UpdatePlcTagAsync(plcTag);
        }
        
        public bool Login(DbPlc.EntityFramework.Entity.Login login1) {
            return base.Channel.Login(login1);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(DbPlc.EntityFramework.Entity.Login login) {
            return base.Channel.LoginAsync(login);
        }
    }
}
