namespace ObserverPattern.ExemploCasoDeUso;

using ObserverPattern.Pattern;

public class Namorada : IObserver
{
    public void EventoOcorreu()
    {
        Console.WriteLine("Namorada: Todas as luzes foram apagadas");
        Console.WriteLine("Namorada: Todos os convidados ficaram em silêncio");
        Console.WriteLine("Namorada: A porta está abrindo...");
        Console.WriteLine("Namorada: Surpresa!!!");
    }
}
