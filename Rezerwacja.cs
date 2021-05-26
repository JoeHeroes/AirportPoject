using System;
using System.Collections;
namespace LiniaLotnicza
{
    public class Rezerwacja
    {
        private Klient Klient;
        private ArrayList Bilety;

        Rezerwacja(Klient k)
        {
            this.Klient = k;
            this.Bilety = new ArrayList();
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
        public Bilet(string MDocelowe,int r, int m, int d, int g, int mi, int s)
        {
            this.MiejsceDocelowe = MDocelowe;
            this.DataLotu = new DateTime(r, m, d, g, m, s);
        }
        public Bilet(string MDocelowe,DateTime data)
        {
            this.MiejsceDocelowe = MDocelowe;
            this.DataLotu = data;
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
}