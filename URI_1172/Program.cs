using System; 

class URI {

    static void Main(string[] args) { 

        int[] numeros = new int[10];
        int i = 0;

        for(i = 0; i < 10; i++){
            numeros[i] = int.Parse(Console.ReadLine());
        }


        for(i = 0; i < 10; i++){
            if(numeros[i] <= 0){
                numeros[i] = 1;
            }
        }

        for(i = 0; i < 10; i++){
            Console.WriteLine($"X[{i}] = {numeros[i]}");
        }

    }

}