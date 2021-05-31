using System;
using System.Collections;
namespace LiniaLotnicza
{

	public class Lot
	{
		private List<Rezerwacja> Rezerwacje;
		private Samolot samolot;
		private Trasa trasa;
		private DateTime DataLotu;
		public Lot() { }

		//Zwykly konstruktor
		public Lot(Samolot s, Trasa t, DateTime data)
		{ this.DataLotu = data; this.trasa = t; this.samolot = s; Rezerwacje = new List<Rezerwacja>(); }

		public List<Rezerwacja> getRezerwacje() { return this.Rezerwacje; }
		public Samolot getSamolot() { return this.samolot; }
		public Trasa getTrasa() { return this.trasa; }
		public void dodajRezerwacje(Rezerwacja r) { Rezerwacje.Add(r); }
		public void usunRezerwacje(Rezerwacja r)
		{
			//Metoda przeglada cala liste rezerwacji i porownuje pola obiektow poprzez metode porownajRezerwacje, a nastepnie usuwa poszczegolne rezerwacje.
			for (int i = 0; i < this.Rezerwacje.Count; i++)
			{
				if (r.Equals(this.Rezerwacje[i]))
					Rezerwacje.RemoveAt(i);
			}
		}
		// Metoda Equals porownuje poszczegolne pola i wywoluje prywatna metode porownajListyRezerwacji ktora porownuje listy rezerwacji i zwraca true jezeli listy sa takie same.

		public override bool Equals(Object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				Lot lot = (Lot)obj;
				List<Rezerwacja> rez = lot.getRezerwacje();              // Sprawdzenie czy listy
				if (rez.Count != this.Rezerwacje.Count)                 // posiadaja taka sama
					return false;                                      // liczbe elementow.

				if (this.samolot.Equals(lot.getSamolot()) && this.trasa.Equals(lot.getTrasa()) && this.DataLotu == lot.getDataLotu() && porownajRezerwacje(lot))
					return true;
				else
					return false;
			}
		}
		private bool porownajRezerwacje(Lot lot)
		{
			List<Rezerwacja> rez = lot.getRezerwacje();
			bool zmienna = false;
			for (int i = 0; i < rez.Count; i++)
			{
				if (rez[i].Equals(this.Rezerwacje[i]))
					zmienna = true;
				else
					return false;
			}
			return zmienna;
		}
		public DateTime getDataLotu(){return this.DataLotu; }
	}
}