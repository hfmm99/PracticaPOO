﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Lote : IProductor
    {
		Cooperativa cooperativa;
		Producto producto { get; set; }

		public Lote(Cooperativa coop)
		{
			cooperativa = coop;

		}

		public void Cultivar(Producto producto)
		{
			this.producto = producto;
			cooperativa.Gastar(producto.Precio);
		}

		public void Producir(Producto producto)
		{
			this.producto = producto;

			cooperativa.Gastar(producto.Precio);
		}
	}
}
