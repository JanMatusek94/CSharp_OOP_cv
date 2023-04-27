using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDelete{
    internal class FilesDelete {

        public static void Mainx() {
            int smazat;
            bool ok;
            string path = @"C:\Users\ACER\Test";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fajly = dir.GetFiles();
      if (dir.Exists) {
        Console.WriteLine("Cesta existuje, má {0} souborů", fajly.Length);
        foreach (FileInfo file in fajly) {
          Console.WriteLine(file);
        }
      } else {
        Console.WriteLine("cesta neexistuje brasko");
      }
            do {
                Console.WriteLine($"Který soubor chceš smáznout? stiskni 1-{fajly.Length}");
                ok = Int32.TryParse(Console.ReadLine(), out smazat);

                if ((!ok && smazat == 0) || smazat > fajly.Length) {
                    Console.WriteLine("Zadej znovu");
                    ok = false;
                }
                else {
                    path = $"{fajly[smazat - 1].FullName}";
                    FileInfo fajl = new FileInfo(path);
                    fajl.Delete();
                }
            } while (!ok);
            foreach (FileInfo file in dir.GetFiles()) {
                Console.WriteLine(file);
            }
        }
    }
}
