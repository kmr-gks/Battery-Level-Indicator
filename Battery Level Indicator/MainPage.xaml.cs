using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace Battery_Level_Indicator
{
	/// <summary>
	/// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
			App.Current.Suspending += OnSuspending;

			//UIの初期化
			ApplicationDataContainer container = ApplicationData.Current.LocalSettings;
			if (container.Values.ContainsKey(toggleSwitchEnable.Name)){
				toggleSwitchEnable.IsOn = (bool)container.Values[toggleSwitchEnable.Name];
			}
			container.Values[toggleSwitchEnable.Name] = toggleSwitchEnable.IsOn;
		}

		private void OnSuspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
		{
			//現在の状態を保存

			ApplicationDataContainer container = ApplicationData.Current.LocalSettings;
			container.Values[toggleSwitchEnable.Name] = toggleSwitchEnable.IsOn;
		}

		private async void toggleSwitchEnable_Toggled(object sender, RoutedEventArgs e)
		{
			if (toggleSwitchEnable.IsOn) {
				//残量表示を有効にする
				CoreApplicationView newView = CoreApplication.CreateNewView();

				int id = 0;
				await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
				{
					var frame = new Frame();
					//frame.Navigate(typeof(AnotherPage));

					Window.Current.Content = frame;
					Window.Current.Activate();
					id = ApplicationView.GetForCurrentView().Id;
				});

				await ApplicationViewSwitcher.TryShowAsStandaloneAsync(id);
			}
		}
	}
}
