using FigureLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        [DataRow("����", 5, 78.5)]
        [DataRow("����", 10, 314)]
        [DataRow("����", 15, 706.5)]
        public void CalculateSquare_CorrectRadius_ReturnsValue(string typeName, double radius, double result)
        {
            //Arrange
            var circle = new Circle(typeName, radius);

            //Act
            var act = circle.CalculateSquare();

            //Assert
            Assert.AreEqual(result, act);
        }
        //������������ ������ � �����������
    }
}