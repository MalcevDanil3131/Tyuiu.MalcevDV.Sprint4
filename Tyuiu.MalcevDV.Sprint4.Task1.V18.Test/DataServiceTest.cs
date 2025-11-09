using Tyuiu.MalcevDV.Sprint4.Task1.V18.Lib;
namespace Tyuiu.MalcevDV.Sprint4.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5 };

            int wait = 21;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
