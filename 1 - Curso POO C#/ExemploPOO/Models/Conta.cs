using System;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        public double saldo;
        public abstract void Creditar(double valor);
        public void ExibirSaldo() => Console.WriteLine($"Seu saldo é de: {saldo}");
        
    }
}