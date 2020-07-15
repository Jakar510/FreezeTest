using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FreezeTest.Models;
using FreezeTest.Views;
using FreezeTest.ViewModels;

namespace FreezeTest.Views
{
	public class ItemsPage : ContentPage
	{
		private ItemsPageView _view;
		protected override void OnAppearing()
		{
			base.OnAppearing();
			_view.OnAppearing();
		}

		public ItemsPage()
		{
			Content = _view = new ItemsPageView();
		}
	}
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class ItemsPageView : ContentView
	{
		ItemsViewModel _viewModel;

		public ItemsPageView()
		{
			InitializeComponent();

			BindingContext = _viewModel = new ItemsViewModel();
		}

		async void OnItemSelected(object sender, EventArgs args)
		{
			var layout = (BindableObject) sender;
			var item = (Item) layout.BindingContext;
			await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item))).ConfigureAwait(true);
		}

		async void AddItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new NavigationPage(new NewItemPage())).ConfigureAwait(true);
		}

		public void OnAppearing()
		{
			if ( _viewModel.Items.Count == 0 )
				_viewModel.IsBusy = true;
		}
	}
}