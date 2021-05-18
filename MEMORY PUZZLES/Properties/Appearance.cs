using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MEMORY_PUZZLES
{
    class Appearance
    {

        public static Random random = new Random();
        public static readonly List<string> icons = new List<string>()
        {
            "!", "!", "$", "$", "o", "o", "%", "%","f", "f", ".", ".","t", "t", "m", "m"
        };
        public static readonly List<string> icons2 = new List<string>()
        {
            "!", "!", "$", "$", "o", "o", "%", "%","f", "f", ".", ".","t", "t", "m", "m"
        };
    }
}
