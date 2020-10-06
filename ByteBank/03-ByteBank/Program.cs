using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCarol = new ContaCorrente();

            contaCarol.titular = "Carol";
            contaCarol.agencia = 863;
            contaCarol.conta = 863452;

            ContaCorrente contaCaroline = new ContaCorrente();
            contaCaroline.titular = "Carol";
            contaCaroline.agencia = 863;
            contaCaroline.conta = 863452;

            int idadeCaroline = 21;
            int idadeCarol = 21;

            Console.WriteLine("Igualdade de tipo de valor: " + (idadeCarol == idadeCaroline));
            Console.WriteLine("Igualdade de tipo de referência: " + (contaCaroline == contaCarol));

            contaCarol = contaCaroline;
            Console.WriteLine(contaCarol == contaCaroline);

            contaCarol.saldo = 300;
            Console.WriteLine(contaCarol.saldo);
            Console.WriteLine(contaCaroline.saldo);

            if(contaCarol.saldo >= 100)
            {
                contaCarol.saldo -= 100;
            }
            Console.WriteLine(contaCarol.saldo);

            Console.ReadLine();
        }
    }
}
