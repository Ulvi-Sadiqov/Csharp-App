using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
	public partial class RegisterLoginWindow : Form
	{
		public RegisterLoginWindow()
		{
			InitializeComponent();
		}

		private void register_Click(object sender, EventArgs e)
		{
			label_name.Text = "";
			label_surname.Text = "";
			label_age.Text = "";
			label_email.Text = "";
			label_password.Text = "";

		}
	}
}
