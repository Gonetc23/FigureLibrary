using FigureLibrary;

namespace UnitTest
{
    [TestClass]
    public class TriangleTests
    {

        [TestMethod]
        [DataRow("Треугольник", 2, 2, 2, 1.7)]
        [DataRow("Треугольник", 1, 4, 4, 2)]
        [DataRow("Треугольник", 10, 5, 7, 16.2)]
        public void CalculateSquare_CorrectSides_ReturnsValue(string typeName, double sideA, double sideB, double sideC, double result)
        {
            //Arrange
            var triangle = new Triangle(typeName, sideA, sideB, sideC);

            //Act
            var act = triangle.CalculateSquare();

            //Assert
            Assert.AreEqual(result, act);
        }
       

        [TestMethod]
        [DataRow( 2, 2, 2, false)]
        [DataRow( 1, 4, 4, false)]
        [DataRow( 10, 5, 7, false)]
        public void IsRightTriangle_NotStraight_ReturnFalse( double sideA, double sideB, double sideC, bool result)
        {
            //Arrange
            var triangle = new Triangle("Треугольник", sideA, sideB, sideC);

            //Act
            var act = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(result, act);
        }



        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        [DataRow( 0, 1, 2)]
        [DataRow( 1, 0, 2)]
        [DataRow( 1, 2, 0)]
        public void Constructor_IncorrectSides_Exception(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle("Треугольник", sideA, sideB, sideC);

            Assert.Inconclusive("Стороны треугольника должны быть положительными");
        }
    }
}

