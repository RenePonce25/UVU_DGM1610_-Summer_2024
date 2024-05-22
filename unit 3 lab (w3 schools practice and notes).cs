using System;

namespace unit3Lab
{
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
      Console.WriteLine("I am Learning C#");
      Console.WriteLine("It is awesome!");
		Console.WriteLine(3 + 3);
		
		Console.Write("This is pretty neat.");
      Console.Write("Hell yeah!!");
		Console.WriteLine("Fortnite battlepass");  // so i can leave comments and notes if i need to.
		/* this might be harder to remember but it
		is very usefull*/
		string name = "Cornelius";
Console.WriteLine(name);
		int myNum = 250;
Console.WriteLine(myNum);
		/* so i learned what a char is which seems simple enough, but im still confused about what a bool is and how you use it.
		Rather im confused on when you would use a bool.*/
		
		const int health = 20;
        int y = 10;
        Console.WriteLine(health - y);
		int x, z;
		x = 21; 
		z = 50;
		Console.WriteLine(x + y + z);
		
		long bigNum = 600000L;
		Console.WriteLine(bigNum + " thats alot of damage.");// so floats and double are pretty much the same thing except floats do smaller fractions.
		float f1 = 35e3F;
		Console.WriteLine(f1);// not a big fan of math but thats pretty cool.
		int myInt = 9;
        double myDouble = myInt;       
        Console.WriteLine(myInt);      
        Console.WriteLine(myDouble);// i didnt really understand this cause they still came out to the same number.but doing it manually it shows 2 difrent values.
		
		int random = 10;
double dude = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(random));    
Console.WriteLine(Convert.ToDouble(random));    
Console.WriteLine(Convert.ToInt32(dude));  //i had already done this without really knowing what it was, but it cool to know what it is now.
Console.WriteLine(Convert.ToString(myBool)); 
		
		Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());//i was having trouble with this before because i couldnt cast inside the readline. can you old convert read lines and not the other way around?
Console.WriteLine("Your age is: " + age);
		
		int badGrade = 50;
if (badGrade < 70 ) 
{
  Console.WriteLine("pretty good.");
} 
else if (badGrade < 90) 
{
  Console.WriteLine("Thats awesome.");
} 
else 
{
  Console.WriteLine("I dont know what to tell you dude.");
}
// im wondering if theres a limit to how many else if lines i can write cause it was supposed to be only true or false
		
		
		
		
	}
}
}