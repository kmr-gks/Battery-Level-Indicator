using Microsoft.Win32;

namespace ParcentDisplayer
{
	public partial class ParcentForm : Form
	{
		private BatteryChargeStatus batteryChargeStatus;
		public ParcentForm()
		{
			InitializeComponent();
			batteryChargeStatus = new BatteryChargeStatus();
			setTextParcent();
		}

		private void setTextParcent(){
			PowerStatus powerStatus = SystemInformation.PowerStatus;
			textBoxParcent.Text = powerStatus.BatteryLifePercent*100 + "%";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}