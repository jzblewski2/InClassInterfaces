using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Dagger(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
