/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 22/08/2015
 * Time: 10:49 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class AgregarClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
			this.btn_regresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_regresar
			// 
			this.btn_regresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_regresar.AutoSize = true;
			this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_regresar.Location = new System.Drawing.Point(300, 150);
			this.btn_regresar.Name = "btn_regresar";
			this.btn_regresar.Size = new System.Drawing.Size(170, 60);
			this.btn_regresar.TabIndex = 0;
			this.btn_regresar.Text = "REGRESAR";
			this.btn_regresar.UseVisualStyleBackColor = true;
			this.btn_regresar.Click += new System.EventHandler(this.Btn_regresarClick);
			// 
			// AgregarClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btn_regresar);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AgregarClientes";
			this.Text = "AgregarClientes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
