using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baramenn_test_2
{
    public class Bara
    {
        public int Level { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Bara(string name, string type, int level)
        {
            Level = level;
            Health = 69;
            Strength = 66;
            Name = name;
            Type = type;
        }
    }
}


