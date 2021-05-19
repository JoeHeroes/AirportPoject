using System;
using System.Collections;


public class Rezerwacja
{
    private Klient Klient;
    private ArrayList Bilety;

    Rezerwacja(Klient k)
    {
        this.Klient = k;
    }
    public Klient getKlient()
    {
        return Klient;
    }
    public ArrayList getBilety()
    {
        return Bilety;
    }
    public void dodajBilet(Bilet b)
    {
        Bilety.Add(b);
    }
    public void usunBilet(Bilet b)
    {
        Bilety.Remove(b);
    }
}
public class Bilet
{
    private string MiejsceDocelowe;
    private DateTime DataLotu;
    public Bilet(string MDocelowe, int r, int m, int d, int g, int mi,int s)
    {
        this.MiejsceDocelowe = MDocelowe;
        this.DataLotu = new DateTime(r, m, d, g, m, s);
    }
    public string getMiejsceDocelowe()
    {
        return this.MiejsceDocelowe;
    }
    public DateTime getData()
    {
        return this.DataLotu;
    }
}