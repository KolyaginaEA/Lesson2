namespace Ekaterina
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());
            Second(N);
            System.Console.ReadKey(true);
        }

        static bool Second(int N)
        {
            if(N < 100)
            {
                System.Console.Write("Третьей цифры нет");
                return false;
            }
            int result = 0;
            int num = N;
            while (num > 0)
            {
                num /= 10;
                result++;
            }
            System.Console.Write("{0} -> {1}", N, (int)((N - ((int)(N / System.Math.Pow(10, result - 2)) * System.Math.Pow(10, result - 2))) / System.Math.Pow(10, result - 3)));
            return true;
        }
    }
}