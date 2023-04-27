using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
//Zadejte počet dnů a hodin. Program vypočte, kolik je to hodin (výsledek může být reálné číslo)
namespace PredelaniCvzVB {
	//class A1 {
	//    static void Mainx(string[] args) {
	//        int dny;
	//        int hodiny;

	//        Console.Write("Zadejte pocet dnu: ");
	//        dny = int.Parse(Console.ReadLine());
	//        Console.Write("Zadejte pocet hodin: ");
	//        hodiny = int.Parse(Console.ReadLine());
	//        Console.WriteLine("\n{0} dnu a {1} hodiny je {2} hodin\n", dny, hodiny, (dny * 24) + hodiny);
	//        Console.WriteLine("\n" + dny + " dnu a " + hodiny + "hodiny je " + (dny * 24) + hodiny + " hodin\n"); //druhá možnost
	//    }
	//}
	class A1FileStr {
		public static void Mainx() {
			string cesta = "C:\\Users\\ACER\\Test\\vstup.txt";
			int celkem, dny, hodiny, pokus;
			try {
				StreamReader vstup = new StreamReader(cesta);
				StreamWriter vystup = new StreamWriter("C:\\Users\\ACER\\Test\\vystup.txt", true);     //tady se nastavi to pridavani
				if (File.Exists(cesta)) {
					int j = 0;
					//                    string[] poleS = File.ReadAllLines(cesta);
					string[] poleS = new string[2];
					while (!vstup.EndOfStream) {
						poleS[j] = vstup.ReadLine();
						j++;
					}
					try {
						dny = Convert.ToInt32(poleS[0]);
						hodiny = Convert.ToInt32(poleS[1]);
						//pokus = Convert.ToInt32(poleS[2]);        //zkouska cteni za koncem souboru
						celkem = dny * 24 + hodiny;
						Console.WriteLine("Celkem " + celkem.ToString());

						if (File.Exists("C:\\Users\\ACER\\Test\\vystup.txt")) {
							vystup.WriteLine(celkem.ToString());
							vystup.Close();
							//File.WriteAllText("C:\\Kurs\\Soubory\\celkemhodin.txt", celkem.ToString());
						}
						else {
							File.Create("C:\\Users\\ACER\\Test\\vystup.txt");
							vystup.WriteLine(celkem.ToString());
							vystup.Close();
							//File.WriteAllText(@"C:\Kurs\Soubory\celkemhodin.txt", celkem.ToString());
						}
					}
					catch (FormatException e) {
						Console.WriteLine("Spatny format cisla. " + e.Message);
					}
					catch (IndexOutOfRangeException e) {
						Console.WriteLine("Pokus o cteni za koncem souboru");
					}
				}
			}
			catch (FileNotFoundException e) {
				Console.WriteLine("Soubor nenalezen! " + e.Message);
			}
			catch (Exception e) {
				Console.WriteLine("Nastala nejaka divna chyba" +e.Message);
			}
		}
	}
}
