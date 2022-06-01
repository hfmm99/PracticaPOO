using PracticaPOO.Enums;

namespace PracticaPOO
{
    public class Granja
    {
        public string Nombre { get; private set; }

        public TipoProducto Tipo { get; private set; }

        /// <summary>Capacidad de Producción</summary>
        public int Capacidad { get; private set; }

        public Granja(string nombre, TipoProducto tipo, int cantidadAnimales)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Capacidad = cantidadAnimales;
        }

        public void AumentarCapacidadGranja(int incremento = 1)
        {
            Capacidad += incremento;
        }

        public void Colectar()
        {

        }

        public void AlimentarAnimales()
        {

        }
    }
}
