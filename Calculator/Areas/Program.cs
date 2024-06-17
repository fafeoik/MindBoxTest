using Areas;
using Areas.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var circle = new AreaCalculator(new CircleAreaCalculator(10.0));
        Console.WriteLine(circle.Calculate());
    }
}

