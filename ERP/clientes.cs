/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 22/08/2015
 * Time: 09:51 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// Description of clientes.
	/// </summary>
	public partial class clientes : Form
	{
		public clientes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnregresarClick(object sender, EventArgs e)
		{
			PantallaPrincipal x=new PantallaPrincipal();
			this.Hide();
			x.Show();
		}
		void Lbl_clientesClick(object sender, EventArgs e)
		{
	
		}
			
			
		void Btn_agregarClick(object sender, EventArgs e)
		{
			AgregarClientes ac=new AgregarClientes();
			this.Hide();
			ac.Show();
		}
		void Btn_buscarClick(object sender, EventArgs e)
		{
			BuscarClientes bc=new BuscarClientes();
			this.Hide();
			bc.Show();
		}
		
		void Btn_eliminarClick(object sender, EventArgs e)
		{
			EliminarClientes ec=new EliminarClientes();
			this.Hide();
			ec.Show();
		}
		void Btn_modificarClick(object sender, EventArgs e)
		{
			ModificarClientes mc=new ModificarClientes();
			this.Hide();
			mc.Show();
		}
	}
}
