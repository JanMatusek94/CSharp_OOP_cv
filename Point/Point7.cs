using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Point7 {

	interface IPerimeter {
		double perimeter();
	}

	class Point {
		private double x, y;
		public Point(double x, double y) {
			this.x = x;
			this.y = y;
		}

		public double getX() { return x; }
		public double getY() { return y; }
		public void setX(double x) { this.x = x; }
		public override string ToString() {
			return $"({x:0.00}; {y:0.00})";
		}
	}

	class Zapornahodnota : Exception {
		public Zapornahodnota(String s) : base(s) { }
	}

	abstract class Shape {
		public Point center;

		public Shape(Point center) {
			this.center = center;
		}
		public Shape() {
			this.center = new Point(0, 0);
		}
		public Shape(double x, double y) : this(new Point(x, y)) {
			//this.center = new Point(x, y);
		}
		//public Shape(Point center) : this(center.x, center.y ){ }

		public override string ToString() {
			return $"Tvar se středem: {center}";
		}
		public virtual void writeInfo() {
			Console.WriteLine($"Střed: {center}");
		}
		public abstract double area();
	}

	class Circle : Shape, IPerimeter {
		public double r;
		public Circle(Point center, double r) : base(center) {
			if (r < 0) {
				throw new Zapornahodnota("Zaporna hodnota polomeru kruhu");
			}
			else { this.r = r; }
		}
		public Circle() { }
		public Circle(double r) : this(new Point(0, 0), r) { }
		public Circle(double x, double y, double r) : this(new Point(x, y), r) { }
		public override string ToString() {
			return $"Kruh s poloměrem {r} a středem: {center}";
		}
		public override void writeInfo() {
			base.writeInfo();
			Console.WriteLine($"Kruh s poloměrem {r}, plochou {area()} a obvodem {perimeter()}\n");
		}
		public double perimeter() {
			return Math.Round(2 * Math.PI * r, 2);
		}
		public override double area() {
			return Math.PI * (r * r);
		}
	}

	class Rectangle : Shape, IPerimeter {
		//public Point center;
		public int a;
		public int b;
		public Rectangle(Point center, int a, int b) : base(center) {
			if (a > 0 || b > 0) {
				this.a = a;
				this.b = b;
			}
			else {
				throw new Zapornahodnota("Zaporna hdnota strany rektanglu");
			}
		}
		public Rectangle(int a, int b) : this(new Point(0, 0), a, b) { }
		public Rectangle() { }
		public Rectangle(Point center, int a) : this(center, a, a) { }
		public Rectangle(int a) : this(new Point(0, 0), a, a) { }
		public override string ToString() {
			return $"Obdélník se stranami 'a' a 'b': [{a},{b}] a středem: {center}";
		}
		public override void writeInfo() {
			base.writeInfo();
			Console.WriteLine($"Stred ctyruhelniku je v bode {center} se stranami {a}, {b}, plochou {area()} a obvodem {perimeter()}");
			if (a != b) { Console.WriteLine("Je to obdelnik. \n"); }   //rozlišení obdélníka od čtverce
			else { Console.WriteLine("Je to ctverec. \n"); }
		}
		public double perimeter() {
			return (2 * a) + (2 * b);
		}
		public override double area() {
			return a * b;
		}
	}

	class Person : IPerimeter {
		private double a;
		private double b;
		public Person(double a, double b) {
			this.a=a; this.b=b;
		}
		public double perimeter() {
			return (2 * a) + (2 * b);
		}
	}

	class TestPoint {
		public static void Mainx() {
			Point bod1 = new Point(3.621, 9.451);
			Point bod2 = new Point(4.694, 5.947);
			Circle kruh1 = new Circle();
			Rectangle rec1 = new Rectangle();
			bool ok;
			double polomer;
			int stranaA;
			int stranaB;
			bool parseA;
			bool parseB;
			do {
				ok = false;
				try {
					Console.WriteLine("Napiš poloměr kroužku");
					polomer = double.Parse(Console.ReadLine());
					kruh1.r = polomer;
					Console.WriteLine(kruh1);
				}
				catch (FormatException e) { Console.WriteLine(e.Message); ok = true; }
				catch (Zapornahodnota e) { Console.WriteLine(e.Message); ok = true; }
			} while (ok);

			do {
				ok = true;
				Console.WriteLine("Napiš stranu a");
				parseA = Int32.TryParse(Console.ReadLine(), out stranaA);
				Console.WriteLine("Napiš stranu b");
				parseB = Int32.TryParse(Console.ReadLine(), out stranaB);

				if ((!parseA && stranaA == 0) || (!parseB && stranaB == 0)) {
					Console.WriteLine("Zadej znovu");
				}
				else {
					ok = false;
					rec1.a = stranaA;
					rec1.b = stranaB;
					Console.WriteLine(rec1);
				}
			} while (ok);
			Point bod = new Point(20.123456, 30.987654);
			Circle kruh10 = new Circle(3);
			Circle kruh2 = new Circle(new Point(20.351, 19.232), 2);
			Circle kruh3 = new Circle(9.12384, 61.974, 6);
			Rectangle obd1 = new Rectangle(6);
			Rectangle obd2 = new Rectangle(7, 9);
			Rectangle obd3 = new Rectangle(new Point(21.321, 36.1584), 8);
			Rectangle obd4 = new Rectangle(bod, 6, 4);
			Person osoba1 = new Person(9, 5);
			Person osoba2 = new Person(10, 6);

			IPerimeter[] tvary = new IPerimeter[] { kruh1, kruh2, kruh3, kruh10, obd1, obd2, obd3, obd4, rec1, osoba2, osoba1};
			double soucetObvodu = 0;
			double soucetObvodu2 = 0;
			double soucetObvodu3 = 0;

			for (int i = 0; i < tvary.Length; i++) {
					soucetObvodu += tvary[i].perimeter();
					Console.WriteLine(tvary[i].perimeter());
				}
			Console.WriteLine("Součet obvodů všech kruhů, obdélníků a osob je " + soucetObvodu);

			List<IPerimeter> tvaryList = new List<IPerimeter>() { kruh1, kruh2, kruh3, kruh10, obd1, obd2, obd3, obd4, rec1, osoba1, osoba2 };

			foreach (IPerimeter item in tvaryList) {
					soucetObvodu2 += item.perimeter();
				Console.WriteLine(item.perimeter());
			}
			Console.WriteLine("Součet obvodů všech kruhů, obdélníků a osob z Listu je " + soucetObvodu2);

			ArrayList tvaryArrayList = new ArrayList() { kruh1, kruh2, kruh3, kruh10, obd1, obd2, obd3, obd4, rec1, osoba1, osoba2 };
			foreach (IPerimeter item in tvaryArrayList) {
					soucetObvodu3 += item.perimeter();
					Console.WriteLine(item.perimeter());
			}
			Console.WriteLine("Součet obvodů všech kruhů, obdélníků a osob z ArrayListu je " + soucetObvodu3);
		}
	}
}



