﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlAzureBackup.SqlAzure.ImportExport {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExportInput", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class ExportInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials BlobCredentialsField;
        
        private SqlAzureBackup.SqlAzure.ImportExport.ConnectionInfo ConnectionInfoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials BlobCredentials {
            get {
                return this.BlobCredentialsField;
            }
            set {
                if ((object.ReferenceEquals(this.BlobCredentialsField, value) != true)) {
                    this.BlobCredentialsField = value;
                    this.RaisePropertyChanged("BlobCredentials");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SqlAzureBackup.SqlAzure.ImportExport.ConnectionInfo ConnectionInfo {
            get {
                return this.ConnectionInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ConnectionInfoField, value) != true)) {
                    this.ConnectionInfoField = value;
                    this.RaisePropertyChanged("ConnectionInfo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BlobCredentials", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SqlAzureBackup.SqlAzure.ImportExport.BlobSharedAccessKeyCredentials))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SqlAzureBackup.SqlAzure.ImportExport.BlobStorageAccessKeyCredentials))]
    public partial class BlobCredentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UriField;
        
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
        public string Uri {
            get {
                return this.UriField;
            }
            set {
                if ((object.ReferenceEquals(this.UriField, value) != true)) {
                    this.UriField = value;
                    this.RaisePropertyChanged("Uri");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectionInfo", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class ConnectionInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatabaseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string DatabaseName {
            get {
                return this.DatabaseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DatabaseNameField, value) != true)) {
                    this.DatabaseNameField = value;
                    this.RaisePropertyChanged("DatabaseName");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerName {
            get {
                return this.ServerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerNameField, value) != true)) {
                    this.ServerNameField = value;
                    this.RaisePropertyChanged("ServerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BlobSharedAccessKeyCredentials", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class BlobSharedAccessKeyCredentials : SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SharedAccessKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SharedAccessKey {
            get {
                return this.SharedAccessKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.SharedAccessKeyField, value) != true)) {
                    this.SharedAccessKeyField = value;
                    this.RaisePropertyChanged("SharedAccessKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BlobStorageAccessKeyCredentials", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class BlobStorageAccessKeyCredentials : SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StorageAccessKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StorageAccessKey {
            get {
                return this.StorageAccessKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.StorageAccessKeyField, value) != true)) {
                    this.StorageAccessKeyField = value;
                    this.RaisePropertyChanged("StorageAccessKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectiveExportInput", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class SelectiveExportInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials BlobCredentialsField;
        
        private SqlAzureBackup.SqlAzure.ImportExport.ConnectionInfo ConnectionInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SqlAzureBackup.SqlAzure.ImportExport.TableName[] TablesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials BlobCredentials {
            get {
                return this.BlobCredentialsField;
            }
            set {
                if ((object.ReferenceEquals(this.BlobCredentialsField, value) != true)) {
                    this.BlobCredentialsField = value;
                    this.RaisePropertyChanged("BlobCredentials");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SqlAzureBackup.SqlAzure.ImportExport.ConnectionInfo ConnectionInfo {
            get {
                return this.ConnectionInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ConnectionInfoField, value) != true)) {
                    this.ConnectionInfoField = value;
                    this.RaisePropertyChanged("ConnectionInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SqlAzureBackup.SqlAzure.ImportExport.TableName[] Tables {
            get {
                return this.TablesField;
            }
            set {
                if ((object.ReferenceEquals(this.TablesField, value) != true)) {
                    this.TablesField = value;
                    this.RaisePropertyChanged("Tables");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TableName", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class TableName : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SchemaNameField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SchemaName {
            get {
                return this.SchemaNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SchemaNameField, value) != true)) {
                    this.SchemaNameField = value;
                    this.RaisePropertyChanged("SchemaName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportInput", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class ImportInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AzureEditionField;
        
        private SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials BlobCredentialsField;
        
        private SqlAzureBackup.SqlAzure.ImportExport.ConnectionInfo ConnectionInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DatabaseSizeInGBField;
        
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
        public string AzureEdition {
            get {
                return this.AzureEditionField;
            }
            set {
                if ((object.ReferenceEquals(this.AzureEditionField, value) != true)) {
                    this.AzureEditionField = value;
                    this.RaisePropertyChanged("AzureEdition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SqlAzureBackup.SqlAzure.ImportExport.BlobCredentials BlobCredentials {
            get {
                return this.BlobCredentialsField;
            }
            set {
                if ((object.ReferenceEquals(this.BlobCredentialsField, value) != true)) {
                    this.BlobCredentialsField = value;
                    this.RaisePropertyChanged("BlobCredentials");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SqlAzureBackup.SqlAzure.ImportExport.ConnectionInfo ConnectionInfo {
            get {
                return this.ConnectionInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ConnectionInfoField, value) != true)) {
                    this.ConnectionInfoField = value;
                    this.RaisePropertyChanged("ConnectionInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DatabaseSizeInGB {
            get {
                return this.DatabaseSizeInGBField;
            }
            set {
                if ((this.DatabaseSizeInGBField.Equals(value) != true)) {
                    this.DatabaseSizeInGBField = value;
                    this.RaisePropertyChanged("DatabaseSizeInGB");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusInput", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class StatusInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RequestIdField;
        
        private string ServerNameField;
        
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestId {
            get {
                return this.RequestIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestIdField, value) != true)) {
                    this.RequestIdField = value;
                    this.RaisePropertyChanged("RequestId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string ServerName {
            get {
                return this.ServerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerNameField, value) != true)) {
                    this.ServerNameField = value;
                    this.RaisePropertyChanged("ServerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusInfo", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.SqlServer.Management.Dac.Servic" +
        "eTypes")]
    [System.SerializableAttribute()]
    public partial class StatusInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BlobUriField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatabaseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastModifiedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime QueuedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RequestIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RequestTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public string BlobUri {
            get {
                return this.BlobUriField;
            }
            set {
                if ((object.ReferenceEquals(this.BlobUriField, value) != true)) {
                    this.BlobUriField = value;
                    this.RaisePropertyChanged("BlobUri");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DatabaseName {
            get {
                return this.DatabaseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DatabaseNameField, value) != true)) {
                    this.DatabaseNameField = value;
                    this.RaisePropertyChanged("DatabaseName");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastModifiedTime {
            get {
                return this.LastModifiedTimeField;
            }
            set {
                if ((this.LastModifiedTimeField.Equals(value) != true)) {
                    this.LastModifiedTimeField = value;
                    this.RaisePropertyChanged("LastModifiedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime QueuedTime {
            get {
                return this.QueuedTimeField;
            }
            set {
                if ((this.QueuedTimeField.Equals(value) != true)) {
                    this.QueuedTimeField = value;
                    this.RaisePropertyChanged("QueuedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestId {
            get {
                return this.RequestIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestIdField, value) != true)) {
                    this.RequestIdField = value;
                    this.RaisePropertyChanged("RequestId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestType {
            get {
                return this.RequestTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestTypeField, value) != true)) {
                    this.RequestTypeField = value;
                    this.RaisePropertyChanged("RequestType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerName {
            get {
                return this.ServerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerNameField, value) != true)) {
                    this.ServerNameField = value;
                    this.RaisePropertyChanged("ServerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SqlAzure.ImportExport.IDACWebService")]
    public interface IDACWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/Export", ReplyAction="http://tempuri.org/IDACWebService/ExportResponse")]
        System.Guid Export(SqlAzureBackup.SqlAzure.ImportExport.ExportInput exportInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/Export", ReplyAction="http://tempuri.org/IDACWebService/ExportResponse")]
        System.Threading.Tasks.Task<System.Guid> ExportAsync(SqlAzureBackup.SqlAzure.ImportExport.ExportInput exportInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/SelectiveExport", ReplyAction="http://tempuri.org/IDACWebService/SelectiveExportResponse")]
        System.Guid SelectiveExport(SqlAzureBackup.SqlAzure.ImportExport.SelectiveExportInput exportInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/SelectiveExport", ReplyAction="http://tempuri.org/IDACWebService/SelectiveExportResponse")]
        System.Threading.Tasks.Task<System.Guid> SelectiveExportAsync(SqlAzureBackup.SqlAzure.ImportExport.SelectiveExportInput exportInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/Import", ReplyAction="http://tempuri.org/IDACWebService/ImportResponse")]
        System.Guid Import(SqlAzureBackup.SqlAzure.ImportExport.ImportInput importInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/Import", ReplyAction="http://tempuri.org/IDACWebService/ImportResponse")]
        System.Threading.Tasks.Task<System.Guid> ImportAsync(SqlAzureBackup.SqlAzure.ImportExport.ImportInput importInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/PostStatus", ReplyAction="http://tempuri.org/IDACWebService/PostStatusResponse")]
        SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[] PostStatus(SqlAzureBackup.SqlAzure.ImportExport.StatusInput statusInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/PostStatus", ReplyAction="http://tempuri.org/IDACWebService/PostStatusResponse")]
        System.Threading.Tasks.Task<SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[]> PostStatusAsync(SqlAzureBackup.SqlAzure.ImportExport.StatusInput statusInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/GetStatus", ReplyAction="http://tempuri.org/IDACWebService/GetStatusResponse")]
        SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[] GetStatus(string serverName, string userName, string password, string requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/GetStatus", ReplyAction="http://tempuri.org/IDACWebService/GetStatusResponse")]
        System.Threading.Tasks.Task<SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[]> GetStatusAsync(string serverName, string userName, string password, string requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/Test", ReplyAction="http://tempuri.org/IDACWebService/TestResponse")]
        int Test();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDACWebService/Test", ReplyAction="http://tempuri.org/IDACWebService/TestResponse")]
        System.Threading.Tasks.Task<int> TestAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDACWebServiceChannel : SqlAzureBackup.SqlAzure.ImportExport.IDACWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DACWebServiceClient : System.ServiceModel.ClientBase<SqlAzureBackup.SqlAzure.ImportExport.IDACWebService>, SqlAzureBackup.SqlAzure.ImportExport.IDACWebService {
        
        public DACWebServiceClient() {
        }
        
        public DACWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DACWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DACWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DACWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid Export(SqlAzureBackup.SqlAzure.ImportExport.ExportInput exportInput) {
            return base.Channel.Export(exportInput);
        }
        
        public System.Threading.Tasks.Task<System.Guid> ExportAsync(SqlAzureBackup.SqlAzure.ImportExport.ExportInput exportInput) {
            return base.Channel.ExportAsync(exportInput);
        }
        
        public System.Guid SelectiveExport(SqlAzureBackup.SqlAzure.ImportExport.SelectiveExportInput exportInput) {
            return base.Channel.SelectiveExport(exportInput);
        }
        
        public System.Threading.Tasks.Task<System.Guid> SelectiveExportAsync(SqlAzureBackup.SqlAzure.ImportExport.SelectiveExportInput exportInput) {
            return base.Channel.SelectiveExportAsync(exportInput);
        }
        
        public System.Guid Import(SqlAzureBackup.SqlAzure.ImportExport.ImportInput importInput) {
            return base.Channel.Import(importInput);
        }
        
        public System.Threading.Tasks.Task<System.Guid> ImportAsync(SqlAzureBackup.SqlAzure.ImportExport.ImportInput importInput) {
            return base.Channel.ImportAsync(importInput);
        }
        
        public SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[] PostStatus(SqlAzureBackup.SqlAzure.ImportExport.StatusInput statusInput) {
            return base.Channel.PostStatus(statusInput);
        }
        
        public System.Threading.Tasks.Task<SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[]> PostStatusAsync(SqlAzureBackup.SqlAzure.ImportExport.StatusInput statusInput) {
            return base.Channel.PostStatusAsync(statusInput);
        }
        
        public SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[] GetStatus(string serverName, string userName, string password, string requestId) {
            return base.Channel.GetStatus(serverName, userName, password, requestId);
        }
        
        public System.Threading.Tasks.Task<SqlAzureBackup.SqlAzure.ImportExport.StatusInfo[]> GetStatusAsync(string serverName, string userName, string password, string requestId) {
            return base.Channel.GetStatusAsync(serverName, userName, password, requestId);
        }
        
        public int Test() {
            return base.Channel.Test();
        }
        
        public System.Threading.Tasks.Task<int> TestAsync() {
            return base.Channel.TestAsync();
        }
    }
}
