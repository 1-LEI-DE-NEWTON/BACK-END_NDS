using System;

namespace SysCaixa;

class SysCaixa
{
    public static void Inicio(Usuario usuario, List<Usuario> usuarios, List<ContaBancaria> contas)
    {
        var conta = contas.Find(c => c.Usuario == usuario);
        
        if (conta == null)
        {
            conta = new ContaBancaria(0, usuario);
            contas.Add(conta);
            TelaInicial(usuario, conta, usuarios, contas);            
        }
        
        else
        {
            Thread.Sleep(600);
            Console.WriteLine("Bem vindo de volta " + usuario.Nome);
            TelaInicial(usuario, conta, usuarios, contas);
        }

    }  
    public static void TelaInicial(Usuario usuario, ContaBancaria conta, List<Usuario> usuarios, List<ContaBancaria> contas)
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao SysCaixa");
        Thread.Sleep(600);
        Console.WriteLine(@"Informe a opção desejada:
1 - Depositar
2 - Sacar
3 - Verificar saldo 
4 - Voltar ao menu
0 - Sair");
        
        var opcao = Console.ReadLine();
        
        switch (opcao)
        {
            case "1":            
                Depositar(usuario, conta, usuarios, contas);
                break;
            case "2":
                Sacar(usuario, conta, usuarios, contas);
                break;
            case "3":
                VerificarSaldo(usuario, conta, usuarios, contas);
                break;
            case "4":
                LoginSysCaixa.TelaInicial(usuarios, contas);
                break;
            case "0":
                Console.WriteLine("Obrigado por usar o SysCaixa");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida");
                TelaInicial(usuario, conta, usuarios, contas);
                break;
        }
    }
            public static void Depositar(Usuario usuario, ContaBancaria conta, List<Usuario> usuarios, List<ContaBancaria> contas)
            {
                Console.Clear();
                Console.WriteLine("Depósito");
                Console.WriteLine("Informe o valor a ser depositado");
                var valor = double.Parse(Console.ReadLine());
                
                if (valor > 0)
                {
                    conta.Saldo += valor;
                    Console.WriteLine("Depósito realizado com sucesso");
                    Thread.Sleep(600);
                    Console.Clear();
                    TelaInicial(usuario, conta, usuarios, contas);                
                }

                else
                {
                    ValorInvalidoOuNulo();
                    Depositar(usuario, conta, usuarios, contas);
                }
        }

        public static void Sacar(Usuario usuario, ContaBancaria conta, List<Usuario> usuarios, List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("Saque");
            Console.WriteLine("Informe o valor a ser sacado");
            var valor = double.Parse(Console.ReadLine());
            
            if (valor > 0)
            {
                if (valor <= conta.Saldo)
                {
                    conta.Saldo -= valor;
                    Console.WriteLine("Saque realizado com sucesso");
                    Thread.Sleep(600);
                    Console.Clear();
                    TelaInicial(usuario, conta, usuarios, contas);
                }
                
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    Thread.Sleep(600);
                    Console.Clear();
                    Sacar(usuario, conta, usuarios, contas);
                }
            }
            
            else
            {
                ValorInvalidoOuNulo();
                Sacar(usuario, conta, usuarios, contas);
            }
        }

        public static void VerificarSaldo(Usuario usuario, ContaBancaria conta, List<Usuario> usuarios, List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("Saldo");
            Console.WriteLine($"Seu saldo disponível é de {conta.Saldo}");
            Thread.Sleep(600);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            TelaInicial(usuario, conta, usuarios, contas);
        }

        public static void ValorInvalidoOuNulo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor inválido\nO valor não pode ser menor ou igual a zero");
            Console.ResetColor();
            Thread.Sleep(600);
            Console.Clear();
        }
}
