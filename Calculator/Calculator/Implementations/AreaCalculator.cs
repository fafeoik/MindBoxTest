namespace Areas.Implementations
{
    public class AreaCalculator
    {
        private readonly IAreaCalculator _areaCalculator;

        public AreaCalculator(IAreaCalculator calculator) => _areaCalculator = calculator;

        public double Calculate() => _areaCalculator.Calculate();
    }
}
