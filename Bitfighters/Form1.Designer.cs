﻿namespace Bitfighters
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.platformLarge = new System.Windows.Forms.PictureBox();
            this.platformLeft = new System.Windows.Forms.PictureBox();
            this.platformRight = new System.Windows.Forms.PictureBox();
            this.platformMedium = new System.Windows.Forms.PictureBox();
            this.platformSmall = new System.Windows.Forms.PictureBox();
            this.playerOne = new System.Windows.Forms.PictureBox();
            this.playerTwo = new System.Windows.Forms.PictureBox();
            this.hpOne = new System.Windows.Forms.PictureBox();
            this.hpTwo = new System.Windows.Forms.PictureBox();
            this.wallLeft = new System.Windows.Forms.PictureBox();
            this.wallRight = new System.Windows.Forms.PictureBox();
            this.topBanner = new System.Windows.Forms.PictureBox();
            this.preWallTimer = new System.Windows.Forms.Timer(this.components);
            this.wallTimer = new System.Windows.Forms.Timer(this.components);
            this.endTimer = new System.Windows.Forms.Timer(this.components);
            this.playerOneMove = new System.Windows.Forms.Timer(this.components);
            this.playerTwoMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.platformLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // platformLarge
            // 
            this.platformLarge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.platformLarge.Location = new System.Drawing.Point(240, 535);
            this.platformLarge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.platformLarge.Name = "platformLarge";
            this.platformLarge.Size = new System.Drawing.Size(200, 20);
            this.platformLarge.TabIndex = 0;
            this.platformLarge.TabStop = false;
            // 
            // platformLeft
            // 
            this.platformLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.platformLeft.Location = new System.Drawing.Point(20, 410);
            this.platformLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.platformLeft.Name = "platformLeft";
            this.platformLeft.Size = new System.Drawing.Size(200, 20);
            this.platformLeft.TabIndex = 1;
            this.platformLeft.TabStop = false;
            // 
            // platformRight
            // 
            this.platformRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.platformRight.Location = new System.Drawing.Point(480, 410);
            this.platformRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.platformRight.Name = "platformRight";
            this.platformRight.Size = new System.Drawing.Size(200, 20);
            this.platformRight.TabIndex = 2;
            this.platformRight.TabStop = false;
            // 
            // platformMedium
            // 
            this.platformMedium.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.platformMedium.Location = new System.Drawing.Point(155, 255);
            this.platformMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.platformMedium.Name = "platformMedium";
            this.platformMedium.Size = new System.Drawing.Size(370, 20);
            this.platformMedium.TabIndex = 3;
            this.platformMedium.TabStop = false;
            // 
            // platformSmall
            // 
            this.platformSmall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.platformSmall.Location = new System.Drawing.Point(240, 145);
            this.platformSmall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.platformSmall.Name = "platformSmall";
            this.platformSmall.Size = new System.Drawing.Size(200, 20);
            this.platformSmall.TabIndex = 4;
            this.platformSmall.TabStop = false;
            // 
            // playerOne
            // 
            this.playerOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playerOne.Location = new System.Drawing.Point(40, 325);
            this.playerOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(50, 50);
            this.playerOne.TabIndex = 5;
            this.playerOne.TabStop = false;
            // 
            // playerTwo
            // 
            this.playerTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playerTwo.Location = new System.Drawing.Point(615, 325);
            this.playerTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(50, 50);
            this.playerTwo.TabIndex = 6;
            this.playerTwo.TabStop = false;
            // 
            // hpOne
            // 
            this.hpOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hpOne.Location = new System.Drawing.Point(10, 10);
            this.hpOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hpOne.Name = "hpOne";
            this.hpOne.Size = new System.Drawing.Size(300, 20);
            this.hpOne.TabIndex = 7;
            this.hpOne.TabStop = false;
            // 
            // hpTwo
            // 
            this.hpTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hpTwo.Location = new System.Drawing.Point(390, 10);
            this.hpTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hpTwo.Name = "hpTwo";
            this.hpTwo.Size = new System.Drawing.Size(300, 20);
            this.hpTwo.TabIndex = 8;
            this.hpTwo.TabStop = false;
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wallLeft.Location = new System.Drawing.Point(0, 40);
            this.wallLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(20, 680);
            this.wallLeft.TabIndex = 9;
            this.wallLeft.TabStop = false;
            // 
            // wallRight
            // 
            this.wallRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wallRight.Location = new System.Drawing.Point(680, 40);
            this.wallRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(20, 680);
            this.wallRight.TabIndex = 10;
            this.wallRight.TabStop = false;
            // 
            // topBanner
            // 
            this.topBanner.BackColor = System.Drawing.Color.Black;
            this.topBanner.Location = new System.Drawing.Point(0, 0);
            this.topBanner.Margin = new System.Windows.Forms.Padding(0);
            this.topBanner.Name = "topBanner";
            this.topBanner.Size = new System.Drawing.Size(700, 40);
            this.topBanner.TabIndex = 11;
            this.topBanner.TabStop = false;
            // 
            // preWallTimer
            // 
            this.preWallTimer.Tick += new System.EventHandler(this.preWallTimer_Tick);
            // 
            // wallTimer
            // 
            this.wallTimer.Tick += new System.EventHandler(this.wallTimer_Tick);
            // 
            // endTimer
            // 
            this.endTimer.Tick += new System.EventHandler(this.endTimer_Tick);
            // 
            // playerOneMove
            // 
            this.playerOneMove.Tick += new System.EventHandler(this.playerOneMove_Tick);
            // 
            // playerTwoMove
            // 
            this.playerTwoMove.Tick += new System.EventHandler(this.playerTwoMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(698, 664);
            this.Controls.Add(this.wallRight);
            this.Controls.Add(this.wallLeft);
            this.Controls.Add(this.hpTwo);
            this.Controls.Add(this.hpOne);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.platformSmall);
            this.Controls.Add(this.platformMedium);
            this.Controls.Add(this.platformRight);
            this.Controls.Add(this.platformLeft);
            this.Controls.Add(this.platformLarge);
            this.Controls.Add(this.topBanner);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BitFighters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.platformLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox platformLarge;
        private System.Windows.Forms.PictureBox platformLeft;
        private System.Windows.Forms.PictureBox platformRight;
        private System.Windows.Forms.PictureBox platformMedium;
        private System.Windows.Forms.PictureBox platformSmall;
        private System.Windows.Forms.PictureBox playerOne;
        private System.Windows.Forms.PictureBox playerTwo;
        private System.Windows.Forms.PictureBox hpOne;
        private System.Windows.Forms.PictureBox hpTwo;
        private System.Windows.Forms.PictureBox wallLeft;
        private System.Windows.Forms.PictureBox wallRight;
        private System.Windows.Forms.PictureBox topBanner;
        private System.Windows.Forms.Timer preWallTimer;
        private System.Windows.Forms.Timer wallTimer;
        private System.Windows.Forms.Timer endTimer;
        private System.Windows.Forms.Timer playerOneMove;
        private System.Windows.Forms.Timer playerTwoMove;
    }
}

