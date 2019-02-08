﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CharityApplication
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="charitySQL")]
	public partial class eventCalendarDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCharityEvent(CharityEvent instance);
    partial void UpdateCharityEvent(CharityEvent instance);
    partial void DeleteCharityEvent(CharityEvent instance);
    partial void InsertCharityEventUser(CharityEventUser instance);
    partial void UpdateCharityEventUser(CharityEventUser instance);
    partial void DeleteCharityEventUser(CharityEventUser instance);
    #endregion
		
		public eventCalendarDataContext() : 
				base(global::CharityApplication.Properties.Settings.Default.charitySQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public eventCalendarDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eventCalendarDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eventCalendarDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eventCalendarDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CharityEvent> CharityEvents
		{
			get
			{
				return this.GetTable<CharityEvent>();
			}
		}
		
		public System.Data.Linq.Table<CharityEventUser> CharityEventUsers
		{
			get
			{
				return this.GetTable<CharityEventUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CharityEvent")]
	public partial class CharityEvent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _eventManagement;
		
		private string _eventName;
		
		private System.Nullable<System.DateTime> _eventStartDate;
		
		private System.Nullable<System.DateTime> _eventEndDate;
		
		private string _eventDescription;
		
		private string _eventLocation;
		
		private string _eventImagePath;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OneventManagementChanging(string value);
    partial void OneventManagementChanged();
    partial void OneventNameChanging(string value);
    partial void OneventNameChanged();
    partial void OneventStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OneventStartDateChanged();
    partial void OneventEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OneventEndDateChanged();
    partial void OneventDescriptionChanging(string value);
    partial void OneventDescriptionChanged();
    partial void OneventLocationChanging(string value);
    partial void OneventLocationChanged();
    partial void OneventImagePathChanging(string value);
    partial void OneventImagePathChanged();
    #endregion
		
		public CharityEvent()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventManagement", DbType="NVarChar(50)")]
		public string eventManagement
		{
			get
			{
				return this._eventManagement;
			}
			set
			{
				if ((this._eventManagement != value))
				{
					this.OneventManagementChanging(value);
					this.SendPropertyChanging();
					this._eventManagement = value;
					this.SendPropertyChanged("eventManagement");
					this.OneventManagementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventName", DbType="NVarChar(50)")]
		public string eventName
		{
			get
			{
				return this._eventName;
			}
			set
			{
				if ((this._eventName != value))
				{
					this.OneventNameChanging(value);
					this.SendPropertyChanging();
					this._eventName = value;
					this.SendPropertyChanged("eventName");
					this.OneventNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventStartDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> eventStartDate
		{
			get
			{
				return this._eventStartDate;
			}
			set
			{
				if ((this._eventStartDate != value))
				{
					this.OneventStartDateChanging(value);
					this.SendPropertyChanging();
					this._eventStartDate = value;
					this.SendPropertyChanged("eventStartDate");
					this.OneventStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventEndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> eventEndDate
		{
			get
			{
				return this._eventEndDate;
			}
			set
			{
				if ((this._eventEndDate != value))
				{
					this.OneventEndDateChanging(value);
					this.SendPropertyChanging();
					this._eventEndDate = value;
					this.SendPropertyChanged("eventEndDate");
					this.OneventEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventDescription", DbType="NVarChar(50)")]
		public string eventDescription
		{
			get
			{
				return this._eventDescription;
			}
			set
			{
				if ((this._eventDescription != value))
				{
					this.OneventDescriptionChanging(value);
					this.SendPropertyChanging();
					this._eventDescription = value;
					this.SendPropertyChanged("eventDescription");
					this.OneventDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventLocation", DbType="NVarChar(50)")]
		public string eventLocation
		{
			get
			{
				return this._eventLocation;
			}
			set
			{
				if ((this._eventLocation != value))
				{
					this.OneventLocationChanging(value);
					this.SendPropertyChanging();
					this._eventLocation = value;
					this.SendPropertyChanged("eventLocation");
					this.OneventLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventImagePath", DbType="NChar(10)")]
		public string eventImagePath
		{
			get
			{
				return this._eventImagePath;
			}
			set
			{
				if ((this._eventImagePath != value))
				{
					this.OneventImagePathChanging(value);
					this.SendPropertyChanging();
					this._eventImagePath = value;
					this.SendPropertyChanged("eventImagePath");
					this.OneventImagePathChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CharityEventUser")]
	public partial class CharityEventUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _charityID;
		
		private System.Nullable<int> _eventID;
		
		private System.Nullable<int> _userID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OncharityIDChanging(System.Nullable<int> value);
    partial void OncharityIDChanged();
    partial void OneventIDChanging(System.Nullable<int> value);
    partial void OneventIDChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    #endregion
		
		public CharityEventUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityID", DbType="Int")]
		public System.Nullable<int> charityID
		{
			get
			{
				return this._charityID;
			}
			set
			{
				if ((this._charityID != value))
				{
					this.OncharityIDChanging(value);
					this.SendPropertyChanging();
					this._charityID = value;
					this.SendPropertyChanged("charityID");
					this.OncharityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventID", DbType="Int")]
		public System.Nullable<int> eventID
		{
			get
			{
				return this._eventID;
			}
			set
			{
				if ((this._eventID != value))
				{
					this.OneventIDChanging(value);
					this.SendPropertyChanging();
					this._eventID = value;
					this.SendPropertyChanged("eventID");
					this.OneventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
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
