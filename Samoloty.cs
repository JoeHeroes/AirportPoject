using System;
namespace LiniaLotnicza
{
	public abstract class Samolot
	{
		protected double Zasieg;
		protected string Id;
		protected int LiczbaMiejsc;
		public Samolot() { }
		public Samolot(double zasieg, string id, int liczbamiejsc) {
			if (zasieg <= 0)
				throw new ZasiegException("Zasieg nie moze byc mniejszy od zera.");
			if (liczbamiejsc <= 0)
				throw new LiczbaMiejscException("Liczba miejsc nie moze byc mniejsza od zera.");
			this.Zasieg = zasieg;
			this.Id = id;
			this.LiczbaMiejsc = liczbamiejsc; }
		public double getZasieg() { return this.Zasieg; }
		public string getId(){return this.Id; }
		public int getLiczbaMiejsc() { return this.LiczbaMiejsc; }
		public override bool Equals(Object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				Samolot s = (Samolot)obj;
				return (this.Id == s.getId() && this.Zasieg == s.getZasieg() && this.LiczbaMiejsc == s.getLiczbaMiejsc());
			}
		}
	}
	public class Dlugodystansowy : Samolot
	{
		public Dlugodystansowy(double zasieg, string id, int liczbamiejsc) : base(zasieg, id, liczbamiejsc)
		{
		}
	}
	public class Sredniodystansowy : Samolot
	{
		public Sredniodystansowy(double zasieg, string id, int liczbamiejsc) : base(zasieg, id, liczbamiejsc)
		{
		}
	}
	public class Regionalny : Samolot
	{
		public Regionalny(double zasieg, string id, int liczbamiejsc) : base(zasieg, id, liczbamiejsc)
		{
		}
	}
	public class SamolotException : Exception 
	{
		public SamolotException(string msg) : base(msg) { }
	}
	public class ZasiegException : SamolotException 
	{
		public ZasiegException(string msg) : base(msg) { }
	}
	public class LiczbaMiejscException : SamolotException 
	{
		public LiczbaMiejscException(string msg) : base(msg) { }
	}

}

