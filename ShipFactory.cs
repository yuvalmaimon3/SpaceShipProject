using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class ShipFactory : Ship
    {
        public Ship Produce_Ship(string type_of_ship,int location)
        {
            if (type_of_ship == "Base Enemy Ship")
            {
                return new BaseEnemyShip(location);
            }
            else if(type_of_ship == "Red Enemy Ship")
            {
                return new RedShip(location);
            }
            else if(type_of_ship == "Mega Ship")
            {
                return new MegaShipSpace(location);
            }
                return null;
            
        }
    }
}
