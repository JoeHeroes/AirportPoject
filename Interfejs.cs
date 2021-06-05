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
			Console.ReadKey();


			while (true)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("			1. Panel Administracyjny");
				Console.WriteLine("			2. Panel u¿ytkownika/goœcia");
				Console.WriteLine("");
				Console.WriteLine("			0. Powrot");

				Console.Write("			      ");
				int wyborPanelu = Convert.ToInt32(Console.ReadLine());


				switch (wyborPanelu)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("");
						Console.WriteLine("			1. Zarzadzanie  Linia Lotnicza");
						Console.WriteLine("			2. Zarzadzanie  Lotniskami");
						Console.WriteLine("			3. Zarzadzanie  Samolotami");
						Console.WriteLine("			4. Zarzadzanie  Lotami");
						Console.WriteLine("			5. Zarzadzanie Trasami");
						Console.WriteLine("			6. Zarzadzanie Kientami");
						Console.WriteLine("");
						Console.WriteLine("			0. Powrot");

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
							default:
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

						int wyborB = Convert.ToInt32(Console.ReadLine());

						switch (wyborB)
						{
							case 1:
								Console.WriteLine("");
								Console.WriteLine("			Witaj w system rezerwacji blitw");



								//NKLDALBNK


								break;
							case 2:
								Console.WriteLine("			Lista wyszukanych Polaczen");
								break;
							case 3:
								WyswietLot(LiniaL);
								break;
							case 4:
								WyswietTrasa(LiniaL);
								break;
							case 5:
								WyswietLotnisko(LiniaL);
								break;
							case 0:
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
			foreach (Lot L in LiniaL.getLoty())
			{
				Console.WriteLine("			Loty: " + L.getTrasa() + " Godziny Lotu: " + L.getDataPocz() + "  " + L.getDataKon());
			}
			Console.ReadKey();
		}
		public static void WyswietTrasa(LiniaLotnicza LiniaL)
		{
			foreach (Lot T in LiniaL.getLoty())
			{
				Console.WriteLine("			Trasy: " + T.getTrasa());
			}
			Console.ReadKey();
		}
		public static void WyswietLotnisko(LiniaLotnicza LiniaL)
		{
			foreach (Lotnisko L in LiniaL.getLotniska())
			{
				Console.WriteLine(L.getId());
			}
			Console.ReadKey();
		}

		public static void WyswietSamolot(LiniaLotnicza LiniaL)
		{
			foreach (Samolot S in LiniaL.getSamoloty())
			{
				Console.WriteLine(S.getId());
			}
			Console.ReadKey();
		}
		public static void WyswietKlient(LiniaLotnicza LiniaL)
		{
			foreach (Klient K in LiniaL.getKlient())
			{
				Console.WriteLine(K.getId());
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
			int wyborLinia = Convert.ToInt32(Console.ReadLine());

			switch (wyborLinia)
			{
				case 1:
					Console.WriteLine(LiniaL.getNazwaLinii());
					Console.ReadKey();
					break;
				case 2:
					//Czekam na metode
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
			int wyborLotnisko = Convert.ToInt32(Console.ReadLine());


			switch (wyborLotnisko)
			{
				case 1:
					WyswietLotnisko(LiniaL);
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
			string krajDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj Miasto Lotniska");
			string miastoDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj ID Lotniska");
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
			string krajUsun = Console.ReadLine();
			Console.WriteLine("			Podaj Miasto Lotniska");
			string miastoUsun = Console.ReadLine();
			Console.WriteLine("			Podaj ID Lotniska");
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
			double zasiegDodaj = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("			Podaj ID Samolotu");
			string idDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj Liczbe miejsc Samolotu");
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
			double zasiegUsun = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("			Podaj ID Samolotu");
			string idUsun = Console.ReadLine();
			Console.WriteLine("			Podaj Liczbe miejsc Samolotu");
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

					//CDN...



					break;
				case 3:

					UsuwanieSamolotu(LiniaL);
					break;
				//fbnklalfk
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
			string idDodaj = Console.ReadLine();

			Console.WriteLine("			Typ Kientami:");
			Console.WriteLine("			1. Indywidualny");
			Console.WriteLine("			2. Firma");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");

			int wyborTypu = Convert.ToInt32(Console.ReadLine());

			switch (wyborTypu)
			{
				case 1:
					DodawanieKlientaIndywidualnego(idDodaj);
					break;
				case 2:
					DodawaniePosrednik(idDodaj);
					break;
				case 0:
					break;
				default:
					break;
			}
		}
		public static Indywidualny DodawanieKlientaIndywidualnego(string idDodaj)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Klienta Indywidualnego:");
			Console.WriteLine(" ");

			Console.WriteLine("			Podaj swoje imie");
			string imieDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj swoje nazwisko");
			string nazwiskoDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj swoja narodowosc");
			string narodowoscDodaj = Console.ReadLine();
			Console.WriteLine("			Podaj swoj wiek");
			int wiekDodaj = Convert.ToInt32(Console.ReadLine());

			Indywidualny KlientI = new Indywidualny(idDodaj, imieDodaj, nazwiskoDodaj, narodowoscDodaj, wiekDodaj);

			return KlientI;

		}

		public static PosrednikFirmy DodawaniePosrednik(string idDodaj)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Posrednik:");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj nazwe reprezentowanej firmy:");
			string nazwaDodaj = Console.ReadLine();

			PosrednikFirmy KlientF = new PosrednikFirmy(idDodaj, nazwaDodaj);
			return KlientF;

		}

		public static void UsuwanieKlient(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Usuwanie Trasy");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj ID");
			string dystanUsun = Console.ReadLine();
			// czekam na klase Klient
		}
	}
}