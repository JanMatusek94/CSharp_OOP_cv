using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Point5 {
    class Point {
        public double x;
        public double y;
        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }
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
        public abstract double perimeter();
        public abstract double area();
    }

    class Circle : Shape {
        public double r;
        public Circle(Point center, double r) : base(center) {
                if (r < 0) {
                    throw new Zapornahodnota("Zaporna hodnota polomeru kruhu");
            }
        }
        public Circle(double r) : this(new Point(0, 0), r) {
        }
        public Circle(double x, double y, double r) : this(new Point(x, y),r) {
        }
        public override string ToString() {
            return $"Kruh s poloměrem {r} a středem: {center}";
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine($"Kruh s poloměrem {r}, plochou {area()} a obvodem {perimeter()}\n");
        }
        public override double perimeter() {
            return Math.Round(2 * Math.PI * r, 2);
        }
        public override double area() {
            return Math.PI * (r * r);
        }
    }

    class Rectangle : Shape {
        //public Point center;
        public int a;
        public int b;
        public Rectangle(Point center, int a, int b) : base(center) {
            if (a > 0 || b > 0) {
                this.a = a;
                this.b = b;
            } else {
                throw new Zapornahodnota("Zaporna hdnota strany rektanglu");
            }

        }
        public Rectangle(int a, int b) : this(new Point(0, 0), a, b) {
        }
        public Rectangle(Point center, int a) : this(center, a, a) {
        }
        public Rectangle(int a) : this(new Point(0, 0), a, a) {
        }
        public override string ToString() {
            return $"Obdélník se stranami 'a' a 'b': [{a},{b}] a středem: {center}";
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine($"Stred ctyruhelniku je v bode {center} se stranami {a}, {b}, plochou {area()} a obvodem {perimeter()}");
            if (a != b) { Console.WriteLine("Je to obdelnik. \n"); }   //rozlišení obdélníka od čtverce
            else { Console.WriteLine("Je to ctverec. \n"); }
        }
        public override double perimeter() {
            return (2 * a) + (2 * b);
        }
        public override double area() {
            return a * b;
        }
    }

    class TestPoint {
        public static void Mainx() {
            bool ok;
            double polomer;
            int stranaA;
            int stranaB;
            do {
                ok = false;
                try {
                    Console.WriteLine("Napiš poloměr kroužku");
                    polomer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Napiš stranu a");
                    Int32.TryParse(Console.ReadLine(), out stranaA);
                    Console.WriteLine("Napiš stranu b");
                    Int32.TryParse(Console.ReadLine(), out stranaB);
                    Circle kruh1 = new Circle(polomer);
                    Rectangle rec1 = new Rectangle(stranaA, stranaB);
                    Console.WriteLine(kruh1);
                    Console.WriteLine(rec1);
                }
                catch (FormatException e) { Console.WriteLine(e.Message); ok = true; }
                catch (Zapornahodnota e) { Console.WriteLine(e.Message); ok = true; }

            } while (ok);
        }
    }
}



