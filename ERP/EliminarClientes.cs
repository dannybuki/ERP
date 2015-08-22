/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 22/08/2015
 * Time: 11:14 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// Description of EliminarClientes.
	/// </summary>
	public partial class EliminarClientes : Form
	{
		public EliminarClientes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_regresarClick(object sender, EventArgs e)
		{
			clientes c=new clientes();
			this.Hide();
			c.Show();
		}
	}
}
