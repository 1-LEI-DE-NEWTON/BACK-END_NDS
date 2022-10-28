namespace Struct;

public class UsuarioStruct
{
    public static void Main(string[] args)
    {
        var usuario1 = new Usuario(1, "Victor", "Guilherme", 20);
        Console.WriteLine($"Name: {usuario1.Name}");
        Console.WriteLine($"Last name: {usuario1.LastName}");
        Console.WriteLine($"Idade: {usuario1.Idade}");
    }

    struct Usuario
    {
        public Usuario(int id, string name, string lastName, int idade)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Idade = idade;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Idade { get; set; }
    }
}
