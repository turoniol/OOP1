namespace Geometry 
{
    public class GeometryFigure 
    {
        private double _area;

        public virtual double Area {
            get => _area;
            protected set  
            {
                if (value < 0.0)
                    throw new InvalidAreaException();
                _area = value;
            }
        }

        public GeometryFigure()
        {
            System.Console.WriteLine("Geometry Figure");
            Area = 0;
        }

        ~GeometryFigure()
        {
            System.Console.WriteLine("Geometry figure Destructor");
        }
    }
}