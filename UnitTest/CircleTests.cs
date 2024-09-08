using FigureLibrary;

namespace UnitTest
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        [DataRow("Круг", 5, 78.5)]
        [DataRow("Круг", 10, 314)]
        [DataRow("Круг", 15, 706.5)]
        public void CalculateSquare_CorrectRadius_ReturnsValue(string typeName, double radius, double result)
        {
            //Arrange
            var circle = new Circle(typeName, radius);

            //Act
            var act = circle.CalculateSquare();

            //Assert
            Assert.AreEqual(result, act);
        }
        //некорректные данные в конструктор
    }
}
