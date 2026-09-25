using OCP.Alien;

namespace OCP.Fabrica;

public static class FabricaAlien
{
    public static IAlien CrearDesdeMuestra(MuestraADN muestra)
    {
        return new CreadrorAlien(muestra.Nombre, muestra.Descripcion, muestra.Habilidad);
    }
}