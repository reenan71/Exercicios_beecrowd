using System;

class URI {
    static void Main(string[] args) { 
        int X = int.Parse(Console.ReadLine());
        
        while (X != 0) {
            for (int i = 1; i <= X; i++) {
                if (i == X) {
                    Console.WriteLine(i);
                } else {
                    Console.Write(i + " ");
                }
            }
            X = int.Parse(Console.ReadLine()); // Leitura de uma nova entrada
        }
    }
}
