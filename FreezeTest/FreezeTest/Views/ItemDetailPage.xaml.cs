using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FreezeTest.Models;
using FreezeTest.ViewModels;

namespace FreezeTest.Views
{
	public class ItemDetailPage : ContentPage
	{
		public ItemDetailPage(ItemDetailViewModel viewModel)
		{
			Content = new ItemDetailView(viewModel);
		}
		public ItemDetailPage()
		{
			Content = new ItemDetailView();
		}
	}
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class ItemDetailView : ContentView
	{
		ItemDetailViewModel _viewModel;

		public ItemDetailView(ItemDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this._viewModel = viewModel;
		}

		public ItemDetailView()
		{
			InitializeComponent();

			var item = new Item
			{
				Text = "Item 1",
				Description = "This is an item description."
			};

			_viewModel = new ItemDetailViewModel(item);
			BindingContext = _viewModel;
		}
	}
}