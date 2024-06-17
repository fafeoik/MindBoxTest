using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas.Implementations
{
    public class CircleAreaCalculator : IAreaCalculator
    {
        private readonly double _radius;

        public CircleAreaCalculator(double radius) =>_radius = radius;

        public double Calculate() => Math.Sqrt(_radius) * Math.PI;
    }
}
