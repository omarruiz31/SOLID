namespace OCP.Alien;

public class CuatroBrazos: IAlien
{
    public virtual string Nombre => "Cuatro brazos";
    public virtual string Descripcion => "Tetramand | Posee super fuerza, piel blindada y cuatro brazos";
    public virtual void UsarHabilidad()
    {
        System.Console.Writeline($"{Nombre} ataca con aplauso sonico");
    }
}
