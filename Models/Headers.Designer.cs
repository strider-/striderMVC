﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace striderMVC.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HeaderEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HeaderEntities object using the connection string found in the 'HeaderEntities' section of the application configuration file.
        /// </summary>
        public HeaderEntities() : base("name=HeaderEntities", "HeaderEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HeaderEntities object.
        /// </summary>
        public HeaderEntities(string connectionString) : base(connectionString, "HeaderEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HeaderEntities object.
        /// </summary>
        public HeaderEntities(EntityConnection connection) : base(connection, "HeaderEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Header> Headers
        {
            get
            {
                if ((_Headers == null))
                {
                    _Headers = base.CreateObjectSet<Header>("Headers");
                }
                return _Headers;
            }
        }
        private ObjectSet<Header> _Headers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Headers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHeaders(Header header)
        {
            base.AddObject("Headers", header);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Models", Name="Header")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Header : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Header object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="value">Initial value of the Value property.</param>
        public static Header CreateHeader(global::System.Int32 id, global::System.String value)
        {
            Header header = new Header();
            header.Id = id;
            header.Value = value;
            return header;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.String _Value;
        partial void OnValueChanging(global::System.String value);
        partial void OnValueChanged();

        #endregion
    
    }

    #endregion
    
}
