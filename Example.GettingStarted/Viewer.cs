using System;
using Forms = System.Windows.Forms;
using Settings = Kean.Platform.Settings;

namespace Example.GettingStarted
{
	public class Viewer : 
		Forms.UserControl
	{
		Imint.Vidview.Viewer vidview;

		public Viewer()
		{
			this.InitializeComponent();
		}

		void InitializeComponent()
		{
			this.vidview = new Imint.Vidview.Viewer();
			this.SuspendLayout();
			// 
			// viewer
			// 
			this.vidview.Asynchronous = Settings.Asynchronous.SetNotify;
			this.vidview.Arguments = "-r telnet://:23";
			this.vidview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vidview.Location = new System.Drawing.Point(0, 0);
			this.vidview.Name = "viewer";
			this.vidview.SeparateProcess = false;
			this.vidview.Size = new System.Drawing.Size(800, 600);
			this.vidview.TabIndex = 0;

			this.Controls.Add(this.vidview);
			this.ResumeLayout(false);
		}
	}
}
