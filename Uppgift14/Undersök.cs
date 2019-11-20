using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift14
{
    class Undersök
    {
        public bool Tecken(char bokstav)
        {
            bool result = Char.IsLetter(bokstav);
            return result;
        }

    }
}
