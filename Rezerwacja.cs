using System;
using System.Collections.Generic;
namespace LiniaLotnicza
{
    public class Rezerwacja
    {
        private Klient Klient;
        private List<Bilet> Bilety;
        public Rezerwacja() { }

        //Zwykly konstruktor
        public Rezerwacja(Klient k)
        {
            this.Klient = new Klient(k);
            this.Bilety = new List<Bilet>();
        }

        // Konstruktor kopiujacy - tworzy nowa liste biletow i przekopiowuje z niej bilety do listy biletow rezerwacji.
        public Rezerwacja(Rezerwacja r)
        {
            this.Klient = new Klient(r.getKlient());
            List<Bilet> b = r.getBilety();
            for (int i = 0; i < b.Count; i++)
            {
                this.Bilety.Add(new Bilet(b[i]));
            }
        }
        public Klient getKlient()
        {
            return Klient;
        }
        public List<Bilet> getBilety()
        {
            return Bilety;
        }
        public void dodajBilet(Bilet b)
        {
            Bilety.Add(b);
        }
        public void usunBilet(Bilet b)
        {
            //Metoda przeglada cala liste biletow i porownuje pola obiektow poprzez metode porownajBilet, a nastepnie usuwa poszczegolne bilety.
            for (int i = 0; i < this.Bilety.Count; i++)
            {
                if (b.porownajBilet(this.Bilety[i]))
                    Bilety.RemoveAt(i);
            }
        }

        // Metoda porownajRezerwacje porownuje poszczegolne pola i wywoluje prywatna metode porownajBilety ktora porownuje listy biletow i zwraca true jezeli listy sa takie same
        public bool porownajRezerwacje(Rezerwacja r)
        {
            List<Bilet> b = r.getBilety();     // Sprawdzenie czy listy
            if (b.Count != this.Bilety.Count)     // posiadaja taka sama
                return false;						// liczbe elementow.
            if (this.Klient.porownajKlienta(r.getKlient()) && porownajBilety(r))
                return true;
            else
                return false;
        }
        private bool porownajBilety(Rezerwacja r)
        {
            List<Bilet> b = r.getBilety();
            bool zmienna = false;
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i].porownajBilet(new Bilet(this.Bilety[i])))
                        zmienna = true;
                else
                    return false;
            }
            return zmienna;
        }
    }
    public class Bilet
    {
        private string MiejsceDocelowe;
        private DateTime DataLotu;
        public Bilet() { }
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
        public Bilet(Bilet bil)
        {
            this.MiejsceDocelowe = bil.getMiejsceDocelowe();
            this.DataLotu = bil.getData();
        }

        public string getMiejsceDocelowe()
        {
            return this.MiejsceDocelowe;
        }
        public DateTime getData()
        {
            return this.DataLotu;
        }
        public bool porownajBilet(Bilet bil)
        {
            return (this.DataLotu == bil.getData() && this.MiejsceDocelowe == bil.getMiejsceDocelowe());
        }
        
    }
}