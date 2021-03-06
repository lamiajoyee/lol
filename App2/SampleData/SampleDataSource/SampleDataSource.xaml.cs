﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Blend.SampleData.SampleDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SampleDataSource { }
#else

	public class SampleDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/SampleDataSource/SampleDataSource.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private GroupCollection _Groups = new GroupCollection();

		public GroupCollection Groups
		{
			get
			{
				return this._Groups;
			}
		}

		private rotation _rotation = new rotation();

		public rotation rotation
		{
			get
			{
				return this._rotation;
			}
		}
	}

	public class GroupCollection : System.Collections.ObjectModel.ObservableCollection<Group>
	{ 
	}

	public class Group : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private ItemCollection _Items = new ItemCollection();

		public ItemCollection Items
		{
			get
			{
				return this._Items;
			}
		}

		private string _playername = string.Empty;

		public string playername
		{
			get
			{
				return this._playername;
			}

			set
			{
				if (this._playername != value)
				{
					this._playername = value;
					this.OnPropertyChanged("playername");
				}
			}
		}

		private string _primary = string.Empty;

		public string primary
		{
			get
			{
				return this._primary;
			}

			set
			{
				if (this._primary != value)
				{
					this._primary = value;
					this.OnPropertyChanged("primary");
				}
			}
		}

		private string _playertitle = string.Empty;

		public string playertitle
		{
			get
			{
				return this._playertitle;
			}

			set
			{
				if (this._playertitle != value)
				{
					this._playertitle = value;
					this.OnPropertyChanged("playertitle");
				}
			}
		}

		private Windows.UI.Xaml.Media.ImageSource _img = null;

		public Windows.UI.Xaml.Media.ImageSource img
		{
			get
			{
				return this._img;
			}

			set
			{
				if (this._img != value)
				{
					this._img = value;
					this.OnPropertyChanged("img");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}

	public class Item : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _att = string.Empty;

		public string att
		{
			get
			{
				return this._att;
			}

			set
			{
				if (this._att != value)
				{
					this._att = value;
					this.OnPropertyChanged("att");
				}
			}
		}

		private string _def = string.Empty;

		public string def
		{
			get
			{
				return this._def;
			}

			set
			{
				if (this._def != value)
				{
					this._def = value;
					this.OnPropertyChanged("def");
				}
			}
		}

		private string _abi = string.Empty;

		public string abi
		{
			get
			{
				return this._abi;
			}

			set
			{
				if (this._abi != value)
				{
					this._abi = value;
					this.OnPropertyChanged("abi");
				}
			}
		}

		private string _diff = string.Empty;

		public string diff
		{
			get
			{
				return this._diff;
			}

			set
			{
				if (this._diff != value)
				{
					this._diff = value;
					this.OnPropertyChanged("diff");
				}
			}
		}
	}

	public class rotation : System.Collections.ObjectModel.ObservableCollection<rotationItem>
	{ 
	}

	public class rotationItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _player_name = string.Empty;

		public string player_name
		{
			get
			{
				return this._player_name;
			}

			set
			{
				if (this._player_name != value)
				{
					this._player_name = value;
					this.OnPropertyChanged("player_name");
				}
			}
		}

		private Windows.UI.Xaml.Media.ImageSource _rotation_img = null;

		public Windows.UI.Xaml.Media.ImageSource rotation_img
		{
			get
			{
				return this._rotation_img;
			}

			set
			{
				if (this._rotation_img != value)
				{
					this._rotation_img = value;
					this.OnPropertyChanged("rotation_img");
				}
			}
		}
	}
#endif
}
