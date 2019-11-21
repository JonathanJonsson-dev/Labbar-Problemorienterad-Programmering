using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift15
{
    class Rotvälska
    {
        public int NumberOfVowels(string sträng)
        {
            char[] småVokaler = ("aeiouyåäö").ToCharArray(); // gör om sträng till en array med charachers
            char[] storaVokaler = ("AEIOUYÅÄÖ").ToCharArray(); // gör om sträng till en array med charachers
            char[] charachersAttKolla= sträng.ToCharArray(); // gör om sträng till en array med charachers
            int counterSmåVokaler, counterStoraVokaler;
            counterSmåVokaler = 0;
            counterStoraVokaler = 0;

            // skapar en loop som först tar första char och sedan kollar om den char stämmer överens med någon char i array:en för vokalerna. 
            foreach (char bokstav in charachersAttKolla)
            {
                foreach  (char vokal in småVokaler)
                {
                    if (bokstav == vokal)
                    {
                        counterSmåVokaler++;
                    }
                }
            }

            // skapar en loop som först tar första char och sedan kollar om den char stämmer överens med någon char i array:en för vokalerna. 
            foreach (char bokstav in charachersAttKolla)
            {
                foreach (char vokal in storaVokaler)
                {
                    if (bokstav == vokal)
                    {
                        counterStoraVokaler++;
                    }
                }
            }

            int total = counterSmåVokaler + counterStoraVokaler;

            return total;
        }

        public string JibberishSmåVokaler(string sträng)
        {
            char[] småVokaler = ("aeiouyåäö").ToCharArray(); // gör om sträng till en array med charachers
            char[] storaVokaler = ("AEIOUYÅÄÖ").ToCharArray(); // gör om sträng till en array med charachers
            char[] charachersAttKolla = sträng.ToCharArray(); // gör om sträng till en array med charachers

            for (int i = 0; i < charachersAttKolla.Length; i++)
            {
                foreach (char vokal in småVokaler)
                {
                    if (charachersAttKolla[i] == vokal)
                    {
                        charachersAttKolla[i] = char.Parse("ö");
                    }
                }
            }
            
            return new String(charachersAttKolla); 
        }

        public string JibberishStoraVokaler(string sträng)
        {
            char[] småVokaler = ("aeiouyåäö").ToCharArray(); // gör om sträng till en array med charachers
            char[] storaVokaler = ("AEIOUYÅÄÖ").ToCharArray(); // gör om sträng till en array med charachers
            char[] charachersAttKolla = sträng.ToCharArray(); // gör om sträng till en array med charachers

            for (int i = 0; i < charachersAttKolla.Length; i++)
            {
                foreach (char vokal in storaVokaler)
                {
                    if (charachersAttKolla[i] == vokal)
                    {
                        charachersAttKolla[i] = char.Parse("Ö");
                    }
                }
            }

            return new String(charachersAttKolla);
        }

        /*
        public bool IsVowel(string sträng)
        {

            if (bokstav == vokal)
            {
                counterSmåVokaler++;
            }
            return resultat;
        }*/
    }
}
