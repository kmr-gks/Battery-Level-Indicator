namespace ParcentDisplayer
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static int Main(string[] args)
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			ApplicationConfiguration.Initialize();
			if (args.Length == 2) {
				try
				{
					var x = int.Parse(args[0]);
					var y = int.Parse(args[1]);
					Application.Run(new ParcentForm(x, y));
				}catch (Exception)
				{
					return -1;
				}

			}
			else{
				Application.Run(new ParcentForm());
			}

			return 0;
		}
	}
}