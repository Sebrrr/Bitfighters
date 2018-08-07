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
        public Form1()
        {
            InitializeComponent();
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
        int leftWallX = 10;
        int rightWallX = 670;
        int endGame = 0;
        double playerOneX = 40;
        double playerOneY = 355;
        double playerOneVX;
        double playerOneVY = 60;
        double playerTwoX = 615;
        double playerTwoY = 355;
        double playerTwoVX;
        double playerTwoVY = 60;
        int wallLeftLeft = 10;
        int wallLeftRight = 33;
        int wallLeftTop = 100;
        int wallLeftBottom = 674;
        int wallRightLeft = 670;
        int wallRightRight = 693;
        int wallRightTop = 100;
        int wallRightBottom = 674;
        int platformSmallLeft = 260;
        int platformSmallRight = 437;
        int platformSmallTop = 145;
        int platformSmallBottom = 179;
        int platformMediumLeft = 175;
        int platformMediumRight = 528;
        int platformMediumTop = 255;
        int platformMediumBottom = 289;
        int platformLargeLeft = 115;
        int platformLargeRight = 590;
        int platformLargeTop = 535;
        int platformLargeBottom = 569;
        int platformLeftLeft = 15;
        int platformLeftRight = 223;
        int platformLeftTop = 410;
        int platformLeftBottom = 444;
        int platformRightLeft = 475;
        int platformRightRight = 491;
        int platformRightTop = 410;
        int platformRightBottom = 444;

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

            leftWallX = leftWallX + 1;
            rightWallX = rightWallX - 1;

            wallLeft.Location = new Point(leftWallX, 100);
            wallRight.Location = new Point(rightWallX, 100);

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
            // it works and there are no errors. I will keep this safe version saved on my computer in case anything goes wrong. Good Luck!
        }

        private void playerTwoMove_Tick(object sender, EventArgs e)
        {

        }
    }
}
