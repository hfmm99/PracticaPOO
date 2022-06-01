using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PracticaPOO
{
    public class ProdAnimal:Producto
    {
		/// <summary>Tiempo de Producción</summary>
		public override int Tiempo { get; set; }

		public ProdAnimal(string nombre, decimal precio, int tiempoProduccion) : base(nombre, precio)
		{
			Tiempo = tiempoProduccion;
		}
	}
}
