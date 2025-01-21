namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //  Reescrita do Método "InstalarAplicativo"
        public override string InstalarAplicativo(string nomeApp)
        {
            return $"O Aplicativo {nomeApp} foi instalado no seu Nokia com sucesso";
        }
    }
}