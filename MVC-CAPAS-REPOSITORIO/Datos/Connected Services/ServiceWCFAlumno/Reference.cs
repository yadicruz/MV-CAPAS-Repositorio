//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.ServiceWCFAlumno {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DCAlumno", Namespace="http://schemas.datacontract.org/2004/07/WCFAlumno")]
    [System.SerializableAttribute()]
    public partial class DCAlumno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string correoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string curpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idEstadoOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idEstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string primerApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string segundoApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
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
        public string correo {
            get {
                return this.correoField;
            }
            set {
                if ((object.ReferenceEquals(this.correoField, value) != true)) {
                    this.correoField = value;
                    this.RaisePropertyChanged("correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string curp {
            get {
                return this.curpField;
            }
            set {
                if ((object.ReferenceEquals(this.curpField, value) != true)) {
                    this.curpField = value;
                    this.RaisePropertyChanged("curp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                if ((this.fechaNacimientoField.Equals(value) != true)) {
                    this.fechaNacimientoField = value;
                    this.RaisePropertyChanged("fechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idEstadoOrigen {
            get {
                return this.idEstadoOrigenField;
            }
            set {
                if ((this.idEstadoOrigenField.Equals(value) != true)) {
                    this.idEstadoOrigenField = value;
                    this.RaisePropertyChanged("idEstadoOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idEstatus {
            get {
                return this.idEstatusField;
            }
            set {
                if ((this.idEstatusField.Equals(value) != true)) {
                    this.idEstatusField = value;
                    this.RaisePropertyChanged("idEstatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string primerApellido {
            get {
                return this.primerApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.primerApellidoField, value) != true)) {
                    this.primerApellidoField = value;
                    this.RaisePropertyChanged("primerApellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string segundoApellido {
            get {
                return this.segundoApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.segundoApellidoField, value) != true)) {
                    this.segundoApellidoField = value;
                    this.RaisePropertyChanged("segundoApellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.telefonoField, value) != true)) {
                    this.telefonoField = value;
                    this.RaisePropertyChanged("telefono");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWCFAlumno.IWcfAlumno")]
    public interface IWcfAlumno {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Consultar", ReplyAction="http://tempuri.org/IWcfAlumno/ConsultarResponse")]
        Datos.ServiceWCFAlumno.DCAlumno[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Consultar", ReplyAction="http://tempuri.org/IWcfAlumno/ConsultarResponse")]
        System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno[]> ConsultarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Crear", ReplyAction="http://tempuri.org/IWcfAlumno/CrearResponse")]
        Datos.ServiceWCFAlumno.DCAlumno Crear(Datos.ServiceWCFAlumno.DCAlumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Crear", ReplyAction="http://tempuri.org/IWcfAlumno/CrearResponse")]
        System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> CrearAsync(Datos.ServiceWCFAlumno.DCAlumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/ConsultarUno", ReplyAction="http://tempuri.org/IWcfAlumno/ConsultarUnoResponse")]
        Datos.ServiceWCFAlumno.DCAlumno ConsultarUno(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/ConsultarUno", ReplyAction="http://tempuri.org/IWcfAlumno/ConsultarUnoResponse")]
        System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> ConsultarUnoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Detalles", ReplyAction="http://tempuri.org/IWcfAlumno/DetallesResponse")]
        Datos.ServiceWCFAlumno.DCAlumno Detalles(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Detalles", ReplyAction="http://tempuri.org/IWcfAlumno/DetallesResponse")]
        System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> DetallesAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Editar", ReplyAction="http://tempuri.org/IWcfAlumno/EditarResponse")]
        Datos.ServiceWCFAlumno.DCAlumno Editar(Datos.ServiceWCFAlumno.DCAlumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Editar", ReplyAction="http://tempuri.org/IWcfAlumno/EditarResponse")]
        System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> EditarAsync(Datos.ServiceWCFAlumno.DCAlumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Eliminar", ReplyAction="http://tempuri.org/IWcfAlumno/EliminarResponse")]
        void Eliminar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfAlumno/Eliminar", ReplyAction="http://tempuri.org/IWcfAlumno/EliminarResponse")]
        System.Threading.Tasks.Task EliminarAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfAlumnoChannel : Datos.ServiceWCFAlumno.IWcfAlumno, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfAlumnoClient : System.ServiceModel.ClientBase<Datos.ServiceWCFAlumno.IWcfAlumno>, Datos.ServiceWCFAlumno.IWcfAlumno {
        
        public WcfAlumnoClient() {
        }
        
        public WcfAlumnoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfAlumnoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfAlumnoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfAlumnoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Datos.ServiceWCFAlumno.DCAlumno[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno[]> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
        
        public Datos.ServiceWCFAlumno.DCAlumno Crear(Datos.ServiceWCFAlumno.DCAlumno alumno) {
            return base.Channel.Crear(alumno);
        }
        
        public System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> CrearAsync(Datos.ServiceWCFAlumno.DCAlumno alumno) {
            return base.Channel.CrearAsync(alumno);
        }
        
        public Datos.ServiceWCFAlumno.DCAlumno ConsultarUno(int id) {
            return base.Channel.ConsultarUno(id);
        }
        
        public System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> ConsultarUnoAsync(int id) {
            return base.Channel.ConsultarUnoAsync(id);
        }
        
        public Datos.ServiceWCFAlumno.DCAlumno Detalles(int id) {
            return base.Channel.Detalles(id);
        }
        
        public System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> DetallesAsync(int id) {
            return base.Channel.DetallesAsync(id);
        }
        
        public Datos.ServiceWCFAlumno.DCAlumno Editar(Datos.ServiceWCFAlumno.DCAlumno alumno) {
            return base.Channel.Editar(alumno);
        }
        
        public System.Threading.Tasks.Task<Datos.ServiceWCFAlumno.DCAlumno> EditarAsync(Datos.ServiceWCFAlumno.DCAlumno alumno) {
            return base.Channel.EditarAsync(alumno);
        }
        
        public void Eliminar(int id) {
            base.Channel.Eliminar(id);
        }
        
        public System.Threading.Tasks.Task EliminarAsync(int id) {
            return base.Channel.EliminarAsync(id);
        }
    }
}
