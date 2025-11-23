using System.Timers;
using static System.Reflection.Metadata.BlobBuilder;

namespace Mini_Car_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            Restart.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            collectdCoins();

        }



        Random r = new Random();

        int collected_coins = 0;

        int x, y;


        void enemy(int speed)
        {

            if (enemy1.Top >= 600)
            {
                x = r.Next(15, 200);

                enemy1.Location = new Point(x, 0);
            }

            else
            {
                enemy1.Top += speed;
            }


            if (enemy2.Top >= 600)
            {
                x = r.Next(15, 410);

                enemy2.Location = new Point(x, 0);
            }

            else
            {
                enemy2.Top += speed;
            }



            if (enemy3.Top >= 600)
            {
                x = r.Next(220, 420);

                enemy3.Location = new Point(x, 0);
            }

            else
            {
                enemy3.Top += speed;
            }

        }





        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                Restart.Visible = true;
                Restart.Enabled = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                Restart.Visible = true;
                Restart.Enabled = true;

            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                Restart.Visible = true;
                Restart.Enabled = true;
            }
        }





        void coins(int speed)
        {

            if (coin1.Top >= 600)
            {
                x = r.Next(15, 200);

                coin1.Location = new Point(x, 0);
            }

            else
            {
                coin1.Top += speed;
            }


            if (coin2.Top >= 600)
            {
                x = r.Next(15, 410);

                coin2.Location = new Point(x, 0);
            }

            else
            {
                coin2.Top += speed;
            }



            if (coin3.Top >= 600)
            {
                x = r.Next(250, 410);

                coin3.Location = new Point(x, 0);
            }

            else
            {
                coin3.Top += speed;
            }


            if (coin4.Top >= 600)
            {
                x = r.Next(350, 410);

                coin4.Location = new Point(x, 0);
            }

            else
            {
                coin4.Top += speed;
            }



        }






        void moveline(int speed)
        {

            if (pictureBox2.Top >= 600)
            { pictureBox2.Top = 0; }

            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 600)
            { pictureBox3.Top = 0; }

            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 600)
            { pictureBox4.Top = 0; }

            else
            {
                pictureBox4.Top += speed;
            }

        }


        void collectdCoins()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collected_coins++;
                score.Text = "Coins=" + collected_coins.ToString();
                x = r.Next(15, 410);

                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collected_coins++;
                score.Text = "Coins=" + collected_coins.ToString();
                x = r.Next(250, 410);

                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collected_coins += 5;
                score.Text = "Coins=" + collected_coins.ToString();
                x = r.Next(15, 410);

                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collected_coins += 5;
                score.Text = "Coins=" + collected_coins.ToString();
                x = r.Next(350, 410);

                coin4.Location = new Point(x, 0);
            }




        }



        int gamespeed = 0;
        private object application;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 22)
                    car.Left += -8;
            }


            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 460)
                    car.Left += 8;
            }


            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 13)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {

            enemy1.Top = r.Next(-500, -100);
            enemy2.Top = r.Next(-800, -200);
            enemy3.Top = r.Next(-900, -300);


            coin1.Top = r.Next(-400, -100);
            coin2.Top = r.Next(-600, -200);
            coin3.Top = r.Next(-700, -300);
            coin4.Top = r.Next(-750, -350);


            car.Left = 180;
            car.Top = 400;

            collected_coins = 0;
            score.Text = "Coins=0";
            gamespeed = 0;

            
            over.Visible = false;
            Restart.Visible = false;
            Restart.Enabled = false;


            timer1.Enabled = true;
        }
    }
}
