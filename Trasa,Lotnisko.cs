using System;
using System.Collections;
namespace Trasa
public class Trasa
{
	private double Dystans;
	private ArrayList Lotniska;
	private int Czas;
	public Trasa(double dystans, int czas) { this.Dystans = dystans; this.Czas = czas; Lotniska = new ArrayList(); }
	public double getDystans() { return this.Dystans; }
	public ArrayList getLotniska() { return Lotniska; }
	public void dodajLotnisko(Lotnisko L) { Lotniska.add(L); }
	public void usunLotnisko(Lotnisko L)
	{
		foreach (Lotnisko Lo in Lotniska)
		{
			if (porownanieLotnisk(L, Lo))
				Lotniska.Remove(Lo);
		}
	}
	private bool porownanieLotnisk(Lotnisko L, Lotnisko Lo)
	{ return (L.getId() == Lo.getId() && L.getKraj() == Lo.getKraj() && L.getMiasto() == Lo.getMiasto()); }
}
public class Lotnisko
{
	private string Kraj, Miasto, Id;
	public Lotnisko(string kraj, string miasto, string id) { this.Kraj = kraj; this.miasto = miasto; this.Id = id; }
	public string getKraj() { return this.Kraj; }
	public string getMiasto() { return this.Miasto; }
	public string getId() { return this.Id; }
}