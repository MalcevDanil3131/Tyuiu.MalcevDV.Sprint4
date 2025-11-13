using Tyuiu.MalcevDV.Sprint4.Task7.V22.Lib;
namespace Tyuiu.MalcevDV.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "695324951753684";

            int res = ds.Calculate(n, m, value);
            int wait = 9216;

            Assert.AreEqual(wait, res);
        }
    }
}
