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

        // Propriedades do celular
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }


        public void Ligar()
        {
            Console.Clear();

            Console.WriteLine("Digite o número ou nome para fazer uma ligação");
            string ligacao = Console.ReadLine();
            Console.WriteLine($"Ligando para {ligacao}...");
            Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadLine();
        }

        public virtual void TocarMusica()
        {
            Console.WriteLine("plim plim plim plim...");
        }

        public string ExibirModelo()
        {
            return Modelo;
        }

        public void VerHoras()
        {
            Console.Clear();

            DateTime hoje = DateTime.Now;
            Console.WriteLine($"======={Modelo.ToUpper()}======");
            Console.WriteLine(hoje.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadLine();
        }

        public void ExibirConfiguracoes()
        {
            Console.Clear();
            Console.WriteLine($"========{Modelo.ToUpper()}=======");
            Console.WriteLine($"Imei: {Imei}");
            Console.WriteLine($"Número de telefone: {Numero}");
            Console.WriteLine($"Armazenamento: {Memoria}GB");
            Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadLine();

        }

        public virtual void InstalarAplicativo()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da aplicação que deseja instalar");
            string nomeApp = Console.ReadLine();
            Console.WriteLine($"O Aplicativo {nomeApp} foi instalado no seu {Modelo} com sucesso");
            Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadLine();


        }
    }
}