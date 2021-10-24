using System.Collections.Generic;
using Geometry;
using System;

public static class PlaneExtension
{
    public static List<GeometryFigure> CheckFigures(this Plane plane, Func<GeometryFigure, bool> predicate)
    {
        List<GeometryFigure> res = new List<GeometryFigure>();
        foreach (var f in plane.GetFigures())
        {
            if (predicate(f))
                res.Add(f);
        }
        return res;
    }
}