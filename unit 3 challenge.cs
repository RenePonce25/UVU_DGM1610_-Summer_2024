using System;
					
public class Program
{
	
 public static void Main()
	{
		int temp = 30;
		Console.WriteLine("Welcome. How is the weather out there?");
		int answer = Convert.ToInt32(Console.ReadLine());
		Compare(temp,answer);
		Console.WriteLine("Totaly unrelated, tell me what your grade percentage is.");
		Console.WriteLine("please use rounded numbers. Im not really that smart.");
		int answer2 = Convert.ToInt32(Console.ReadLine());
	 checkGrades(answer2);
	}
	
	public static void Compare (int temp,int answer){
	if(answer >	temp) {
		Console.WriteLine("Better drink some water and stay in the shade");
	} 
		else{
		Console.WriteLine("looks like a nice day for a stroll");}
	}
	public static void checkGrades(int answer2){
		 const int reallyGood = 92;
	   const int good = 82;
	   const int okay = 72;
	   const int minGrade = 50;
		switch(answer2){
				case (reallyGood):
				Console.WriteLine("Dang, im jealous.");
				break;
				case(good):
				Console.WriteLine("Youre doing good.");
				break;
				case(okay):
				Console.WriteLine("Awesome");
				break;
				case(minGrade):
				Console.WriteLine("Damn thats not looking so hot.");
				break;
	}
		
}
}

