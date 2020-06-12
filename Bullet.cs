using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SpaceShip
{
    public abstract class Bullet : PictureBox,IMoveBullet
    {
        public enum BelongTo
        {
            Enemy,
            Me
          
        }
        private BelongTo belong_to; 

        private int speed;

        private int damage;

        public int DamagePro
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public BelongTo Belong_to
        {
            get
            {
                return belong_to;
            }

            set
            {
                belong_to = value;
            }
        }

        public virtual bool Move_Bullet() { return false;} //Move the bullet and return true if bullet cross playground area
    }
}
