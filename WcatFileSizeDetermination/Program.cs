using System;
using System.Windows.Forms;

namespace WcatFileSizeDetermination
{
    internal static class Program
	{
		[STAThread]
		private static void Main(string[] agrs)
        {
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
