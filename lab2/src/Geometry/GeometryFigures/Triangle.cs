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

        public Triangle(double a, double b, double c)
        {
            // System.Console.WriteLine("Triangle");
            if (a + b < c || a + c < b || b + c < a)
                throw new InvalidTriangleException (
                    new InvalidTriangleExceptionArgs {
                        message = "The sum of two sides must be greater than the third.",
                        value = (a, b, c),
                    }
                );
            _a = new Side(a);
            _b = new Side(b);
            _c = new Side(c);
        }

        public override double GetArea()
        {
            double p = GetSemiPerimeter();
            return Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private double GetSemiPerimeter() => (A + B + C) / 2;
    }
}