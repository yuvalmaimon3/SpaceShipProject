using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class BaceEnemyBullet : Bullet
    {
        public BaceEnemyBullet(int location_x, int location_y)
        {
            Belong_to = BelongTo.Enemy;

            Size = new System.Drawing.Size(40,40);
                       
            Speed = 50;

            DamagePro = 10;

            Location = new System.Drawing.Point(location_x+20, location_y+5);

            Image = Properties.Resources.BaseBulletIcon2;

            BackColor = System.Drawing.Color.Transparent;

        }
        public override bool Move_Bullet() 
        {
            if (this.Left > 20)
            {
                this.Left -= Speed;

                return false;       //Bullet still in the playgound area
            }          

            this.Hide();

            return true;       //  Bullet cross the playground area

            }
    
    }
}