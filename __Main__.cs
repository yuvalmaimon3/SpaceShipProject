using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpaceShip
{
    public partial class Main : Form
    {
        double current_round = 1;

        int score = 0;

        int delete_enemy_ship_index;

        int count;

        ShipFactory ship_factory = new ShipFactory();

        BulletsFactory bullet_factory = new BulletsFactory();

        MyShip Myship = new MyShip();

        List<Bullet> enemy_bullets = new List<Bullet>();

        List<int> delete_bullet_index;

        List<Ship> EnemyShips = new List<Ship>();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        public Main()
        {

            InitializeComponent();

            Load_SpaceShips.Enabled = true;

            Load_SpaceShips.Interval = 1;

            timer1.Interval = 100;

            Build_New_Playgorund();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            foreach (Ship enemy in EnemyShips)
            {
                enemy.Move_Ship(playground.Top, playground.Bottom);     //Shot action

                if (count % 20 == 0) // Frequency of shot
                {
                    enemy_bullets.Add(enemy.Shot()); // Add bullet bullet list
                    playground.Controls.Add(enemy_bullets[enemy_bullets.Count - 1]);    // Add the new bullet into playground                   
                }

            }

            delete_bullet_index = new List<int>();

            RUN();

            DeleteBullets();

        }


        private void DeleteBullets() // Delete bullet 
        {

            if (delete_bullet_index.Count != 0)
                for (int i = 0; i < delete_bullet_index.Count; i++)
                {
                    enemy_bullets.RemoveAt(delete_bullet_index[i] - i); //Remove the bullets by order              
                }

        }

        private void RUN() //Main Function
        {
            foreach (Bullet bullet in enemy_bullets)
            {
                bool delete_bullet = false;

                delete_bullet = bullet.Move_Bullet();    // Move bullet and check if need to delete(return "True" and "False")

                if (delete_bullet)
                {
                    delete_bullet_index.Add(enemy_bullets.IndexOf(bullet));
                    // Save bullet index in order to delete it in delete functoin
                    continue;
                }
                else if (bullet.Belong_to == Bullet.BelongTo.Enemy)

                    Enemy_Bullet_Hit(bullet);

                else
                {
                    if (My_Bullet_Hit(bullet))
                    {
                        EnemyShips.RemoveAt(delete_enemy_ship_index);
                    }
                }
            }


            if (EnemyShips.Count == 0)  //Round end
            {

                Stage_End();

                return;
            }
            else if (EnemyShips[0].GetType() == typeof(MegaShipSpace)) //MegaShip is apper
            {
                current_round = 3.5;
                if (count % 100 == 0)
                {

                    Load_SpaceShips.Enabled = true;
                }
            }

        }

        private void Enemy_Bullet_Hit(Bullet bullet)
        {
            if (bullet.Location.X <= 70)  // Virtual line.Bullet closing to "myship"
            {
                if (bullet.Left <= Myship.Right && bullet.Top >= Myship.Top-20 && bullet.Bottom <= Myship.Bottom+20) //My ship be damaged
                {
                    Myship.Health -= bullet.DamagePro;   // Ship damaged

                    bullet.Hide();

                    delete_bullet_index.Add(enemy_bullets.IndexOf(bullet)); 

                    My_Health.Text = "Health :" + Myship.Health.ToString();

                    if (Myship.Health <= 0)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Game Over");
                    }

                }
            }
        }

        public void Building_Ship(string ship_type)
        {
            // Build ship correspondingly to the current round
            if (current_round == 1)
            {

                Building_Ship2(50, 300, 1, ship_type);
            }

            else if (current_round == 2)
            {

                Building_Ship2(200, 100, 2, ship_type);
            }
            else if (current_round == 3)
            {

                Building_Ship2(200, 400, 1, ship_type);
            }




        }

        // Add the ship into the game
        private void Building_Ship2(int location, int jump, int amount, String ship_type)
        {
            for (int i = 0; i < amount; i++)
            {
                EnemyShips.Add(ship_factory.Produce_Ship(ship_type, location));

                location += jump;
            }
        }

        private bool My_Bullet_Hit(Bullet bullet)
        {
            bool prevent_double_hit = false;
            if (bullet.Location.X >= 700)  // Virtual line. The bullet closing to "enemy ships"
            {
                foreach (Ship enemy_ship in EnemyShips)
                {
                    if (bullet.Right >= enemy_ship.Left && bullet.Top >= enemy_ship.Top -20 && bullet.Bottom <= enemy_ship.Bottom +20)// if my bullet touch enemy
                    {

                        enemy_ship.Health -= bullet.DamagePro;

                        bullet.Hide();

                        if (!prevent_double_hit)    // When multi ships share similar location 
                        {
                            delete_bullet_index.Add(enemy_bullets.IndexOf(bullet));

                            prevent_double_hit = true;
                        }


                        if (enemy_ship.Health <= 0) //If the ship die hide him and delete him.
                        {
                            enemy_ship.Hide();

                            delete_enemy_ship_index = EnemyShips.IndexOf(enemy_ship);   //get the index of the die ship

                            if (enemy_ship.GetType() == typeof(BaseEnemyShip))                           
                                score += 20;
                           
                            else if (enemy_ship.GetType() == typeof(RedShip))                            
                                score += 40;
                            
                            else if (enemy_ship.GetType() == typeof(MegaShipSpace))
                                score += 100;

                                Score_Label.Text = "Score : " + score.ToString();

                            return true;    //ship is died
                        }
                    }
                }
            }
            return false;
        }

        private void Load_SpaceShips_Tick(object sender, EventArgs e)   //Seconde timer. Make the enemy ship
        {
            if (current_round == 1)
            {
                Building_Ship("Base Enemy Ship");


            }

            else if (current_round == 2)
            {
                Building_Ship("Red Enemy Ship");


            }

            else if (current_round == 3)
            {
                Building_Ship("Mega Ship");


            }

            else if (current_round == 3.5)
            {

                Building_Ship2(10, 0, 1, "Base Enemy Ship");

            }

            foreach (Ship enemy_ship in EnemyShips)
            {
                playground.Controls.Add(enemy_ship);
            }

            Load_SpaceShips.Enabled = false;

            timer1.Enabled = true;

        }



        private void Stage_End()
        {
            if (Go_Next())   // move my ship and check if my ship cross the playgroung 
                Start_New_Round();
        }

        private bool Go_Next()
        {
            if (Myship.Left < playground.Right)
            {
                Myship.Left = Myship.Left + 50; // Moving my ship into the right age.

                return false;
            }

            else
                return true;

        }

        private void Start_New_Round()
        {

            EnemyShips.Clear();

            enemy_bullets.Clear();

            timer1.Enabled = false;

            ++current_round;

            Thread.Sleep(1500); 

            Myship.Left = playground.Left - (playground.Left / 2);

            Build_New_Playgorund();


        }

        private void Build_New_Playgorund()
        {
            if (current_round == 1)
            {

                playground.BackgroundImage = Properties.Resources.Map1;

                playground.BackgroundImageLayout = ImageLayout.Stretch;

                playground.BackColor = Color.DarkGray;

                this.TopMost = true; 

                Myship.Left = playground.Left - (playground.Left / 2);

                Myship.Top = playground.Bottom - (playground.Bottom / 2);

                playground.Controls.Add(Myship);

                My_Health.Text = "Health :" + Myship.Health.ToString();

                My_Health.Left = playground.Left;

                Rounds.Text = "Round : " + current_round;

            }
            else if (current_round == 2)
            {
                playground.BackgroundImage = Properties.Resources.Map2;

                playground.BackColor = Color.Orange;

                timer1.Enabled = false;

                Load_SpaceShips.Enabled = true;

                Rounds.Text = "Round : " + current_round;

            }
            else if (current_round == 3)
            {
                playground.BackgroundImage = Properties.Resources.Map4;

                playground.BackColor = Color.Transparent;

                timer1.Enabled = false;

                Load_SpaceShips.Enabled = true;

                Rounds.Text = "Round : " + current_round;

            }
            else if(current_round == 4.5)
            {
                MessageBox.Show("Mission Complete");
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Down)         // Click down key
            {
                if (Myship.Bottom < playground.Bottom - 10)
                    Myship.Top = Myship.Top + 20;
            }

            if (e.KeyCode == Keys.Up)      // Click up key
            {
                if (Myship.Top > playground.Top + 10)
                    Myship.Top = Myship.Top - 20;
            }

            if (e.KeyCode == Keys.Space)    //Shot
            {
                enemy_bullets.Add(Myship.Shot());

                playground.Controls.Add(enemy_bullets[enemy_bullets.Count - 1]);
            }
        }
    }
}
