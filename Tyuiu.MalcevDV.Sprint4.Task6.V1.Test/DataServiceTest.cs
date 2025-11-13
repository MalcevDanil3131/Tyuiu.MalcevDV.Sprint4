using Tyuiu.MalcevDV.Sprint4.Task6.V1.Lib;
namespace Tyuiu.MalcevDV.Sprint4.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var Array = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(Array), wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
