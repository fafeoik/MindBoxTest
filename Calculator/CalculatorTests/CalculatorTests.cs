using Areas.Implementations;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CanNotAddNegativeRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaCalculator(new CircleAreaCalculator(-5)));
        }

        [Fact]
        public void CanNotAddNegativeTriangleSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaCalculator(new TriangleAreaCalculator(-5,8,12)));
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaCalculator(new TriangleAreaCalculator(3,-2,4)));
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaCalculator(new TriangleAreaCalculator(10,14,-10)));
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaCalculator(new TriangleAreaCalculator(0,0,0)));
        }

        [Fact]
        public void CanCountCircleArea()
        {
            AreaCalculator circle = new AreaCalculator(new CircleAreaCalculator(4));

            double area = circle.Calculate();

            Assert.Equal(50.27, area);
        }

        [Fact]
        public void CanCountTriangleArea()
        {
            AreaCalculator triangle = new AreaCalculator(new TriangleAreaCalculator(12,12,12));

            double area = triangle.Calculate();

            Assert.Equal(62.35, area);
        }

        [Fact]
        public void CanDefineRightTriangle()
        {
            TriangleAreaCalculator triangle = new TriangleAreaCalculator(3, 4, 5);

            bool isRight = triangle.IsRight;

            Assert.True(isRight);
        }

        [Fact]
        public void CanDefineNotRightTriangle()
        {
            TriangleAreaCalculator triangle = new TriangleAreaCalculator(2, 2, 3);

            bool isRight = triangle.IsRight;

            Assert.False(isRight);
        }
    }
}
