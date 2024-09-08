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
        [DataRow("Треугольник", 2, 2, 2, false)]
        [DataRow("Треугольник", 1, 4, 4, false)]
        [DataRow("Треугольник", 10, 5, 7, false)]
        public void IsRightTriangle_NotStraight_ReturnFalse(string typeName, double sideA, double sideB, double sideC, bool result)
        {
            //Arrange
            var triangle = new Triangle(typeName, sideA, sideB, sideC);

            //Act
            var act = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(result, act);
        }
    }
}

