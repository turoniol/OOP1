using System;
using static System.Console;
using static Tester;

TestWriter();
GC.Collect();
GC.WaitForPendingFinalizers();
TestGarbage();

Garbage g = new Garbage();
g.Append(10);
WriteLine($"Gen: {GC.GetGeneration(g)}");
for (int i = 0; i < 40000; ++i)
{
    Garbage garbage = new Garbage();
}
WriteLine($"Gen: {GC.GetGeneration(g)}");
