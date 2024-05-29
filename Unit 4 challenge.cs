using System;
					
public class Program
{
	public static void Main()
	{
		 Random random = new Random();
        int randomNumber = random.Next(1, 11);
		int numberOfAttempts = 0;
        bool correctGuess = false;
		
		Console.WriteLine("Lets play a game. Guess a number between 1 and 10.");
		
		while(!correctGuess){
		int answer = Convert.ToInt32(Console.ReadLine());
		  numberOfAttempts++;
		  correctGuess = checkAnswer(answer, randomNumber, numberOfAttempts);
		}
		  Console.WriteLine("Let me get to know you. What's your favorite food?");
        string[] favoriteFoods ={"pizza","hamburgers","hawaian BBQ","sushi","tacos"}; 
		Console.WriteLine(favoriteFoods.Length);
		foreach(var food in favoriteFoods){
			Console.WriteLine(food);}
		 for (int i = 0; i < favoriteFoods.Length; i++);
		 Console.WriteLine("Enter your favorite food:");
        string userInput = Console.ReadLine();
		bool found = false;
        foreach (string food in favoriteFoods)
        {
            if (userInput.Equals(food, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }
   if (found)
        {
            Console.WriteLine("I love " + userInput + "!");
        }
        else
        {
            Console.WriteLine("Sorry, that food is not in our list.");
        }
		}
		 public static bool checkAnswer(int answer, int randomNumber, int numberOfAttempts){
		 if (answer == randomNumber)
            {
                Console.WriteLine("Ayyy!! You got it in only " + numberOfAttempts + " tries.");
			 return true;
            }
            else if (answer < randomNumber)
            {
                Console.WriteLine("A little cold Try again.");
            }
            else
            {
                Console.WriteLine("Too hot! Try again.");
			  }
			 return false;
		}
	}