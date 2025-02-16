using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

        int inCount = 0;
        int outCount = 0;

        for(int index = 0; index < N; index++)
        {
            int X = int.Parse(Console.ReadLine());

            if(X >= 10 && X <= 20)
            {
                inCount++;
            }
            else
            {
                outCount++;
            }
        }
        Console.WriteLine(inCount + " in");
        Console.WriteLine(outCount + " out");
        

    }

}