
public class ManipulacaoString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Removendo espaços laterias: ");
        Console.WriteLine(nome.Trim());
        Console.WriteLine("Removendo espaços excedentes entre os nomes: ");
        Console.WriteLine(nome.Replace(" ", ""));
        Console.WriteLine("Passando todas as letras para minusculo: ");
        Console.WriteLine(nome.ToLower());
        Console.WriteLine("Passando todas as letras para maiusculo: ");
        Console.WriteLine(nome.ToUpper());
        Console.WriteLine("Adicionando uma palavra ao nome: ");
        Console.WriteLine(nome.Insert(5,"ADICIONADA "));
        Console.WriteLine("Removendo uma palavra do nome: ");
        Console.WriteLine(nome.Remove(5,0));
        Console.WriteLine("Pesquisando uma palavra dentro do nome: ");
        Console.WriteLine($"Informe uma palavra para pesquisar dentro de {nome}");
        string comparacao = Console.ReadLine();
        Console.WriteLine(nome.Contains(comparacao));
        Console.WriteLine("Informando a quantidade de letras no nome: ");
        Console.WriteLine(nome.Replace(" ", "").Length);
    }
}
