using System;
using System.Collections;
namespace Trasa
public class Trasa()
{
	private double Dystans;
	private ArrayList Lotniska;
	private int Czas;
public Trasa(double dystans, int czas) { this.Dystans = dystans;this.Czas = czas; Lotniska = new ArrayList(); }
public double getDystans() { return this.Dystans; }
public ArrayList getLotniska() { return Lotniska; }
public void dodajLotnisko(Lotnisko L) { Lotniska.add(L); }
public void usunLotnisko(Lotnisko L) { Lotnisko.//}
}
public class Lotnisko()
{
	private string Kraj, Miasto, Id;
    public Lotnisko(string kraj,string miasto,string id) { this.Kraj = kraj; this.miasto = miasto; this.Id = id; }
	public getKraj() { return this.Kraj; }
	public getMiasto() { return this.Miasto; }
	public getId() { return this.Id; }
}
