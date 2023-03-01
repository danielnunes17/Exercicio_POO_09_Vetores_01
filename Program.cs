using Exercicio_POO_09_Vetores_01;

public class Program
{
    public static void Main(string[] args)
    {
        Estudante[] vetorEstudante = new Estudante[10];

        Console.WriteLine("Quantos quartos serão alugados: ");
        int quantidadeQuartos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidadeQuartos; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vetorEstudante[quarto] = new Estudante(nome, email);
        }
        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < 10; i++)
        {
            if (vetorEstudante[i] != null)
                Console.WriteLine(i + ", " + vetorEstudante[i]);
        }
    }
}