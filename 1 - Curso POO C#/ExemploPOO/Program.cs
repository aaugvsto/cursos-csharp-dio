using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string [] args)
        {


            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Augusto";
            // p1.Idade = 20;

            // p1.Apresentar(); 
            

            // Retangulo ret1 = new Retangulo();
            // ret1.DefinirMedidas(0 , 0);
            // Console.WriteLine($"Area: {ret1.ObterArea()}"); 

            // Retangulo ret2 = new Retangulo();
            // ret2.DefinirMedidas(30 , 30);
            // Console.WriteLine($"Area: {ret2.ObterArea()}");

            
            // Aluno a1 = new Aluno();

            // a1.Nome = "Augusto";
            // a1.Idade = 20;
            // a1.Nota = 10;

            // a1.Apresentar(); 

            // Professor prof = new Professor();

            // prof.Nome = "Alberto";
            // prof.Idade = 50;
            // prof.Documento = "123";
            // prof.Salario = 2000;

            // prof.Apresentar();
            
            // ContaCorrente conta = new ContaCorrente();
            // conta.ExibirSaldo();
            // conta.Creditar(5000);
            // conta.ExibirSaldo();

            Computador computador = new Computador();
            Console.WriteLine(computador.ToString());


        }
    }
}