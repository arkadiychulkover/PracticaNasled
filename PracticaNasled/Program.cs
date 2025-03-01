namespace PracticaNasled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"C Area: {circle.Area()}");
            Console.WriteLine($"C Perimeter: {circle.Perimeter()}");
            Square square = new Square(5);
            Console.WriteLine($"Sq Area: {square.Area()}");
            Console.WriteLine($"Sq Perimeter: {square.Perimeter()}");

        }
    }

    //public class Human
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Human(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //    public virtual void DoWork()
    //    {
    //        Console.WriteLine($"{Name} is working, Age: {Age}");
    //    }
    //}

    //public class Worker : Human
    //{
    //    public Worker(string name, int age) : base(name, age)
    //    {
    //    }
    //    public override void DoWork()
    //    {
    //        Console.WriteLine($"{Name} is working as a worker, Age: {Age}");
    //    }
    //}

    public abstract class  Figura
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class  Triengle : Figura
    {
        private int a, b, c;
        public Triengle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            return (double)(p * (p - a) * (p - b) * (p - c));
        }
        public override double Perimeter()
        {
            return a + b + c;
        }
    }

    public class  Square : Figura
    {
        private int a;
        public Square(int a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }
        public override double Perimeter()
        {
            return 4 * a;
        }
    }

    public class  Romb : Figura
    {
        private int a, b;
        public Romb(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a * b / 2;
        }
        public override double Perimeter()
        {
            return 2 * (a + b);
        }
    }

    public class  Pramokut : Figura
    {
        private int a, b;
        public Pramokut(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a * b;
        }
        public override double Perimeter()
        {
            return 2 * (a + b);
        }
    }

    public class  Paralelogram
    {
        private int a, b;
        public Paralelogram(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double Area()
        {
            return a * b;
        }
        public double Perimeter()
        {
            return 2 * (a + b);
        }
    }

    public class Trapezia : Figura
    {
        private int a, b, c, d;
        public Trapezia(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override double Area()
        {
            return (a + b) / 2 * c;
        }
        public override double Perimeter()
        {
            return a + b + c + d;
        }
    }

    public class Circle : Figura
    {
        private int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return 3.14 * r * r;
        }
        public override double Perimeter()
        {
            return 3.14 * 2 * r;
        }
    }

    public class Ellipse : Figura
    {
        private int a, b;
        public Ellipse(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return 3.14 * a * b;
        }
        public override double Perimeter()
        {
            return 3.14 * (a + b);
        }
    }
}
