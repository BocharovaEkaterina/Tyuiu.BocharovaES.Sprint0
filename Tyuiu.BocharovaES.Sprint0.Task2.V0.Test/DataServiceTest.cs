using Tyuiu.BocharovaES.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BocharovaES.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Екатерина";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Екатерина", res);
        }
    }
}
