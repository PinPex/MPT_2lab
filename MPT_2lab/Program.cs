

public class Program
{
    public static int MinOfThreeNumbers(int a, int b, int c)
    {
        return Math.Min(Math.Min(a, b), c);
    }
    public static double SumEvenIndexes(double[,] A)
    {
        double sum = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if ((i + j) % 2 == 0)
                {
                    sum += A[i, j];
                }
            }
        }
        return sum;
    }
    public static double MaxUnderAndOnDiagonal(double[,] A)
    {
        if (A.GetLength(0) == 0)
        {
            return System.Double.MaxValue;
        }
        double max = A[0, 0]; // предполагаем, что первый элемент максимальный
        
        for (int i = 1; i < A.GetLength(0); i++) // начинаем со второй строки
        {
            for (int j = 0; j < i; j++) // идем до j < i, чтобы учитывать только элементы ниже главной диагонали
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
        }
        return max;
    }
    public static void Main(string[] args)
    {
    }
}