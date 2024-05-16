using System;
public class Unit2Challenge{
	public Weapon Rifle;
	
	public void Main()
	{
		Console.WriteLine("do ya like guns?");
		Console.WriteLine("yes/no");
		string answer = Console.ReadLine();
		Console.WriteLine("Well here you go anyway.");
		Rifle=new Weapon();
		Console.WriteLine("This " + Rifle.Weaponname + " holds " + Rifle.totalammo + " rounds ");
		Console.WriteLine("try firing it." + " [type fire] ");
		string action = Console.ReadLine();
		Rifle.ammocount--;
		Console.WriteLine("you now have " + Rifle.ammocount + " rounds in the mag. ");
								  
	}
}
public class Weapon{
	public int totalammo=35;
	public int ammocount=6;
	public string Weaponname= "Rifle";
	public float Damage=55.9f;
}

