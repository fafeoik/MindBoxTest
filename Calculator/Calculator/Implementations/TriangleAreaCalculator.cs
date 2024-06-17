namespace Areas.Implementations
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public bool IsRight
        {
            get
            {
                return CheckIsTriangleRight();
            }
        }

        public TriangleAreaCalculator(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide) && (firstSide > 0 && secondSide > 0 && thirdSide > 0))
            {
                _a = firstSide;
                _b = secondSide;
                _c = thirdSide;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(firstSide), nameof(secondSide), nameof(thirdSide));
            }
        }

        public double Calculate()
        {
            if (IsRight)
                Console.WriteLine("Треугольник прямоугольный");
            else
                Console.WriteLine("Треугольник не прямоугольный");

            double semiperimeter = (_a + _b + _c) / 2;
            return Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - _a) * (semiperimeter - _b) * (semiperimeter - _c)), 2);
        }

        private bool CheckIsTriangleRight() => _a * _a + _b * _b == _c * _c || _a * _a + _c * _c == _b * _b || _b * _b + _c * _c == _a * _a;
    }
}
