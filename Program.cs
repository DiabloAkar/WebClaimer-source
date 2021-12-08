using System;
using System.Windows.Forms;

namespace AramaM0t0ru
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000B0A5 File Offset: 0x000092A5
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
