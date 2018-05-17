using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.DeviceInfo;

namespace InfoCollectPOC
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			GetDeviceInfo();
            
		}

		void GetDeviceInfo()
		{
			lblID.Text += CrossDeviceInfo.Current.Id;
			lblIdiom.Text += CrossDeviceInfo.Current.Idiom.ToString();
			lblModel.Text += CrossDeviceInfo.Current.Model;
			lblPlatform.Text += CrossDeviceInfo.Current.Platform;
			lblVersion.Text += CrossDeviceInfo.Current.Version;
			lblVersionNum.Text += CrossDeviceInfo.Current.VersionNumber;
			lblIsDevice.Text += CrossDeviceInfo.Current.IsDevice;
		}
	}
}
