internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Menu();


    }
    static void Menu(){

        Console.WriteLine("Qual função deseja?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("---------------------");
        Console.WriteLine("Selecione uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao){
            case 1: Soma(); break;

            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao();break;
            case 5: break;
            default:
                Console.WriteLine("Opção invalida");
                Menu();
                break;


        }


    }
    static void Soma(){
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;

        Console.WriteLine($"resultado da soma: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao(){
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Primeiro valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultadoSubtracao = v1 - v2;

        Console.WriteLine($"O resultado da subtração: {resultadoSubtracao}");
        Console.ReadKey();
        Menu();

    }

    static void Divisao(){
        Console.Clear();
        Console.WriteLine("Primeiro valor ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultadoDivisao = v1 / v2;

        Console.WriteLine($"O resultado da divisão é {resultadoDivisao}");
        Console.ReadKey();
        Menu();

    } 

    static void Multiplicacao(){
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultadoMultiplicacao = v1 * v2;

        Console.WriteLine($"O resultado da multiplicação é {resultadoMultiplicacao}");
        Console.ReadKey();
        Menu();
    }
}

