using System;
using System.Collections.Generic;


namespace Interfejs
{
	class Program
	{
		static void Main(string[] args)
		{

			LiniaLotnicza LiniaL = new LiniaLotnicza("Lot");

			Console.WriteLine("");
			Console.WriteLine("		   Witamy w systemie kontroli lotow");
			Console.WriteLine("");
			Console.WriteLine("				Autorzy: ");
			Console.WriteLine("			- Michal Dienisik ");
			Console.WriteLine("			- Kornel Golebiewski");
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
						Console.WriteLine("			1. Zarzadzanie  Linia Lotnicza"); //OK
						Console.WriteLine("			2. Zarzadzanie  Lotniskami"); //OK
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
								Console.WriteLine("			Witaj w system rezerwacji biletow");

								Klient K = TworzenieKlienta();
								Rezerwacja R = new Rezerwacja(K);




								break;
							case 2:
								Console.WriteLine("			Lista wyszukanych Polaczen");

								WyswietLot(LiniaL);

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
				Console.WriteLine("			 Godziny Lotu: " + L.getDataPocz() + "  " + L.getDataKon() + "  ");
				WyswietTrasaJedna(L);
			}
			Console.ReadKey();
		}


		public static void WyswietTrasaJedna(Lot l)
		{
			Trasa t = l.getTrasa();
			Console.WriteLine("			Id: " + t.getId());
			WyswietLotniskaAll(t);
		}
		public static void WyswietTrasa(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Trasy: ");
			foreach (Trasa T in LiniaL.getTrasy())
			{
				Console.WriteLine("			Id: " + T.getId());
				Console.WriteLine("			Dystans:" + T.getDystans());
				WyswietLotniskaAll(T);
			}
			Console.ReadKey();
		}

		public static void WyswietLotniskaAll(Trasa T)
		{

			foreach (Lotnisko lotnisko in T.getLotniska())
			{
				Console.WriteLine("			 Panstwo: " + lotnisko.getKraj() + " Miasto " + lotnisko.getMiasto() + " ID: " + lotnisko.getId());
			}


		}
		public static void WyswietLotniska(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Lotniska: ");
			foreach (Lotnisko L in LiniaL.getLotniska())
			{
				Console.WriteLine("			" + L.getId() + " Miasto: " + L.getMiasto() + " Kraj: " + L.getKraj());
			}
			Console.ReadKey();
		}

		public static void WyswietSamolot(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			Samoloty: ");
			foreach (Samolot S in LiniaL.getSamoloty())
			{

				Console.WriteLine("			Id: " + S.getId());
				Console.WriteLine("			Zasieg: " + S.getZasieg());
				Console.WriteLine("			LiczbaMiejsc: " + S.getLiczbaMiejsc() + "\n");
			}
			Console.ReadKey();
		}
		public static void WyswietKlient(LiniaLotnicza LiniaL)
		{
			Console.WriteLine("");
			Console.WriteLine("			  Klienci: ");
			Console.WriteLine("");

			string id = Console.ReadLine();

			Console.WriteLine("			Typ Kientami:");
			Console.WriteLine("			1. Indywidualny");
			Console.WriteLine("			2. Firma");
			Console.WriteLine("");
			Console.WriteLine("			0. Powrot");

			Console.Write("			         ");
			int wybor = Convert.ToInt32(Console.ReadLine());

			switch (wybor)
			{
				case 1:
					foreach (Indywidualny I in LiniaL.getKlient())
					{
						Console.WriteLine("			" + I.getId() + " " + I.getImie() + " " + I.getNazwisko() + " " + I.getWiek() + " " + I.getNarodowosc());
					}
					break;
				case 2:

					foreach (PosrednikFirmy P in LiniaL.getKlient())
					{
						Console.WriteLine("			" + P.getId() + " " + P.getNazwaFirmy());
					}
					break;
				case 0:
					break;
				default:
					break;
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
					Console.Write("			         ");
					Console.WriteLine(LiniaL.getNazwaLinii());
					Console.ReadKey();
					break;
				case 2:
					Samolot s = TworzenieSamolotu();
					try { LiniaL.dodajSamolot(s); } catch (ListaException Le) { Console.WriteLine("			" + Le.Message); };
			

					Trasa t = DodawanieTrasa(LiniaL);
					try { LiniaL.dodajTrase(t); }catch (ListaException Le) { Console.WriteLine("			" + Le.Message);};

					DateTime DataP = DataOdlotu();
					DateTime DataK = DataPrzylotu();


					Console.WriteLine("			Podaj ID lotu");
					Console.Write("			         ");
					string id = Console.ReadLine();
					LiniaL.generujLot(t, DataP, DataK, id);
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
					Lotnisko lAdd = TworzenieLotniska();
					try { LiniaL.dodajLotnisko(lAdd); } catch(ListaException Le) { Console.WriteLine("			" + Le.Message); };
					break;
				case 3:
					Lotnisko lDelete = TworzenieLotniska();
					try { LiniaL.usunLotnisko(lDelete); } catch(UsunException Ue) { Console.WriteLine("			" + Ue.Message); };
					break;
				case 0:
					break;
				default:
					break;

			}


		}
		public static Lotnisko TworzenieLotniska()
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Lotniska");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Panstwo Lotniska");
			Console.Write("			         ");
			string kraj = Console.ReadLine();
			Console.WriteLine("			Podaj Miasto Lotniska");
			Console.Write("			         ");
			string miasto = Console.ReadLine();
			Console.WriteLine("			Podaj ID Lotniska");
			Console.Write("			         ");
			string id = Console.ReadLine();
			return new Lotnisko(kraj, miasto, id);

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
					Samolot sAdd = TworzenieSamolotu();
					try { LiniaL.dodajSamolot(sAdd); } catch (ListaException Le) { Console.WriteLine("			" + Le.Message); };
					break;
				case 3:
					Samolot sDelete = TworzenieSamolotu();
					try { LiniaL.usunSamolot(sDelete); } catch (UsunException Ue) { Console.WriteLine("			" + Ue.Message); };
					break;
				case 0:
					break;
				default:
					break;
			}
		}

		public static Samolot TworzenieSamolotu()
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Samolotu");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Zasieg Samolotu");
			Console.Write("			         ");
			double zasieg = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("			Podaj ID Samolotu");
			Console.Write("			         ");
			string id = Console.ReadLine();
			Console.WriteLine("			Podaj Liczbe miejsc Samolotu");
			Console.Write("			         ");
			int miejsca = Convert.ToInt32(Console.ReadLine());
			if (zasieg <= 1000)
			{
				Regionalny samolotR = new Regionalny(zasieg, id, miejsca);
				return samolotR;
			}
			else if (zasieg <= 5000)
			{
				Sredniodystansowy samolotS = new Sredniodystansowy(zasieg, id, miejsca);
				return samolotS;
			}
			else
			{
				Dlugodystansowy samolotD = new Dlugodystansowy(zasieg, id, miejsca);
				return samolotD;
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
					Lot lAdd = TworzenieLotu(LiniaL);
					try { LiniaL.dodajLot(lAdd); } catch (ListaException Le) { Console.WriteLine("			" + Le.Message); };
					break;
				case 3:
					Lot l = TworzenieLotu(LiniaL);
					try { LiniaL.usunLot(l); } catch (UsunException Ue) { Console.WriteLine("			" + Ue.Message); };

					break;
				case 0:
					break;
				default:
					break;

			}
		}

		public static DateTime DataOdlotu()
		{

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

			return new DateTime(rokOdlotu, miesieacOdlotu, dzienOdlotu, godzinaOdlotu, minutaOdlotu, 0);

		}
		public static DateTime DataPrzylotu()
		{
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

			return new DateTime(rokPrzylotu, miesieacPrzylotu, dzienPrzylotu, godzinaPrzylotu, minutaPrzylotu, 0);

		}

		public static Lot TworzenieLotu(LiniaLotnicza LL)
		{
			Samolot s = TworzenieSamolotu();
			try { LL.dodajSamolot(s); } catch (ListaException Le) { };

			Trasa t = DodawanieTrasa(LL);
			try { LL.dodajTrase(t); } catch (ListaException Le) { };

			DateTime dataOdlotuDelete = DataOdlotu();
			DateTime dataPrzylotuDelete = DataPrzylotu();


			Console.WriteLine("			Podaj ID lotu");
			Console.Write("			         ");
			string id = Console.ReadLine();
			return new Lot(s, t, dataOdlotuDelete, dataPrzylotuDelete, id);

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
			Console.WriteLine("			Podaj Id Trasy");
			Console.Write("			         ");
			string id = Console.ReadLine();
			Console.WriteLine("			Podaj dystans Trasy");
			Console.Write("			         ");
			double dystan = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("			Dodawanie Lotnisk do trasy, by rozpoczac wcisnij dowolny przycisk procz 0");
			Trasa Add = new Trasa(dystan,id);
			while (true)
			{
				Console.Write("			         ");
				if (Console.ReadLine() == "0")
					break;
				Lotnisko l = TworzenieLotniska();
				try { LL.dodajLotnisko(l); } catch (ListaException Le) { }
				Add.dodajLotnisko(l);
				Console.WriteLine("			By kontynowac dodawanie kliknij dowolny przycisk procz 0");
				Console.WriteLine("			By zakonczyc dodawanie wcisnij 0");
			}
			try { LL.dodajTrase(Add); } catch (ListaException Le) { };
			return Add;

		}
		public static void UsuwanieTrasa(LiniaLotnicza LL)
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Usuwanie Trasy");
			Console.WriteLine(" ");
			Console.WriteLine("			Podaj Id Trasy");
			Console.Write("			         ");
			string id = Console.ReadLine();
			Console.WriteLine("			Podaj dystans Trasy");
			Console.Write("			         ");
			double dystan = Convert.ToDouble(Console.ReadLine());
			Trasa Delete = new Trasa(dystan,id);
			try { LL.usunTrase(Delete); } catch (UsunException Ue) { Console.WriteLine("			" + Ue.Message); };
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
					Klient kAdd = TworzenieKlienta();
					try { LiniaL.dodajKlienta(kAdd); } catch (ListaException Le) { Console.WriteLine("			" + Le.Message); };
					break;
				case 3:
					Klient kDelete = TworzenieKlienta();
					try { LiniaL.usunKlienta(kDelete); } catch (UsunException Ue) { Console.WriteLine("			" + Ue.Message); };
					break;
				case 0:
					break;
				default:
					break;

			}
		}
		public static Klient TworzenieKlienta()
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("			Dodawanie Klienta :");
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
					return I;
					break;
				case 2:
					PosrednikFirmy P = Posrednikfirmy(id);
					return P;
					break;
				case 0:
					break;
				default:
					break;
			}
			return null;
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
	}
}