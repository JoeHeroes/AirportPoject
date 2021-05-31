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
                if (b.Equals(this.Bilety[i]))
                    Bilety.RemoveAt(i);
            }
        }

        // Metoda Equals porownuje poszczegolne pola i wywoluje prywatna metode porownajBilety ktora porownuje listy biletow i zwraca true jezeli listy sa takie same
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Rezerwacja r = (Rezerwacja)obj;
                List<Bilet> b = r.getBilety();     // Sprawdzenie czy listy
                if (b.Count != this.Bilety.Count)     // posiadaja taka sama
                    return false;                       // liczbe elementow.
                if (this.Klient.Equals(r.getKlient()) && porownajBilety(r))
                    return true;
                else
                    return false;
            }
        }
        private bool porownajBilety(Rezerwacja r)
        {
            List<Bilet> b = r.getBilety();
            bool zmienna = false;
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i].Equals(this.Bilety[i]))
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
            public Bilet(string MDocelowe, int r, int m, int d, int g, int mi, int s)
            {
                this.MiejsceDocelowe = MDocelowe;
                this.DataLotu = new DateTime(r, m, d, g, m, s);
            }
            public Bilet(string MDocelowe, DateTime data)
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
            public override bool Equals(Object obj)
            {
                if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                {
                    return false;
                }
                else
                {
                    Bilet bil = (Bilet)obj;
                    return (this.DataLotu == bil.getData() && this.MiejsceDocelowe == bil.getMiejsceDocelowe());
                }

            }
        }
}