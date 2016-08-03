﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Research.Science.FetchClimate2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JobDB")]
	public partial class JobsDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertJob(Job instance);
    partial void UpdateJob(Job instance);
    partial void DeleteJob(Job instance);
    #endregion
		
		public JobsDBDataContext() : 
				base(global::Microsoft.Research.Science.FetchClimate2.Properties.Settings.Default.JobDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public JobsDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobsDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobsDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobsDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Job> Jobs
		{
			get
			{
				return this.GetTable<Job>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Job")]
	public partial class Job : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Hash;
		
		private int _PartNo;
		
		private int _PartsCount;
		
		private byte _Priority;
		
		private byte _Status;
		
		private System.DateTime _Touchtime;
		
		private System.DateTime _SubmitTime;
		
		private System.Nullable<System.DateTime> _StartTime;
		
		private byte _IsHeavyJob;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHashChanging(string value);
    partial void OnHashChanged();
    partial void OnPartNoChanging(int value);
    partial void OnPartNoChanged();
    partial void OnPartsCountChanging(int value);
    partial void OnPartsCountChanged();
    partial void OnPriorityChanging(byte value);
    partial void OnPriorityChanged();
    partial void OnStatusChanging(byte value);
    partial void OnStatusChanged();
    partial void OnTouchtimeChanging(System.DateTime value);
    partial void OnTouchtimeChanged();
    partial void OnSubmitTimeChanging(System.DateTime value);
    partial void OnSubmitTimeChanged();
    partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnStartTimeChanged();
    partial void OnIsHeavyJobChanging(byte value);
    partial void OnIsHeavyJobChanged();
    #endregion
		
		public Job()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hash", DbType="Char(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Hash
		{
			get
			{
				return this._Hash;
			}
			set
			{
				if ((this._Hash != value))
				{
					this.OnHashChanging(value);
					this.SendPropertyChanging();
					this._Hash = value;
					this.SendPropertyChanged("Hash");
					this.OnHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PartNo
		{
			get
			{
				return this._PartNo;
			}
			set
			{
				if ((this._PartNo != value))
				{
					this.OnPartNoChanging(value);
					this.SendPropertyChanging();
					this._PartNo = value;
					this.SendPropertyChanged("PartNo");
					this.OnPartNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartsCount", DbType="Int NOT NULL")]
		public int PartsCount
		{
			get
			{
				return this._PartsCount;
			}
			set
			{
				if ((this._PartsCount != value))
				{
					this.OnPartsCountChanging(value);
					this.SendPropertyChanging();
					this._PartsCount = value;
					this.SendPropertyChanged("PartsCount");
					this.OnPartsCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priority", DbType="TinyInt NOT NULL")]
		public byte Priority
		{
			get
			{
				return this._Priority;
			}
			set
			{
				if ((this._Priority != value))
				{
					this.OnPriorityChanging(value);
					this.SendPropertyChanging();
					this._Priority = value;
					this.SendPropertyChanged("Priority");
					this.OnPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="TinyInt NOT NULL")]
		public byte Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Touchtime", DbType="DateTime NOT NULL")]
		public System.DateTime Touchtime
		{
			get
			{
				return this._Touchtime;
			}
			set
			{
				if ((this._Touchtime != value))
				{
					this.OnTouchtimeChanging(value);
					this.SendPropertyChanging();
					this._Touchtime = value;
					this.SendPropertyChanged("Touchtime");
					this.OnTouchtimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubmitTime", DbType="DateTime NOT NULL")]
		public System.DateTime SubmitTime
		{
			get
			{
				return this._SubmitTime;
			}
			set
			{
				if ((this._SubmitTime != value))
				{
					this.OnSubmitTimeChanging(value);
					this.SendPropertyChanging();
					this._SubmitTime = value;
					this.SendPropertyChanged("SubmitTime");
					this.OnSubmitTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsHeavyJob", DbType="TinyInt NOT NULL")]
		public byte IsHeavyJob
		{
			get
			{
				return this._IsHeavyJob;
			}
			set
			{
				if ((this._IsHeavyJob != value))
				{
					this.OnIsHeavyJobChanging(value);
					this.SendPropertyChanging();
					this._IsHeavyJob = value;
					this.SendPropertyChanged("IsHeavyJob");
					this.OnIsHeavyJobChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591