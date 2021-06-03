using System;
using System.Collections;


namespace Main
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("1. Panel Administracyjny");
				Console.WriteLine("2. Panel u¿ytkownika/goœcia");

				int wyborPanelu = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				while (true)
				{
					switch (wyborPanelu)
					{
						case 1:
							Console.Clear();

							Console.WriteLine("1. Zarzadzanie  Linia Lotnicza");

							Console.WriteLine("2. Zarzadzanie  Lotniskami");

							Console.WriteLine("3. Zarzadzanie  Samolotami");

							Console.WriteLine("4. Zarzadzanie  Lotami");

							Console.WriteLine("5. Zarzadzanie Trasami");

							Console.WriteLine("6. Zarzadzanie Kientami");

							Console.WriteLine("0. Wyjdz");

							int wybor = Convert.ToInt32(Console.ReadLine());
							LiniaLotnicza LiniaL = new LiniaLotnicza("Lot");

							switch (wybor)
							{
								case 1:
									Console.Clear();
									Console.WriteLine("Zarzadzanie Linia Lotnicza:");
									Console.WriteLine("1. Wyœwietl nazwe");
									Console.WriteLine("2. Generuj Lot");
									Console.WriteLine("0. Wyjdz");
									int wyborLinia = Convert.ToInt32(Console.ReadLine());

									switch (wyborLinia)
									{
										case 1:
											Console.WriteLine(LiniaL.getNazwaLinii());
											break;
										case 2:
											break;
										case 0:
											break;

									}

									break;
								case 2:
									Console.Clear();
									Console.WriteLine("Zarzadzanie  Lotniskami:");
									Console.WriteLine("1. Wyœwietl nazwe");
									Console.WriteLine("2. Dodaj Lotnisko");
									Console.WriteLine("3. Usun Lotnisko");
									Console.WriteLine("0. Wyjdz");
									int wyborLotnisko = Convert.ToInt32(Console.ReadLine());


									switch (wyborLotnisko)
									{
										case 1:
											Console.WriteLine(LiniaL.getLotnisko());
											break;
										case 2:
											Console.WriteLine("Dodawanie Lotniska");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj Panstwo Lotniska");
											string krajDodaj = Console.ReadLine();
											Console.WriteLine("Podaj Miasto Lotniska");
											string miastoDodaj = Console.ReadLine();
											Console.WriteLine("Podaj ID Lotniska");
											string idDodaj = Console.ReadLine();
											Lotnisko l_Add = new Lotnisko(krajDodaj, miastoDodaj, idDodaj);
											LiniaL.dodajLotnisko(l_Add);
											break;
										case 3:
											Console.WriteLine("Usuwanie Lotniska");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj Panstwo Lotniska");
											string krajUsun = Console.ReadLine();
											Console.WriteLine("Podaj Miasto Lotniska");
											string miastoUsun = Console.ReadLine();
											Console.WriteLine("Podaj ID Lotniska");
											string idUsun = Console.ReadLine();
											Lotnisko l_Delete = new Lotnisko(krajUsun, miastoUsun, idUsun);
											LiniaL.usunLotnisko(l_Delete);
											break;
										case 0:
											Console.Clear();
											break;

									}

									break;
								case 3:
									Console.Clear();
									Console.WriteLine("Zarzadzanie Samolotami:");
									Console.WriteLine("1. Wyœwietl nazwe");
									Console.WriteLine("2. Dodaj Samolot");
									Console.WriteLine("3. Usun Samolot");
									Console.WriteLine("0. Wyjdz");
									int wyborSamolot = Convert.ToInt32(Console.ReadLine());
									switch (wyborSamolot)
									{
										case 1:
											Console.WriteLine(LiniaL.getSamoloty());
											break;
										case 2:
											Console.Clear();
											Console.WriteLine("Dodawanie Samolotu");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj Zasieg Samolotu");
											double zasiegDodaj = Convert.ToDouble(Console.ReadLine());
											Console.WriteLine("Podaj ID Samolotu");
											string idDodaj = Console.ReadLine();
											Console.WriteLine("Podaj Liczbe miejsc Samolotu");
											int miejscaDodaj = Convert.ToInt32(Console.ReadLine());
											Samolot s_Add = new Samolot(zasiegDodaj, idDodaj, miejscaDodaj);
											LiniaL.dodajSamolot(s_Add);

											break;
										case 3:
											Console.Clear();
											Console.WriteLine("Usuwanie Samolotu");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj Zasieg Samolotu");
											double zasiegUsun = Convert.ToDouble(Console.ReadLine());
											Console.WriteLine("Podaj ID Samolotu");
											string idUsun = Console.ReadLine();
											Console.WriteLine("Podaj Liczbe miejsc Samolotu");
											int miejscaUsun = Convert.ToInt32(Console.ReadLine());
											Samolot s_Delete = new Samolot(zasiegUsun, idUsun, miejscaUsun);
											LiniaL.usunSamolot(s_Delete);

											break;
										case 0:

											break;

									}

									break;
								case 4:
									Console.Clear();
									Console.WriteLine("Zarzadzanie Lotami:");
									Console.WriteLine("1. Wyœwietl nazwe");
									Console.WriteLine("2. Dodaj Lot");
									Console.WriteLine("3. Usun Lot");
									Console.WriteLine("0. Wyjdz");
									int wyborLot = Convert.ToInt32(Console.ReadLine());
									switch (wyborLot)
									{
										case 1:
											Console.WriteLine(LiniaL.getLoty());
											break;
										case 2:
											Console.Clear();
											Console.WriteLine("Dodawanie Lotu:");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj Samolot:");

											Console.WriteLine("Podaj Zasieg Samolotu");
											double zasiegDodaj = Convert.ToDouble(Console.ReadLine());
											Console.WriteLine("Podaj ID Samolotu");
											string idDodaj = Console.ReadLine();
											Console.WriteLine("Podaj Liczbe miejsc Samolotu");
											int miejscaDodaj = Convert.ToInt32(Console.ReadLine());
											Samolot samolotLot = new Samolot(zasiegDodaj, idDodaj, miejscaDodaj);

											Console.WriteLine("Podaj Trase");


											Console.WriteLine("Podaj Date odlotu");
											Console.WriteLine("Podaj Date przylotu");







											break;
										case 3:
											Console.Clear();
											Console.WriteLine("Usuwanie Samolotu");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj Zasieg Samolotu");
											double zasiegUsun = Convert.ToDouble(Console.ReadLine());
											Console.WriteLine("Podaj ID Samolotu");
											string idUsun = Console.ReadLine();
											Console.WriteLine("Podaj Liczbe miejsc Samolotu");
											int miejscaUsun = Convert.ToInt32(Console.ReadLine());
											Samolot s_Delete = new Samolot(zasiegUsun, idUsun, miejscaUsun);
											LiniaL.usunSamolot(s_Delete);

											break;

									}

									break;
								case 5:
									Console.Clear();
									Console.WriteLine("Zarzadzanie Trasami:");
									Console.WriteLine("1. Wyœwietl nazwe");
									Console.WriteLine("2. Dodaj Trase");
									Console.WriteLine("3. Usun Trase");
									Console.WriteLine("0. Wyjdz");
									int wyborTrasa = Convert.ToInt32(Console.ReadLine());
									switch (wyborTrasa)
									{
										case 1:
											Console.WriteLine(LiniaL.getTrasy());
											break;
										case 2:
											Console.Clear();
											Console.WriteLine("Dodawanie Trasy");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj dystans Trasy");
											double dystanDodaj = Convert.ToDouble(Console.ReadLine());
											Trasa t_Add = new Trasa(dystanDodaj);
											LiniaL.dodajTrase(t_Add);
											break;
										case 3:
											Console.Clear();
											Console.WriteLine("Usuwanie Trasy");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj dystans Trasy");
											double dystanUsun = Convert.ToDouble(Console.ReadLine());
											Trasa t_Delete = new Trasa(dystanUsun);
											LiniaL.usunTrase(t_Delete);

											break;
										case 0:
											break;

									}

									break;
								case 6:
									Console.Clear();
									Console.WriteLine("Zarzadzanie Kientami:");
									Console.WriteLine("1. Wyœwietl dane");
									Console.WriteLine("2. Dodaj Klienta");
									Console.WriteLine("3. Usun Klienta");
									Console.WriteLine("0. Wyjdz");
									int wyborKlienta = Convert.ToInt32(Console.ReadLine());
									switch (wyborKlienta)
									{
										case 1:
											Console.WriteLine(LiniaL.getKlient());
											break;
										case 2:
											Console.Clear();
											Console.WriteLine("Dodawanie Klienta");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj ID");
											string idDodaj = Console.ReadLine();

											break;
										case 3:
											Console.Clear();
											Console.WriteLine("Usuwanie Trasy");
											Console.WriteLine(" ");
											Console.WriteLine("Podaj ID");
											string dystanUsun = Console.ReadLine();


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



							break;
						case 2:
							Console.Clear();
							Console.WriteLine("Witaj w systemie rezerwacji biletow firmy lotniczej LOT");
							LiniaLotnicza LiniaLot = new LiniaLotnicza("Lot");
							while (true)
							{

								Console.WriteLine("1. Rezerwuj bilet");
								Console.WriteLine("2. Szukaj po³aczen");
								Console.WriteLine("3. Wyœwietl loty");
								Console.WriteLine("4. Wyœwietl trasy");
								Console.WriteLine("5. Wyœwietl bilet");
								Console.WriteLine("6. Wyœwietl rezerwacja");
								Console.WriteLine("0. Wyjdz");
								int wybor1 = Convert.ToInt32(Console.ReadLine());


								switch (wybor1)
								{
									case 1:
										Console.Clear();
										Console.WriteLine("Dodawanie Trasy");
										Console.WriteLine(" ");
										Console.WriteLine("Podaj dystans Trasy");
										double dystanDodaj = Convert.ToDouble(Console.ReadLine());
										Trasa t_Add = new Trasa(dystanDodaj);





										break;


									case 2:

										break;
									case 3:
										Console.WriteLine(LiniaLot.getLoty());
										break;
									case 4:
										Console.WriteLine(LiniaLot.getTrasy());
										break;
									case 5:
										Console.WriteLine(LiniaLot.getLoty());
										break;
									case 0:
										break;

									default:
										break;
								}

							}


						default:
							Console.WriteLine("Nie ma takiej opcji");
							break;
					}

				}



			}
		}


	}