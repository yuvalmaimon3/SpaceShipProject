using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    public class BulletsFactory
    {
        
        public Bullet MakeBullet (String bullet_type,int loc_x, int loc_y)
        {
            if (bullet_type == "Base Enemy Bullet")
                return new BaceEnemyBullet(loc_x-20,loc_y-10);

            else if (bullet_type == "My Ship Bullet")
                return new ShipBullet(loc_x+55, loc_y+11);

            else if (bullet_type == "Red Bullet")
                return new RedBullet(loc_x + 55, loc_y + 11);

            else if (bullet_type == "Gold Bullet")
                return new GoldBullet(loc_x + 55, loc_y + 11);

            else return null;
        }
        

        
    }
}
