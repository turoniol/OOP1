namespace Geometry
{
    public class Rectangle : GeometryFigure
    {
        private Side _a, _b;

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

        public override double Area 
        { 
            get
            {
                double S = A * B;
                base.Area = S;
                return S;
            } 
            protected set => base.Area = value;
        }

        public Rectangle(double a, double b)
        {
            System.Console.WriteLine("Rectangle");
            _a = new Side(a);
            _b = new Side(b);
        }
    }
}