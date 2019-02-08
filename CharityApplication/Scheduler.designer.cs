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
	public partial class SchedulerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertCharity(Charity instance);
    partial void UpdateCharity(Charity instance);
    partial void DeleteCharity(Charity instance);
    #endregion
		
		public SchedulerDataContext() : 
				base(global::CharityApplication.Properties.Settings.Default.charitySQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Charity> Charities
		{
			get
			{
				return this.GetTable<Charity>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _text;
		
		private System.Nullable<System.DateTime> _start_date;
		
		private System.Nullable<System.DateTime> _end_date;
		
		private string _userID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void Onstart_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onstart_dateChanged();
    partial void Onend_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onend_dateChanged();
    partial void OnuserIDChanging(string value);
    partial void OnuserIDChanged();
    #endregion
		
		public Event()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> start_date
		{
			get
			{
				return this._start_date;
			}
			set
			{
				if ((this._start_date != value))
				{
					this.Onstart_dateChanging(value);
					this.SendPropertyChanging();
					this._start_date = value;
					this.SendPropertyChanged("start_date");
					this.Onstart_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> end_date
		{
			get
			{
				return this._end_date;
			}
			set
			{
				if ((this._end_date != value))
				{
					this.Onend_dateChanging(value);
					this.SendPropertyChanging();
					this._end_date = value;
					this.SendPropertyChanged("end_date");
					this.Onend_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="NVarChar(50)")]
		public string userID
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _userEmail;
		
		private string _userPassword;
		
		private string _userForename;
		
		private string _userSurname;
		
		private System.Nullable<int> _userVolunteer;
		
		private System.Nullable<int> _userStore;
		
		private string _userSkillSet;
		
		private string _userPostcode;
		
		private string _imagePath;
		
		private System.DateTime _userCreation;
		
		private System.Nullable<int> _charityUmbrella;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnuserEmailChanging(string value);
    partial void OnuserEmailChanged();
    partial void OnuserPasswordChanging(string value);
    partial void OnuserPasswordChanged();
    partial void OnuserForenameChanging(string value);
    partial void OnuserForenameChanged();
    partial void OnuserSurnameChanging(string value);
    partial void OnuserSurnameChanged();
    partial void OnuserVolunteerChanging(System.Nullable<int> value);
    partial void OnuserVolunteerChanged();
    partial void OnuserStoreChanging(System.Nullable<int> value);
    partial void OnuserStoreChanged();
    partial void OnuserSkillSetChanging(string value);
    partial void OnuserSkillSetChanged();
    partial void OnuserPostcodeChanging(string value);
    partial void OnuserPostcodeChanged();
    partial void OnimagePathChanging(string value);
    partial void OnimagePathChanged();
    partial void OnuserCreationChanging(System.DateTime value);
    partial void OnuserCreationChanged();
    partial void OncharityUmbrellaChanging(System.Nullable<int> value);
    partial void OncharityUmbrellaChanged();
    #endregion
		
		public User()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userEmail", DbType="NVarChar(50)")]
		public string userEmail
		{
			get
			{
				return this._userEmail;
			}
			set
			{
				if ((this._userEmail != value))
				{
					this.OnuserEmailChanging(value);
					this.SendPropertyChanging();
					this._userEmail = value;
					this.SendPropertyChanged("userEmail");
					this.OnuserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userPassword", DbType="NVarChar(200)")]
		public string userPassword
		{
			get
			{
				return this._userPassword;
			}
			set
			{
				if ((this._userPassword != value))
				{
					this.OnuserPasswordChanging(value);
					this.SendPropertyChanging();
					this._userPassword = value;
					this.SendPropertyChanged("userPassword");
					this.OnuserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userForename", DbType="NVarChar(50)")]
		public string userForename
		{
			get
			{
				return this._userForename;
			}
			set
			{
				if ((this._userForename != value))
				{
					this.OnuserForenameChanging(value);
					this.SendPropertyChanging();
					this._userForename = value;
					this.SendPropertyChanged("userForename");
					this.OnuserForenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userSurname", DbType="NVarChar(50)")]
		public string userSurname
		{
			get
			{
				return this._userSurname;
			}
			set
			{
				if ((this._userSurname != value))
				{
					this.OnuserSurnameChanging(value);
					this.SendPropertyChanging();
					this._userSurname = value;
					this.SendPropertyChanged("userSurname");
					this.OnuserSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userVolunteer", DbType="Int")]
		public System.Nullable<int> userVolunteer
		{
			get
			{
				return this._userVolunteer;
			}
			set
			{
				if ((this._userVolunteer != value))
				{
					this.OnuserVolunteerChanging(value);
					this.SendPropertyChanging();
					this._userVolunteer = value;
					this.SendPropertyChanged("userVolunteer");
					this.OnuserVolunteerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userStore", DbType="Int")]
		public System.Nullable<int> userStore
		{
			get
			{
				return this._userStore;
			}
			set
			{
				if ((this._userStore != value))
				{
					this.OnuserStoreChanging(value);
					this.SendPropertyChanging();
					this._userStore = value;
					this.SendPropertyChanged("userStore");
					this.OnuserStoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userSkillSet", DbType="NVarChar(MAX)")]
		public string userSkillSet
		{
			get
			{
				return this._userSkillSet;
			}
			set
			{
				if ((this._userSkillSet != value))
				{
					this.OnuserSkillSetChanging(value);
					this.SendPropertyChanging();
					this._userSkillSet = value;
					this.SendPropertyChanged("userSkillSet");
					this.OnuserSkillSetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userPostcode", DbType="NVarChar(50)")]
		public string userPostcode
		{
			get
			{
				return this._userPostcode;
			}
			set
			{
				if ((this._userPostcode != value))
				{
					this.OnuserPostcodeChanging(value);
					this.SendPropertyChanging();
					this._userPostcode = value;
					this.SendPropertyChanged("userPostcode");
					this.OnuserPostcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagePath", DbType="NVarChar(250)")]
		public string imagePath
		{
			get
			{
				return this._imagePath;
			}
			set
			{
				if ((this._imagePath != value))
				{
					this.OnimagePathChanging(value);
					this.SendPropertyChanging();
					this._imagePath = value;
					this.SendPropertyChanged("imagePath");
					this.OnimagePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userCreation", DbType="DateTime NOT NULL")]
		public System.DateTime userCreation
		{
			get
			{
				return this._userCreation;
			}
			set
			{
				if ((this._userCreation != value))
				{
					this.OnuserCreationChanging(value);
					this.SendPropertyChanging();
					this._userCreation = value;
					this.SendPropertyChanged("userCreation");
					this.OnuserCreationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityUmbrella", DbType="Int")]
		public System.Nullable<int> charityUmbrella
		{
			get
			{
				return this._charityUmbrella;
			}
			set
			{
				if ((this._charityUmbrella != value))
				{
					this.OncharityUmbrellaChanging(value);
					this.SendPropertyChanging();
					this._charityUmbrella = value;
					this.SendPropertyChanged("charityUmbrella");
					this.OncharityUmbrellaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Charity")]
	public partial class Charity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _charityId;
		
		private string _charityOrganiser;
		
		private string _charityMessage;
		
		private string _charityName;
		
		private string _charityLocation;
		
		private string _charityImage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncharityIdChanging(int value);
    partial void OncharityIdChanged();
    partial void OncharityOrganiserChanging(string value);
    partial void OncharityOrganiserChanged();
    partial void OncharityMessageChanging(string value);
    partial void OncharityMessageChanged();
    partial void OncharityNameChanging(string value);
    partial void OncharityNameChanged();
    partial void OncharityLocationChanging(string value);
    partial void OncharityLocationChanged();
    partial void OncharityImageChanging(string value);
    partial void OncharityImageChanged();
    #endregion
		
		public Charity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int charityId
		{
			get
			{
				return this._charityId;
			}
			set
			{
				if ((this._charityId != value))
				{
					this.OncharityIdChanging(value);
					this.SendPropertyChanging();
					this._charityId = value;
					this.SendPropertyChanged("charityId");
					this.OncharityIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityOrganiser", DbType="NVarChar(50)")]
		public string charityOrganiser
		{
			get
			{
				return this._charityOrganiser;
			}
			set
			{
				if ((this._charityOrganiser != value))
				{
					this.OncharityOrganiserChanging(value);
					this.SendPropertyChanging();
					this._charityOrganiser = value;
					this.SendPropertyChanged("charityOrganiser");
					this.OncharityOrganiserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityMessage", DbType="NVarChar(50)")]
		public string charityMessage
		{
			get
			{
				return this._charityMessage;
			}
			set
			{
				if ((this._charityMessage != value))
				{
					this.OncharityMessageChanging(value);
					this.SendPropertyChanging();
					this._charityMessage = value;
					this.SendPropertyChanged("charityMessage");
					this.OncharityMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityName", DbType="NVarChar(50)")]
		public string charityName
		{
			get
			{
				return this._charityName;
			}
			set
			{
				if ((this._charityName != value))
				{
					this.OncharityNameChanging(value);
					this.SendPropertyChanging();
					this._charityName = value;
					this.SendPropertyChanged("charityName");
					this.OncharityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityLocation", DbType="NVarChar(50)")]
		public string charityLocation
		{
			get
			{
				return this._charityLocation;
			}
			set
			{
				if ((this._charityLocation != value))
				{
					this.OncharityLocationChanging(value);
					this.SendPropertyChanging();
					this._charityLocation = value;
					this.SendPropertyChanged("charityLocation");
					this.OncharityLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_charityImage", DbType="NVarChar(50)")]
		public string charityImage
		{
			get
			{
				return this._charityImage;
			}
			set
			{
				if ((this._charityImage != value))
				{
					this.OncharityImageChanging(value);
					this.SendPropertyChanging();
					this._charityImage = value;
					this.SendPropertyChanged("charityImage");
					this.OncharityImageChanged();
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
