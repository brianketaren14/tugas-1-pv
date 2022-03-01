/*
 * Created by SharpDevelop.
 * User: User
 * Date: 15/12/2021
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator
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
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			txtAngka1.Clear();
			txtAngka2.Clear();
			lblHasil.Text = "";
		}		
		void Button2Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text)){
				MessageBox.Show("Angka 1 dan angka 2 harus diisi terlebih dahulu");
			} else {
				float a,b,c;
				a = float.Parse(this.txtAngka1.Text);
				b = float.Parse(this.txtAngka2.Text);
				c = a+b;
				this.lblHasil.Text = c.ToString();
				tambahRIwayat(a,b,c,'+');
			}	
		}
		
		void BtnKurangClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text)){
				MessageBox.Show("Angka 1 dan angka 2 harus diisi terlebih dahulu");
			} else {
				float a,b,c;
				a = float.Parse(this.txtAngka1.Text);
				b = float.Parse(this.txtAngka2.Text);
				c = a-b;
				this.lblHasil.Text = c.ToString();
				tambahRIwayat(a,b,c,'-');
			}
		}
		
		void BtnKaliClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text)){
				MessageBox.Show("Angka 1 dan angka 2 harus diisi terlebih dahulu");
			} else {
				float a,b,c;
				a = float.Parse(this.txtAngka1.Text);
				b = float.Parse(this.txtAngka2.Text);
				c = a*b;
				this.lblHasil.Text = c.ToString();
				tambahRIwayat(a,b,c,'*');
			}			
		}
		
		void BtnBagiClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text)){
				MessageBox.Show("Angka 1 dan angka 2 harus diisi terlebih dahulu");
			} else {
				float a,b,c;
				a = float.Parse(this.txtAngka1.Text);
				b = float.Parse(this.txtAngka2.Text);
				c = a/b;
				this.lblHasil.Text = c.ToString();
				tambahRIwayat(a,b,c,'/');
			}			
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtAngka1.Clear();
			txtAngka2.Clear();
			lblHasil.Text = "";
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void tambahRIwayat(float a, float b, float c, char operasi){
			riwayatKalkulator.Items.Add(a+" "+operasi+" "+b+" = "+c);
		}
		


	}
}
