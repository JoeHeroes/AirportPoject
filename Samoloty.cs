using System;
namespace LiniaLotnicza
{
	public abstract class Samolot
	{
		protected double Zasieg;
		protected string Id;
		protected int LiczbaMiejsc
	public Samolot(double zasieg, string id, int liczbamiejsc) {
			if (zasieg <= 0)
				throw new ZasiegException("Zasieg nie moze byc mniejszy od zera.");
			if (liczbamiejsc <= 0)
				throw new LiczbaMiejscException("Liczba miejsc nie moze byc mniejszy od zera.");
			this.Zasieg = zasieg; 
			this.Id = id; 
			this.LiczbaMiejsc = liczbamiejsc; }
		public double getZasieg(return this.Zasieg;)
	public string getId(return this.Id;)
}
	public class Dlugodystansowy : Samolot
	{ }
	public class Sredniodystansowy : Samolot
	{ }
	public class Regionalny : Samolot
	{ }
	public class SamolotException : Exception { }
	public class ZasiegException : SamolotException { }
	public class LiczbaMiejscException : SamolotException { }


}

