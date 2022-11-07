using System;
using System.Linq.Expressions;

Menu();

static void Menu()
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("---------MENU-------------");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1 - Exceção Genérica");
    Console.WriteLine("2 - Exceção DivideByZeroException");
    Console.WriteLine("0 - Sair");
    Console.WriteLine(" ");

    Console.WriteLine("Digite a opção:");
    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ExcecaoGenerica(10, 0);
            break;
        case "2":
            ExcecaoDivideByZeroException(10, 0);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.ReadKey();
}

static void ExcecaoGenerica(int num, int divisor)
{
    try
    {
        var resultado = num / divisor;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro ExcecaoGenerica: " + ex.Message);
    }

}

static void ExcecaoDivideByZeroException(int num, int divisor)
{
    try
    {
        var resultado = num / divisor;
    }
    catch (DivideByZeroException e )
    {
        Console.WriteLine("Erro ExcecaoDivideByZeroException: " + e.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro ExcecaoDivideByZeroException: " + ex.Message);
    }
}