using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FreezeTest.Views
{
	public class NavStackTest : ContentPage
	{
		public int Count { get; private set; }

		public NavStackTest() => Init();
		private void Init()
		{
			Count = 0;
			NewPageCommand = new Command(async () => await TryNavigation().ConfigureAwait(true));

			Content = new StackLayout
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					 new Label
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 VerticalTextAlignment = TextAlignment.Center,
						 HorizontalTextAlignment = TextAlignment.Center,
						 FontSize = 30,
						 Text = $"Home Page ID: {Count}"
					 },
					 new Button
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 FontSize = 20,
						 Command = new Command(async () => await Navigation.PushAsync(new SubPage(this, Count)).ConfigureAwait(true)),
						 Text = "Add Page",
					 },
				 }
			};
		}

		public Command NewPageCommand { get; set; }
		public SubPage NewPage { get; set; }
		protected override void OnAppearing()
		{
			base.OnAppearing();
			NewPageCommand?.Execute(this);
		}
		private async Task TryNavigation()
		{
			{
				if ( NewPage is null ) return;

				try
				{
					await Navigation.PushAsync(NewPage).ConfigureAwait(true);
				}
				catch ( Exception e )
				{
					Console.WriteLine(e);
				}
				finally
				{
					NewPage = null;
				}
			}
		}
	}
	public class SubPage : ContentPage
	{
		private NavStackTest _HomePage { get; set; }
		public int Count { get; private set; }

		public SubPage( NavStackTest page, int count ) => Init(page, count);

		private void Init( NavStackTest page, int count )
		{
			_HomePage = page ?? throw new ArgumentNullException(nameof(page));
			count++;
			Count = count;
			Init();
		}
		private void Init()
		{
			Content = new StackLayout
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					 new Label
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 VerticalTextAlignment = TextAlignment.Center,
						 HorizontalTextAlignment = TextAlignment.Center,
						 FontSize = 30,
						 Text = $"Page ID: {Count}"
					 },
					 new Button
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 FontSize = 20,
						 Command = new Command(async () => await Navigation.PushAsync(new SubPage(_HomePage, Count)).ConfigureAwait(true)),
						 Text = "Add Page",
					 },
					 new Button
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 FontSize = 20,
						 Command = new Command(async () => await Navigation.PopAsync().ConfigureAwait(true)),
						 Text = "Remove Page",
					 },
					 new Button
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 FontSize = 20,
						 Command = new Command(async () => await Navigation.PopToRootAsync().ConfigureAwait(true)),
						 Text = "Go To Root",
					 },
					 new Button
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 FontSize = 20,
						 Command = new Command(async () =>
						 {
							 await Navigation.PopToRootAsync().ConfigureAwait(true);
							 await Navigation.PushAsync(new SubPage(_HomePage, Count)).ConfigureAwait(true);
						 }),
						 Text = "Go To Root, then add page",
					 },
					 new Button
					 {
						 HorizontalOptions = LayoutOptions.FillAndExpand,
						 VerticalOptions = LayoutOptions.FillAndExpand,
						 FontSize = 20,
						 Command = new Command(async () =>
						 {
							 _HomePage.NewPage = new SubPage(_HomePage, Count);
							 await Navigation.PopToRootAsync().ConfigureAwait(true);
						 }),
						 Text = "Workaround",
					 }
				 }
			};
		}
	}
}