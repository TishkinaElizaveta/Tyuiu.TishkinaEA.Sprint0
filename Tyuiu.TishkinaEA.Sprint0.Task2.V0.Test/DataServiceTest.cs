using Tyuiu.TishkinaEA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TishkinaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Лиза";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Лиза", res);

        }
    }
}