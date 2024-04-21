using Xolta.TriangleClassification.Factories;
using Xolta.TriangleClassification.Models;

namespace Xolta.TriangleClassification.UnitTests
{
    public class TriangleFactoryTests
    {
        private readonly ITriangleFactory _sut;

        public TriangleFactoryTests()
        {
            _sut = new TriangleFactory();
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(56, 56, 56)]
        [InlineData(9380, 9380, 9380)]
        public void Create_AllSidesAreEqual_CreatesEquilateralTriangleType(int sideA, int sideB, int sideC)
        {
            // arrange
            Type expectedType = typeof(EquilateralTriangle);

            // act
            Triangle triangle = _sut.Create(sideA, sideB, sideC);
            Type actualType = triangle.GetType();

            // assert
            Assert.True(actualType == expectedType);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(56, 56, 56)]
        [InlineData(9380, 9380, 9380)]
        public void Create_AllSidesAreEqual_ReturnsCorrectName(int sideA, int sideB, int sideC)
        {
            // arrange
            string expectedName = "Equilateral";

            // act
            Triangle triangle = _sut.Create(sideA, sideB, sideC);
            string actualName = triangle.ToString();

            // assert
            Assert.True(actualName == expectedName);
        }

        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(3, 1, 1)]
        [InlineData(1, 3, 1)]
        public void Create_TwoSidesAreEqual_CreatesIsoscelesTriangleType(int sideA, int sideB, int sideC)
        {
            // arrange
            Type expectedType = typeof(IsoscelesTriangle);

            // act
            Triangle triangle = _sut.Create(sideA, sideB, sideC);
            Type actualType = triangle.GetType();

            // assert
            Assert.True(actualType == expectedType);
        }

        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(3, 1, 1)]
        [InlineData(1, 3, 1)]
        public void Create_TwoSidesAreEqual_ReturnsCorrectName(int sideA, int sideB, int sideC)
        {
            // arrange
            string expectedName = "Isosceles";

            // act
            Triangle triangle = _sut.Create(sideA, sideB, sideC);
            string actualName = triangle.ToString();

            // assert
            Assert.True(actualName == expectedName);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(11, 16, 22)]
        [InlineData(1123, 645, 3451)]
        public void Create_NoSidesAreEqual_CreatesScaleneTriangleType(int sideA, int sideB, int sideC)
        {
            // arrange
            Type expectedType = typeof(ScaleneTriangle);

            // act
            Triangle triangle = _sut.Create(sideA, sideB, sideC);
            Type actualType = triangle.GetType();

            // assert
            Assert.True(actualType == expectedType);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(11, 16, 22)]
        [InlineData(1123, 645, 3451)]
        public void Create_NoSidesAreEqual_ReturnsCorrectName(int sideA, int sideB, int sideC)
        {
            // arrange
            string expectedName = "Scalene";

            // act
            Triangle triangle = _sut.Create(sideA, sideB, sideC);
            string actualName = triangle.ToString();

            // assert
            Assert.True(actualName == expectedName);
        }
    }
}