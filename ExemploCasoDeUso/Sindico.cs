namespace ObserverPattern.ExemploCasoDeUso;

using ObserverPattern.Pattern;

public class Sindico : IObserver
{
    public void EventoOcorreu()
    {
        Console.WriteLine("Síndico: Se fizer bagunça, vai ter que limpar tudo");
        Console.WriteLine("Síndico: Se fizer barulho, vai ter que pagar multa");
        Console.WriteLine("Síndico: Se fizer algo errado, vai ter que sair!!!");
    }
}
