
using Bank.Entities;
using Bank.Utils;
using System;
using System.Runtime.Intrinsics.X86;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager bank;
            Initialize initialize = new Initialize();

            if (initialize._flag) /* Verifico se realiza um deposito inicial */
            {
                Logger.LoggerMessage("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                if (saldo <= 0)
                {
                    Logger.LoggerError("Operação na permitida, valor inválido");
                    return;
                }
                bank = new Manager(initialize._account, initialize._name, saldo);
            }
            else
            {
                bank = new Manager(initialize._account, initialize._name);
            }

            while (true) 
            {
                Logger.LoggerMessage("Realizar um novo depósito (s/n)? ");
                var aux = Console.ReadLine().ToLower() == "s" ? true : false;

                if (!aux) { 
                    bank.GetDatas();
                    break; 
                }

                bank.Deposito();
            }

            Logger.LoggerMessage("\nRealizar um saque (s/n)? ");
            var aux1 = Console.ReadLine().ToLower() == "s" ? true : false;

            if (!aux1)
            {
                Console.WriteLine(bank.GetDatas());
                return;
            }

            bank.Saque();
        }
    }
}