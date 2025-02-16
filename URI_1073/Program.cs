using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        for (int index = 2; index <= N; index += 2)
        {
            Console.WriteLine($"{index}^2 = {index* index}");
        }
    }
}