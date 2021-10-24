using Geometry;
using System;
using static System.Console;

#region events
ITypeWriter ctw = new ConsoleWriter();
IAreaWriter caw = new ConsoleWriter();

ComplexWriter writer = new ComplexWriter();
writer.ComplexWritingEvent += new WritingHandle(delegate (GeometryFigure obj) {
                                                    WriteLine(Plane.GetType(obj));
                                                });
writer.ComplexWritingEvent += new WritingHandle((GeometryFigure obj) => WriteLine(obj.GetArea()));
writer.ComplexWritingEvent += new WritingHandle(new Action<GeometryFigure>(ctw.Write));

RightTriangle rt = new RightTriangle(3, 4, 5);
Rectangle rect = new Rectangle(2, 5);

writer.Write(rt);
writer.Write(rect);
#endregion

#region extension method
Func<GeometryFigure, bool> ckeckArea = (GeometryFigure obj) => obj.GetArea() == 5;
Plane p = Plane.GetInstance();

var withArea5 = p.CheckFigures(ckeckArea);
#endregion 

#region exceptions
try
{
    RightTriangle tr = new RightTriangle(5, 2, 4);
}
catch (InvalidTriangleException ex)
{
    Error.WriteLine("Error: " + ex.Message + Environment.NewLine +
        "Values: " + ex.Value.ToString()
    );
}

// 2
try
{
    try
    {
        Side s = new Side(-1);
    }
    catch (InvalidSideLengthException)
    {
        throw new Exception();
    }
}
catch (Exception ex)
{
    Error.WriteLine("Oh no... Smt went wrong:" +
        ex.StackTrace
    );
}
#endregion
