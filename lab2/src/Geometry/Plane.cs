using System.Collections.Generic;

namespace Geometry
{
    public class Plane
    {
        public readonly static double e;
        public readonly static double pi;
        public readonly static double tau;
        public readonly static double sqrt2;
        public readonly static double phi;
        private static Plane _instance;
        private List<GeometryFigure> _figures;

        static Plane()
        {
            e = 2.718281828;
            pi = 3.141592653;
            tau = 6.283185307;
            sqrt2 = 1.414213562;
            phi = 1.618033988;
        }

        private Plane() 
        {
            _figures = new List<GeometryFigure>();
        }

        public static Plane GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new Plane();
            }

            return _instance;
        }
    
        public int AddFigure(GeometryFigure obj)
        {
            _figures.Add(obj);
            return _figures.Count;
        }

        public void RemoveFigure(GeometryFigure obj) => _figures.Remove(obj);

        public GeometryFigure GetFigure(int id) => _figures[id];

        public List<GeometryFigure> GetFigures() => new List<GeometryFigure>(_figures);

        public int Count() => _figures.Count;

        public static string GetType(GeometryFigure f)
        {
            System.Type t = typeof(GeometryFigure);
            if (f is RightTriangle)
                t = typeof(RightTriangle);
            else if (f is Triangle)
                t = typeof(Triangle);
            else if(f is Square)
                t = typeof(Square);
            else if (f is Rectangle)
                t = typeof(Rectangle);

            return t.ToString();
        }
    }
}