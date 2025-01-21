namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Reecrita do Método "InstalarAplicativo"
        public override string InstalarAplicativo(string nomeApp)
        {
            return $"O aplicativo {nomeApp} foi instalado no Iphone";
        }
    }
}