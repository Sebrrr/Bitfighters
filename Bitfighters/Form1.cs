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

    public partial class Brick{
        protected double x, y, width, height;
        
        public double getX(){
            return x;
        }     
        public double getY(){
            return y;
        }     
        public double getWidth(){
            return width;
        }     
        public double getHeight(){
            return height;
        }     

        public Brick(){
            this.x = 0;
            this.y = 0;
            this.width = 50;
            this.height = 50;
        }
        
        public Brick(double x, double y){
            this.x = x;
            this.y = y;
            this.width = 50;
            this.height = 50;
}

        public Brick(double x, double y, double width, double height){
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void shiftX(double change){
            this.x = change + this.x;
        }

    }

    public partial class Player : Brick
    {
        protected double vx, vy;
        public Player(double x, double y){
            this.x = x;
            this.y = y;
            this.width = 50;
            this.height = 50;
            this.vx = 0;
            this.vy = 60;
        }
        
        public void update(){
            //Apply gravity calculations. This function is called 60 times a second
            vy = vy + 9.8/60.0;
            //Shift by y velocity
            x = x + vx;
            y = y + vy;
        }
    }

    public partial class Form1 : Form
    {
        public Player one, two;
        public Brick zoneLeft, zoneRight;
        public Brick[] platforms = new Brick[5];

        public Form1() {
            InitializeComponent();

            one = new Player(40, 355);
            two = new Player(615, 355);
        
            zoneLeft = new Brick(0, 0, 20, 720);
            zoneRight = new Brick(700, 0, 20, 720);
        
            platforms[0] = new Brick(260, 145, 200, 20);
            platforms[1] = new Brick(175, 255, 370, 20);
            platforms[2] = new Brick(115, 535, 490, 20);
            platforms[3] = new Brick(15, 410, 200, 20);
            platforms[4] = new Brick(505, 410, 200, 20);

            preWallTimer.Interval = 1000;
            preWallTimer.Enabled = true;
            preWallTimer.Start();
            playerOneMove.Interval = 10;
            playerOneMove.Enabled = true;
            playerOneMove.Start();
            playerTwoMove.Interval = 10;
            playerTwoMove.Enabled = true;
            playerTwoMove.Start();
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

        private void playerOneMove_Tick(object sender, EventArgs e)
        {
            // fill in your code on how to keep the players from crashing into each other or phasing through any floors.
            // I already declared variables indicating the perimiter of each of the walls.
            // remember, the location of the players is set to the top left coordinates. since the players are 50x50 squares, if you wanted the coordinates of the
            // bottom right corner, it would be (playerOneX, (playerOneY + 50)). The timers are already initialized, you need to fill in the code for the two
            // player timers. I already ste up the wall timers, and also the the end game timers. The walls will start moving at 10 sexonds in, reach their
            // final position 20 seconds after that, and the game will end 15 seconds later if no player kills the other. I just ran a test, 
            // it works and there are no errors. I will keep this safe version saved on my computer in case anything goes wrong.
        }

        private void playerTwoMove_Tick(object sender, EventArgs e)
        {

        }
    }
}
