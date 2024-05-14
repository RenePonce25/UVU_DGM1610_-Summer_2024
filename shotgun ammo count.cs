using System;
					
public class Program
{
	public Weapon shotgun;
	
	public void Main()
	{
		shotgun=new Weapon();
		Console.WriteLine(shotgun.weaponname + " has ammo count of " + shotgun.ammocount);  
	}
}

    public class Weapon {
   public int ammocount=6; 
   public string weaponname= "shotgun";
   public float firepower=55.6f;
	}