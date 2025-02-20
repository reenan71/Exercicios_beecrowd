using System; 

class URI {

    static void Main(string[] args) { 

      int N = int.Parse(Console.ReadLine());

      if (2 < N && N < 1000)
        {
          for (int i = 1; i <= 10; i++)
          {
            Console.WriteLine($"{i} X {N} = {i * N}");
          }
        }
      

    }

}