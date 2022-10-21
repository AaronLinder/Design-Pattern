using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class SingeltonPattern
    {
        public string name;

        private static SingeltonPattern unserKoenig;

        private SingeltonPattern()
        {
        }
        
        public static SingeltonPattern getInstance()
        {
            if (unserKoenig == null)
            {
                unserKoenig = new SingeltonPattern();
            }
            return unserKoenig;
        }


        public void setName(string Name)
        {
            name = Name;
        }

        public string Angriffsbefehl()
        {
            return name + " befiehlt: Wir greifen an!";
        }

        public string Rückzugbefehl()
        {
            return name + " befiehlt: Wir ziehn uns zurück!";
        }
    }
}
