using static System.Math;

namespace Geometry
{
    public class Triangle : GeometryFigure
    {
        private Side _a, _b, _c;

        public double A 
        {
            get => _a.Length;
            private set => _a.Length = value;
        }

        public double B 
        {
            get => _b.Length;
            private set => _b.Length = value;
        }

        public double C
        {
            get => _c.Length;
            private set => _c.Length = value;
        }

        public override double Area 
        { 
            get
            {
                double p = GetSemiPerimeter();
                // Heron's formula
                double S =  Sqrt(p * (p - A) * (p - B) * (p - C));
                base.Area = S;
                return S;
            }
            protected set => base.Area = value; 
        }

        public Triangle(double a, double b, double c)
        {
            System.Console.WriteLine("Triangle");
            if (a + b < c || a + c < b || b + c < a)
                throw new InvalidSideLengthException();
            _a = new Side(a);
            _b = new Side(b);
            _c = new Side(c);
        }

        private double GetSemiPerimeter() => (A + B + C) / 2;
    }
}