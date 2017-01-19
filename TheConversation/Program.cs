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

			string userName;
			string userInput1;
			string userInput2;

			//
			// start the conversation
			//
			Console.WriteLine("Whats your name?");
			userName = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine("Hello, ", userName);
			// 
			// pause for user
			//
			Console.WriteLine();
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
