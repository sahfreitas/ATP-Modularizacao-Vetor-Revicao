using System;

class Programa
{
    public static void Main()
    {
        int[] vetor = new int[12];

        Preencher(vetor);

        Console.WriteLine("=== Estoque antes das vendas ===");
        Exibir(vetor);

        for (int i = 0; i < vetor.Length; i++)
        {
            Venda(ref vetor[i]);
        }

        Console.WriteLine("\n=== Estoque após as vendas ===");
        Exibir(vetor);

        Console.WriteLine("\nTotal final de produtos: " + Total(vetor));
    }

    public static void Preencher(int[] vetor)
    {
        Random r = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(5, 51);
        }
    }
    
    public static void Venda(ref int q)
    {
        q -= 5; 
    }

    public static int Total(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;
    }

    public static void Exibir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}