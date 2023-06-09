using Windows.Devices.Power;

namespace ParcentDisplayer
{
	public partial class ParcentForm : Form
	{
		public ParcentForm(int x, int y) : this()
		{
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(x, y);
		}
		public ParcentForm()
		{
			InitializeComponent();

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
				/*
				var g = CreateGraphics();
				g.DrawString(text, new Font("MS UI Gothic", 10), Brushes.Black, 0, 0);
				g.Dispose();
				*/
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

		private void setTextParcent()
		{

			PowerStatus powerStatus = SystemInformation.PowerStatus;
			string text = (int)(powerStatus.BatteryLifePercent * 100) + "%";
			Invoke((MethodInvoker)delegate
			{
				labelParcent.Text = text;
				//フォームに直接描画する
				/*
				var g = CreateGraphics();
				g.DrawString(text, new Font("MS UI Gothic", 10), Brushes.Black, 0, 0);
				g.Dispose();
				*/
			});

		}
	}
}