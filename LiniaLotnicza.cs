using System;
using System.Collections.Generic;
namespace LiniaLotnicza
{
	public class LiniaLotnicza
	{
		private string nazwaLinii;
		private List<Samolot> samoloty;
		private List<Lot> loty;
		private List<Trasa> trasy;
		private List<Klient> klienci;

		//Konstruktor
		public LiniaLotnicza(string nazwa)
		{
			this.nazwaLinii = nazwa;
			samoloty = new List<Samolot>();
			loty = new List<Lot>();
			trasy = new List<Trasa>();
			klienci = new List<Klient>();
		}

		//gettery
		public string getNazwaLinii() { return this.nazwaLinii; }
		public List<Lot> getLoty() { return this.loty; }
		public List<Samolot> getSamoloty() { return this.samoloty; }
		public List<Trasa> getTrasy() { return this.trasy; }
		public List<Klient> getKlient() { return this.klienci; }

		//dodawanie do list
		public void dodajSamolot(Samolot s)
		{
			for (int i = 0; i < samoloty.Count; i++)
			{
				if (s.Equals(samoloty[i]))
					throw new ListaException("Wybrany samolot zostal juz dodany.");
			}
			samoloty.Add(s);
		}

		public void dodajKlienta(Klient k)
		{
			for (int i = 0; i < klienci.Count; i++)
			{
				if (k.Equals(klienci[i]))
					throw new ListaException("Wybrany klient zostal juz dodany.");
			}
			klienci.Add(k);
		}
		public void dodajTrase(Trasa t)
		{
			for (int i = 0; i < trasy.Count; i++)
			{
				if (t.Equals(trasy[i]))
					throw new ListaException("Wybrana trasa zostala juz dodana.");
			}
			trasy.Add(t);
		}
		public void dodajLot(Lot l)
		{
			for (int i = 0; i < loty.Count; i++)
			{
				if (l.Equals(loty[i]))
					throw new ListaException("Wybrany lot zostal juz dodany.");
			}
			loty.Add(l);
		}


	}
	public class LiniaLotniczaException : Exception
	{
		public LiniaLotniczaException(string msg) : base(msg) { }
	}
	public class ListaException : LiniaLotniczaException
	{
		public ListaException(string msg) : base(msg) { }
	}

}

