namespace OCP.Alien

public class Humongusuario: IAlien
{
    public virtual string Nombre => "Humongusuario";
    public virtual string Descripcion => "Vaxasaurio | Posee super fuerza y puede crecer hasta 20 metros";
    public virtual void UsarHabilidad()
    {
        System.Console.Writeline($"{Nombre} golpea el suelo y crea un mini terremoto");
    }
}