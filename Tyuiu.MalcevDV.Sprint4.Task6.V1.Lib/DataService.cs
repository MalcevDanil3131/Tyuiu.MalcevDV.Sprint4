using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalcevDV.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 6);
            return mas.Length;
        }
    }
}
