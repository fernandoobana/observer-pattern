namespace ObserverPattern.Pattern;

public interface ISubject
{
    public void RegistrarObserver(string tipo, IObserver observer);
    public void NotificarObservers(string tipo);
}