/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 6/8/2015
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class PantallaPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button cmdregresar;
		private System.Windows.Forms.Label lblpaleteria;
		private System.Windows.Forms.Label lblicepro;
		private System.Windows.Forms.Button btn_empleados;
		private System.Windows.Forms.Button btn_proveedores;
		private System.Windows.Forms.Button btn_inventario;
		private System.Windows.Forms.Button btn_venta;
		private System.Windows.Forms.Button btn_clientes;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
			this.cmdregresar = new System.Windows.Forms.Button();
			this.lblpaleteria = new System.Windows.Forms.Label();
			this.lblicepro = new System.Windows.Forms.Label();
			this.btn_empleados = new System.Windows.Forms.Button();
			this.btn_proveedores = new System.Windows.Forms.Button();
			this.btn_inventario = new System.Windows.Forms.Button();
			this.btn_venta = new System.Windows.Forms.Button();
			this.btn_clientes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdregresar
			// 
			this.cmdregresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdregresar.AutoSize = true;
			this.cmdregresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdregresar.Location = new System.Drawing.Point(694, 43);
			this.cmdregresar.MaximumSize = new System.Drawing.Size(90, 29);
			this.cmdregresar.Name = "cmdregresar";
			this.cmdregresar.Size = new System.Drawing.Size(90, 29);
			this.cmdregresar.TabIndex = 0;
			this.cmdregresar.Text = "Sign Out";
			this.cmdregresar.UseVisualStyleBackColor = true;
			this.cmdregresar.Click += new System.EventHandler(this.CmdregresarClick);
			// 
			// lblpaleteria
			// 
			this.lblpaleteria.AutoSize = true;
			this.lblpaleteria.BackColor = System.Drawing.Color.Transparent;
			this.lblpaleteria.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblpaleteria.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpaleteria.ForeColor = System.Drawing.Color.Chocolate;
			this.lblpaleteria.Location = new System.Drawing.Point(0, 0);
			this.lblpaleteria.Name = "lblpaleteria";
			this.lblpaleteria.Size = new System.Drawing.Size(382, 41);
			this.lblpaleteria.TabIndex = 1;
			this.lblpaleteria.Text = "Paleteria Loma Bonita";
			this.lblpaleteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblicepro
			// 
			this.lblicepro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblicepro.AutoSize = true;
			this.lblicepro.BackColor = System.Drawing.Color.Transparent;
			this.lblicepro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblicepro.ForeColor = System.Drawing.Color.Sienna;
			this.lblicepro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblicepro.Location = new System.Drawing.Point(613, 0);
			this.lblicepro.Name = "lblicepro";
			this.lblicepro.Size = new System.Drawing.Size(171, 40);
			this.lblicepro.TabIndex = 2;
			this.lblicepro.Text = "ICEPRO v1.0";
			this.lblicepro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblicepro.UseCompatibleTextRendering = true;
			// 
			// btn_empleados
			// 
			this.btn_empleados.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_empleados.AutoSize = true;
			this.btn_empleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_empleados.Location = new System.Drawing.Point(25, 121);
			this.btn_empleados.Name = "btn_empleados";
			this.btn_empleados.Size = new System.Drawing.Size(154, 61);
			this.btn_empleados.TabIndex = 3;
			this.btn_empleados.Text = "EMPLEADOS";
			this.btn_empleados.UseVisualStyleBackColor = true;
			this.btn_empleados.Click += new System.EventHandler(this.Btn_empleadosClick);
			// 
			// btn_proveedores
			// 
			this.btn_proveedores.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_proveedores.AutoSize = true;
			this.btn_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_proveedores.Location = new System.Drawing.Point(613, 187);
			this.btn_proveedores.Name = "btn_proveedores";
			this.btn_proveedores.Size = new System.Drawing.Size(154, 61);
			this.btn_proveedores.TabIndex = 6;
			this.btn_proveedores.Text = "PROVEEDORES";
			this.btn_proveedores.UseVisualStyleBackColor = true;
			this.btn_proveedores.Click += new System.EventHandler(this.Btn_proveedoresClick);
			// 
			// btn_inventario
			// 
			this.btn_inventario.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_inventario.AutoSize = true;
			this.btn_inventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_inventario.Location = new System.Drawing.Point(613, 254);
			this.btn_inventario.Name = "btn_inventario";
			this.btn_inventario.Size = new System.Drawing.Size(154, 61);
			this.btn_inventario.TabIndex = 7;
			this.btn_inventario.Text = "INVENTARIO";
			this.btn_inventario.UseVisualStyleBackColor = true;
			this.btn_inventario.Click += new System.EventHandler(this.Btn_inventarioClick);
			// 
			// btn_venta
			// 
			this.btn_venta.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_venta.AutoSize = true;
			this.btn_venta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_venta.Location = new System.Drawing.Point(25, 254);
			this.btn_venta.Name = "btn_venta";
			this.btn_venta.Size = new System.Drawing.Size(154, 60);
			this.btn_venta.TabIndex = 8;
			this.btn_venta.Text = "VENTA";
			this.btn_venta.UseVisualStyleBackColor = true;
			this.btn_venta.Click += new System.EventHandler(this.Btn_ventaClick);
			// 
			// btn_clientes
			// 
			this.btn_clientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_clientes.AutoSize = true;
			this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clientes.Location = new System.Drawing.Point(613, 121);
			this.btn_clientes.Name = "btn_clientes";
			this.btn_clientes.Size = new System.Drawing.Size(154, 60);
			this.btn_clientes.TabIndex = 9;
			this.btn_clientes.Text = "CLIENTES";
			this.btn_clientes.UseVisualStyleBackColor = true;
			this.btn_clientes.Click += new System.EventHandler(this.Btn_clientesClick);
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btn_clientes);
			this.Controls.Add(this.btn_venta);
			this.Controls.Add(this.btn_inventario);
			this.Controls.Add(this.btn_proveedores);
			this.Controls.Add(this.btn_empleados);
			this.Controls.Add(this.lblicepro);
			this.Controls.Add(this.lblpaleteria);
			this.Controls.Add(this.cmdregresar);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "PantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PantallaPrincipal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PantallaPrincipalLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
