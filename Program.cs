using System;

namespace RigaCodingW3D1
{
	class Program
	{
		static void Main(string[] args)
		{
			Greeting();
		}


		static void Largest()
		{
			//1) Cilvēks ievada 6 skaitlus, izvadām lielāko.
			int largest = 0;
			for (int i = 1; i <= 6; i++)
			{
				Console.WriteLine($"input digit #{i}");
				int input = Convert.ToInt32(Console.ReadLine());
				if (input > largest)
				{
					largest = input;
				}
			}
			Console.WriteLine($"{largest} was the largest");
		}

		static void DegreeConvert()
		{
			//2) Uztaisīt programmu, kurā cilvēks var ievadīt, cik ārā ir grādi(pēc fārenheita) un šo ievadu pārkonvertē uz grādiem pēc celsija un izvadam rezultātu.
			//https://www.rapidtables.com/convert/temperature/how-fahrenheit-to-celsius.html

			Console.WriteLine("Temperature outside in Fahrenheit:");
			int fahr = Convert.ToInt32(Console.ReadLine());
			double cels = (fahr - 32) / 1.8;
			Console.WriteLine($"in Celsium outside is {cels}");

		}

		static void DrawBox()
		{
			//3) Lietotājs ievada 1 skaitli(augstums) un otru(platums) un tad izvadam kasti no # simbola.
			//Piemērs- cilvēks ievada 4 kā augstumu un 5 kā platumu un tiek izvadīts

			//#####
			//#####
			//#####
			//#####

			Console.WriteLine("Height:");
			int height = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Width:");
			int width = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < height; i++)
			{
				string result = null;
				string hashtag = "#";
				for (int ia = 0; ia < width; ia++)
				{
					result = result + hashtag;
				}
				Console.WriteLine(result);
			}

		}

		static void Contains()
		{
			//4) Cilvēks ievada simbolu virkni.Pārbaudīt vai simbolu virkne satur vārdus "suns" vai "zirgs". Ja satur, tad liekam ievadīt vēlreiz un vēlreiz, kamēr ievade nav bez šiem vārdiem.
			//https://www.geeksforgeeks.org/c-sharp-string-contains-method/ Jāizmanto String.contains metode.
			bool present = true;
			string input = null;
			Console.WriteLine("Insert words without using SUNS or ZIRGS");
			while (present == true)
			{
				input = Console.ReadLine().ToLower();
				if (input.Contains("suns") || input.Contains("zirgs"))
				{
					Console.WriteLine("Try again");

				}
				else
				{
					present = !present;
					Console.WriteLine("Well done!!");
				}

			}

		}

		static void Game()
		{
			//5) Spēle- 1. spēlētājs ievada minamo vārdu.Otrais spēlētājs var minēt 5 reizes, ja nav uzminējis, tad uzvar 1. Ja uzmin, tad jāparādā, ka uzvar 2. spēlētājs.
			Console.WriteLine("Input a word to guess:");
			string riddle = Console.ReadLine().ToLower();
			Console.Clear();
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Try and guess");
				string guess = Console.ReadLine().ToLower();
				if (guess == riddle)
				{
					Console.WriteLine("Well done");
					break;
				}
				else if (guess.Contains(riddle))
				{
					Console.WriteLine("somewhere in the middle");
				}
				else
				{
					Console.WriteLine("Try again");
				}
				Console.Clear();
				Console.WriteLine("Game Over");
			}

		}

		static void Greeting()
		{
			//6) Cilvēks ievada savu vārdu, programma ar viņu sasveicinās.

			Console.WriteLine("Hello world! What's your name?");
			string input = Console.ReadLine();
			Console.WriteLine($"Hello {input}!");

			bool a = true;
			while (a == true)
			{
				input = QuestionBlock();
				if (input == "Draw a box" || input == "1")
				{
					DrawBox();
				}
				else if (input == "play a game" || input == "2")
				{
					Game();
				}
				else if (input == "convert degree" || input == "3")
				{
					DegreeConvert();
				}
				else if (input == "get a largest number" || input == "4")
				{
					Largest();
				}
				else
				{
					Console.WriteLine("Bye");
					break;
				}
			}
		}
		static string QuestionBlock()
		{
			Console.WriteLine("Select what you want to do?");
			Console.WriteLine("1. Draw a box");
			Console.WriteLine("2. Play a game");
			Console.WriteLine("3. Convert degree");
			Console.WriteLine("4. get a largest number");
			string input = Console.ReadLine().ToLower();
			return input;
		}
	}
}
