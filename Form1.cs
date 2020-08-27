﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        //global variables
        int carSpeed = 5;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int Score = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            trophy.Visible = false; // hide the trophy image
            button1.Enabled = false; // disable the button when game is running
            explosion.Visible = false; // hide the explosion image
            trafficSpeed = 5; // set the traffic back to default
            roadSpeed = 5; // set the road speed back to default
            Score = 0; // reset score to 0
            player.Left = 161; // reset player left
            player.Top = 286; // reset player top
            carLeft = false; // reset the moving left to false
            carRight = false; // reset the moving right to false
                              // move the AI to default position this will be off the screen
            AI1.Left = 66;
            AI1.Top = -120;
            AI2.Left = 294;
            AI2.Top = -185;
            //reset the road to their default position
            roadTrack2.Left = -3;
            roadTrack2.Top = -222;
            roadTrack1.Left = -2;
            roadTrack1.Top = -638;
            //start the timer
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Score++; // increase the score as we move
            distance.Text = "" + Score; // show the score on the distance label
            roadTrack1.Top += roadSpeed; // move the track 1 down with the +=
            roadTrack2.Top += roadSpeed; // move the track 2 down with the +=
                                         // if the track has gone past -630 then we set it back to default
                                         // this means it will give us a seamless animation
            if (roadTrack1.Top > 630)
            {
                roadTrack1.Top = -630;
            }
            if (roadTrack2.Top > 630)
            {
                roadTrack2.Top = -630;
            }
            // end of track animation.
            if (carLeft) { player.Left -= carSpeed; } // move the car left if the car left is true
            if (carRight) { player.Left += carSpeed; } // move the car right if the car right is true
                                                       // end of car moving
                                                       //bounce the car off the boundaries of the panel
            if (player.Left < 1)
            {
                carLeft = false; // stop the car from going off screen
            }
            else if (player.Left + player.Width > 380)
            {
                carRight = false;
            }
            // end of the boundaries checks
            //move the AI cars down
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;
            //respawn the AIs and change the their images
            if (AI1.Top > panel1.Height)
            {
                changeAI1(); // change the AI car images once they left the scene
                AI1.Left = rnd.Next(2, 160); // random numbers where they appear on the left
                AI1.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            }
            if (AI2.Top > panel1.Height)
            {
                changeAI2(); // change the AI car images once they left the scene
                AI2.Left = rnd.Next(185, 327); // random numbers where they appear on the left
                AI2.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            }
            // end of respawning the AIs and image changing
            // hit test the player and AI
            //below if statement is checking multiple conditions
            // if player hits AI1 OR player hits AI2
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver(); // this will run when the player hits an AI object
            }
            // end of hit testing the player.
            // speed up the traffic
            // below we are checking for multiple conditions
            // if score is above 100 AND below 500
            if (Score > 100 && Score < 500)
            {
                trafficSpeed = 6;
                roadSpeed = 7;
            }
            // if score is above 500 AND below 1000
            else if (Score > 500 && Score < 1000)
            {
                trafficSpeed = 7;
                roadSpeed = 8;
            }
            // if score is above 1200
            else if (Score > 1200)
            {
                trafficSpeed = 9;
                roadSpeed = 10;
            }
            // end of the traffic speeding up
        }

        private void move(object sender, KeyEventArgs e)
        {

        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            //if the player pressed the left key AND the player is inside the panel
            // then we set the car left boolean to true
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                carLeft = true;
            }
            // if player pressed the right key and the player left plus player width is less then the panel1 width
            // then we set the player right to true
            if (e.KeyCode == Keys.Right && player.Left + player.Width < panel1.Width)
            {
                carRight = true;
            }
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
        }

        private void changeAI1()
        {
            int num = rnd.Next(1, 8); // we set up a local variable to generate a number between 1 and 8
                                      // by using a switch statement we can show any image based on that number
                                      // switch statement will check which number has been generated and will displayer the images as requested
            switch (num)
            {
                // if the number generated is 1 we show the green car
                case 1:
                    AI1.Image = Properties.Resources.carGreen;
                    break;
                // if the number generated is 2 we show the grey car
                case 2:
                    AI1.Image = Properties.Resources.carGrey;
                    break;
                // if the number generated is 3 we show the orange car
                case 3:
                    AI1.Image = Properties.Resources.carOrange;
                    break;
                // if the number generated is 4 we show the pink car
                case 4:
                    AI1.Image = Properties.Resources.carPink;
                    break;
                // if the number generated is 5 we show the red car
                case 5:
                    AI1.Image = Properties.Resources.CarRed;
                    break;
                // if the number generated is 6 we show the blue truck
                case 6:
                    AI1.Image = Properties.Resources.TruckBlue;
                    break;
                // if the number generated is 7 we show the white truck
                case 7:
                    AI1.Image = Properties.Resources.TruckWhite;
                    break;
                // if the number generated is 8 we show the ambulance
                // this is why its important to name your images so they make logical sense
                case 8:
                    AI1.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }
        }

        private void changeAI2()
        {
            int num = rnd.Next(1, 8); // we set up a local variable to generate a number between 1 and 8
                                      // by using a switch statement we can show any image based on that number
                                      // switch statement will check which number has been generated and will displayer the images as requested
            switch (num)
            {
                // if the number generated is 1 we show the green car
                case 1:
                    AI2.Image = Properties.Resources.carGreen;
                    break;
                // if the number generated is 2 we show the grey car
                case 2:
                    AI2.Image = Properties.Resources.carGrey;
                    break;
                // if the number generated is 3 we show the orange car
                case 3:
                    AI2.Image = Properties.Resources.carOrange;
                    break;
                // if the number generated is 4 we show the pink car
                case 4:
                    AI2.Image = Properties.Resources.carPink;
                    break;
                // if the number generated is 5 we show the red car
                case 5:
                    AI2.Image = Properties.Resources.CarRed;
                    break;
                // if the number generated is 6 we show the blue truck
                case 6:
                    AI2.Image = Properties.Resources.TruckBlue;
                    break;
                // if the number generated is 7 we show the white truck
                case 7:
                    AI2.Image = Properties.Resources.TruckWhite;
                    break;
                // if the number generated is 8 we show the ambulance
                case 8:
                    AI2.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }
        }

        private void gameOver()
        {
            trophy.Visible = true; // change the trophy to visible
            timer1.Stop(); // stop the timer
            button1.Enabled = true; // enable the button so we can use it now
                                    //showing the explosion image on top of the car image
            explosion.Visible = true; // make the image visible
            player.Controls.Add(explosion); // add the explosion image on top of the player image
            explosion.Location = new Point(-8, 5); // we are moving the image so its suitably positioned
            explosion.BackColor = Color.Transparent; // change the background to transparent
            explosion.BringToFront();// bring to front of the player image
                                     // final score trophy
                                     // if the player score less than a 1000 we give them a bronze
            if (Score < 1000)
            {
                trophy.Image = Properties.Resources.bronze;
            }
            // if player scored more than 2000 then give them a silver
            if (Score > 2000)
            {
                trophy.Image = Properties.Resources.silver;
            }
            // if player scored more than 3500 then give them a gold trophy
            if (Score > 3500)
            {
                trophy.Image = Properties.Resources.gold;
            }

            playSound();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"hit.wav");
            player.Play();
        }
    }
}
