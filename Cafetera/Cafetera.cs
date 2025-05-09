
using System;

namespace Cafetera
{
	/// <summary>
	/// Description of Cafetera.
	/// </summary>
	public class Cafetera
	{
		private int _capacidadMaxima = 0;
		private int _cantidadActual = 0; 
		
		public Cafetera()
		{
			_capacidadMaxima = 1000;
			_cantidadActual = 0;
		}
		
		//                  1500
		public Cafetera(int capacidad) {
			_cantidadActual = capacidad;
			_capacidadMaxima = capacidad;
		}
		
		//                   2000           3000 
		public Cafetera(int capacidad, int cantidad) {
			_cantidadActual = cantidad;
			_capacidadMaxima = capacidad;
			
			if (_cantidadActual > _capacidadMaxima) {
				_cantidadActual = _capacidadMaxima;
			}
		}
		
		public int getCapacidad() {
			return _capacidadMaxima;
		}

		public int getCantidad() {
			return _cantidadActual;
		}
		
		public void setCantidad(int cantidad) {
			_cantidadActual = cantidad;
		}
		
		public void setCapacidad(int capacidad) {
			_capacidadMaxima = capacidad;
		}
		
		public void llenarCafetera() {
			_cantidadActual = _capacidadMaxima;
		}
		
		public int servirTaza(int taza) {
			if (taza <= _cantidadActual) {
				// 400 = 500 - 100 
				// _cantidadActual -= taza;
				_cantidadActual = _cantidadActual - taza;
				return taza;
			}
			
			int aux = _cantidadActual;
			_cantidadActual = 0;
			return aux;
		}
		
		public void vaciarCafetera() {
			_cantidadActual = 0;
		}
		
		public void agregarCafe(int cafe) {
			_cantidadActual = _cantidadActual + cafe;
		}
	}
}
