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
    public partial class ProjectEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ProjectEntities object using the connection string found in the 'ProjectEntities' section of the application configuration file.
        /// </summary>
        public ProjectEntities() : base("name=ProjectEntities", "ProjectEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProjectEntities object.
        /// </summary>
        public ProjectEntities(string connectionString) : base(connectionString, "ProjectEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProjectEntities object.
        /// </summary>
        public ProjectEntities(EntityConnection connection) : base(connection, "ProjectEntities")
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
        public ObjectSet<Project> Projects
        {
            get
            {
                if ((_Projects == null))
                {
                    _Projects = base.CreateObjectSet<Project>("Projects");
                }
                return _Projects;
            }
        }
        private ObjectSet<Project> _Projects;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Projects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProjects(Project project)
        {
            base.AddObject("Projects", project);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Models", Name="Project")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Project : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Project object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="summary">Initial value of the Summary property.</param>
        /// <param name="progress">Initial value of the Progress property.</param>
        public static Project CreateProject(global::System.Int32 id, global::System.String title, global::System.String summary, global::System.Double progress)
        {
            Project project = new Project();
            project.ID = id;
            project.Title = title;
            project.Summary = summary;
            project.Progress = progress;
            return project;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Summary
        {
            get
            {
                return _Summary;
            }
            set
            {
                OnSummaryChanging(value);
                ReportPropertyChanging("Summary");
                _Summary = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Summary");
                OnSummaryChanged();
            }
        }
        private global::System.String _Summary;
        partial void OnSummaryChanging(global::System.String value);
        partial void OnSummaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Progress
        {
            get
            {
                return _Progress;
            }
            set
            {
                OnProgressChanging(value);
                ReportPropertyChanging("Progress");
                _Progress = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Progress");
                OnProgressChanged();
            }
        }
        private global::System.Double _Progress;
        partial void OnProgressChanging(global::System.Double value);
        partial void OnProgressChanged();

        #endregion
    
    }

    #endregion
    
}
