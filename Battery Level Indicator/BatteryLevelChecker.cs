using System;
using System.Threading.Tasks;
using Windows.Devices.Power;

namespace Battery_Level_Indicator
{
	public class BatteryReportHandler
	{
		public event Action<BatteryReport> ReportUpdated;

		public async Task Start()
		{
			var aggregateBattery = Battery.AggregateBattery;
			aggregateBattery.ReportUpdated += AggregateBattery_ReportUpdated;

			await Task.CompletedTask;
		}

		private void AggregateBattery_ReportUpdated(Battery sender, object args)
		{
			var report = sender.GetReport();
			ReportUpdated?.Invoke(report);

		}
	}
}