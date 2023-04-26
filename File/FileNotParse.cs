using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace File {
    internal class FileNotParse {
        public static void Mainx() {
            string path = @"C:\Users\programator\test\jjnn.txt";
            StreamWriter vystup = new StreamWriter(path);
            string text = "Ahoj, toto je zkouska siren";
            vystup.Write(text);
            vystup.Close();

            StreamReader vstup = new StreamReader(path);
            string line = vstup.ReadLine();
            Console.WriteLine(line);

        }
    }
}
