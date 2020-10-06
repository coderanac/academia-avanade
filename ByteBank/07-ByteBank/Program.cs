using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(190, 190281736);
            ContaCorrente conta2 = new ContaCorrente(190, 190281736);
            ContaCorrente conta3 = new ContaCorrente(190, 190281736);

            Console.WriteLine(conta.Agencia + " " + conta.Conta);
            Console.WriteLine(ContaCorrente.TotalContas);
            Console.ReadLine();
        }
    }
}
