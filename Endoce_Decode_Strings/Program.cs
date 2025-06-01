using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endoce_Decode_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "merhaba", "dünya", "yazılım" };
            Encoder encoder = new Encoder();
            Decoder decoder = new Decoder();
            string encoded=encoder.Encode(kelimeler);
            Console.WriteLine(encoded);
            string[] decoded=decoder.Decode(encoded);
            Console.WriteLine("Decoded:");
            foreach (string kelime in decoded)
            {

                Console.WriteLine("-" + kelime);
            }
        }
    }
}
