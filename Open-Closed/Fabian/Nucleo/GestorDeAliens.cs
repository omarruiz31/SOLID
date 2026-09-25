namespace OCP.Nucleo;

using OCP.Alien;

public class GestorDeAliens
{
    private readonly List<(string Nombre, Func<IAlien> Crear, bool Desbloqueado)> _catalogo = new()
    {
        ("Fuego", () => new Fuego(), true),
        ("Humongosaurio", () => new Humongosaurio(), true),
        ("Cuatro brazos", () => new CuatroBrazos(), true)
    };

    private readonly List<(string Nombre, Func<IAlien> Crear)> _escanearADN = new();

    private readonly Dictionary<Type, Func<IAlien>> _fusion = new()
    {
        { typeof(Fuego), () => new Fuego() },
        { typeof(Humongosaurio), () => new Humongosaurio() },
        { typeof(CuatroBrazos), () => new CuatroBrazos() }
    };

}