using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
	public class ItemViewModel : INotifyPropertyChanged
	{
		public ItemViewModel( int categoryId)
		{
			this.ItemCollection = new ObservableCollection<Item>( );

			for( int i = 0; i < 4; i++)
			{
				this.ItemCollection.Add( new Item( ) { Name = $"V1-{categoryId}", Description = $"c{categoryId}/T1 rocks"});
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{		
			ArgumentNullException.ThrowIfNull(e);
			PropertyChanged?.Invoke(this, e);
		}

		public ObservableCollection<Item> ItemCollection	{ get; set; }
	}
}
