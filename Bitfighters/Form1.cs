using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitfighters
{
    public partial class Form1 : Form
    {
        public Player one, two;
        public Brick zoneLeft, zoneRight;
        public static Brick[] platforms = new Brick[5];

        public Form1()
        {
            InitializeComponent();

            //window is actually 490 x 490

            one = new Player(40, 100);
            two = new Player(400, 100);
        
            zoneLeft = new Brick(0, 0, 20, 720);
            zoneRight = new Brick(440, 0, 20, 720);
        
            platforms[0] = new Brick(240, 145, 200, 20);
            platforms[1] = new Brick(155, 255, 370, 20);
            platforms[2] = new Brick(240, 535, 200, 20);
            platforms[3] = new Brick(15, 410, 200, 20);
            platforms[4] = new Brick(505, 410, 200, 20);

            int FPS = 100;

            preWallTimer.Interval = 100;
            preWallTimer.Enabled = true;
            preWallTimer.Start();
            playerOneMove.Interval = 1000/FPS;
            playerOneMove.Enabled = true;
            playerOneMove.Start();
            playerTwoMove.Interval = 1000/FPS;
            playerTwoMove.Enabled = true;
            playerTwoMove.Start();
            playerOne.Location = new Point(40, 355);
            playerTwo.Location = new Point(615, 355);
        }
        
        int activateWallTimer = 0;
        int activateEndTimer = 0;
        int endGame = 0; 
        

        private void preWallTimer_Tick(object sender, EventArgs e)
        {
            activateWallTimer = activateWallTimer + 1;

            if (activateWallTimer == 10)
            {
                preWallTimer.Stop();
                wallTimer.Interval = 100;
                wallTimer.Enabled = true;
                wallTimer.Start();
            }
        }

        private void wallTimer_Tick(object sender, EventArgs e)
        {
            activateEndTimer = activateEndTimer + 1;

            this.zoneLeft.shiftX(1);
            this.zoneRight.shiftX(-1);

            wallLeft.Location = new Point((int) zoneLeft.getX(), 100);
            wallRight.Location = new Point((int) zoneRight.getX(), 100);

            if (activateEndTimer == 200)
            {
                wallTimer.Stop();
                endTimer.Interval = 1000;
                endTimer.Enabled = true;
                endTimer.Start();
            }
        }

        private void endTimer_Tick(object sender, EventArgs e)
        {
            endGame = endGame + 1;

            if (endGame == 15)
            {
                endTimer.Stop();
                MessageBox.Show("The timer has run out, the match has ended in a draw.");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerOneMove_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(one.getY());
            one.update();
            playerOne.Location = new Point(one.getX(), one.getY());
        }

        private void playerTwoMove_Tick(object sender, EventArgs e)
        {
            two.update();
            playerTwo.Location = new Point(two.getX(), two.getY());
        }
    }

    public partial class Brick
    {
        protected int x, y, width, height;

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }

        public Brick()
        {
            this.x = 0;
            this.y = 0;
            this.width = 50;
            this.height = 50;
        }

        public Brick(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.width = 50;
            this.height = 50;
        }

        public Brick(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void shiftX(int change)
        {
            this.x = change + this.x;
        }

    }

    public partial class Player : Brick
    {
        private bool gravity = true;
        protected double vx, vy;
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.width = 50;
            this.height = 50;
            this.vx = 0;
            this.vy = 0;
        }

        public void update()
        {
            for(int i = 0; i < Form1.platforms.Length; i++)
            {
                Brick platform = Form1.platforms[i];
                if (isTouching(platform))
                {
                    gravity = false;
                }
            }
            gravity = true;
            //Apply gravity calculations. This function is called 100 times a second
            if (gravity)
            {
                vy = vy + 9.81/100;
            } else
            {
                vy = 0;
            }

            //Shift by y velocity
            x = x + (int)vx;
            y = y + (int)vy;
        }

        public bool isTouching(Brick other)
        {
            bool goodX = (x > other.getX()) ^ (x + width < other.getX() + other.getWidth());
            bool goodY = (y < other.getY()) ^ (y + height > other.getY() + other.getHeight());
            return goodX && goodY;
        }

        public int[] whereTouched(Brick other)
        {

            /*
              ____________4____________
             |                         |
            1|                         |2
             |____________3____________|
             
            */
            int[] collisions = new int[5];

            //Check top

            return new int[] { 1 };
        }
    }
}
