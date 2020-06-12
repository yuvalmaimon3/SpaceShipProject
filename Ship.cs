using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SpaceShip
{
    abstract class Ship : PictureBox,IShot,IMoveShip
    {
        public virtual Bullet Shot() { return null; }

        public virtual void Move_Ship(int top_limit, int bot_limit) { }

        public enum Bullets
        {
            regular,
            rocket
        }
        private Bullets bullet;   

        private int health;

        public Bullets Bullet
        {
            get
            {
                return bullet;
            }

            set
            {
                bullet = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }
    }
}
