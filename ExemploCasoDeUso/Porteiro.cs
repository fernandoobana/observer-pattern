namespace ObserverPattern.ExemploCasoDeUso;

using ObserverPattern.Pattern;

public class Porteiro : ISubject
{
    private readonly Dictionary<string, List<IObserver>> Observers = [];

    public void RegistrarObserver(string tipo, IObserver observer)
    {
        if (!Observers.TryGetValue(tipo, out List<IObserver>? value))
        {
            value = ([]);
            Observers[tipo] = value;
        }

        value.Add(observer);
    }

    public void NotificarObservers(string tipo)
    {
        if (!Observers.TryGetValue(tipo, out List<IObserver>? value))
            return;

        foreach (var observer in Observers[tipo])
        {
            observer.EventoOcorreu();
        }
    }

    public void Monitorar()
    {
        string? acao;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Porteiro monitorando...");
            Console.WriteLine("Digite o tipo evento que aconteceu:");

            acao = Console.ReadLine();
            NotificarObservers(acao!);

        } while(acao.ToLower() != "sair");
    }
}
