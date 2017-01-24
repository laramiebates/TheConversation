using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//
			// variables
			//

			int age;

			//
			// start the conversation
			//

			Console.Write("What is your name? ");
			string userName = Console.ReadLine();
			Console.WriteLine();


			//
			// get user age
			//

			Console.Write("What is your age? ");
			age = int.Parse(Console.ReadLine());

			Console.WriteLine("Hello, " + userName + "you are " + age + " years old!");
			//Console.WriteLine("{0} you are {1} years old", userName, age)

			//
			// continue the conversation
			//

			Console.WriteLine("Would you like to talk? ");
			Console.Write("Type Yes or No: ");
			string startConvo = Console.ReadLine();

			if (startConvo == "yes")
				
			{
				//
				// variables
				//

				string visitedSites;
				string recommendSites;
				string userAnswer;

				// has user visited historical sites

				Console.WriteLine("Great lets get started!");
				Console.Write("Have you visited any historical sites in our area?");
				visitedSites = Console.ReadLine();

				// yes visited historical sites

				if (visitedSites == "yes")

				{

					Console.WriteLine("Great! There are so many beautiful ones to visit." +
									  " Maybe I can recommend some you havent visited, is it ok if I ask a few questions?");
				}

				// no has not visited sites

				else if (visitedSites == "no")

				{

					Console.Write("Thats unfortunate, but there is still time! Ill ask you about a few of your interests and then recommend some sites to visit, is that okay?");

					recommendSites = Console.ReadLine();

					// yes recommend sites

					if (recommendSites == "yes")

					{
						// lakes or forests

						Console.Write("Lets start, would you say you are more interested in the Great Lakes or our great forests?");
						userAnswer = Console.ReadLine();

					}

					// do not recommend sites

					else

					{

						Console.WriteLine("I'm sorry to hear that, have a nice day, " + userName);

					}
				}

				else

				{

					Console.WriteLine("I dont understand! You must type yes or no");

				}

			}

			else {

					Console.WriteLine("Thats disappointing, " + userName);
			
			}
					
			// 
			// pause for user input to exit
			//

			Console.WriteLine();
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
