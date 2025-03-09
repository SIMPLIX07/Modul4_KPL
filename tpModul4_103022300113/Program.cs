using System;
using tpModul4_103022300113;

namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodePos = new KodePos("Batununggal", "40266");

            kodePos.DisplayKodePos();

            DoorMachine door = new DoorMachine();
            door.DisplayState();
            door.BukaPintu();
            door.DisplayState();
            door.KunciPintu();
            door.DisplayState();
        }
    }
}
