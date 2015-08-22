/*
 * Created by SharpDevelop.
 * User: Daniel Rivas
 * Date: 11/08/2015
 * Time: 12:02 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP
{
	/// <summary>
	/// Description of VentaNew.
	/// </summary>
	public partial class VentaNew : Form
	{
		public VentaNew()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void VentaNuevaLoad(object sender, EventArgs e)
		{
			DateTime estedia = DateTime.Today;
			txtfecha.Text = estedia.ToString("d");
			txthora.Text = DateTime.Now.ToString("hh:mm:ss");
		}
		void Btn_regresarClick(object sender, EventArgs e)
		{
			PantallaPrincipal x=new PantallaPrincipal();
			this.Hide();
			x.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			VentaNew v=new VentaNew();
			v.Show();
			this.Hide();
		}
		void Btn_guardarClick(object sender, EventArgs e)
		{
			try{
					string MyConnection3 = "datasource=localhost;database=erpbd;username=root;password=";
					string Query = "INSERT INTO venta VALUES(null,'" + txtfecha.Text + "','" + txthora.Text +"','" +
						textBox1.Text + "','" + txtsubtotal.Text + "','" + txtiva.Text + "','" + txtTotal.Text +"');";
					MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
					MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
            		MyConn3.Open();
            		int resultado = MyCommand3.ExecuteNonQuery();
            		MyConn3.Close();
            		if(resultado > 0)
            		{
            			MessageBox.Show("Venta registrada con éxito.");
            		}
            		else
            		{
            			MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            		}
			   }
			catch (Exception ex)
			{
				MessageBox.Show("error" + ex.ToString());
			}
		}
		void TxtsubtotalTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void GroupBox2Enter(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}
