using System.Collections.Generic;

public class Garbage
{
    private List<decimal> _list = new List<decimal>();

    public void Append(int count)
    {
        for (int i = 0; i < count; ++i)
            _list.Add(0.0m);
    }

    ~Garbage()
    {
        // System.Console.WriteLine("The garbage is destroyed!");
    }
}