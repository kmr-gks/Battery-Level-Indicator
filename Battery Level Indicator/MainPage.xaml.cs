using System;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace Battery_Level_Indicator
{
	/// <summary>
	/// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
	/// </summary>
	public sealed partial class MainPage : Page
	{
		// マニフェストで指定したTaskId
		const string StartUpTaskId = "blistartupId";

		public MainPage()
		{
			this.InitializeComponent();
			App.Current.Suspending += OnSuspending;

			//UIの初期化
			ApplicationDataContainer container = ApplicationData.Current.LocalSettings;
			if (container.Values.ContainsKey(toggleSwitchEnable.Name))
			{
				toggleSwitchEnable.IsOn = (bool)container.Values[toggleSwitchEnable.Name];
			}
		}

		public static void puts(string str)
		{
			System.Diagnostics.Debug.WriteLine(str);
		}

		private void OnSuspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
		{
			//現在の状態を保存

			ApplicationDataContainer container = ApplicationData.Current.LocalSettings;
			container.Values[toggleSwitchEnable.Name] = toggleSwitchEnable.IsOn;
		}

		private async void toggleSwitchEnable_Toggled(object sender, RoutedEventArgs e)
		{
			// StartupTaskオブジェクトを得る
			StartupTask startupTask = await StartupTask.GetAsync(StartUpTaskId);
			if (toggleSwitchEnable.IsOn)
			{
				//createIndicator();

				// 自動起動を要求する
				StartupTaskState state = await startupTask.RequestEnableAsync();
			}
			else
			{
				startupTask.Disable();
			}
			SetupAutoStartupToggle();
		}

		private async void SetupAutoStartupToggle()
		{
			// StartupTaskオブジェクトを得る
			StartupTask startupTask = await StartupTask.GetAsync(StartUpTaskId);

			// StartupTaskの状態に応じてToggleSwitchの状態を設定する
			switch (startupTask.State)
			{
				case StartupTaskState.Disabled:
					// トグル OFF、変更可能
					textBlockAutoStartSetting.Text = "Autostart is disabled, I'll demand.";
					break;
				case StartupTaskState.DisabledByUser:
					// トグル OFF、変更不可
					textBlockAutoStartSetting.Text = "Enable startup in task manager.";
					break;
				case StartupTaskState.DisabledByPolicy:
					// トグル OFF、変更不可
					textBlockAutoStartSetting.Text = "Autostart is disabled due to group policy.";
					break;
				case StartupTaskState.Enabled:
					// トグル ON、変更可能
					textBlockAutoStartSetting.Text = "Autostart is enabled";
					createIndicator();
					break;
				case StartupTaskState.EnabledByPolicy:
					// トグル ON、変更不可
					textBlockAutoStartSetting.Text = "Autostart is enabled due to group policy";
					createIndicator();
					break;
			}
		}


		public static async void createIndicator()
		{

			//残量表示を有効にする
			Frame rootFrame = Window.Current.Content as Frame;
			if (rootFrame == null)
			{
				rootFrame = new Frame();
				Window.Current.Content = rootFrame;
			}
			string payload = string.Empty;
			rootFrame.Navigate(typeof(parcent), payload);
			Window.Current.Activate();

			//ウィンドウ最前面表示
			//await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay);
		}
	}
}