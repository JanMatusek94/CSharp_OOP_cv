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
       public static void Mainx(string[] args) {
            string cesta = @"C:\Users\programator\test";
            StreamReader vstup = new StreamReader(cesta+"\\dnyyy.txt");
            StreamReader vstup2 = new StreamReader(cesta + "\\hodiny.txt");
            int hodiny;
            int dny;
            dny = int.Parse(vstup.ReadToEnd());
            hodiny = int.Parse(vstup2.ReadToEnd());


            Console.WriteLine("\n{0} dnu a {1} hodiny je {2} hodin\n", dny, hodiny, (dny * 24) + hodiny);
            Console.WriteLine("\n" + dny + " dnu a " + hodiny + "hodiny je " + ((dny * 24) + hodiny) + " hodin\n"); //druhá možnost
        }
    }
}