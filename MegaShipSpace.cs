using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class MegaShipSpace : Ship
    {
        BulletsFactory bullet_factory = new BulletsFactory();

        Bullet bullet;

        private int move_direction = 2;
       
        public MegaShipSpace(int location)
        {

            Bullet = Bullets.regular;

            Size = new System.Drawing.Size(200, 180);

            Location = new System.Drawing.Point(1000, location); //לשנות את זה למספר שיתקבל בבנאי. המספר שישלח יעבור את הבדיקות האם יש חללית באותו מיקום

            BackColor = System.Drawing.Color.Transparent;

            Health = 5000;

            Image = Properties.Resources.MegaShipSpaceIcone;
        }

        public override Bullet Shot()
        {
            bullet = bullet_factory.MakeBullet("Gold Bullet", this.Location.X, this.Location.Y + 33);  // Create new bullet 
            return bullet;
        }

        public override void Move_Ship(int top_limit, int bot_limit)
        {
            Top += move_direction;
            if (Top <= top_limit - 60 || Bottom >= bot_limit + 60)
                move_direction *= -1;

        }
    }
}

