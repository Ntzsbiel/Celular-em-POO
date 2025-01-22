namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Reecrita do Método "InstalarAplicativo"
        public override void TocarMusica()
        {
            Console.Clear();
            Console.WriteLine("tuts tuts tuts tuts quero ver!");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();

        }
    }
}