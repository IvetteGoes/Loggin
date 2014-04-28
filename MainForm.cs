/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 18/04/2014
 * Time: 10:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Aceros8DeJulio;




namespace Aceros8DeJulio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtnomTextChanged(object sender, EventArgs e)
		{
			
		}
		
		private void BtnentrarClick(object sender, EventArgs e)
		{
			if(txtnom.Text=="aceros8dejulio@sample.com")
			{
				if(txtcontra.Text=="123456")
				{
					Menu abrir = new Menu();
					abrir.Show();
					
					this.Hide();
				}
				else
				{
					MessageBox.Show("Contraseña incorrecta");
				}
				 
			}
			else {
				MessageBox.Show("Ususario incorrecto");
			}
		}
	}
}
