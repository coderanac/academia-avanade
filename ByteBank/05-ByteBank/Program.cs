using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente carol = new Cliente();
            carol.nome = "Carol";
            carol.cpf = "831.430.320-81";
            carol.profissao = "FullStack";

            ContaCorrente conta = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();

            conta.conta = 00011109;
            conta.agencia = 001;
            conta.saldo = 200;

            conta.titular = carol;
            conta2.titular = new Cliente();

            conta.titular.nome = "Caroline";

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta2.titular.nome);
            Console.ReadLine();

        }
    }
}
