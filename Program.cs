using System;
using TesteGit.Tester;

internal class Program
{
    private static void Main(string[] args)
    {
        AlteracaoDeArquivos teste1 = new AlteracaoDeArquivos();
        System.Console.WriteLine("Teste para upar no GitHub!");
        
        System.Console.WriteLine();
        System.Console.WriteLine("Qual arquivo sofreu alteração? ");
        string arquivo = Console.ReadLine();
        teste1 = new AlteracaoDeArquivos(arquivo);
        
        System.Console.WriteLine(teste1.ToString());
        
    }
}