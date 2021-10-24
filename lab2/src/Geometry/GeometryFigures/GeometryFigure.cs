namespace Geometry 
{
public abstract class GeometryFigure 
{
    public GeometryFigure()
    {
        // System.Console.WriteLine("Geometry Figure");
    }

    public abstract double GetArea();

    ~GeometryFigure()
    {
        System.Console.WriteLine("Geometry figure Destructor");
    }
}
}