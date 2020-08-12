using System;

namespace Lyckohjulet
{
	public static class Program
	{
		// Det här är en metod, tänk funktion som i Javascript för mig.
		public static void Main(string[] args)
		{

			//Här instansierar jag min klass Tal så jag kan använda den här.
			//Exempel på en instansiering av en klass är, Tal gissatTal = new Tal();
			Tal gissatTal = new Tal();
			SlumpTalsGenerator slumpTal = new SlumpTalsGenerator();

			Console.WriteLine("\n");
			Console.WriteLine("\tVÄLKOMMEN TILL LYCKOHJULET!");
			Console.WriteLine("\t----------------------------------------");
			Console.WriteLine("\n");
			Console.WriteLine("Här gäller det att se om du gissat på rätt nummer som datorn slumpat ut.");
			Console.WriteLine("\n");
			Console.WriteLine("Skriv ett tal mellan 1 - 10");
			string input = gissatTal.talet = Console.ReadLine();
			bool success = int.TryParse(input, out int result);

			while (!success)
			{
				Console.WriteLine("Du har inte angett en siffra. Försök igen.");
				Console.WriteLine("Ange en siffra");
				input = Console.ReadLine();
				success = int.TryParse(input, out result);
			}
			string x = KollaTalet(result, slumpTal.slumpatTal);

			Console.WriteLine(x);
			Console.ReadLine();

		}

		private static string KollaTalet(int gissadeTalet, int genereratTal)
		{
			//Skriver ut det slumpade talet av programmet.
			Console.WriteLine(genereratTal);

			string correct;
			if (gissadeTalet != genereratTal)
			{
				Console.WriteLine("Fel svar. Gissa igen.");
				string nyttSvar = Console.ReadLine();
				
				bool success = int.TryParse(nyttSvar, out _);
				while (!success)
				{
					Console.WriteLine("Du har inte angett en siffra. Försök igen.");
					Console.WriteLine("Ange en siffra");
					nyttSvar = Console.ReadLine();
					success = int.TryParse(nyttSvar, out _);
				}
				correct = $"\nGrattis du gissade rätt på siffran {nyttSvar}! \nTryck på [{ConsoleKey.Enter}] för att avsluta.";
				return correct;
			}

			ConsoleKey continueKey = ConsoleKey.Enter;
			correct = $"\nGrattis du gissade rätt på siffran {gissadeTalet}! \nTryck på [{continueKey}] för att avsluta.";
			return correct;



		}
	}
}
