using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int count = 1;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine("PUM");
            count++;
        }
    }

}