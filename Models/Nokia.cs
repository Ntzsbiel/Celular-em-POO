namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //  Reescrita do Método "InstalarAplicativo"
        public override void TocarMusica()
        {
            Console.Clear();
            Console.WriteLine("Mas tem que me prender, tem que seduzir!");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();

        }
    }
}