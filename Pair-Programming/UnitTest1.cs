using NUnit.Framework;
namespace Pair_Programming {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void User_Input_Is_Empty() {
            // Arrange
            var calc = new Calculator();
            var expect = 0;

            // Act
            var result = calc.Sum();

            // Assert
            Assert.AreEqual(expect, result);

        }
         [Test]
        public void User_Input_Is_One_Number_Should_Return_Same_Number() {
            // Arrange
            var calc = new Calculator();
            var expect = 3;

            // Act
            var result = calc.Sum("3");

            // Assert
            Assert.AreEqual(expect, result);

        }
    }
}