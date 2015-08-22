/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 22/08/2015
 * Time: 09:51 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class clientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnregresar;
		private System.Windows.Forms.Label lbl_clientes;
		private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.Button btn_buscar;
		private System.Windows.Forms.Button btn_modificar;
		private System.Windows.Forms.Button btn_eliminar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
			this.btnregresar = new System.Windows.Forms.Button();
			this.lbl_clientes = new System.Windows.Forms.Label();
			this.btn_agregar = new System.Windows.Forms.Button();
			this.btn_buscar = new System.Windows.Forms.Button();
			this.btn_eliminar = new System.Windows.Forms.Button();
			this.btn_modificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnregresar
			// 
			this.btnregresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnregresar.AutoSize = true;
			this.btnregresar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.btnregresar.Location = new System.Drawing.Point(600, 250);
			this.btnregresar.Name = "btnregresar";
			this.btnregresar.Size = new System.Drawing.Size(170, 60);
			this.btnregresar.TabIndex = 0;
			this.btnregresar.Text = "REGRESAR";
			this.btnregresar.UseVisualStyleBackColor = true;
			this.btnregresar.Click += new System.EventHandler(this.BtnregresarClick);
			// 
			// lbl_clientes
			// 
			this.lbl_clientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbl_clientes.AutoSize = true;
			this.lbl_clientes.BackColor = System.Drawing.Color.Transparent;
			this.lbl_clientes.Font = new System.Drawing.Font("Century Gothic", 38F, System.Drawing.FontStyle.Bold);
			this.lbl_clientes.Location = new System.Drawing.Point(280, 26);
			this.lbl_clientes.Name = "lbl_clientes";
			this.lbl_clientes.Size = new System.Drawing.Size(241, 60);
			this.lbl_clientes.TabIndex = 1;
			this.lbl_clientes.Text = "CLIENTES";
			this.lbl_clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl_clientes.Click += new System.EventHandler(this.Lbl_clientesClick);
			// 
			// btn_agregar
			// 
			this.btn_agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_agregar.AutoSize = true;
			this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.btn_agregar.Location = new System.Drawing.Point(12, 100);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(170, 60);
			this.btn_agregar.TabIndex = 2;
			this.btn_agregar.Text = "AGREGAR";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.Btn_agregarClick);
			// 
			// btn_buscar
			// 
			this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_buscar.AutoSize = true;
			this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.btn_buscar.Location = new System.Drawing.Point(206, 100);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.Size = new System.Drawing.Size(170, 60);
			this.btn_buscar.TabIndex = 3;
			this.btn_buscar.Text = "BUSCAR";
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.Btn_buscarClick);
			// 
			// btn_eliminar
			// 
			this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_eliminar.AutoSize = true;
			this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.btn_eliminar.Location = new System.Drawing.Point(600, 100);
			this.btn_eliminar.Name = "btn_eliminar";
			this.btn_eliminar.Size = new System.Drawing.Size(170, 60);
			this.btn_eliminar.TabIndex = 5;
			this.btn_eliminar.Text = "ELIMINAR";
			this.btn_eliminar.UseVisualStyleBackColor = true;
			this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminarClick);
			// 
			// btn_modificar
			// 
			this.btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_modificar.AutoSize = true;
			this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_modificar.Location = new System.Drawing.Point(400, 100);
			this.btn_modificar.Name = "btn_modificar";
			this.btn_modificar.Size = new System.Drawing.Size(170, 60);
			this.btn_modificar.TabIndex = 6;
			this.btn_modificar.Text = "MODIFICAR";
			this.btn_modificar.UseVisualStyleBackColor = true;
			this.btn_modificar.Click += new System.EventHandler(this.Btn_modificarClick);
			// 
			// clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btn_modificar);
			this.Controls.Add(this.btn_eliminar);
			this.Controls.Add(this.btn_buscar);
			this.Controls.Add(this.btn_agregar);
			this.Controls.Add(this.lbl_clientes);
			this.Controls.Add(this.btnregresar);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "clientes";
			this.Text = "CLIENTES";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
