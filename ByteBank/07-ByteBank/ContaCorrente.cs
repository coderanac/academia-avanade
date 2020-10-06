using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalContas { get; set; }

        public Cliente _titular;
        private int _agencia;
        private int _conta;
        private double _saldo = 100;

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            TotalContas++;
        }

        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }
        }
        public int Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDesino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDesino.Depositar(valor);
            return true;
        }
    }
}