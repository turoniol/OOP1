using Geometry;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using static System.Console;

public static class Tester
{
    public static void WriteAboutMemory(long mem)
    {
        WriteLine($"Memory: {OutputFormater.GetFormattedNumber(mem)} bytes.");
    }

    public static void TestGeometry()
    {
        Debug.Assert(new Triangle(3, 4, 5).Area == 6);
        Debug.Assert(new RightTriangle(5, 12, 13).Area == 30);
        Debug.Assert(new Side(5).Length == 5);
        Debug.Assert(new Rectangle(3, 4).Area == 12);
        Debug.Assert(new Square(3).Area == 9);

        Console.WriteLine("Ok!");
    }

    public static void TestPlaneSingleton()
    {
        Plane plane1 = Plane.GetInstance();
        plane1.AddFigure(new Triangle(3, 4, 5));

        Plane plane2 = Plane.GetInstance();
        plane2.AddFigure(new Square(5));

        Debug.Assert(plane2 == plane1);

        Console.WriteLine("Plane is disposed.");

        Console.WriteLine("Ok!");
    }


    private static void MakeGarbage(int count)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < count; i++)
        {
            list.Add(i.ToString());
        }
    }
    public static void TestGarbage()
    {
        MakeGarbage(10);
        WriteAboutMemory(GC.GetTotalMemory(false));
        GC.Collect();
        System.Diagnostics.Stopwatch sp = new System.Diagnostics.Stopwatch();
        sp.Start();
        GC.WaitForPendingFinalizers();
        sp.Stop();
        WriteLine($"Time: {sp.Elapsed}");
        WriteAboutMemory(GC.GetTotalMemory(true));
    }

    public static void TestWriter()
    {
        WriteAboutMemory(GC.GetTotalMemory(false));
        using GeometryWriter w = new GeometryWriter("output.txt");
        w.AppendArea(new RightTriangle(3, 4, 5));
        WriteAboutMemory(GC.GetTotalMemory(true));
    }
}