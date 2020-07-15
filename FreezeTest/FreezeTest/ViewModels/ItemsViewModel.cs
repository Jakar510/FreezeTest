using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using FreezeTest.Models;
using FreezeTest.Views;

namespace FreezeTest.ViewModels
{
	public class ItemsViewModel : BaseViewModel
	{
		public ObservableCollection<Item> Items { get; set; }
		public Command LoadItemsCommand { get; set; }

		public ItemsViewModel()
		{
			Title = "Browse";
			Items = new ObservableCollection<Item>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand().ConfigureAwait(true));

			MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
			{
				var newItem = item as Item;
				Items.Add(newItem);
				await DataStore.AddItemAsync(newItem).ConfigureAwait(true);
			});
		}

		async Task ExecuteLoadItemsCommand()
		{
			IsBusy = true;

			try
			{
				Items.Clear();
				IEnumerable<Item> items = await DataStore.GetItemsAsync(true).ConfigureAwait(true);
				foreach ( Item item in items )
				{
					Items.Add(item);
				}
			}
			catch ( Exception ex )
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}