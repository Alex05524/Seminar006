internal partial class Program
{
    private static void Main(string[] args)
    {
        double[,] Numbers = new double[2, 2];
        double[] crossPoint = new double[2];

        void InNum()
        {
            for (int i = 0; i < Numbers.GetLength(0); i++)
            {
                Console.Write($"Введите коэффициенты: ");
                for (int j = 0; j < Numbers.GetLength(1); j++)
                {
                    if (j == 0) Console.Write($"k{i + 1}: ");
                    else Console.Write($"b{i + 1}: ");
                    Numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        double[] Decision(double[,] Numbers)
        {
            crossPoint[0] = (Numbers[1, 1] - Numbers[0, 1]) / (Numbers[0, 0] - Numbers[1, 0]);
            crossPoint[1] = crossPoint[0] * Numbers[0, 0] + Numbers[0, 1];
            return crossPoint;
        }

        void Result(double[,] Numbers)
        {
            if (Numbers[0, 0] == Numbers[1, 0] && Numbers[0, 1] == Numbers[1, 1])
            {
                Console.Write($"Прямые совпадают");
            }
            else if (Numbers[0, 0] == Numbers[1, 0] && Numbers[0, 1] != Numbers[1, 1])
            {
                Console.Write($"Прямые параллельны");
            }
            else
            {
                Decision(Numbers);
                Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
            }
        }

        InNum();
        Result(Numbers);
    }
}