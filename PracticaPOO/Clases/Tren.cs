namespace PracticaPOO.Clases
{
    public class Tren : Transporte
    {
        Producto[] productos;

        public int CantidadVagones { get; private set; }

        public Tren(int vagones)
        {
            CantidadVagones = vagones;
            productos = new Producto[CantidadVagones];
        }
    }
}
