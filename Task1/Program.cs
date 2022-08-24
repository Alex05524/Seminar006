internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] Num = new int[m];

        void InNum(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                Num[i] = Convert.ToInt32(Console.ReadLine());
                }
                }
                int UserResult(int[] Num)
                {
                    int count = 0;
                    for (int i = 0; i < Num.Length; i++)
                    {
                        if(Num[i] > 0) count += 1;
                        }
                        return count;
                        }
                        
InNum(m);
Console.WriteLine($"Результат: {UserResult(Num)}");
}
}