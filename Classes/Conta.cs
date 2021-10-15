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

        public void Depositar(double valorDeposito)
        {

            this.saldo += valorDeposito;

            Console.WriteLine($"Saldo atual da conta de {this.nome} é {this.saldo}");

        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
                
            }

        }


        public override string ToString(){
            
            return $"TipoConta: {this.tipoConta} | Nome: {this.nome} | Saldo: {this.saldo} | Crédito: {this.credito}";

        }

    }
}