using FigureLibrary;

namespace UnitTest
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        [DataRow( 5, 78.5)]
        [DataRow( 10, 314)]
        [DataRow( 15, 706.5)]
        public void CalculateSquare_CorrectRadius_ReturnsValue( double radius, double result)
        {
            //Arrange
            var circle = new Circle("Круг", radius);

            //Act
            var act = circle.CalculateSquare();

            //Assert
            Assert.AreEqual(result, act);
        }


        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        [DataRow(0)]
        [DataRow(-5)]
        [DataRow(-10)]
        public void Constructor_IncorrectRadius_Exception(double radius)
        {
            var circle = new Circle("Круг", radius);

            Assert.Inconclusive("Некорректный радиус");
        }
    }
}
