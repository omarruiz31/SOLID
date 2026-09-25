namespace OCP.Alien;

public class CreadrorAlien : IAlien
{
    public string Nombre { get; }
    public string Descripcion { get; }
    public readonly string _habilidad;

    public CreadrorAlien(string nombre, string descripcion, string habilidad)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        _habilidad = habilidad;
    }

    public void UsarHabilidad()
    {
        System.Console.Writeline($"{Nombre} esta usando su habilidad: {_habilidad}");
    }
}