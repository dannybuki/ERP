/*
 * Creado por SharpDevelop.
 * Usuario: Pablo
 * Fecha: 10/8/2015
 * Hora: 19:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ERP
{
	partial class VentaNew
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txtfecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txthora;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txtfolio;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_regresar;
		private System.Windows.Forms.Button btn_nuevo;
		private System.Windows.Forms.Button btn_guardar;
		private System.Windows.Forms.TextBox txtsubtotal;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtiva;
		private System.Windows.Forms.Label total;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaNew));
			this.label1 = new System.Windows.Forms.Label();
			this.txtfecha = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txthora = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtfolio = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.total = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtiva = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtsubtotal = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_regresar = new System.Windows.Forms.Button();
			this.btn_nuevo = new System.Windows.Forms.Button();
			this.btn_guardar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtfecha
			// 
			this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfecha.Location = new System.Drawing.Point(91, 16);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(142, 29);
			this.txtfecha.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Hora:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txthora
			// 
			this.txthora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txthora.Location = new System.Drawing.Point(91, 47);
			this.txthora.Name = "txthora";
			this.txthora.Size = new System.Drawing.Size(142, 29);
			this.txthora.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Folio:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtfolio
			// 
			this.txtfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfolio.Location = new System.Drawing.Point(91, 76);
			this.txtfolio.Name = "txtfolio";
			this.txtfolio.Size = new System.Drawing.Size(142, 29);
			this.txtfolio.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSize = true;
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtfolio);
			this.groupBox1.Controls.Add(this.txtfecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txthora);
			this.groupBox1.Location = new System.Drawing.Point(533, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 122);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(197, 29);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cliente:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.AutoSize = true;
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.total);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtiva);
			this.groupBox2.Controls.Add(this.txtTotal);
			this.groupBox2.Controls.Add(this.txtsubtotal);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(515, 248);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			this.groupBox2.Enter += new System.EventHandler(this.GroupBox2Enter);
			// 
			// total
			// 
			this.total.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total.Location = new System.Drawing.Point(103, 200);
			this.total.Name = "total";
			this.total.Size = new System.Drawing.Size(100, 23);
			this.total.TabIndex = 15;
			this.total.Text = "total";
			this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(103, 156);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "IVA";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(103, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "subtotal";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtiva
			// 
			this.txtiva.Location = new System.Drawing.Point(209, 161);
			this.txtiva.Name = "txtiva";
			this.txtiva.Size = new System.Drawing.Size(300, 20);
			this.txtiva.TabIndex = 12;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(209, 200);
			this.txtTotal.MinimumSize = new System.Drawing.Size(300, 30);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(300, 20);
			this.txtTotal.TabIndex = 11;
			this.txtTotal.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// txtsubtotal
			// 
			this.txtsubtotal.Location = new System.Drawing.Point(209, 105);
			this.txtsubtotal.MinimumSize = new System.Drawing.Size(300, 30);
			this.txtsubtotal.Name = "txtsubtotal";
			this.txtsubtotal.Size = new System.Drawing.Size(300, 30);
			this.txtsubtotal.TabIndex = 10;
			this.txtsubtotal.TextChanged += new System.EventHandler(this.TxtsubtotalTextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(209, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(300, 31);
			this.textBox2.TabIndex = 9;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(209, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 31);
			this.textBox1.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(197, 29);
			this.label5.TabIndex = 7;
			this.label5.Text = "Número de cliente:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_regresar
			// 
			this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_regresar.AutoSize = true;
			this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_regresar.Location = new System.Drawing.Point(566, 175);
			this.btn_regresar.MaximumSize = new System.Drawing.Size(200, 150);
			this.btn_regresar.Name = "btn_regresar";
			this.btn_regresar.Size = new System.Drawing.Size(200, 85);
			this.btn_regresar.TabIndex = 8;
			this.btn_regresar.Text = "REGRESAR";
			this.btn_regresar.UseVisualStyleBackColor = true;
			this.btn_regresar.Click += new System.EventHandler(this.Btn_regresarClick);
			// 
			// btn_nuevo
			// 
			this.btn_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_nuevo.AutoSize = true;
			this.btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_nuevo.Location = new System.Drawing.Point(50, 275);
			this.btn_nuevo.Name = "btn_nuevo";
			this.btn_nuevo.Size = new System.Drawing.Size(165, 56);
			this.btn_nuevo.TabIndex = 9;
			this.btn_nuevo.Text = "NUEVO";
			this.btn_nuevo.UseVisualStyleBackColor = true;
			this.btn_nuevo.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn_guardar
			// 
			this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_guardar.AutoSize = true;
			this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_guardar.Location = new System.Drawing.Point(356, 275);
			this.btn_guardar.Name = "btn_guardar";
			this.btn_guardar.Size = new System.Drawing.Size(165, 56);
			this.btn_guardar.TabIndex = 10;
			this.btn_guardar.Text = "GUARDAR";
			this.btn_guardar.UseVisualStyleBackColor = true;
			this.btn_guardar.Click += new System.EventHandler(this.Btn_guardarClick);
			// 
			// VentaNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btn_guardar);
			this.Controls.Add(this.btn_nuevo);
			this.Controls.Add(this.btn_regresar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "VentaNew";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Venta Nueva";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.VentaNuevaLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
