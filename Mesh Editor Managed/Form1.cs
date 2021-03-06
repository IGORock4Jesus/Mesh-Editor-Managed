﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesh_Editor_Managed
{
	public partial class Form1 : Form
	{
		Random random;

		public Form1()
		{
			InitializeComponent();
			random = new Random(Environment.TickCount);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage tabPage = new TabPage("Новый файл");
			var viewport = new Viewport { BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)) };
			tabPage.Controls.Add(viewport);

			fileTabs.TabPages.Add(tabPage);
		}
	}
}
