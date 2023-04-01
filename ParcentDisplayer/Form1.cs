
using System.Windows.Forms;
using Windows.Devices.Power;
using Windows.System;
using Windows.System.Power;

namespace ParcentDisplayer
{
	public partial class ParcentForm : Form
	{
		public ParcentForm()
		{
			InitializeComponent();
			var aggb = Battery.AggregateBattery;
			aggb.ReportUpdated += Battery_ReportUpdated;

			//UIスレッドから呼び出すと例外が発生する
			//setTextParcent();
			textBoxParcent.Text = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100) + "%";
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

		private void puts(string str)
		{
			System.Diagnostics.Debug.WriteLine(str);
		}

		private void setTextParcent(string str = null)
		{

			PowerStatus powerStatus = SystemInformation.PowerStatus;
			Invoke((MethodInvoker)delegate { textBoxParcent.Text = powerStatus.BatteryLifePercent * 100 + "%" + str; });
		}

		private void textBoxParcent_TextChanged(object sender, EventArgs e)
		{

		}
	}
}