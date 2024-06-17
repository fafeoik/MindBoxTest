using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas.Implementations
{
    public class AreaCalculator
    {
        private readonly IAreaCalculator _areaCalculator;

        public AreaCalculator(IAreaCalculator calculator) => _areaCalculator = calculator;

        public double Calculate() => _areaCalculator.Calculate();
    }
}
