using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Point9 {
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
        public abstract double perimeter();
        public abstract double area();
    }

    class Circle : Shape {
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
        public override double perimeter() {
            return (2 * a) + (2 * b);
        }
        public override double area() {
            return a * b;
        }
    }

    class Person {
        private double a;
        private double b;
        public Person(double a, double b) {
            this.a = a; this.b = b;
        }
        public double perimeter() {
            return (2 * a) + (2 * b);
        }
    }

    class Cylinder : Circle {
        double height;
        Point bod;
        public Cylinder(Circle kruh, double height) : base(kruh.center.x, kruh.center.y, kruh.r) {
            this.height = height;
            this.bod = kruh.center;
        }
        public double surface() {
            return (2 * base.area()) + (base.perimeter() * height);
        }
        public double volume() {
            return base.area() * height;
        }
        public override string ToString() {
            return $"Cylindr s plochou {surface()} a objemem {volume()} a středem v bodě " + bod.ToString();
        }
    }

    class TestPoint {
        public static void Mainx() {
            Point bod1 = new Point(3.621, 9.451);
            Point bod2 = new Point(4.694, 5.947);
            Circle kruh1 = new Circle();
            Rectangle rec1 = new Rectangle();
            Circle kruh = new Circle(20, 19, 3);
            Cylinder cylindr = new Cylinder(kruh, 20);
            Console.WriteLine(cylindr);
        }
    }
}



