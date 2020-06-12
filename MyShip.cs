using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SpaceShip
{
    class MyShip : Ship
    {
        Bullet bullet;

        BulletsFactory bullet_factory = new BulletsFactory();

        public MyShip()
        {
            Image = Properties.Resources.MyShipIcon;

            Location = new System.Drawing.Point(20, 224); 

            Size = new System.Drawing.Size(80,64);

            Health = 100;

            Bullet = Bullets.regular;

            BackColor = System.Drawing.Color.Transparent;
        }
        public override Bullet Shot()
        {
            bullet = bullet_factory.MakeBullet("My Ship Bullet", this.Location.X+50, this.Location.Y);  // Create new bullet 

            return bullet;
        }

    }
}
