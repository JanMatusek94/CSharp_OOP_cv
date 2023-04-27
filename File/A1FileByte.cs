using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1FileByte {
	internal class A1FileByte {
		public static void Mainx() {
			string cesta = "C:\\Users\\ACER\\Test\\byty.dat";
			int celkem, dny, hodiny;
			byte[] proZapis = new byte[2];
			proZapis[0] = 6;
			proZapis[1] = 12;
			try {

				using (FileStream fs = new FileStream(cesta, FileMode.Create)) {


					if (File.Exists(cesta)) {
						for (int i = 0; i < 2; i++) {
							fs.WriteByte(proZapis[i]);
						}
						fs.Seek(0, SeekOrigin.Begin);
						dny = fs.ReadByte();
						hodiny = fs.ReadByte();
						fs.Close();
						celkem = dny * 24 + hodiny;
						Console.WriteLine("Celkem " + celkem.ToString());
						
					}
					else {
						Console.WriteLine("Soubor neexistuje!");
					}
				}
			}
			catch (FileNotFoundException e) {
				Console.WriteLine("Soubor nenalezen! " + e.Message);
			}
			catch (Exception e) {
				Console.WriteLine("Nastala nejaka divna chyba" + e.Message);
			}
		}
	}
}
