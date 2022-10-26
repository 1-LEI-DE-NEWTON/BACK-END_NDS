using System;

namespace LoginPage;

    class LoginPage
    {
        public static void Main()
        {
            var usuarios = new List<Usuario>();
            TelaInicial(usuarios);

        }

        public static void TelaInicial(List<Usuario> usuarios)
        {
            Console.WriteLine("Bem vindo ao sistema de login");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Cadastro");
            Console.WriteLine("0 - Sair");
            var opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    if (usuarios.Count == 0)
                        {
                            Console.WriteLine("O sistema deve conter ao menos um usuário para funcionar!");
                            Thread.Sleep(600);
                            TelaInicial(usuarios);
                        }
                    
                    else
                        {
                            Login(usuarios);
                        }                        
                    break;

                case "2":
                    {
                        var usuario = CadastrarUsuario();
                        usuarios.Add(usuario);            
                        TelaInicial(usuarios);
                    }
                    break;

                case "0":
                    Console.WriteLine("Obrigado por usar o sistema");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    TelaInicial(usuarios);
                    break;
            }
        }
        
        public static Usuario CadastrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de usuário");
            Console.WriteLine("Digite o nome do usuário");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário");
            var senha = Console.ReadLine();
            
            if (nome == string.Empty || senha == string.Empty)
                {
                Console.WriteLine("Nome ou senha inválidos");
                Console.WriteLine("Nome ou senha não podem ser vazios");
                Thread.Sleep(600);
                CadastrarUsuario();
                }
            
            var usuario = new Usuario(nome, senha);

            return usuario;
        }


        public static void Login(List<Usuario> usuarios)
        {
            Console.WriteLine("Login de usuário");
            Console.WriteLine("Digite o nome do usuário");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário");
            var senha = Console.ReadLine();
            var usuario = usuarios.Find(u => u.Nome == nome && u.Senha == senha);                                
            
            if (usuario != null)
            {
                Console.WriteLine($"Bem vindo {usuario.Nome}!");
                Thread.Sleep(3000);
                Denovo(usuarios);
                return;
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos");
                Thread.Sleep(600);
                Denovo(usuarios);
            }
    }
    public static void Denovo(List<Usuario> usuarios)
        {
            Console.WriteLine("Gostaria de tentar novamente?");
            Console.WriteLine("1- Sim\n2- Não");
            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    TelaInicial(usuarios);
                    break;
                case 2:
                    Console.WriteLine("Saindo. Obrigado por usar o programa!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Denovo(usuarios);
                    break;
            }
        }
    }

public class Usuario
{
    public Usuario(string nome, string senha)
    {
        Nome = nome;
        Senha = senha;
    }

    public string Nome { get; set; }
    public string Senha { get; set; }
}
