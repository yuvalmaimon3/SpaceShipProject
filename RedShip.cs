using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class RedShip : Ship
    {
        BulletsFactory bullet_factory = new BulletsFactory();

        Bullet bullet;

        private int move_direction = 4;

        public RedShip(int location)
        {

            Bullet = Bullets.regular;

            Size = new System.Drawing.Size(50, 80);

            Location = new System.Drawing.Point(1100, location); 

            BackColor = System.Drawing.Color.Transparent;

            Health = 300;

            Image = Properties.Resources.RedShipIcon;
        }

        public override Bullet Shot()
        {
            bullet = bullet_factory.MakeBullet("Red Bullet", this.Location.X, this.Location.Y + 11);  // Create new bullet 
            return bullet;
        }

        public override void Move_Ship(int top_limit, int bot_limit)
        {
            Top += move_direction;
            if (Top <= top_limit -20 || Bottom >= bot_limit + 20)
                move_direction *= -1;

        }
    }
}
