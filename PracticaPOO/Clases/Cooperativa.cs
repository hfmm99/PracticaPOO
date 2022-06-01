namespace PracticaPOO
{
    public class Cooperativa
    {
		public decimal Dinero { get; set; }

		public bool Gastar(decimal monto)
		{
			if (Dinero > monto)
			{
				Dinero -= monto;
			}

			return false;
		}
	}
}
