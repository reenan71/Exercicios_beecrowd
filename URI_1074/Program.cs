using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (X % 2 == 0)
            {
                if (X > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }
            else
            {
                if (X > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }

        }
    }

}