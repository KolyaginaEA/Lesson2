namespace Ekaterina
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());
            Day(N);
            System.Console.ReadKey(true);
        }

        static bool Day(int N)
        {
            if(N < 1 || N > 7)
            {
                System.Console.Write("Число не обозначает день недели");
                return false;
            }
            if (N >= 1 && N <= 5)
            {
                System.Console.Write("{0} -> нет", N);
                return false;
            }
            else System.Console.Write("{0} -> да", N);
            return true;
        }
    }
}