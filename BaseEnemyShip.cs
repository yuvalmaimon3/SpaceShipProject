using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
     class BaseEnemyShip : Ship
    {
        BulletsFactory bullet_factory = new BulletsFactory();

        Bullet bullet;

        private int move_direction = 4;

        public BaseEnemyShip(int location)
        {
            
            Bullet = Bullets.regular;

            Size = new System.Drawing.Size(50,70);

            Location = new System.Drawing.Point(1100, location); 

            BackColor = System.Drawing.Color.Transparent;

            Health = 150;

            Image = Properties.Resources.kspaceduel_48;
        }

        public override Bullet Shot()
        {
            bullet = bullet_factory.MakeBullet("Base Enemy Bullet", this.Location.X, this.Location.Y+25);  // Create new bullet 
            return bullet;
        }

        public override void Move_Ship(int top_limit,int bot_limit)
        {
            Top += move_direction;
            if (Top <= top_limit || Bottom >= bot_limit)
                move_direction *= -1;
           
        }

    }
}
