using System;
namespace LiniaLotnicza
{
	public abstract class Klient
	{
		protected string Id;
		public Klient() { }
		public Klient(string id)
		{
			if (id <= 0)
				throw new IdException("Id nie może byc mniejsze równe 0.");
			this.Id = id;
		}
		public string getId() { return this.Id; }
		public override bool Equals(Object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				Klient k = (Klient)obj;
				return (this.Id == k.getId());
			}
		}
	}
	public class Indywidualny : Klient
	{
		public string Imie;
		public string Nazwisko;
		public string Narodowosc;
		public int Wiek;
		public Indywidualny() { }
		public Indywidualny(string imie, string nazwisko, string narodowosc, int wiek) : base(id)
		{
			if (wiek < 0)
				throw new WiekException("Wiek nie może być ujemny.");
			this.Imie = imie;
			this.Nazwisko = nazwisko;
			this.Narodowosc = narodowosc;
			this.Wiek = wiek;
		}
		public string getImie() { return this.Imie; }
		public string getNazwisko() { return this.Nazwisko; }
		public int getWiek() { return this.Wiek; }
		public override bool Equals(Object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				Indywidualny i = (Indywidualny)obj;
				return (this.Imie == i.getImie() && this.getNazwisko == i.getNazwisko(), this.getWiek == i.getWiek());  ///Nie wiem co tutaj jest źle -> do poprawy jak ktoś wie, jeśli jest coś źle
			}
		}
	}

	
	public class PosrednikFirmy : Klient
	{
		public string NazwaFirmy;
		public PosrednikFirmy() { }
		public PosrednikFirmy(string nazwafirmy) : base(id)
		{
			this.NazwaFirmy = nazwafirmy;
		}
        public string getNazwaFirmy() { return.NazwaFirmy; }
		public override bool Equals(Object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				PosrednikFirmy pf = (PosrednikFirmy)obj;
				return (this.NazwaFirmy == pf.getNazwaFirmy());  ///Nie wiem co tutaj jest źle -> do poprawy jak ktoś wie

			}
		}
	}
	public class KlientException : Exception
	{
		public KlientException(string msg) : base(msg) { }
	}
	public class IdException : KlientException
	{
		public IdException(string msg) : base(msg) { }
	}
    public class WiekException : KlientException
	{
		public WiekException(string msg) : base(msg) { }
	}
}