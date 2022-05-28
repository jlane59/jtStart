using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Giraffe
{
    internal class MakeSnail
    {
        public string name;
        public string quality;
        public double health;
        public double energy;
        public MakeSnail(string aName, string aQuality, double aHealth, double aEnergy)
        {
            //uniqueName = aUniqueName;
            name = aName;
            quality = aQuality;
            health = aHealth;
            energy = aEnergy;
        }
    }
}
