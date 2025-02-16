using System; 

class URI {

    static void Main(string[] args) { 
      
      int X = int.Parse(Console.ReadLine());

      for(int index = 1; index <= X; index++)
      {
        if(index % 2 != 0)
        {
          Console.WriteLine(index);
        }
      }
    }

}
