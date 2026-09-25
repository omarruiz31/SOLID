namespace OCP.Alien

public class HumongusuarioSupremo : Humongusuario
{
    public override string Nombre => "Humongusuario Supremo";
    public override void UsarHabilidad()
    {
        base.UsarHabilidad();
        System.Console.Writeline($"{Nombre} lanza misiles de sus brazos ");
    }
}