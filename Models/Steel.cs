using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Steel : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        // default constructor
        public Steel()
        {
            Name = "Steel Armor";
            Defense = 20;
        }
        // constructor
        public Steel(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }

        // method
        public void MyMethod()
        {

        }
    }
}
