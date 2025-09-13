namespace Tyuiu.KozhevnikovYV.Sprint0.Task5.V0.Test
{
    using Tyuiu.KozhevnikovYV.Sprint0.Task5.V0.Lib;
    [TestClass]
    public sealed class DaraServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(50, 5));
        }
    }
}
