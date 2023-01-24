
        {
            System.Console.Write("N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());
            Second(N);
            System.Console.ReadKey(true);
        }

        static bool Second(int N)
        {
            if(N < 100 || N > 999)
            {
                System.Console.Write("Число не трёхзначное");
                return false;
            }
            System.Console.Write("{0} -> {1}", N, (N - (N / 100) * 100) / 10);
            return true;
        }
