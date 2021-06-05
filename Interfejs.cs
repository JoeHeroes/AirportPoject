using System;
using System.Collections;


namespace Interfejs
{
	class Program
	{
		static void Main(string[] args)
		{

			LiniaLotnicza LiniaL = new LiniaLotnicza("Lot by KGMDKG 2020C");

			Regionalny samolotR = new Regionalny(100, "99823", 23);
			LiniaL.dodajSamolot(samolotR);

			Lotnisko L1 = new Lotnisko("Polska", "Warsaw", "09813");
			LiniaL.dodajLotnisko(L1);
			Lotnisko L2 = new Lotnisko("PoDlska", "W3arsaw", "098D13");
			LiniaL.dodajLotnisko(L2);

			Console.WriteLine("");
			Console.WriteLine("		   Witamy w system kontroli lotow");
			Console.WriteLine("");
			Console.WriteLine("				Autorzy: ");
			Console.WriteLine("			- Micha³ Dienisik ");
			Console.WriteLine("			- Kornel Go³ebiewski");
			Console.WriteLine("			- Krzyszytof Goral");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("		Przycisnij dowolny przycisk aby zaczac ...");
			Console.Write("			         ");
			Console.ReadKey();


			while (true)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("			1. Panel Administracyjny");
				Console.WriteLine("			2. Panel u¿ytkownika/goœcia");
				Console.WriteLine("");
				Console.WriteLine("			0. Powrot");

				Console.Write("			         ");
				int wyborPanelu = Convert.ToInt32(Console.ReadLine());


				switch (wyborPanelu)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("");
						Console.WriteLine("			1. Zarzadzanie  Linia Lotnicza"); //Barakuje metody generuju
						Console.WriteLine("			2. Zarzadzanie  Lotniskami"); // Problem z usuwanie Lostniska
						Console.WriteLine("			3. Zarzadzanie  Samolotami"); //OK
						Console.WriteLine("			4. Zarzadzanie  Lotami"); // Problem z usuwaniem
						Console.WriteLine("			5. Zarzadzanie  Trasami"); //OK
						Console.WriteLine("			6. Zarzadzanie  Kientami"); //OK
						Console.WriteLine("");
						Console.WriteLine("			0. Powrot");

						Console.Write("			         ");
						int wyborA = Convert.ToInt32(Console.ReadLine());

						switch (wyborA)
						{
							case 1:
								OperacjeLiniaLotnicza(LiniaL);
								break;
							case 2:
								OperacjeLotniska(LiniaL);
								break;
							case 3:
								OperacjeSamolot(LiniaL);
								break;
							case 4:
								OperacjeLot(LiniaL);
								break;
							case 5:
								OperacjeTrasa(LiniaL);
								break;
							case 6:
								OperacjeKlient(LiniaL);
								break;
							case 0:
								break;
						}

						break;
					case 2:
						Console.Clear();
						Console.WriteLine("");
						Console.WriteLine("			1. Rezerwuj bilet");
						Console.WriteLine("			2. Szukaj polaczen");
						Console.WriteLine("			3. Wyœwietl liste lotow");
						Console.WriteLine("			4. Wyœwietl liste tras");
						Console.WriteLine("			5. Wyœwietl liste lotnisk");
						Console.WriteLine("");
						Console.WriteLine("			0. Powrot");

						Console.Write("			         ");
						int wyborB = Convert.ToInt32(Console.ReadLine());

						switch (wyborB)
						{
							case 1:
								Console.WriteLine("");
								Console.WriteLine("			Witaj w system rezerwacji blitw");


								//System rezewracji


								break;
							case 2:
								Console.WriteLine("			Lista wyszukanych Polaczen");

								//Szukanie Polaczen

								break;
							case 3:
								WyswietLot(LiniaL);
								break;
							case 4:
								WyswietTrasa(LiniaL);
								break;
							case 5:
								WyswietLotniska(LiniaL);
								break;
							case 0:
								break;
							default:
								break;
						}
						break;
					case 0:
						break;
					default:
						break;
				}
			}
		}

		public static void WyswietLot(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Loty: ");
			foreach (Lot L in LiniaL.getLoty())
			{
				Console.WriteLine("			 Godziny Lotu: " + L.getDataPocz() + "  " + L.getDataKon());
			}
			Console.ReadKey();
		}
		public static void WyswietTrasa(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Trasy: ");
			foreach (Trasa T in LiniaL.getTrasy())
			{
				Console.WriteLine("			" + T.getDystans());
			}
			Console.ReadKey();
		}
		public static void WyswietLotniska(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Lotniska: ");
			foreach (Lotnisko L in LiniaL.getLotniska())
			{
				Console.WriteLine("			" + L.getId());
			}
			Console.ReadKey();
		}

		public static void WyswietSamolot(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Samoloty: ");
			foreach (Samolot S in LiniaL.getSamoloty())
			{

				Console.WriteLine("			" + S.getId());
			}
			Console.ReadKey();
		}
		public static void WyswietKlient(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			  Klienci: ");
			Console.WriteLine("");


			foreach (Klient K in LiniaL.getKlient())
			{
				Console.WriteLine("			" + K.getId());

			}
			Console.ReadKey();
		}

		public static void OperacjeLiniaLotnicza(LiniaLotnicza LiniaL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Zarzadzanie Linia Lotnicza:");
			Console.WriteLine("			1. Wyœwietl nazwe");
			Console.WriteLine("			2. Generuj Lot");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");
			Console.Write("			         ");
			int wyborLinia = Convert.ToInt32(Console.ReadLine());

			switch (wyborLinia)
			{
				case 1:
					Console.WriteLine(LiniaL.getNazwaLinii());
					Console.ReadKey();
					break;
				case 2:
					//Metoda generuj lot
					break;
				case 0:
					break;
				default:
					break;

			}

		}
		public static void OperacjeLotniska(LiniaLotnicza LiniaL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Zarzadzanie  Lotniskami:");
			Console.WriteLine("			1. Wyœwietl nazwe");
			Console.WriteLine("			2. Dodaj Lotnisko");
			Console.WriteLine("			3. Usun Lotnisko");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");
			Console.Write("			         ");
			int wyborLotnisko = Convert.ToInt32(Console.ReadLine());


			switch (wyborLotnisko)
			{
				case 1:
					WyswietLotniska(LiniaL);
					break;
				case 2:
					DodawanieLotniska(LiniaL);
					break;
				case 3:
					UsuwanieLotniska(LiniaL);
					break;
				case 0:
					break;
				default:
					break;

			}


		}
		public static void DodawanieLotniska(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Lotniska");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Panstwo Lotniska");
			Console.Write("			         ");
			string krajDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj Miasto Lotniska");
			Console.Write("			         ");
			string miastoDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj ID Lotniska");
			Console.Write("			         ");
			string idDodaj = Console.ReadLine();
			Lotnisko l_Add = new Lotnisko(krajDodaj, miastoDodaj, idDodaj);
			LL.dodajLotnisko(l_Add);
		}
		public static void UsuwanieLotniska(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Usuwanie Lotniska");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Panstwo Lotniska");
			Console.Write("			         ");
			string krajUsun = Console.ReadLine();
			Console.WriteLine("			Podaj Miasto Lotniska");
			Console.Write("			         ");
			string miastoUsun = Console.ReadLine();
			Console.WriteLine("			Podaj ID Lotniska");
			Console.Write("			         ");
			string idUsun = Console.ReadLine();
			Lotnisko l_Delete = new Lotnisko(krajUsun, miastoUsun, idUsun);
			LL.usunLotnisko(l_Delete);
		}



		public static void OperacjeSamolot(LiniaLotnicza LiniaL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Zarzadzanie Samolotami:");
			Console.WriteLine("			1. Wyœwietl nazwe");
			Console.WriteLine("			2. Dodaj Samolot");
			Console.WriteLine("			3. Usun Samolot");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");
			Console.Write("			         ");
			int wyborSamolot = Convert.ToInt32(Console.ReadLine());
			switch (wyborSamolot)
			{
				case 1:
					WyswietSamolot(LiniaL);
					break;
				case 2:
					DodawanieSamolotu(LiniaL);
					break;
				case 3:
					UsuwanieSamolotu(LiniaL);
					break;
				case 0:
					break;
				default:
					break;
			}
		}

		public static Samolot DodawanieSamolotu(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Samolotu");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Zasieg Samolotu");
			Console.Write("			         ");
			double zasiegDodaj = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("			Podaj ID Samolotu");
			Console.Write("			         ");
			string idDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj Liczbe miejsc Samolotu");
			Console.Write("			         ");
			int miejscaDodaj = Convert.ToInt32(Console.ReadLine());
			if (zasiegDodaj < 1000)
			{
				Regionalny samolotR = new Regionalny(zasiegDodaj, idDodaj, miejscaDodaj);
				LL.dodajSamolot(samolotR);
				return samolotR;
			}
			else if (zasiegDodaj < 5000)
			{
				Sredniodystansowy samolotS = new Sredniodystansowy(zasiegDodaj, idDodaj, miejscaDodaj);
				LL.dodajSamolot(samolotS);
				return samolotS;
			}
			else
			{
				Dlugodystansowy samolotD = new Dlugodystansowy(zasiegDodaj, idDodaj, miejscaDodaj);
				LL.dodajSamolot(samolotD);
				return samolotD;
			}

		}
		public static void UsuwanieSamolotu(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Usuwanie Samolotu");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Zasieg Samolotu");
			Console.Write("			         ");
			double zasiegUsun = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("			Podaj ID Samolotu");
			Console.Write("			         ");
			string idUsun = Console.ReadLine();
			Console.WriteLine("			Podaj Liczbe miejsc Samolotu");
			Console.Write("			         ");
			int miejscaUsun = Convert.ToInt32(Console.ReadLine());

			if (zasiegUsun < 1000)
			{
				Regionalny samolotR = new Regionalny(zasiegUsun, idUsun, miejscaUsun);
				LL.usunSamolot(samolotR);
			}
			else if (zasiegUsun < 5000)
			{
				Sredniodystansowy samolotS = new Sredniodystansowy(zasiegUsun, idUsun, miejscaUsun);
				LL.usunSamolot(samolotS);
			}
			else
			{
				Dlugodystansowy samolotD = new Dlugodystansowy(zasiegUsun, idUsun, miejscaUsun);
				LL.usunSamolot(samolotD);
			}

		}
		public static void OperacjeLot(LiniaLotnicza LiniaL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Zarzadzanie Lotami:");
			Console.WriteLine("			1. Wyœwietl nazwe");
			Console.WriteLine("			2. Dodaj Lot");
			Console.WriteLine("			3. Usun Lot");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");
			Console.Write("			         ");
			int wyborLot = Convert.ToInt32(Console.ReadLine());
			switch (wyborLot)
			{
				case 1:
					WyswietLot(LiniaL);
					break;
				case 2:
					Samolot S = DodawanieSamolotu(LiniaL);

					Trasa T = DodawanieTrasa(LiniaL);

					Console.WriteLine("");
					Console.WriteLine("			Podaj Date odlotu: ");
					Console.WriteLine("");
					Console.Write("			Rok odlotu: ");
					Console.Write("			         ");
					int rokOdlotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Miesiac odlotu: ");
					int miesieacOdlotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Dzien odlotu: ");
					int dzienOdlotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Godzine odlotu: ");
					int godzinaOdlotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Minute odlotu: ");
					int minutaOdlotu = Convert.ToInt32(Console.ReadLine());

					DateTime dataOdlotu = new DateTime(rokOdlotu, miesieacOdlotu, dzienOdlotu, godzinaOdlotu, minutaOdlotu, 0);


					Console.WriteLine("");
					Console.WriteLine("			Podaj Date przylotu: ");
					Console.WriteLine("");
					Console.Write("			Rok przylotu: ");
					int rokPrzylotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Miesiac przylotu: ");
					int miesieacPrzylotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Dzien przylotu: ");
					int dzienPrzylotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Godzine przylotu: ");
					int godzinaPrzylotu = Convert.ToInt32(Console.ReadLine());
					Console.Write("			Minuta przylotu: ");
					int minutaPrzylotu = Convert.ToInt32(Console.ReadLine());

					DateTime dataPrzylotu = new DateTime(rokPrzylotu, miesieacPrzylotu, dzienPrzylotu, godzinaPrzylotu, minutaPrzylotu, 0);

					Lot L = new Lot(S, T, dataOdlotu, dataPrzylotu);

					LiniaL.dodajLot(L);



					break;
				case 3:
					UsuwanieSamolotu(LiniaL);
					break;
				case 0:
					break;
				default:
					break;

			}
		}
		public static void OperacjeTrasa(LiniaLotnicza LiniaL)
		{
			Console.Clear();
			Console.WriteLine("			Zarzadzanie Trasami:");
			Console.WriteLine("			1. Wyœwietl nazwe");
			Console.WriteLine("			2. Dodaj Trase");
			Console.WriteLine("			3. Usun Trase");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");
			Console.Write("			         ");
			int wyborTrasa = Convert.ToInt32(Console.ReadLine());
			switch (wyborTrasa)
			{
				case 1:
					WyswietTrasa(LiniaL);
					break;
				case 2:
					DodawanieTrasa(LiniaL);
					break;
				case 3:
					UsuwanieTrasa(LiniaL);
					break;
				case 0:
					break;
				default:
					break;
			}

		}

		public static Trasa DodawanieTrasa(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Trasy");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj dystans Trasy");
			Console.Write("			         ");
			double dystanDodaj = Convert.ToDouble(Console.ReadLine());
			Trasa t_Add = new Trasa(dystanDodaj);
			LL.dodajTrase(t_Add);
			return t_Add;

		}
		public static void UsuwanieTrasa(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Usuwanie Trasy");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj dystans Trasy");
			Console.Write("			         ");
			double dystanUsun = Convert.ToDouble(Console.ReadLine());
			Trasa t_Delete = new Trasa(dystanUsun);
			LL.usunTrase(t_Delete);
		}
		public static void OperacjeKlient(LiniaLotnicza LiniaL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Zarzadzanie Kientami:");
			Console.WriteLine("			1. Wyœwietl dane");
			Console.WriteLine("			2. Dodaj Klienta");
			Console.WriteLine("			3. Usun Klienta");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");
			Console.Write("			         ");
			int wyborKlienta = Convert.ToInt32(Console.ReadLine());
			switch (wyborKlienta)
			{
				case 1:
					WyswietKlient(LiniaL);
					break;
				case 2:
					DodawanieKlient(LiniaL);
					break;
				case 3:
					UsuwanieKlient(LiniaL);
					break;
				case 0:
					break;
				default:
					break;

			}
		}
		public static void DodawanieKlient(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Klienta :");
			Console.WriteLine("			Podaj ID");
			Console.Write("			         ");
			string idDodaj = Console.ReadLine();

			Console.WriteLine("			Typ Kientami:");
			Console.WriteLine("			1. Indywidualny");
			Console.WriteLine("			2. Firma");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");

			Console.Write("			         ");
			int wyborTypu = Convert.ToInt32(Console.ReadLine());

			switch (wyborTypu)
			{
				case 1:
					Indywidualny I = KlientIndywidualy(idDodaj);
					LL.dodajKlienta(I);
					break;
				case 2:
					PosrednikFirmy P = Posrednikfirmy(idDodaj);
					LL.dodajKlienta(P);
					break;
				case 0:
					break;
				default:
					break;
			}
		}
		public static Indywidualny KlientIndywidualy(string id)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Klient Indywidualy:");
			Console.WriteLine(" ");

			Console.WriteLine("			Podaj imie");
			Console.Write("			         ");
			string imie = Console.ReadLine();
			Console.WriteLine("			Podaj nazwisko");
			Console.Write("			         ");
			string nazwisko = Console.ReadLine();
			Console.WriteLine("			Podaj narodowosc");
			Console.Write("			         ");
			string narodowosc = Console.ReadLine();
			Console.WriteLine("			Podaj swoj wiek");
			Console.Write("			         ");
			int wiek = Convert.ToInt32(Console.ReadLine());

			Indywidualny KlientI = new Indywidualny(id, imie, nazwisko, narodowosc, wiek);
			return KlientI;

		}

		public static PosrednikFirmy Posrednikfirmy(string id)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Posrednik:");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj nazwe reprezentowanej firmy:");
			Console.Write("			         ");
			string nazwa = Console.ReadLine();

			PosrednikFirmy KlientF = new PosrednikFirmy(id, nazwa);
			return KlientF;
		}

		public static void UsuwanieKlient(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Usuwanie Klienta");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj ID");
			Console.Write("			         ");
			string id = Console.ReadLine();
			Console.WriteLine("			Typ Kientami:");
			Console.WriteLine("			1. Indywidualny");
			Console.WriteLine("			2. Firma");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");

			Console.Write("			         ");
			int wyborTypu = Convert.ToInt32(Console.ReadLine());

			switch (wyborTypu)
			{
				case 1:
					Indywidualny I = KlientIndywidualy(id);
					LL.usunKlienta(I);
					break;
				case 2:
					PosrednikFirmy P = Posrednikfirmy(id);
					LL.usunKlienta(P);
					break;
				case 0:
					break;
				default:
					break;
			}


		}
	}
}