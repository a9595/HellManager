using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HellManager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//InitializeDb();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new HellManager());
		}

		
	}
}
