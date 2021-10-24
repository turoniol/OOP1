namespace Geometry
{
    public class ConsoleWriter : IAreaWriter, ITypeWriter
    {
        void IAreaWriter.Write(GeometryFigure obj) => Write(obj.GetArea().ToString());

        void ITypeWriter.Write(GeometryFigure obj) => Write(Plane.GetType(obj));

        private void Write(string m) => System.Console.WriteLine(m);
    }
}