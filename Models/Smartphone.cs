namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public List<string> celulares = new List<string>();
        // Propriedades do celular
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }


        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract string InstalarAplicativo(string nomeApp);
    }
}