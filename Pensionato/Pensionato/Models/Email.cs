using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato.Models
{
    internal class Email
    {
        private string? _emailAddress;

        private readonly string[] domains = { "@gmail.com", "@yahoo.com", "@hotmail.com" };

        public Email(string valor)
        {
            for (int i = 0; i < domains.Length; i++)
            {
                if (valor.EndsWith(domains[i]))
                {
                    _emailAddress = valor;
                    break;  
                }
            }
        }
        public override string ToString()
        {
            return _emailAddress ?? "Email inválido";
        }
    }
}
