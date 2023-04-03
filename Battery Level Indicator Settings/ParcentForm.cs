using Windows.Devices.Power;

namespace Battery_Level_Indicator_Settings
{
	public partial class ParcentForm : Form
	{
		private static ParcentForm instance = null;
		private static Properties.Settings data = Properties.Settings.Default;

		//フォームの二重起動を阻止する コンストラクタの代わり
		public static ParcentForm Create(int x, int y)
		{
			if (instance != null)
			{
				//Close()すると例外
				instance.Hide();
			}
			instance = new ParcentForm(x, y);
			return instance;
		}

		public static ParcentForm Create()
		{
			return Create(data.indicatorX, data.indicatorY);
		}

		private ParcentForm(int x, int y)
		{
			InitializeComponent();

			//位置変更
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(x, y);

			//右クリックメニューを登録
			contextMenuMain.Items.Add("Refresh", null, (a, b) => { this.setTextParcent(); });
			contextMenuMain.Items.Add("Exit", null, (a, b) => { this.Close(); });

			Battery.AggregateBattery.ReportUpdated += Battery_ReportUpdated;

			//UIスレッドから呼び出すと例外が発生する
			try
			{
				PowerStatus powerStatus = SystemInformation.PowerStatus;
				string text = (int)(powerStatus.BatteryLifePercent * 100) + "%";
				labelParcent.Text = text;
			}
			catch (Exception ex)
			{
				puts(ex.Message + ex.Source);
			}
		}

		private void Battery_ReportUpdated(Battery sender, object args)
		{
			string now = DateTime.Now.ToString("H:mm:ss");
			puts("parcent" + now);
			try
			{
				setTextParcent();
			}
			catch (Exception ex)
			{
				puts(ex.Message + ex.Source);
			}
		}

		public static void puts(string str)
		{
			System.Diagnostics.Debug.WriteLine(str);
		}

		public static void showException(Exception exception)
		{
			MessageBox.Show(exception.Message + "\n" + exception.StackTrace);
		}

		private void setTextParcent()
		{
			PowerStatus powerStatus = SystemInformation.PowerStatus;
			string text = (int)(powerStatus.BatteryLifePercent * 100) + "%";
			Invoke((MethodInvoker)delegate
			{
				labelParcent.Text = text;
			});

		}
	}
}
