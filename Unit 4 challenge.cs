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

	  