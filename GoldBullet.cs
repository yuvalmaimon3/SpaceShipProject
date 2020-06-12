using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class GoldBullet : Bullet
    {
        public GoldBullet(int location_x, int location_y)
        {
            Belong_to = BelongTo.Enemy;

            Size = new System.Drawing.Size(40, 40); 

            Speed = 40;

            DamagePro = 40;

            Location = new System.Drawing.Point(location_x + 20, location_y + 5);

            Image = Properties.Resources.GoldBulletIcon;

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
