using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FreezeTest.Droid
{
	[Activity(Label = "FreezeTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		internal static MainActivity Instance { get; private set; }
		protected override void OnCreate(Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);
			//LibVLCSharp.Forms.Shared.LibVLCSharpFormsRenderer.Init();
			//LibVLCSharp.Shared.Core.Initialize();
			LibVLCSharp.Forms.Platforms.Android.Platform.Init(this);
			global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
			Xamarin.Forms.Forms.SetFlags("MediaElement_Experimental");
			Xamarin.Forms.Forms.Init(this, savedInstanceState);

			Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);
			Plugin.NFC.CrossNFC.Init(this);
			Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			ZXing.Net.Mobile.Forms.Android.Platform.Init();
			AiForms.Renderers.Droid.SettingsViewInit.Init();
			Acr.UserDialogs.UserDialogs.Init(this);
			//MediaManager.CrossMediaManager.Current.Init();

			Instance = this; 
			LoadApplication(new App());
		}
		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
		{
			//global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}
		protected override void OnNewIntent(Android.Content.Intent intent)
		{
			base.OnNewIntent(intent);

			// Plugin NFC: Tag Discovery Interception
			Plugin.NFC.CrossNFC.OnNewIntent(intent);
		}
	}
}