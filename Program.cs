using System;

namespace RigaCodingW3D1
{
	class Program
	{
		static void Main(string[] args)
		{
			Largest();
		}

//1) Cilvēks ievada 6 skaitlus, izvadām lielāko.
		static void Largest()
		{
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

//2) Uztaisīt programmu, kurā cilvēks var ievadīt, cik ārā ir grādi(pēc fārenheita) un šo ievadu pārkonvertē uz grādiem pēc celsija un izvadam rezultātu.
//https://www.rapidtables.com/convert/temperature/how-fahrenheit-to-celsius.html

//3) Lietotājs ievada 1 skaitli(augstums) un otru(platums) un tad izvadam kasti no # simbola.
//Piemērs- cilvēks ievada 4 kā augstumu un 5 kā platumu un tiek izvadīts

//#####
//#####
//#####
//#####

//4) Cilvēks ievada simbolu virkni.Pārbaudīt vai simbolu virkne satur vārdus "suns" vai "zirgs". Ja satur, tad liekam ievadīt vēlreiz un vēlreiz, kamēr ievade nav bez šiem vārdiem.
//https://www.geeksforgeeks.org/c-sharp-string-contains-method/ Jāizmanto String.contains metode.

//5) Spēle- 1. spēlētājs ievada minamo vārdu.Otrais spēlētājs var minēt 5 reizes, ja nav uzminējis, tad uzvar 1. Ja uzmin, tad jāparādā, ka uzvar 2. spēlētājs.

//6) Cilvēks ievada savu vārdu, programma ar viņu sasveicinās.
	}
}
