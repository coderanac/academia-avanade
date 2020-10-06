using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente carol = new Cliente();
            carol.Nome = "Carol";

            conta.Titular = carol;
            Console.WriteLine(conta.Titular.Nome);
            

            conta.Saldo = 10;
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
