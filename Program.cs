using System.Diagnostics;
using System.Globalization;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphones


bool menuSeleção = true;
bool MenuPrincipal = true;

while (MenuPrincipal)
{
    do
    {
        Console.Clear();
        Console.WriteLine("           Bem vindo");
        Console.WriteLine("     Escolha um SmartPhone:");

        Console.WriteLine("Digite 1 para receber um Iphone");
        Console.WriteLine("Digite 2 para rceber um Nokia");
        Console.WriteLine("Digite 3 para SAIR");

        switch (Console.ReadLine())
        {
            default:
                Console.WriteLine("Opção invalida");
                Console.WriteLine("Clique em qualquer tecla para continuar");
                Console.ReadLine();
                break;

            case "1":
                Console.Clear();
                Console.WriteLine("Você selecionou um Iphone");
                Console.WriteLine("Crie um numero para o seu celular :");
                Iphone Iphone1 = new Iphone(Console.ReadLine(), "Iphone X", "111111111", 256);
                break;

            case "2":
                Console.Clear();
                Console.WriteLine("Você selecionou um Nokia");
                Console.WriteLine("Crie um numero para o seu celular :");
                Nokia Nokia2 = new Nokia(Console.ReadLine(), "Nokia Tijolao", "222222222", 10);
                break;

            case "3":
                Console.WriteLine("O programa será encerrado");
                menuSeleção = false;
                break;


        }
    } while (menuSeleção);
}