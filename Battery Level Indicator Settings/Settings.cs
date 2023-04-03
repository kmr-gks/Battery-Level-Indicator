using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Popups;

namespace Battery_Level_Indicator_Settings
{
	public partial class Settings : Form
	{
		Properties.Settings data = Properties.Settings.Default;
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
			data.autostart = checkBoxAutostart.Checked;
			if (checkBoxAutostart.Checked)
			{
				//スタートアップに登録
				// StartupTaskオブジェクトを得る
			}
		}

		private void buttonIndicatorStart_Click(object sender, EventArgs e)
		{
			var newForm = new ParcentForm();
			//メインフォームを残量表示フォームに変更
			MainClass.mainApplicationContext.MainForm = newForm;
			newForm.Show();
		}

		private void Settings_FormClosed(object sender, FormClosedEventArgs e)
		{
			data.Save();
		}

		private void radioButtonPosition_CheckedChanged(object sender, EventArgs e)
		{
			//チェックが外されたとき、付いたとき2回呼ばれる。
			var radioButton = sender as RadioButton;
			//外れたときは何もしない
			if (radioButton == null || radioButton.Checked == false) return;
			if (radioButton.Text == radioButtonLeftTop.Text)
			{
				data.indicatorX = 100;
				data.indicatorY = 100;
			}
			else
			if (radioButton.Text == radioButtonLeftBottom.Text)
			{
				data.indicatorX = 100;
				data.indicatorY = 800;
			}
			else
			if (radioButton.Text == radioButtonRightTop.Text)
			{
				data.indicatorX = 800;
				data.indicatorY = 100;
			}
			else
			if (radioButton.Text == radioButtonRightBottom.Text)
			{
				data.indicatorX = 800;
				data.indicatorY = 800;
			}
			if (radioButton.Text == radioButtonPosCustom.Text)
			{
				numericPosX.Enabled = true;
				numericPosY.Enabled = true;
				data.indicatorX = (int)numericPosX.Value;
				data.indicatorY = (int)numericPosY.Value;
			}
			else
			{
				numericPosX.Enabled = false;
				numericPosY.Enabled = false;
			}
			//MessageBox.Show(radioButton.Text + "\n" + radioButton.Checked);
		}

		private void numericPos_ValueChanged(object sender, EventArgs e)
		{
			var box = sender as NumericUpDown;
			if (box == null) return;
			if (box.Name == numericPosX.Name)
			{
				data.indicatorX = (int)box.Value;
			}
			else if (box.Name == numericPosY.Name)
			{
				data.indicatorY = (int)box.Value;
			}
		}
	}
}
