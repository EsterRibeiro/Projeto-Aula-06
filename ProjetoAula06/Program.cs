using ProjetoAula06.Entities;

namespace ProjetoAula06;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de pessoa: ");

        try
        {

            var pessoa = new Pessoa();
            pessoa.Id = Guid.NewGuid();

            Console.Write("Nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            pessoa.Cpf = Console.ReadLine();

            Console.WriteLine("Dados de pessoa:");
            Console.WriteLine($"id: {pessoa.Id}");
            Console.WriteLine($"nome: {pessoa.Nome}");
            Console.WriteLine($"cpf: {pessoa.Cpf}");


        }
        catch (ArgumentException e) {
            Console.WriteLine("\nErro de validação");
            Console.WriteLine(e.Message);
        }
        finally {
            Console.Write("Deseja repetir o processo? S/N: "); //ocorre independente de cair no try ou catch, não é obrigatório
            var opcao = Console.ReadLine();

            if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase)) { 
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Fim do programa.");
            }
        }
    }
}