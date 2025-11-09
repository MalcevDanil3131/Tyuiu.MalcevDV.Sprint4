using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalcevDV.Sprint4.Task0.V22.Lib
{
    public class DataService : ISprint4Task0V22
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sumOddArrel = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) sumOddArrel += array[i];
            }
            return sumOddArrel;
        }
    }
}
