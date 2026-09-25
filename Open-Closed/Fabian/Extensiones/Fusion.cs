using OCP.Alien;

namespace OCP.Extensiones;

public class Fusion<TAlienA, TAlienB> : IAlien
    where TAlienA : IAlien, new()
    where TAlienB : IAlien, new()
{
    private readonly TAlienA _alienA = new();
    private readonly TAlienB _alienB = new();
    public string Nombre => $"{_alienA.Nombre} + {_alienB.Nombre}";
    public string Descripcion => $"Habilidades combinadas de {_alienA.Descripcion} + {_alienB.Descripcion}";

    public void UsarHabilidad()
    {
        System.Console.WriteLine($"{Nombre} activa ambas mitades de ADN fusionando:");
        _alienA.UsarHabilidad();
        _alienB.UsarHabilidad();
    }
}