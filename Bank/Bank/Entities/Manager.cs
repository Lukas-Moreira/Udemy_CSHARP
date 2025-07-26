using Bank.Utils;
using System;
using System.Globalization;

namespace Bank.Entities
{
    public class Manager
    {
        private int _account;
        private string _name;
        private double _saldo;

        public Manager(int account, string name)
        {
            _account = account;
            _name = name;
            _saldo = 0;
        }

        public Manager(int account, string name, double saldo)
        {
            _account = account;
            _name = name;
            if (!Deposito(saldo))
            {
                Logger.LoggerError("Não foi possível realizar a abertuda de conta");
            }
        }

        public bool Deposito()
        {
            Logger.LoggerMessage("Entre com o valor para o depósito: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor < 0) {
                Logger.LoggerError("Não foi possível realizar deposito");
                return false;
            }

            _saldo += valor;
            Logger.LoggerAccept( $"Conta aberta com sucesso" +
                                 $"\nDeposito de {valor} realizado com sucesso" +
                                 $"\n{GetDatas()}\n");
            return true;
        }

        public bool Deposito(double valor)
        {
            if (valor < 0)
            {
                Logger.LoggerError("Valor não permitido, por favor insira um valor válido");
                return false;
            }

            _saldo += valor;
            Logger.LoggerAccept($"Conta aberta com sucesso" +
                                $"\n{GetDatas()}\n");
            return true;
        }

        public bool Saque()
        {
            Logger.LoggerMessage("Entre com o valor para o saque: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor > _saldo)
            {
                Logger.LoggerError("Valor não permitido, saldo insuficiente");
                return false;
            }

            _saldo -= valor + 5;
            Logger.LoggerAccept($"Saque de {valor} realizado com sucesso" +
                                 $"\n{GetDatas()}");
            return true;
        }

        public string GetDatas()
        {
            string datas = $"\nDados da conta:\nNúmero da conta {_account}, Titular da conta {_name}, Saldo $ {_saldo.ToString("F2")}";
            return datas ;
        }

    }
}
