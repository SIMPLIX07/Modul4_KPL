using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_103022300113
{
    class KodePos
    {
        public string Kelurahan { get; set; }
        public string KodePosValue { get; set; }

        public KodePos(string kelurahan, string kodePosValue)
        {
            Kelurahan = kelurahan;
            KodePosValue = kodePosValue;
        }

        public void DisplayKodePos()
        {
            Console.WriteLine($"Kelurahan: {Kelurahan}, Kode Pos: {KodePosValue}");
        }
    }
}
