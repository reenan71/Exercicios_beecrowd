using System; 

class URI {

    static void Main(string[] args) { 
      
      int X = int.Parse(Console.ReadLine());

      if(X % 2 == 0)
        {
          X++;
        }
      for(int index = 0; index < 6; index++)
      {
          Console.WriteLine(X + 2 * index);
      }
    }

}
