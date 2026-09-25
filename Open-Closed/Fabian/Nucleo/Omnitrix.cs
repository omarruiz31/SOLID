namespace OCP.Nucleo;

public class Omnitrix
{
    public IAlien? AlienActual { get; private set; }
    public bool EstaTransformado => AlienActual != null;

    public void Transformar(IAlien alien)
    {
        AlienActual = alien;
        System.Console.Writeline($"Transformacion completa eres un {AlienActual}");
    }

    public void Destransformar(IAlien alien)
    {
        if (AlienActual != null)
        {
            System.Console.Writeline($"Timeout. {AlienActual.Nombre} ahora es ben");
            AlienActual = null;
        }
    }
}