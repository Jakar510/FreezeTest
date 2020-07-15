using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreezeTest.Views
{
	public class SettingsViewPage : ContentPage
	{
		public SettingsViewPage()
		{
			Content = new SettingsView();
		}
	}
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsView : StackLayout
	{
		public SettingsView()
		{
			InitializeComponent();
		}
	}
}