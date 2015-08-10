/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 10/08/2015
 * Time: 10:58 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// Description of construccion.
	/// </summary>
	public partial class construccion : Form
	{
		public construccion()
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
			PantallaPrincipal x=new PantallaPrincipal();
			this.Hide();
			x.Show();
		}
	}
}
