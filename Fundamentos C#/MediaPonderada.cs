namespace MediaPonderada;

public class MediaPonderada
{
    public static void Main(string[] args)
    {
        string aux;
        
        Console.WriteLine("O programa vai calcular uma média ponderada.\n" +
                          "Vamos precisar das seguintes informações:\n" +
                          "Valores para cálculo da média e valores para" +
                          " os pesos");
        
        Console.WriteLine("Digite o primeiro número: ");
        aux = Console.ReadLine();
        float num1 = Convert.ToSingle(aux);
        Console.WriteLine("Digite o segundo número: ");
        aux = Console.ReadLine();
        float num2 = Convert.ToSingle(aux);
        Console.WriteLine($"Digite o valor do peso para {num1}");
        float peso1 = float.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o valor do peso para {num2}");
        float peso2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"A média ponderada é: {(peso1*num1)+(peso2*num2)/peso1+peso2}");
        Denovo();
    }

    public static void Denovo()
    {
        Console.WriteLine("Deseja fazer outra média? (S/N)");
        string resposta = Console.ReadLine();

        if (resposta == "S" || resposta == "s")
        {
            Main(null);
        }
        else
        {
            Console.WriteLine("Obrigado por usar nossa aplicação!");
            Environment.Exit(0);
        }
    } 
}
