﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieReviews.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="moviereviews")]
	public partial class MovieDB : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertReview(Review instance);
    partial void UpdateReview(Review instance);
    partial void DeleteReview(Review instance);
    #endregion
		
		public MovieDB() : 
				base(global::MovieReviews.Properties.Settings.Default.moviereviewsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDB(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDB(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDB(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDB(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<Review> Reviews
		{
			get
			{
				return this.GetTable<Review>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.movies")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieID;
		
		private string _Title;
		
		private System.DateTime _ReleaseDate;
		
		private EntitySet<Review> _Reviews;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnReleaseDateChanging(System.DateTime value);
    partial void OnReleaseDateChanged();
    #endregion
		
		public Movie()
		{
			this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="movie_id", Storage="_MovieID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="title", Storage="_Title", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="release_date", Storage="_ReleaseDate", DbType="DateTime NOT NULL")]
		public System.DateTime ReleaseDate
		{
			get
			{
				return this._ReleaseDate;
			}
			set
			{
				if ((this._ReleaseDate != value))
				{
					this.OnReleaseDateChanging(value);
					this.SendPropertyChanging();
					this._ReleaseDate = value;
					this.SendPropertyChanged("ReleaseDate");
					this.OnReleaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_Review", Storage="_Reviews", ThisKey="MovieID", OtherKey="MovieID")]
		public EntitySet<Review> Reviews
		{
			get
			{
				return this._Reviews;
			}
			set
			{
				this._Reviews.Assign(value);
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
		
		private void attach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reviews")]
	public partial class Review : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReviewID;
		
		private int _MovieID;
		
		private string _Summary;
		
		private int _Rating;
		
		private string _Body;
		
		private string _Reviewer;
		
		private EntityRef<Movie> _Movie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReviewIDChanging(int value);
    partial void OnReviewIDChanged();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnRatingChanging(int value);
    partial void OnRatingChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnReviewerChanging(string value);
    partial void OnReviewerChanged();
    #endregion
		
		public Review()
		{
			this._Movie = default(EntityRef<Movie>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="review_id", Storage="_ReviewID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ReviewID
		{
			get
			{
				return this._ReviewID;
			}
			set
			{
				if ((this._ReviewID != value))
				{
					this.OnReviewIDChanging(value);
					this.SendPropertyChanging();
					this._ReviewID = value;
					this.SendPropertyChanged("ReviewID");
					this.OnReviewIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="movie_id", Storage="_MovieID", DbType="Int NOT NULL")]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="summary", Storage="_Summary", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this.OnSummaryChanging(value);
					this.SendPropertyChanging();
					this._Summary = value;
					this.SendPropertyChanged("Summary");
					this.OnSummaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rating", Storage="_Rating", DbType="Int NOT NULL")]
		public int Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="review", Storage="_Body", DbType="NVarChar(512) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="reviewer", Storage="_Reviewer", DbType="NVarChar(64)")]
		public string Reviewer
		{
			get
			{
				return this._Reviewer;
			}
			set
			{
				if ((this._Reviewer != value))
				{
					this.OnReviewerChanging(value);
					this.SendPropertyChanging();
					this._Reviewer = value;
					this.SendPropertyChanged("Reviewer");
					this.OnReviewerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_Review", Storage="_Movie", ThisKey="MovieID", OtherKey="MovieID", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.Reviews.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.Reviews.Add(this);
						this._MovieID = value.MovieID;
					}
					else
					{
						this._MovieID = default(int);
					}
					this.SendPropertyChanged("Movie");
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
