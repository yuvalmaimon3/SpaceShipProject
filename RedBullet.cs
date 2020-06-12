using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class RedBullet : Bullet
    {
        public RedBullet(int location_x, int location_y)
        {
            Belong_to = BelongTo.Enemy;

            Size = new System.Drawing.Size(40, 40);

            Speed = 65;

            DamagePro = 25;

            Location = new System.Drawing.Point(location_x + 20, location_y + 5);

            Image = Properties.Resources.RedBulletIcon;

            BackColor = System.Drawing.Color.Transparent;

        }

        public override bool Move_Bullet()
        {
            if (this.Left > 20)
            {
                this.Left -= Speed;

                return false;      
            }

            this.Hide();

            return true;       

        }
    }
}
