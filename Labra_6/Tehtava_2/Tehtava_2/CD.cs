using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Songs { get; set; }
        public override string ToString()
        {
            return Name + " " + Artist + " " + Songs +" ";
        }
    }
}
