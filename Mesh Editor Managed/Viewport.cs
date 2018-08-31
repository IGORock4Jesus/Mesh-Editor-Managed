using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesh_Editor_Managed
{
	public partial class Viewport : UserControl
	{
		Renderer renderer;

		public Viewport()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
		}

		private void Viewport_Load(object sender, EventArgs e)
		{
			renderer = new Renderer(this);
		}

		private void Viewport_Paint(object sender, PaintEventArgs e)
		{
			renderer.Render();
		}

		protected override void OnHandleDestroyed(EventArgs e)
		{
			renderer.Dispose();

			base.OnHandleDestroyed(e);
		}
	}
}
