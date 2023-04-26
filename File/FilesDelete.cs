using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDelete{
    internal class File {

        public static void Mainx() {
            int smazat;
            bool ok;
            string path = @"C:\Users\programator\test";
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles()) {
                Console.WriteLine(file);
            }
            do {
                Console.WriteLine($"Který soubor chceš smáznout? stiskni 1-{dir.GetFiles().Length}");
                ok = Int32.TryParse(Console.ReadLine(), out smazat);

                if ((!ok && smazat == 0) || smazat > dir.GetFiles().Length) {
                    Console.WriteLine("Zadej znovu");
                    ok = false;
                }
                else {
                    path = $"{dir.GetFiles()[smazat - 1].FullName}";
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
