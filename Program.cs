using System.Diagnostics;
using System.Globalization;
using DesafioPOO.Models;

// Variável global para armazenar o smartphone selecionado
Smartphone celularSelecionado = null;
bool MenuSeleção = true;
bool menuPrincipal = false;

// -----------MENU DE BOAS VINDAS---------
do
{
    Console.Clear();
    Console.WriteLine("           Bem vindo");
    Console.WriteLine("     Escolha um SmartPhone:");

    Console.WriteLine("Digite 1 para receber um Iphone");
    Console.WriteLine("Digite 2 para receber um Nokia");
    Console.WriteLine("Digite 3 para SAIR");

    //---------MENU DE SELEÇÃO DO SMARTPHONE----------
    switch (Console.ReadLine())
    {
        default:
            Console.WriteLine("Opção inválida");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
            break;

        case "1":
            Console.Clear();
            Console.WriteLine("Você selecionou um Iphone");
            Console.WriteLine("Crie um número para o seu celular:");
            celularSelecionado = new Iphone(Console.ReadLine(), "Iphone X", "111111111", 256);
            MenuSeleção = false;
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Você selecionou um Nokia");
            Console.WriteLine("Crie um número para o seu celular:");
            celularSelecionado = new Nokia(Console.ReadLine(), "Nokia Tijolao", "222222222", 10);
            MenuSeleção = false;
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            MenuSeleção = false;
            break;
    }

} while (MenuSeleção);

// Verificação do smartphone configurado
if (celularSelecionado == null)
{
    Console.WriteLine("Nenhum celular foi configurado.");
    Console.ReadKey();
}
else
{
    menuPrincipal = true;
    Console.Clear();
    Console.WriteLine($"O Modelo do seu Celular é: {celularSelecionado.ExibirModelo()}");
    Console.WriteLine("             Iniciando...");
    Console.WriteLine("Clique em qualquer tecla para continuar...");
    Console.ReadLine();
}
//-----------MENU PRINCIPAL DO CELULAR----------
while (menuPrincipal)
{

    Console.Clear();
    Console.WriteLine("===== Menu Principal =====");
    Console.WriteLine("1 - Ver Horas");
    Console.WriteLine("2 - Ligar");
    Console.WriteLine("3 - Tocar Música");
    Console.WriteLine("4 - Instalar Aplicativo");
    Console.WriteLine("5 - Ver configurações");
    Console.WriteLine("6 - Sair");
    Console.WriteLine("=========================");
    Console.Write("Escolha uma opção (1-6): ");

    switch (Console.ReadLine())
    {

        default:
            Console.WriteLine("Opção Invalida, pressione qualquer tecla para continuar");
            Console.ReadLine();
            break;

        case "1":
            celularSelecionado.VerHoras();
            break;

        case "2":
            celularSelecionado.Ligar();
            break;

        case "3":
            celularSelecionado.TocarMusica();
            break;

        case "4":
            Console.WriteLine("Digite o aplicativo que deseja instalar");
            celularSelecionado.InstalarAplicativo();
            break;

        case "5":
        celularSelecionado.ExibirConfiguracoes();
        break;

        case "6":
            Console.Clear();
            Console.WriteLine("O programa será encerrado");
            menuPrincipal = false;
            break;
    }
}

