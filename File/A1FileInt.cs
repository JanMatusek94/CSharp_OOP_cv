using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1FileInt {
	internal class A1FileInt {
		public static void Mainx() {
			string cesta = "C:\\Users\\ACER\\Test\\byty.dat";
			int celkem, dny, hodiny;
			int[] proZapis = new int[2];
			proZapis[0] = 6;
			proZapis[1] = 12;
			try {

				FileStream fs = new FileStream(cesta, FileMode.Create);
				BinaryWriter bw = new BinaryWriter(fs);
				BinaryReader br = new BinaryReader(fs);


				if (File.Exists(cesta)) {
					for (int i = 0; i < 2; i++) {
						bw.Write(proZapis[i]);
					}
					fs.Seek(0, SeekOrigin.Begin);
					dny = br.ReadInt32();
					hodiny = br.ReadInt32();
					bw.Close(); br.Close(); fs.Close();
					celkem = dny * 24 + hodiny;
					Console.WriteLine("Celkem " + celkem.ToString());
				}
				else {
					Console.WriteLine("Soubor neexistuje!");
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
