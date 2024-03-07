using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales_19_1_2024
{
    public class gato : Animal
    {
        public string maullar { get; set; }
        public override string sonido()
        {
            return maullar;
        }

        public string raza { get; set; }
        public override string raza()
        {
            return mau;
        }
    }
}