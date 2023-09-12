class Program
{
    public static void Main(String[] args)
    {
        AdicionarConta gerenciar = new AdicionarConta();
        bool peugeot = true;
        while (peugeot)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Bem vindo a CaixaTem");
            Console.WriteLine("[1] - Criar Conta");
            Console.WriteLine("[2] - Listar Conta");
            Console.WriteLine("[3] - Encerrar CaixaTem");
            Console.WriteLine("------------------------------------");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite seu nome ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite sua idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Selecione [1] - Conta corrente / [2] - Conta poupança");
                    int op = Convert.ToInt32(Console.ReadLine());

                    if (op == 1)
                    {
                        ContaCorrente novaConta = new ContaCorrente(nome, idade);
                        gerenciar.AdicionaConta(novaConta);
                    }
                    else if (op == 2)
                    {
                        ContaPoupança novaConta = new ContaPoupança(nome, idade);
                        gerenciar.AdicionaConta(novaConta);
                    }
                    break;
                case 2:
                    List<Conta> todasasContas = gerenciar.ExibirContas();
                    if (todasasContas.Count > 0)
                    {
                        Console.WriteLine("Todas as pessoas cadastradas:");
                        
                        foreach (var conta in todasasContas)
                        {

                            Console.WriteLine($"Nome: {conta.Id} {conta._Nome}");
                            
                        }
                    }
                        break;

            }
        }
    }
}
