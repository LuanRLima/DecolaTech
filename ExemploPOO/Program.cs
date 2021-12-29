using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPoog
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste2");
            var caminhoArquivo = Path.Combine(caminhoPathCombine, "ArquivoTeste.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste1", "ArquivoTeste2.txt");
            var listaString = new List<string>()
            {
                "Linha 1",
                "Linha 2",
                "Linha 3",
                "Linha 4",
                "Linha 5"
            };
            var ListaStringContinuacao = new List<string>()
            {
                "Linha 6",
                "Linha 7",
                "Linha 8",
                "Linha 9",
                "Linha 10"
            };
            FileHelper helper = new FileHelper();

            // helper.CriarArquivosTextoStream(caminhoArquivo, listaString);
            // helper.AdcionarTextoSream(caminhoArquivo, ListaStringContinuacao);
            // helper.CopiarArquivo(caminhoArquivo, novoCaminhoArquivo, true);
            helper.ApagarArquivo(caminhoArquivo);
            // helper.LerArquivoTextoStream(caminhoArquivo);
            // helper.ListarDiretorios(caminho);
            // helper.ListarAquivosDiretorios(caminho);
            // System.Console.WriteLine("Criando diretorios: " + caminhoPathCombine);
            // helper.ApagarDiretorios(caminhoPathCombine, true);
            // helper.CriarArquivosTexto(caminhoArquivo, "Olá teste de escrita de arquivo");
            // helper.CriarArquivosTextoStream(caminhoArquivo, ListaString);
            // ICalculadora calculadora = new Calculadora();
            // System.Console.WriteLine(calculadora.Dividir(10, 2));
            // System.Console.WriteLine(calculadora.Multiplicar(10, 2));
            // System.Console.WriteLine(calculadora.Somar(10, 2));
            // System.Console.WriteLine(calculadora.Subtrair(10, 2));

            // Computador computador = new Computador();
            // System.Console.WriteLine(computador.ToString());

            // Corrente conta = new Corrente();
            // conta.credditar(100);
            // conta.ExibirSaldo();

            // Aluno p1 = new Aluno();
            // p1.Nome = "Maria";
            // p1.Idade = 20;
            // p1.Nota = 10;
            // p1.Documento = "123.456.789-10";
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "João";
            // p2.Idade = 30;
            // p2.Salario = 1000;
            // p2.Documento = "987.654.321-10";
            // p2.Apresentar();

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "João";
            // p1.Idade = 20;

            // p1.Apresentar();

            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(10, 5);
            // Console.WriteLine(r1.CalcularArea());
            // r1.DefinirMedidas(-1, -1);
            // Console.WriteLine(r1.CalcularArea());
        }
    }
}