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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

	

		private void button1_MouseHover(object sender, EventArgs e)
		{


		}
		Events events = new Events();
		Allpins allpins = new Allpins();
		Settings settings = new Settings();
		private void button2_Click(object sender, EventArgs e)
		{
			events.Visible = true;
			allpins.Visible = false;
			settings.Visible = false;

			lbl_description.Visible = false;
			lbl_email.Visible = false;
			lbl_name.Visible = false;
			lbl_profile.Visible = false;
			 btn_follow.Visible = false;

			lbl_topic.Text = "Events";
		
			events.Location = new Point(10,40);
	
			lbl_Header.Controls.Add(events);
			
		}

		private void lbl_Header_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			lbl_description.Visible = true;
			lbl_email.Visible = true;
			lbl_name.Visible = true;
			lbl_profile.Visible = true;
			btn_follow.Visible = true;
			lbl_topic.Text = "Person Account";
			events.Visible = false;
			allpins.Visible = false;
			settings.Visible = false;

		}

		private void button3_Click(object sender, EventArgs e)
		{
			allpins.Visible = true;
			settings.Visible = false;
			events.Visible = false;
			lbl_description.Visible = false;
			lbl_email.Visible = false;
			lbl_name.Visible = false;
			lbl_profile.Visible = false;
			btn_follow.Visible = false;
			events.Visible = false;
			lbl_topic.Text = "All Pins";

			events.Location = new Point(10, 40);

			lbl_Header.Controls.Add(allpins);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			settings.Visible = true;
			allpins.Visible = false;
			events.Visible = false;

			lbl_description.Visible = false;
			lbl_email.Visible = false;
			lbl_name.Visible = false;
			lbl_profile.Visible = false;
			btn_follow.Visible = false;
			events.Visible = false;
			lbl_topic.Text = "Settings";

			events.Location = new Point(10, 40);

			lbl_Header.Controls.Add(settings);
		}
	}
}
