using System;
using System.Collections;
namespace LiniaLotnicza
{

	public class Lot
	{
		private ArrayList Rezerwacje;
		private Samolot Samolot;
		private Trasa Trasa;
		private DateTime DataLotu;
		public Lot(Samolot s, Trasa t, DateTime data)
		{ this.DataLotu = data; this.Trasa = t; this.Samolot = s; Rezerwacje = new ArrayList()};
		public ArrayList getRezerwacje() { return this.Rezerwacje; }
		public getSamolot() { return this.Samolot; }
		public getTrasa() { return this.Trasa; }
		public void dodajRezerwacje(Rezerwacja r) { Rezerwacje.Add(r); }
		public void usunRezerwacje(Rezerwacja r)
		{
			foreach (Rezerwacja re in Rezerwacje)
			{
				if (porownanieRezerwacji(r, re))
					Rezerwacje.Remove(re);
			}
		}
		private bool porownanieRezerwacji(Rezerwacja r, Rezerwacja re)
		{
			return (porownanieKlientow(r.getKlient(), re.getKlient());
		}
		public DateTime getDataLotu(){return this.DataLotu; }
	}
}