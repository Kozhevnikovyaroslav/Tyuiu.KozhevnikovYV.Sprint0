namespace Tyuiu.KozhevnikovYV.Sprint0.Task2.V0.Test
{
    using Tyuiu.KozhevnikovYV.Sprint0.Task2.V0.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ярослав";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Ярослав", res);
        }
    }
}
