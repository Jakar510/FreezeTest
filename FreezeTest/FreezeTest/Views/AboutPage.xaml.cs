using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreezeTest.Views
{
	public class AboutPage : ContentPage
	{
		public AboutPage()
		{
			Content = new AboutPageView();
		}
	}
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class AboutPageView : ContentView
	{
		public AboutPageView()
		{
			InitializeComponent();
		}
	}
}