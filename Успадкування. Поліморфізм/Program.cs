using System;


    public abstract class Shape
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : throw new ArgumentException("Radius must be positive"); }
        }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value > 0 ? value : throw new ArgumentException("Side length must be positive"); }
        }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("Circle 1", 3);
            Circle circle2 = new Circle("Circle 2", 5);

            Square square1 = new Square("Square 1", 4);
            Square square2 = new Square("Square 2", 7);

            Console.WriteLine($"{circle1.Name}: Area = {circle1.Area()}, Perimeter = {circle1.Perimeter()}");
            Console.WriteLine($"{circle2.Name}: Area = {circle2.Area()}, Perimeter = {circle2.Perimeter()}");
            Console.WriteLine($"{square1.Name}: Area = {square1.Area()}, Perimeter = {square1.Perimeter()}");
            Console.WriteLine($"{square2.Name}: Area = {square2.Area()}, Perimeter = {square2.Perimeter()}");

            Square largestSquare = square1.Area() > square2.Area() ? square1 : square2;
            Console.WriteLine($"\nLargest Square Area: {largestSquare.Area()} ({largestSquare.Name})");

            Circle largestCircle = circle1.Area() > circle2.Area() ? circle1 : circle2;
            Console.WriteLine($"Largest Circle Area: {largestCircle.Area()} ({largestCircle.Name})");
        }
    }
}

