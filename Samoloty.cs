using System;
namespace LiniaLotnicza
{
	public abstract class Samolot
	{
		protected double Zasieg;
		protected string Id;
		protected int LiczbaMiejsc;
	public Samolot(double zasieg, string id, int liczbamiejsc) {
			if (zasieg <= 0)
				throw new ZasiegException("Zasieg nie moze byc mniejszy od zera.");
			if (liczbamiejsc <= 0)
				throw new LiczbaMiejscException("Liczba miejsc nie moze byc mniejszy od zera.");
			this.Zasieg = zasieg;
			this.Id = id;
			this.LiczbaMiejsc = liczbamiejsc; }
		public Samolot(Samolot s)
        {
			this.Zasieg = s.getZasieg();
			this.Id = s.getId();
			this.LiczbaMiejsc = s.getLiczbaMiejsc();
        }
		public double getZasieg() { return this.Zasieg; }
		public string getId(){return this.Id; }
		public int getLiczbaMiejsc() { return this.LiczbaMiejsc; }
		public bool porownajSamolot(Samolot s)
        {
			return (this.Id == s.getId() && this.Zasieg == s.getZasieg() && this.LiczbaMiejsc == s.getLiczbaMiejsc());
		}
}
	public class Dlugodystansowy : Samolot
	{
		public Dlugodystansowy(double zasieg, string id, int liczbamiejsc) : base(zasieg, id, liczbamiejsc) { }
	}
	public class Sredniodystansowy : Samolot
	{
		public Sredniodystansowy(double zasieg, string id, int liczbamiejsc) : base(zasieg, id, liczbamiejsc) { }
	}
	public class Regionalny : Samolot
	{
		public Regionalny(double zasieg, string id, int liczbamiejsc) : base(zasieg, id, liczbamiejsc) { }
	}
	public class SamolotException : Exception { }
	public class ZasiegException : SamolotException { }
	public class LiczbaMiejscException : SamolotException { }


}

