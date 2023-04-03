using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Popups;

namespace Battery_Level_Indicator_Settings
{
	public partial class Settings : Form
	{
		Properties.Settings data = Properties.Settings.Default;
		public Settings()
		{
			InitializeComponent();

			//UIの初期化
			//自動起動チェックボックスの状態を読み込む
			checkBoxAutostart.Checked = data.autostart;
			foreach (var radioButton in new RadioButton[] { radioButtonLeftTop, radioButtonLeftBottom, radioButtonRightTop, radioButtonRightBottom, radioButtonPosCustom })
			{
				if (radioButton.Text == data.radioPosSelect)
				{
					radioButton.Checked = true;
				}
			}
			numericPosX.Value = data.customX;
			numericPosY.Value = data.customY;
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
			var newForm = ParcentForm.Create();
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

			//デスクトップ画面の解像度(タスクバー除く)を取得
			var area = Screen.GetWorkingArea(this);
			//%表示ウィンドウのサイズを指定する
			var controlWidth = 40;
			var controlHeight = 20;
			data.radioPosSelect = radioButton.Text;
			if (radioButton.Text == radioButtonLeftTop.Text)
			{
				data.indicatorX = area.Left;
				data.indicatorY = area.Top;
			}
			else
			if (radioButton.Text == radioButtonLeftBottom.Text)
			{
				data.indicatorX = area.Left;
				data.indicatorY = area.Bottom-controlHeight;
			}
			else
			if (radioButton.Text == radioButtonRightTop.Text)
			{
				data.indicatorX = area.Right-controlWidth;
				data.indicatorY = area.Top;
			}
			else
			if (radioButton.Text == radioButtonRightBottom.Text)
			{
				data.indicatorX = area.Right- controlWidth;
				data.indicatorY = area.Bottom-controlHeight;
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
		}

		private void numericPos_ValueChanged(object sender, EventArgs e)
		{
			var box = sender as NumericUpDown;
			if (box == null) return;
			if (box.Name == numericPosX.Name)
			{
				data.customX = box.Value;
				data.indicatorX = (int)box.Value;
			}
			else if (box.Name == numericPosY.Name)
			{
				data.customY = (int)box.Value;
				data.indicatorY = (int)box.Value;
			}
		}
	}
}
