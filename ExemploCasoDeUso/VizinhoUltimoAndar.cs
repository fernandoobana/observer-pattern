namespace ObserverPattern.ExemploCasoDeUso;

using ObserverPattern.Pattern;

public class VizinhoUltimoAndar : IObserver
{
    public void EventoOcorreu()
    {
        Console.WriteLine("Vizinho: Entregador da pizza chegou");
        Console.WriteLine("Vizinho: Vai buscar a pizza, paga e volta para ap!");
    }
}