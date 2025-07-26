using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Utils
{
    internal class Initialize
    {
        public int _account;
        public string _name;
        public bool _flag;

        const string logo = "Banco Central Individual";
        const int tamanho = 60;

        static void _init_()
        {
            /* Desenhando as linhas superiores e inferiores */
            string upperLine = new('#', tamanho);
            string lowerLine = upperLine;

            /* Achando o tamanho do texto */
            int larguraTexto = tamanho - 4;

            int paddingEsquerda = (larguraTexto - logo.Length) / 2;
            int paddingDireira  = larguraTexto - logo.Length - paddingEsquerda;

            string centerLine = "# " + new string(' ', paddingEsquerda) + logo + new string(' ', paddingDireira) + " #";

            string space = "# " + new string(' ', larguraTexto) + " #";

            string version = "\nv1.0.0" +
                             "\nAutor: Lukas Lujan Moreira" +
                             "\nCriado em: 26/07/2025";


            string[] commands = {upperLine, space, centerLine, space, lowerLine };

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < commands.Length; i++) {
                Console.WriteLine(commands[i]);
            }
            Console.WriteLine(version);
            Console.ResetColor();

        }

        public Initialize()
        {
            _init_();

            Console.WriteLine();
            Logger.LoggerMessage("Entre com o número da conta: ");
            _account = int.Parse(Console.ReadLine());

            Logger.LoggerMessage("Entre com o titular da conta: ");
            _name = Console.ReadLine();

            Logger.LoggerMessage("Haverá depósito inicial (s/n)? ");
            _flag = Console.ReadLine().ToLower() == "s" ? true : false;
        }
    }
}
