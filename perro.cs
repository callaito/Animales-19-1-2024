using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales_19_1_2024
{
    public class perro: Animal
    {
        public string ladrar {  get; set; }
        public override string sonido()
        {
            return ladrar;
        }

    }
}
