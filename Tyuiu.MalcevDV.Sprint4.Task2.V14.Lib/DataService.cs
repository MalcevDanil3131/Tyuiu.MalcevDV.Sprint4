using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalcevDV.Sprint4.Task2.V14.Lib
{
    public class DataService : ISprint4Task2V14
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
