using System;
using System.Collections;
namespace LiniaLotnicza
{

	public class Lot
	{
		private List<Rezerwacja> Rezerwacje;
		private Samolot Samolot;
		private Trasa Trasa;
		private DateTime DataLotu;
		public Lot() { }

		//Zwykly konstruktor
		public Lot(Samolot s, Trasa t, DateTime data)
		{ this.DataLotu = data; this.Trasa = new Trasa(t); this.Samolot = new Samolot(s); Rezerwacje = new List<Rezerwacja>(); }

		// Konstruktor kopiujacy - tworzy nowa liste rezerwacji i przekopiowuje z niej rezerwacje do listy rezerwacji lotu.
		public Lot(Lot lot)
		{
			this.Samolot = new Samolot(lot.getSamolot());
			this.Trasa = new Trasa(lot.getTrasa());
			List<Rezerwacja> rez = lot.getRezerwacje();
			this.Rezerwacje = new List<Rezerwacja>(lot.getRezerwacje());
		}
		public List<Rezerwacja> getRezerwacje() { return this.Rezerwacje; }
		public Samolot getSamolot() { return this.Samolot; }
		public Trasa getTrasa() { return this.Trasa; }
		public void dodajRezerwacje(Rezerwacja r) { Rezerwacje.Add(r); }
		public void usunRezerwacje(Rezerwacja r)
		{
			//Metoda przeglada cala liste rezerwacji i porownuje pola obiektow poprzez metode porownajRezerwacje, a nastepnie usuwa poszczegolne rezerwacje.
			for (int i = 0; i < this.Rezerwacje.Count; i++)
			{
				if (r.porownajRezerwacje(this.Rezerwacje[i]))
					Rezerwacje.RemoveAt(i);
			}
		}
		// Metoda porownajLot porownuje poszczegolne pola i wywoluje prywatna metode porownajListyRezerwacji ktora porownuje listy rezerwacji i zwraca true jezeli listy sa takie same.

		public bool porownajLot(Lot lot)
		{
			List<Rezerwacja> rez = lot.getRezerwacje();				 // Sprawdzenie czy listy
			if (rez.Count != this.Rezerwacje.Count)			    	// posiadaja taka sama
				return false;								       // liczbe elementow.

			if (this.Samolot.porownajSamolot(new Samolot(lot.getSamolot()))&&this.Trasa.porownajTrase(new Trasa(lot.getTrasa()))&&this.DataLotu==lot.getDataLotu() && porownajRezerwacje(lot))
				return true;
			else
				return false;
		}
		private bool porownajRezerwacje(Lot lot)
		{
			List<Rezerwacja> rez = lot.getRezerwacje();
			bool zmienna = false;
			for (int i = 0; i < rez.Count; i++)
			{
				if (rez[i].porownajRezerwacje(new Rezerwacja(this.Rezerwacje[i])))
					zmienna = true;
				else
					return false;
			}
			return zmienna;
		}
		//Metoda porownanieRezerwacji wywoluje porownanie klientow
		private bool porownajRezerwacje(Rezerwacja r, Rezerwacja re)
		{
			Klient k = r.getKlient(), kl = re.getKlient();
			return (k.porownajKlienta(kl));
		}
		public DateTime getDataLotu(){return this.DataLotu; }
	}
}