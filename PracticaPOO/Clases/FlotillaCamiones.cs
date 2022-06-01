using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO.Clases
{
    public class FlotillaCamiones
    {
        List<Camión> flotilla;

        public FlotillaCamiones()
        {
            flotilla = new List<Camión>();
        }

        public void AdquirirCamión()
        {
            flotilla.Add(new Camión());
        }
    }
}
