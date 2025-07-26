using Pensionato.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato.Models
{
    internal class Room
    {
        private readonly Cliente _client;
        private int _roomNumber;

        public Room(int roomNumber)
        {
            Console.WriteLine($"Datas from Client.");
            Console.Write("Enter the client's name: ");
            string clientName = Console.ReadLine();
            Console.Write("Enter the client's email: ");
            string clientEmail = Console.ReadLine();

            _client = new Cliente(clientName,clientEmail);
            _roomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{_client}\n" +
                   $"Room: {_roomNumber}";
        }
    }
}
