public class DonRamon implements Inquilino,Habitantes{
    private String nombre = "Don Ramon";

    @Override
    public void InteractuarConElChavo() {
        System.out.println(nombre + "le mete un coscorron al chavo");
    }

    @Override
    public void pagarRenta() {
        System.out.println(nombre + "Le jura que pagara la proxima semana");
    }
}
