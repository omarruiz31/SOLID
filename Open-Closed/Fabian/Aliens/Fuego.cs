namespace OCP.Alien

public class Fuego: IAlien
{
    public virtual string Nombre => "Fuego";
    public virtual string Descripcion => "Pyronita | Ser compuesto por plasma y rocas volcanicas";
    public virtual UsarHabilidad()
    {
        System.Console.Writeline($"{Nombre} lanza bolas de fuego");
    }
}