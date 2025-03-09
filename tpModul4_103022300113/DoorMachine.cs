using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_103022300113
{
    class DoorMachine
    {
        private string state;

        public DoorMachine()
        {
            state = "Terkunci";  // Status awal pintu
        }

        public void KunciPintu()
        {
            if (state == "Terbuka")
            {
                state = "Terkunci";
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        public void BukaPintu()
        {
            if (state == "Terkunci")
            {
                state = "Terbuka";
                Console.WriteLine("Pintu terbuka");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void DisplayState()
        {
            Console.WriteLine($"Status pintu: {state}");
        }
    }
}
