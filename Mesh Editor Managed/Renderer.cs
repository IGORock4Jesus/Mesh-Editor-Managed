using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.Direct3D9;
using System.Threading;

namespace Mesh_Editor_Managed
{
	public partial class Renderer : IDisposable
	{
		Direct3D direct;
		Device device;
		private Task task;
		private bool runned;
		private readonly Control control;

		public delegate void RenderHandler(Renderer control);
		public event RenderHandler Drawing, BeforeReset, AfterReset;

		internal void Render()
		{
			device.Clear(ClearFlags.All, new SharpDX.Color(control.BackColor.R, control.BackColor.G, control.BackColor.B), 1.0f, 0);
			device.BeginScene();

			Drawing?.Invoke(this);

			device.EndScene();
			device.Present();
		}

		public Renderer(Control control)
		{
			this.control = control;

			direct = new Direct3D();
			device = new Device(direct, 0, DeviceType.Hardware, control.Handle,
				CreateFlags.HardwareVertexProcessing /*| CreateFlags.Multithreaded*/,
				new PresentParameters
				{
					AutoDepthStencilFormat = Format.D24S8,
					BackBufferCount = 1,
					BackBufferFormat = Format.A8R8G8B8,
					BackBufferHeight = control.ClientSize.Height,
					BackBufferWidth = control.ClientSize.Width,
					DeviceWindowHandle = control.Handle,
					EnableAutoDepthStencil = true,
					SwapEffect = SwapEffect.Discard,
					Windowed = true
				});

			//runned = true;
			//task = Task.Run(new Action(Rendering));

		}

		private void Rendering()
		{
			while (runned)
			{
				Render();

				Thread.Sleep(10);
			}
		}

		public void Dispose()
		{
			runned = false;
			//task.Wait();
		}
	}
}
