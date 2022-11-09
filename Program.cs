using Exceptions.Exceptions;
using System;
using System.Linq.Expressions;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("--------------------------");
    Console.WriteLine("---------MENU-------------");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1 - Exceção Genérica");
    Console.WriteLine("2 - Exceção DivideByZeroException");
    Console.WriteLine("3 - Exceção ArgumentException");
    Console.WriteLine("4 - Exceção Personalizada");
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
        case "3":
            ExcecaoArgumentException(10, 0);
            break;
        case "4":
            ExcecaoPersonalizada(200);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            RecarregarMenu();
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
        RecarregarMenu();
    }
}

static void ExcecaoDivideByZeroException(int num, int divisor)
{
    try
    {
        var resultado = num / divisor;
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine("Erro ExcecaoDivideByZeroException: " + e.Message);
        RecarregarMenu();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro Génerica: " + ex.Message);
        RecarregarMenu();
    }
}

static void ExcecaoArgumentException(int num, int divisor)
{
    try
    {
        if (divisor <= 0)
        {
            throw new ArgumentException("O argumento divisor deve ser maior que 0.", nameof(divisor));
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro do tipo ArgumentException");
        Console.WriteLine("Parâmetro: " + ex.ParamName);
        RecarregarMenu();
    }
    var resultado = num / divisor;
    Console.WriteLine($"Resultado é {resultado}");
}

static void ExcecaoPersonalizada(double valor)
{
    try
    {
        var _saldo = 100;

        if (_saldo < valor)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente no valor de " + valor);
        }
    }
    catch (SaldoInsuficienteException ex)
    {
        Console.WriteLine("Erro na exceção SaldoInsuficienteException: " + ex.Message);
        RecarregarMenu();
    }
}

static void RecarregarMenu()
{
    Console.ReadKey();
    Menu();
}