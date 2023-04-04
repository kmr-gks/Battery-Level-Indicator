using System.Runtime.InteropServices;
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


		private void checkBoxAutostart_CheckedChanged(object sender, EventArgs e)
		{
			data.autostart = checkBoxAutostart.Checked;
			var startupDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

			var lnkPath = startupDir + "\\Battery Level Indicator.lnk";
			if (checkBoxAutostart.Checked)
			{
				//スタートアップに登録
				//https://cammy.co.jp/technical/c_shortcut/

				var targetPath = Application.ExecutablePath;

				// WshShellを作成
				var t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8"));
				dynamic shell = Activator.CreateInstance(t);

				//WshShortcutを作成
				var shortcut = shell.CreateShortcut(lnkPath);

				//リンク先
				shortcut.TargetPath = targetPath;
				//アイコンのパス
				shortcut.IconLocation = Application.ExecutablePath + ",0";

				// 引数
				shortcut.Arguments = "/indicator";
				// 作業フォルダ
				shortcut.WorkingDirectory = Application.StartupPath;
				// 実行時の大きさ 1が通常、3が最大化、7が最小化
				shortcut.WindowStyle = 1;
				// コメント
				shortcut.Description = "Battery Level Indicator Auto-start";

				//ショートカットを作成
				shortcut.Save();

				//後始末
				Marshal.FinalReleaseComObject(shortcut);
				Marshal.FinalReleaseComObject(shell);
			}
			else
			{
				File.Delete(lnkPath);
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
				data.indicatorY = area.Bottom - controlHeight;
			}
			else
			if (radioButton.Text == radioButtonRightTop.Text)
			{
				data.indicatorX = area.Right - controlWidth;
				data.indicatorY = area.Top;
			}
			else
			if (radioButton.Text == radioButtonRightBottom.Text)
			{
				data.indicatorX = area.Right - controlWidth;
				data.indicatorY = area.Bottom - controlHeight;
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
			if (box == null || !radioButtonPosCustom.Checked) return;
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

		private void buttonAboutStartup_Click(object sender, EventArgs e)
		{
			MessageBox.Show("If the checkbox is on, the Indicator runs at Windows startup, and a shortcut will be created in\n"+Environment.GetFolderPath(Environment.SpecialFolder.Startup), "About startup");
		}
	}
}
