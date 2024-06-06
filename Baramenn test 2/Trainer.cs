using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baramenn_test_2
{
    internal class Trainer
    {
        public List<Bara> Men { get; set; }
        public int Cash { get; set; }
        public int TrainerHealth { get; set; }
        public string Name { get; set; }
        public List <Items> Items { get; set; }

        public Trainer(string name, int cash, int trainerHealth)
        {
            Cash = cash;
            Name = name;
            TrainerHealth = trainerHealth;
        }
    }
}
/*public void Fight()
{
 var men = new BaraList()
}
*/
