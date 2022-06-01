using PracticaPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticaPOO.Program;

namespace PracticaPOO
{
public class Semilla : ProdVegetal
    {
		public Enums.Semilla Tipo { get; set; }

		public Semilla() : base("Semilla", 100, 1) { }

		public Semilla(Enums.Semilla tipo) : this()
		{
			this.Tipo = tipo;
		}
	}
}
