using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Lechería : Granja //, IProductor
    {
		Cooperativa cooperativa;

		public Lechería(string nombre, int cantidad, Cooperativa coop):base(nombre, Enums.TipoProducto.Leche, cantidad)
		{
			cooperativa = coop;
		}

		/*
		public void Producir(Producto producto)
		{
			this.producto = producto;
			cooperativa.Gastar(producto.Precio);
		}
		*/
	}
}
