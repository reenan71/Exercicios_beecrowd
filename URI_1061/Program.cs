using System; 

class URI {

    static void Main(string[] args) { 

        string[] input1 = Console.ReadLine().Split(' ');
        int diaInicio = int.Parse(input1[1]);

        string[] input2 = Console.ReadLine().Split(':');
        int horaInicio = int.Parse(input2[0]);
        int minutoInicio = int.Parse(input2[1]);
        int segundoInicio = int.Parse(input2[2]);

        string [] input3 = Console.ReadLine().Split(' ');
        int diaFim = int.Parse(input3[1]);

        string [] input4 = Console.ReadLine().Split(':');
        int horaFim = int.Parse(input4[0]);
        int minutoFim = int.Parse(input4[1]);
        int segundoFim = int.Parse(input4[2]);

        int inicioTotalSegundos = (diaInicio * 86400) + (horaInicio * 3600) + (minutoInicio * 60) + segundoInicio;
        int fimTotalSegundos = (diaFim * 86400) + (horaFim * 3600) + (minutoFim * 60) + segundoFim;

        int duracaoTotalSegundos = fimTotalSegundos - inicioTotalSegundos;

        int duracaoDias = duracaoTotalSegundos / 86400;
        duracaoTotalSegundos = duracaoTotalSegundos %= 86400;
        int horas = duracaoTotalSegundos / 3600;
        duracaoTotalSegundos = duracaoTotalSegundos %= 3600;
        int minutos = duracaoTotalSegundos / 60;
        int segundos = duracaoTotalSegundos %= 60;

        Console.WriteLine($"{duracaoDias} dia(s)");
        Console.WriteLine($"{horas} hora(s)");
        Console.WriteLine($"{minutos} minuto(s)");
        Console.WriteLine($"{segundos} segundo(s)");

        
        


    }

}
