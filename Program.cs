using System.Reflection.Metadata;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();

    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Escolha uma opção de Opeçao: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Porcentagem");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("----------------------");
        Console.WriteLine("Selecione uma opção: ");
        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Divisao();
                break;
            case 4:
                Multiplicacao();
                break;
            case 5:
                Porcentagem();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Menu();
                break;
        }
    }


    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Digite dois para calcular: ");
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        float resultado = num1 + num2;
        Console.WriteLine($"A soma de {num1} + {num2} = {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Digite dois para calcular: ");
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        float resultado = num1 - num2;
        Console.WriteLine($"A subtração de {num1} - {num2} = {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Digite dois para calcular: ");
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        float resultado = num1 / num2;
        Console.WriteLine($"A divisão de {num1} / {num2} = {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Digite dois para calcular: ");
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        float resultado = num1 * num2;
        Console.WriteLine($"A multiplicação de {num1} * {num2} = {resultado}");
        Console.ReadKey();
        Menu();

    }
    static void Porcentagem()
        
    {
        Console.Clear();

        Console.WriteLine("Digite dois para calcular: ");
        Console.WriteLine("Digite a porcentagem: ");
        float porcentagem = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor base: ");      
        float valorbase = float.Parse(Console.ReadLine());
        Console.WriteLine("Exemplo: 10% de 100 = 10"); 
        Console.WriteLine(" ");

        float resultado = (porcentagem /100) * valorbase;
        Console.WriteLine($"A porcentagem de {porcentagem} % {valorbase} = {resultado}");
        Console.ReadKey();
        Menu();

    }
}
