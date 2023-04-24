using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point1 {
	class Point {
		private double x;
		private double y;
		public Point(double x, double y) {
			this.x = x;
			this.y = y;
		}
		public override string ToString() {
			return $"({x:0.00}; {y:0.00})";
		}
	}

	class Shape {
		public Point center;

		public Shape(Point center) {
			this.center = center;
		}
		public Shape(double x, double y) {
			center = new Point(x, y);
		}
		public override string ToString() {
			return $"Tvar se středem: {center}";
		}
	}

	class Circle : Shape {
		public double r;
		public Circle(Point center, int r) : base(center){
			this.r = r;
		}
		public Circle(int r) : base(new Point(0,0)){
			this.r = r;
		}
		public Circle(double x, double y, double r) : base(new Point(x,y)) {
			this.r = r;
		}
		public override string ToString() {
			return $"Kruh s poloměrem {r} a středem: {center}";
		}
	}

	class Rectangle : Shape {
		//public Point center;
		public int a;
		public int b;
		public Rectangle(Point center, int a, int b) : base(center) {
			this.a = a;
			this.b = b;
		}
		public Rectangle(int a, int b) : base (new Point(0,0)){
			this.a = a;
			this.b = b;
		}
		public Rectangle(Point center, int a) : base(center){
			this.a = a;
			b = a;
		}
		public Rectangle(int a) : base(new Point(0,0)){
			this.a = a;
			b = a;
		}
		public override string ToString() {
			return $"Obdélník se stranami 'a' a 'b': [{a},{b}] a středem: {center}";
		}
	}

	class TestPoint {
		public static void Mainx() {
			Point bod = new Point(20.123456, 30.987654);
			Shape tvar = new Shape(bod);
			Shape tvar2 = new Shape(15.3589411, 30.139784);
			Circle kruh1 = new Circle(3);
			Circle kruh2 = new Circle(new Point(20.351, 19.232), 2);
			Circle kruh3 = new Circle(9.12384, 61.974, 6);
			Rectangle obd1 = new Rectangle(6);
			Rectangle obd2 = new Rectangle(7, 9);
			Rectangle obd3 = new Rectangle(new Point(21.321,36.1584), 8);
			Rectangle obd4 = new Rectangle(bod, 6, 4);
			Console.WriteLine(bod);
			Console.WriteLine(tvar);
			Console.WriteLine(tvar2);
			Console.WriteLine(kruh1);
			Console.WriteLine(kruh2);
			Console.WriteLine(kruh3);
			Console.WriteLine(obd1);
			Console.WriteLine(obd2);
			Console.WriteLine(obd3);
			Console.WriteLine(obd4);
        }
	}
}
