using System;
using System.Collections;
namespace LiniaLotnicza
{
	public class Trasa
	{
		private double Dystans;
		private ArrayList Lotniska;
		private int Czas;
		public Trasa(double dystans, int czas) {
			if (czas <= 0)
				throw new CzasException("Czas przelotu nie moze byc mniejszy od zera.");
			if (dystans <= 0)
				throw new DystansException("Dystans nie moze byc mniejszy od zera.");
			this.Dystans = dystans; 
			this.Czas = czas; 
			Lotniska = new ArrayList(); }
		public Trasa(Trasa t)
        {
			this.Dystans = t.getDystans();
			this.Czas = t.getCzas();
			this.Lotniska = t.getLotniska();
        }
		public double getDystans() { return this.Dystans; }
		public ArrayList getLotniska() { return this.Lotniska; }
		public int getCzas() { return this.Czas; }
		public void dodajLotnisko(Lotnisko L) { Lotniska.add(L); }
		public void usunLotnisko(Lotnisko L)
		{
			//Metoda przeglada cala liste lotnisk i porwnuje pola obiektow poprzez metode porownajLotnisko
			foreach (Lotnisko Lo in Lotniska)
			{
				if (L.porownajLotnisko(Lo)
					Lotniska.Remove(Lo);
			}
		}
	}
	public class Lotnisko
	{
		private string Kraj, Miasto, Id;
		public Lotnisko(string kraj, string miasto, string id) { this.Kraj = kraj; this.miasto = miasto; this.Id = id; }
		public Lotnisko(Lotnisko l) { this.Kraj = l.getKraj();this.Miasto = l.getMiasto();this.Id = l.getId(); }
		public string getKraj() { return this.Kraj; }
		public string getMiasto() { return this.Miasto; }
		public string getId() { return this.Id; }
		public bool porownajLotnisko(Lotnisko l) { return (this.Id == l.getId() && this.Kraj == l.getKraj() && this.Miasto == l.getMiasto()); }
	}
	public class TrasaException : Exception { }
	public class DystansException : TrasaException { }
	public class CzasException : TrasaException { }
}