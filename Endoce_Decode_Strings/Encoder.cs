using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Endoce_Decode_Strings
{
    public class Encoder
    {
        public string Encode(string[] veri )
        {
            string sonuc = "";
            foreach(string kelime in veri ) 
                {
                sonuc += kelime.Length + "#" + kelime;
                    }
            return sonuc;
        }
    }
}
