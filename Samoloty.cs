using System;
namespace Samolot
public abstract class Samolot
{
	protected double Zasieg;
	protected string Id;
	protected int LiczbaMiejsc
	public Samolot(double zasieg, string id, int liczbamiejsc) { this.Zasieg = zasieg;this.Id = id;this.LiczbaMiejsc = liczbamiejsc; }
	public double getZasieg(return this.Zasieg;)
	public string getId(return this.Id;)
}
public class Dlugodystansowy : Samolot
{ }
public class Sredniodystansowy : Samolot
{ }
public class Regionalny : Samolot
{ }



