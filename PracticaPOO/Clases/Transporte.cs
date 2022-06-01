using PracticaPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Clases
{
   public class Transporte
    {
        public  TipoTransporte Tipo{ get; set; }
        public string Duracion { get; set; }
        Dictionary<int,Producto> Productos { get; set; }



    }
}
