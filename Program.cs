using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Conta conta1 = new Conta("Joao",200.00,500.00,TipoConta.PessoaFisica);


            Console.WriteLine(conta1.ToString());



        }
    }
}
