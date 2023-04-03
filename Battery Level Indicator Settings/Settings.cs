using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battery_Level_Indicator_Settings
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void checkBoxAutostart_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void buttonIndicatorStart_Click(object sender, EventArgs e)
		{
			var newForm = new ParcentForm(100, 100);
			//メインフォームを残量表示フォームに変更
			MainClass.mainApplicationContext.MainForm = newForm;
			newForm.Show();
		}
	}
}
