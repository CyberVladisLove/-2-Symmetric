using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCompare
{
    public class Row
    {
        public string Algorithm { get; set; } 
        public string Mode { get; set; }
        public string Time { get; set; }



        public Row(string algorithm, string mode, string time)
        {
            Algorithm = algorithm;
            Mode = mode;
            Time = time;
        }
    }
}
