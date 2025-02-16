using System; 

class URI {

    static void Main(string[] args) { 

        string [] valores = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(valores[0]);
        int minutoInicial = int.Parse(valores[1]);
        int horaFinal = int.Parse(valores[2]);
        int minutoFinal = int.Parse(valores[3]);

        int instanteInicial = (horaInicial * 60) + minutoInicial;
        int instanteFinal = (horaFinal * 60) + minutoFinal;

        int duracao;
        int tempo = 24;
        int hora = 60;
        

        if(instanteInicial < instanteFinal) {
            duracao = instanteFinal - instanteInicial;
        } else {
            duracao = (tempo * hora - instanteInicial) + instanteFinal;
        }

        int duracaoHoras = duracao / hora;
        int duracaoMinutos = duracao % hora;

        Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        
    }

}
