using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCarol = new ContaCorrente();

            contaCarol.titular = "Carol";

            Console.WriteLine(contaCarol.saldo);
            bool resultadoSaque = contaCarol.Sacar(150);

            if(resultadoSaque == true)
            {
                Console.WriteLine(
                    "Saque efetuado com sucesso. Seu saldo atual é de R$ " + contaCarol.saldo
                    );
            }
            else
            {
                Console.WriteLine(
                    "Saque não efetuado por falta de saldo. Saldo R$ " + contaCarol.saldo
                    );
            }

            contaCarol.Depositar(400);


            Console.WriteLine(contaCarol.saldo);
            bool resultadoNovoSaque = contaCarol.Sacar(150);

            if (resultadoNovoSaque == true)
            {
                Console.WriteLine(
                    "Saque efetuado com sucesso. Seu saldo atual é de R$ " + contaCarol.saldo
                    );
            }
            else
            {
                Console.WriteLine(
                    "Saque não efetuado por falta de saldo. Saldo R$ " + contaCarol.saldo
                    );
            }


            ContaCorrente contaDestino = new ContaCorrente();

            Console.WriteLine("Saldo carol antes de transferir: " + contaCarol.saldo);
            Console.WriteLine("Saldo destino antes de transferir: " + contaDestino.saldo);

            bool resultadoTransferencia = contaCarol.Transferir(200, contaDestino);

            Console.WriteLine("Saldo carol depois de transferir: " + contaCarol.saldo);
            Console.WriteLine("Saldo destino depois de transferir: " + contaDestino.saldo);
            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            bool resultadoNovaTransferencia = contaDestino.Transferir(200, contaCarol);
            Console.WriteLine("Saldo carol depois de transferir: " + contaCarol.saldo);
            Console.WriteLine("Saldo destino depois de transferir: " + contaDestino.saldo);
            Console.WriteLine("Resultado da transferência: " + resultadoNovaTransferencia);

            Console.ReadLine();
        }
    }
}
