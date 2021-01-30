using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
	public partial class Settings : UserControl
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		DialogResult x = MessageBox.Show("Your Account will active and you Can Get other Function","Setting Up", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (x == DialogResult.Yes) {
				MessageBox.Show("Setting Up has been Succesfully");
			}
		}
	}
}
