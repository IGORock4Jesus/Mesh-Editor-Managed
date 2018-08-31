using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesh_Editor_Managed
{
	class Camera
	{
		Vector3 position, right, up, front;

		public Camera()
		{
			position = new Vector3();
			right = new Vector3(1, 0, 0);
			up = new Vector3(0, 1, 0);
			front = new Vector3(0, 0, 1);
		}

		void Render(Renderer renderer)
		{

		}
	}
}
