using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Popups;

namespace Battery_Level_Indicator_Settings
{
	public partial class Settings : Form
	{
		Properties.Settings data=Properties.Settings.Default;
		// マニフェストで指定したTaskId
		private const string StartUpTaskId = "blisstartupId";
		public Settings()
		{
			InitializeComponent();

			//UIの初期化
			//自動起動チェックボックスの状態を読み込む
			checkBoxAutostart.Checked = data.autostart;
		}

		private async void checkBoxAutostart_CheckedChanged(object sender, EventArgs e)
		{
			data.autostart= checkBoxAutostart.Checked;
			data.Save();
		}

		private void buttonIndicatorStart_Click(object sender, EventArgs e)
		{
			var newForm = new ParcentForm(100, 100);
			//メインフォームを残量表示フォームに変更
			MainClass.mainApplicationContext.MainForm = newForm;
			newForm.Show();
		}
	}
}
