using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato.Models
{
    internal class Cliente
    {
        private string _nome;
        private Email _email;

        public Cliente(string nome, string email)
        {
            _nome = nome;
            _email = new Email(email);
        }

        public override string ToString()
        {
            return $"Nome: {_nome}\n" +
                   $"Email: {_email}";
        }
    }
}
