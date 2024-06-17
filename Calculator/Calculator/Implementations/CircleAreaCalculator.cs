namespace Areas.Implementations
{
    public class CircleAreaCalculator : IAreaCalculator
    {
        private readonly double _radius;

        public CircleAreaCalculator(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius));

            _radius = radius;
        }

        public double Calculate() => Math.Round(Math.Pow(_radius, 2) * Math.PI, 2);
    }
}
