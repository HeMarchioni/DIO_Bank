using System;

namespace DIO.Bank
{
    public class Conta
    {
        
        private string nome { get; set; }

        private double saldo { get; set; }

        private double credito { get; set; }
        private TipoConta tipoConta { get; set; }


        
        public Conta (string nome, double saldo, double credito, TipoConta tipoConta)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
            this.tipoConta = tipoConta;
        }



        public bool Sacar(double valorSaque)
        {

            if (this.saldo - valorSaque < (this.credito *-1))
            {
                Console.WriteLine("Saldo insuficiente:");
                return false;
            }

            this.saldo -= valorSaque;

            Console.WriteLine($"Saldo atual da conta de {this.nome} é {this.saldo}");

            return true;

        }



    }
}