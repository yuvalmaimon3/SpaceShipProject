using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShip
{
    class ShipBullet : Bullet
    {
        public ShipBullet(int location_x, int location_y)
        {
            Belong_to = BelongTo.Me;

            Size = new System.Drawing.Size(38, 38); 

            Image = Properties.Resources.SmallShurikenIcon;

            BackColor = System.Drawing.Color.Transparent;

            Speed = 100;

            DamagePro = 50;

            Location = new System.Drawing.Point(location_x, location_y);

        }
        public override bool Move_Bullet()
        {
            if (this.Right <= 1200)
            {
                this.Left += Speed;

                return false;       //the bullet dont cross the play ground
            }

              this.Hide();

              return true;       // the bullet cross the play ground
        }
    }
}
