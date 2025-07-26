using Pensionato.Models;
using Pensionato.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Manager
    {
        private int _rooms = 10;
        private Room[] _roomList = new Room[10];
        private int _rooms_will_be_rented = 0;
        
        public Manager()
        {
            Initialize init = new Initialize();
            
            Logger.Log("Manager initialized with 10 rooms available.",true);
            
            Logger.Log("Pensionato application started.", true);
            
            Logger.Log("How many rooms will be rented? ", false);

            _rooms_will_be_rented = int.Parse(Console.ReadLine());

            if (_rooms_will_be_rented > _rooms)
            {
                Logger.LogError("You cannot rent more rooms than available.");
                return;
            }

            if (_rooms_will_be_rented < 1)
            {
                Logger.LogError("You must rent at least one room.");
                return;
            }

            for (int i = 0; i < _rooms_will_be_rented; i++)
            {
                Console.Write($"\nPlease enter the number room: ");
                int roomNumber = int.Parse(Console.ReadLine());
                if (roomNumber < 0 || roomNumber-1 >= _rooms)
                {
                    Logger.LogError("Invalid room number. Please enter a number between 0 and 9.");
                    continue;
                }
                try
                {
                    _roomList[roomNumber] = new Room(roomNumber);
                    
                }
                catch (Exception ex)
                {
                    Logger.LogError($"Failed to rent room {roomNumber}: {ex.Message}");
                }
            }

            for (int i = 0; i < _rooms; i++)
            {
                if (_roomList[i] != null)
                {                    
                    Console.WriteLine($"\nRoom #{i}");
                    Console.WriteLine(_roomList[i].ToString());
                    continue;
                }
            }

        }
    }
}
