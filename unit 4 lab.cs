using System;
					
public class Program
{
	public static void Main()
	{
		
		string[] guns = {"M1911","Glock 18","MP5","M16","AK-47"};
		Console.WriteLine(guns.Length);
		for(var i = 0; i < guns.Length ; i++){
			guns [i] = "Weapon broken";
		}
		foreach(var gun in guns){
			Console.WriteLine(gun);
		}

			fireArms[] newgun = {new fireArms (), new fireArms ()};
			newgun[1].weaponName = "Defender";
			newgun[1].damage = 66;
			foreach(var weapon in newgun){
			Console.WriteLine(weapon.weaponName);
				Console.WriteLine(weapon.damage);
			}
			}
	public void Pyramid(){
	Console.WriteLine("Lets build a pyramid.Give me a whole munber");
		int rows;
		
		while(!int.TryParse(Console.ReadLine(), out rows) || rows <= 0){
		Console.WriteLine("Give me a munber bigger than zero dude.");
		}
		
	}
		public static void buildPyramid( int rows){
	  for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
	}

		


public class fireArms{
	public string weaponName = "M14A1";
		public int damage = 45;
}



