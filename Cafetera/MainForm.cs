using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cafetera
{
	public partial class MainForm : Form
	{
		Cafetera cafetera_1;
		Cafetera cafetera_2;
		Cafetera cafetera_3;
		
		public MainForm()
		{
			InitializeComponent();
			
			cafetera_1 = new Cafetera();
			cafetera_2 = new Cafetera(1500);
			cafetera_3 = new Cafetera(2000, 3000);
			
			progressBar1.Value = cafetera_3.getCantidad();
			label1.Text = cafetera_3.getCantidad().ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			cafetera_3.llenarCafetera();
			progressBar1.Value = cafetera_3.getCantidad();
			label1.Text = cafetera_3.getCantidad().ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string aux = textBox1.Text;
			int cantidad = int.Parse(aux);
			int taza = cafetera_3.servirTaza(cantidad);
			
			progressBar1.Value = cafetera_3.getCantidad();
			label1.Text = cafetera_3.getCantidad().ToString();
			
			if (cantidad != taza) {
				MessageBox.Show("no alcanza");
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			cafetera_3.vaciarCafetera();
			
			progressBar1.Value = cafetera_3.getCantidad();
			label1.Text = cafetera_3.getCantidad().ToString();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string aux = textBox2.Text;
			int cantidad = int.Parse(aux);
			
			int cantidadCafetera = cafetera_3.getCantidad();
			int capacidadCafetera = cafetera_3.getCapacidad();
			int total = cantidadCafetera + cantidad;
			
			if (total <= capacidadCafetera) {
				cafetera_3.agregarCafe(cantidad);
				progressBar1.Value = cafetera_3.getCantidad();
				label1.Text = cafetera_3.getCantidad().ToString();
			}
		}
	}
}
