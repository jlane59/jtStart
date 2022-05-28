using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Player
    {
        public string name;
        public double health;
        public double speed;
        public double energy;
        public string weaponName;
        public double weaponDamage;

        public Player(string aName, double aHealth, double aSpeed, double aEnergy, string aWeaponName, double aWeaponDamage)
        {
            name = aName;
            health = aHealth;
            speed = aSpeed;
            energy = aEnergy;
            weaponName = aWeaponName;
            weaponDamage = aWeaponDamage;


        }
    
    
    }
}
