using Tyuiu.MalcevDV.Sprint4.Task2.V14.Lib;
namespace Tyuiu.MalcevDV.Sprint4.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[] numbers = { 9, 2, 2, 3, 2, 2, 1 };

            int res = ds.Calculate(numbers);
            int wait = 27;

            Assert.AreEqual(wait, res);
        }
    }
}
