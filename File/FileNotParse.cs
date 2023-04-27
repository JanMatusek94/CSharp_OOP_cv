using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;


//2.nejjednodušší verze zápisu a čtení, tedy uložení a načtení nějakého celého textu (čili text se nebude parsovat). 
//  Takže podobně jednoduché jako čtení a zápis ve zkoušce z formuláře ve VB. Soubor FileNotParse.cs

namespace Filee {
  internal class FileNotParse {
    public static void Mainx() {
      //ČTENÍ A ZÁPIS Z JEDNOHO STRINGU POMOCI STREAMWRITER & STREAMREADER
      string path = @"C:\Users\ACER\Test\teststream.txt";
      StreamWriter vystup = new StreamWriter(path);
      string text = "Ahoj, toto je zkouska siren";
      vystup.Write(text);
      vystup.Close();

      StreamReader vstup = new StreamReader(path);
      string line = vstup.ReadLine();
      Console.WriteLine(line);
      vstup.Close();

      //ČTENÍ A ZÁPIS POMOCÍ TŘÍDY FILE
			string path2 = @"C:\Users\ACER\Test\teststream2.txt";
      string line2;
      File.WriteAllText(path2, "zkouška siren 2");
      line2 = File.ReadAllText(path2);
      Console.WriteLine(line2);

      //ČTENÍ A ZAPIS Z POLE POMOCI TRIDY FILE
      string path3 = @"C:\Users\ACER\Test\teststream3.txt";
			int[] poleI = new int[20];
      for (int i = 1; i < poleI.Length; i++) {
        poleI[i] = i;
      }
      string[] poleS = new string[20];
      for (int i = 1; i < poleS.Length; i++) {
        poleS[i] = poleI[i].ToString();
      }
      File.WriteAllLines(path3, poleS);
      string[] poleS2 = File.ReadAllLines(path3);


		}
  }
}
