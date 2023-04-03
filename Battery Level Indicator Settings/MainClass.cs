namespace Battery_Level_Indicator_Settings
{
	internal static class MainClass
	{

		public static ApplicationContext mainApplicationContext = new ApplicationContext();

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static int Main(string[] args)
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			if (args.Length == 0 )
			{
				//ˆø”‚È‚µ:İ’è‰æ–Ê
				mainApplicationContext.MainForm = new Settings();
				Application.Run(mainApplicationContext);
			}
			else if (args.Length == 2)
			{
				//ˆø”‚ª”š2ŒÂ:c—Ê•\¦
				try
				{
					var x = int.Parse(args[0]);
					var y = int.Parse(args[1]);
					mainApplicationContext.MainForm = new ParcentForm(x, y);
					Application.Run(mainApplicationContext);
				}
				catch (Exception)
				{
					return -1;
				}

			}
			return 0;
		}
	}
}