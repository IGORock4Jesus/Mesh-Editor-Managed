﻿namespace Mesh_Editor_Managed
{
	partial class Viewport
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Viewport
			// 
			this.Name = "Viewport";
			this.Size = new System.Drawing.Size(596, 412);
			this.Load += new System.EventHandler(this.Viewport_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Viewport_Paint);
			this.ResumeLayout(false);

		}

		#endregion
	}
}