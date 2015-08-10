/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 10/08/2015
 * Time: 10:37 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class venta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_regresar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venta));
			this.btn_regresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_regresar
			// 
			this.btn_regresar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_regresar.Location = new System.Drawing.Point(0, 319);
			this.btn_regresar.MaximumSize = new System.Drawing.Size(200, 50);
			this.btn_regresar.Name = "btn_regresar";
			this.btn_regresar.Size = new System.Drawing.Size(200, 50);
			this.btn_regresar.TabIndex = 0;
			this.btn_regresar.Text = "REGRESAR";
			this.btn_regresar.UseVisualStyleBackColor = true;
			this.btn_regresar.Click += new System.EventHandler(this.Btn_regresarClick);
			// 
			// venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(435, 369);
			this.Controls.Add(this.btn_regresar);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "venta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "venta";
			this.ResumeLayout(false);

		}
	}
}
