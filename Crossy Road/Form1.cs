using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossy_Road
{
    public partial class Form1 : Form
    {
        //initializing keys that will be used to control the player
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftDown = false;
        bool rightDown = false;

        //pen setup
        Pen redPen = new Pen(Color.DarkRed);
        Pen bluePen = new Pen(Color.DarkBlue);
        Pen blackPen = new Pen(Color.Black);

        //set up brushes
        SolidBrush greyBrush = new SolidBrush(Color.Gray);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        //set up cars from LEFT
        List<Rectangle> leftCars1 = new List<Rectangle>();
        List<int> leftSpeeds1 = new List<int>();
        List<string> leftColour1 = new List<string>();
        int carSize = 2;

        List<Rectangle> leftCars2 = new List<Rectangle>();
        List<int> leftSpeeds2 = new List<int>();
        List<string> leftColour2 = new List<string>();

        List<Rectangle> leftCars3 = new List<Rectangle>();
        List<int> leftSpeeds3 = new List<int>();
        List<string> leftColour3 = new List<string>();

        List<Rectangle> leftCars4 = new List<Rectangle>();
        List<int> leftSpeeds4 = new List<int>();
        List<string> leftColour4 = new List<string>();

        List<Rectangle> leftCars5 = new List<Rectangle>();
        List<int> leftSpeeds5 = new List<int>();
        List<string> leftColour5 = new List<string>();

        //set up cars from RIGHT
        List<Rectangle> rightCars1 = new List<Rectangle>();
        List<int> rightSpeeds1 = new List<int>();
        List<string> rightColour1 = new List<string>();

        List<Rectangle> rightCars2 = new List<Rectangle>();
        List<int> rightSpeeds2 = new List<int>();
        List<string> rightColour2 = new List<string>();

        List<Rectangle> rightCars3 = new List<Rectangle>();
        List<int> rightSpeeds3 = new List<int>();
        List<string> rightColour3 = new List<string>();

        List<Rectangle> rightCars4 = new List<Rectangle>();
        List<int> rightSpeeds4 = new List<int>();
        List<string> rightColour4 = new List<string>();

        List<Rectangle> rightCars5 = new List<Rectangle>();
        List<int> rightSpeeds5 = new List<int>();
        List<string> rightColour5 = new List<string>();

        //declare random value
        Random randGen = new Random();
        int randValue = 20;
        int randValue2 = 25;
        int randValue3 = 15;
        int randValue4 = 20;
        int randValue5 = 30;
        int randValue6 = 15;
        int randValue7 = 25;
        int randValue8 = 20;
        int randValue9 = 30;
        int randValue10 = 15;

        //player set up
        Rectangle player = new Rectangle(140, 530, 20, 20);
        int playerSpeed = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                        case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                        case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player  up 
            if (upArrowDown == true && player.Y >= 0)
            {
                player.Y -= playerSpeed;

            }

            //move player down
            if (downArrowDown == true && player.Y < this.Height - 20)
            {
                player.Y += playerSpeed;
            }

            //move player left and right
            if (leftDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (rightDown == true && player.X < 280)
            {
                player.X += playerSpeed;
            }

            // move cars from LEFT
            for (int i = 0; i < leftCars1.Count(); i++)
            {
                //find the new postion of x based on speed
                int xRight = leftCars1[i].X + leftSpeeds1[i];

                //replace the rectangle in the list with updated one using new y
                leftCars1[i] = new Rectangle(xRight, 40, leftCars1[i].Width, leftCars1[i].Height);

            }

            for (int i = 0; i < leftCars2.Count(); i++)
            {
                //find the new postion of x based on speed
                int xRight = leftCars2[i].X + leftSpeeds2[i];

                //replace the rectangle in the list with updated one using new y
                leftCars2[i] = new Rectangle(xRight, 140, leftCars2[i].Width, leftCars2[i].Height);

            }

            for (int i = 0; i < leftCars3.Count(); i++)
            {
                //find the new postion of x based on speed
                int xRight = leftCars3[i].X + leftSpeeds3[i];

                //replace the rectangle in the list with updated one using new y
                leftCars3[i] = new Rectangle(xRight, 240, leftCars3[i].Width, leftCars3[i].Height);

            }

            for (int i = 0; i < leftCars4.Count(); i++)
            {
                //find the new postion of x based on speed
                int xRight = leftCars4[i].X + leftSpeeds4[i];

                //replace the rectangle in the list with updated one using new y
                leftCars4[i] = new Rectangle(xRight, 340, leftCars4[i].Width, leftCars4[i].Height);

            }

            for (int i = 0; i < leftCars5.Count(); i++)
            {
                //find the new postion of x based on speed
                int xRight = leftCars5[i].X + leftSpeeds5[i];

                //replace the rectangle in the list with updated one using new y
                leftCars5[i] = new Rectangle(xRight, 440, leftCars5[i].Width, leftCars5[i].Height);

            }

            //move cars from RIGHT
            for (int i = 0; i < rightCars1.Count(); i++)
            {
                //find the new postion of x based on speed
                int xLeft = rightCars1[i].X - rightSpeeds1[i];

                //replace the rectangle in the list with updated one using new y
                rightCars1[i] = new Rectangle(xLeft, 80, rightCars1[i].Width, rightCars1[i].Height);
            }

            for (int i = 0; i < rightCars2.Count(); i++)
            {
                //find the new postion of x based on speed
                int xLeft = rightCars2[i].X - rightSpeeds2[i];

                //replace the rectangle in the list with updated one using new y
                rightCars2[i] = new Rectangle(xLeft, 180, rightCars2[i].Width, rightCars2[i].Height);
            }

            for (int i = 0; i < rightCars3.Count(); i++)
            {
                //find the new postion of x based on speed
                int xLeft = rightCars3[i].X - rightSpeeds3[i];

                //replace the rectangle in the list with updated one using new y
                rightCars3[i] = new Rectangle(xLeft, 280, rightCars3[i].Width, rightCars3[i].Height);
            }


            for (int i = 0; i < rightCars4.Count(); i++)
            {
                //find the new postion of x based on speed
                int xLeft = rightCars4[i].X - rightSpeeds4[i];

                //replace the rectangle in the list with updated one using new y
                rightCars4[i] = new Rectangle(xLeft, 380, rightCars4[i].Width, rightCars4[i].Height);
            }

            for (int i = 0; i < rightCars5.Count(); i++)
            {
                //find the new postion of x based on speed
                int xLeft = rightCars5[i].X - rightSpeeds5[i];

                //replace the rectangle in the list with updated one using new y
                rightCars5[i] = new Rectangle(xLeft, 480, rightCars5[i].Width, rightCars5[i].Height);
            }


            //check to see if a new ball should be created
            randValue--;

            //check to see if new ball should be added from LEFT
            if (randValue == 0)
            {
                leftCars1.Add(new Rectangle(0, 40, 20, 10));
                leftSpeeds1.Add(randGen.Next(2, 2));
                leftColour1.Add("dark red");
                randValue = randGen.Next(25, 75);
            }

            randValue2--;
            if (randValue2 == 0)
            {
                leftCars2.Add(new Rectangle(0, 140, 20, 10));
                leftSpeeds2.Add(randGen.Next(2, 2));
                leftColour2.Add("dark red");
                randValue2 = randGen.Next(25, 75);
            }

            randValue3--;
            if (randValue3 == 0)
            {
                leftCars3.Add(new Rectangle(0, 240, 20, 10));
                leftSpeeds3.Add(randGen.Next(2, 2));
                leftColour3.Add("dark red");
                randValue3 = randGen.Next(25, 75);
            }

            randValue4--;
            if (randValue4 == 0)
            {
                leftCars4.Add(new Rectangle(0, 340, 20, 10));
                leftSpeeds4.Add(randGen.Next(2, 2));
                leftColour4.Add("dark red");
                randValue4 = randGen.Next(25, 75);
            }

            randValue5--;
            if (randValue5 == 0)
            {
                leftCars5.Add(new Rectangle(0, 440, 20, 10));
                leftSpeeds5.Add(randGen.Next(2, 2));
                leftColour5.Add("dark red");
                randValue5 = randGen.Next(25, 75);
            }

            //check to see if new ball should be added from RIGHT
            randValue6--;
            if (randValue6 == 0)
            {
                rightCars1.Add(new Rectangle(300, 80, 20, 10));
                rightSpeeds1.Add(randGen.Next(2, 2));
                rightColour1.Add("dark blue");
                randValue6 = randGen.Next(25, 75);
            }

            randValue7--;
            if (randValue7 == 0)
            {
                rightCars2.Add(new Rectangle(300, 180, 20, 10));
                rightSpeeds2.Add(randGen.Next(2, 2));
                rightColour2.Add("dark blue");
                randValue7 = randGen.Next(25, 75);
            }

            randValue8--;
            if (randValue8 == 0)
            {
                rightCars3.Add(new Rectangle(300, 280, 20, 10));
                rightSpeeds3.Add(randGen.Next(2, 2));
                rightColour3.Add("dark blue");
                randValue8 = randGen.Next(25, 75);
            }

            randValue9--;
            if (randValue9 == 0)
            {
                rightCars4.Add(new Rectangle(300, 380, 20, 10));
                rightSpeeds4.Add(randGen.Next(2, 2));
                rightColour4.Add("dark blue");
                randValue9 = randGen.Next(25, 75);
            }

            randValue10--;
            if (randValue10 == 0)
            {
                rightCars5.Add(new Rectangle(300, 480, 20, 10));
                rightSpeeds5.Add(randGen.Next(2, 2));
                rightColour5.Add("dark blue");
                randValue10 = randGen.Next(25, 75);
            }

            //check if ball is across play area from LEFT and remove it if it is
            for (int i = 0; i < leftCars1.Count(); i++)
            {
                if (leftCars1[i].X > this.Width - carSize)
                {
                    leftCars1.RemoveAt(i);
                    leftSpeeds1.RemoveAt(i);
                    leftColour1.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars2.Count(); i++)
            {
                if (leftCars2[i].X > this.Width - carSize)
                {
                    leftCars2.RemoveAt(i);
                    leftSpeeds2.RemoveAt(i);
                    leftColour2.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars3.Count(); i++)
            {
                if (leftCars3[i].X > this.Width - carSize)
                {
                    leftCars3.RemoveAt(i);
                    leftSpeeds3.RemoveAt(i);
                    leftColour3.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars4.Count(); i++)
            {
                if (leftCars4[i].X > this.Width - carSize)
                {
                    leftCars4.RemoveAt(i);
                    leftSpeeds4.RemoveAt(i);
                    leftColour4.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars5.Count(); i++)
            {
                if (leftCars5[i].X > this.Width - carSize)
                {
                    leftCars5.RemoveAt(i);
                    leftSpeeds5.RemoveAt(i);
                    leftColour5.RemoveAt(i);
                }
            }

            //check if ball is across play area from RIGHT and remove it if it is
            for (int i = 0; i < rightCars1.Count(); i++)
            {
                if (rightCars1[i].X < 0)
                {
                    rightCars1.RemoveAt(i);
                    rightSpeeds1.RemoveAt(i);
                    rightColour1.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars2.Count(); i++)
            {
                if (rightCars2[i].X < 0)
                {
                    rightCars2.RemoveAt(i);
                    rightSpeeds2.RemoveAt(i);
                    rightColour2.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars3.Count(); i++)
            {
                if (rightCars3[i].X < 0)
                {
                    rightCars3.RemoveAt(i);
                    rightSpeeds3.RemoveAt(i);
                    rightColour3.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars4.Count(); i++)
            {
                if (rightCars4[i].X < 0)
                {
                    rightCars4.RemoveAt(i);
                    rightSpeeds4.RemoveAt(i);
                    rightColour4.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars5.Count(); i++)
            {
                if (rightCars5[i].X < 0)
                {
                    rightCars5.RemoveAt(i);
                    rightSpeeds5.RemoveAt(i);
                    rightColour5.RemoveAt(i);
                }
            }

            //check for intersections with player
            for (int i = 0; i < leftCars1.Count(); i++)
            {
                if (player.IntersectsWith(leftCars1[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    leftCars1.RemoveAt(i);
                    leftSpeeds1.RemoveAt(i);
                    leftColour1.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars2.Count(); i++)
            {
                if (player.IntersectsWith(leftCars2[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    leftCars2.RemoveAt(i);
                    leftSpeeds2.RemoveAt(i);
                    leftColour2.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars3.Count(); i++)
            {
                if (player.IntersectsWith(leftCars3[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    leftCars3.RemoveAt(i);
                    leftSpeeds3.RemoveAt(i);
                    leftColour3.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars4.Count(); i++)
            {
                if (player.IntersectsWith(leftCars4[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    leftCars4.RemoveAt(i);
                    leftSpeeds4.RemoveAt(i);
                    leftColour4.RemoveAt(i);
                }
            }

            for (int i = 0; i < leftCars5.Count(); i++)
            {
                if (player.IntersectsWith(leftCars5[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    leftCars5.RemoveAt(i);
                    leftSpeeds5.RemoveAt(i);
                    leftColour5.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars1.Count(); i++)
            {
                if (player.IntersectsWith(rightCars1[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    rightCars1.RemoveAt(i);
                    rightSpeeds1.RemoveAt(i);
                    rightColour1.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars2.Count(); i++)
            {
                if (player.IntersectsWith(rightCars2[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    rightCars2.RemoveAt(i);
                    rightSpeeds2.RemoveAt(i);
                    rightColour2.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars3.Count(); i++)
            {
                if (player.IntersectsWith(rightCars3[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    rightCars3.RemoveAt(i);
                    rightSpeeds3.RemoveAt(i);
                    rightColour3.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars4.Count(); i++)
            {
                if (player.IntersectsWith(rightCars4[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    rightCars4.RemoveAt(i);
                    rightSpeeds4.RemoveAt(i);
                    rightColour4.RemoveAt(i);
                }
            }

            for (int i = 0; i < rightCars5.Count(); i++)
            {
                if (player.IntersectsWith(rightCars5[i]))
                {
                    player.Y = 530;
                    player.X = 140;


                    rightCars5.RemoveAt(i);
                    rightSpeeds5.RemoveAt(i);
                    rightColour5.RemoveAt(i);
                }
            }



            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw background of screen
            e.Graphics.FillRectangle(greyBrush, 0, 30, this.Width, 80);
            e.Graphics.FillRectangle(greyBrush, 0, 130, this.Width, 80);
            e.Graphics.FillRectangle(greyBrush, 0, 230, this.Width, 80);
            e.Graphics.FillRectangle(greyBrush, 0, 330, this.Width, 80);
            e.Graphics.FillRectangle(greyBrush, 0, 430, this.Width, 80);

            e.Graphics.FillRectangle(yellowBrush, 0, 65, this.Width, 5);
            e.Graphics.FillRectangle(yellowBrush, 0, 165, this.Width, 5);
            e.Graphics.FillRectangle(yellowBrush, 0, 265, this.Width, 5);
            e.Graphics.FillRectangle(yellowBrush, 0, 365, this.Width, 5);
            e.Graphics.FillRectangle(yellowBrush, 0, 465, this.Width, 5);

            //draw character
            e.Graphics.FillRectangle(whiteBrush, player);

            //draw finish line
            e.Graphics.FillRectangle(blackBrush, 0, 0, this.Width, 16);
            e.Graphics.FillRectangle(whiteBrush, 0, 6, this.Width, 3);

            //draw cars from LEFT - 1
            for (int i = 0; i < leftCars1.Count(); i++)
            {
                if (leftColour1[i] == "dark red")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(redPen, leftCars1[i].X, leftCars1[i].Y, leftCars1[i].X + leftCars1[i].Width, leftCars1[i].Y);
                    e.Graphics.DrawLine(redPen, leftCars1[i].X + leftCars1[i].Width, leftCars1[i].Y, leftCars1[i].X + leftCars1[i].Width, leftCars1[i].Y + leftCars1[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars1[i].X, leftCars1[i].Y, leftCars1[i].X, leftCars1[i].Y + leftCars1[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars1[i].X + leftCars1[i].Width, leftCars1[i].Y + leftCars1[i].Height - 5, leftCars1[i].X + leftCars1[i].Width + 5, leftCars1[i].Y + leftCars1[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars1[i].X + leftCars1[i].Width + 5, leftCars1[i].Y + leftCars1[i].Height - 5, leftCars1[i].X + leftCars1[i].Width + 5, leftCars1[i].Y + leftCars1[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars1[i].X, leftCars1[i].Y + leftCars1[i].Height, leftCars1[i].X + leftCars1[i].Width + 5, leftCars1[i].Y + leftCars1[i].Height);
                    e.Graphics.DrawEllipse(blackPen, leftCars1[i].X + 3, leftCars1[i].Y + leftCars1[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, leftCars1[i].X + 15, leftCars1[i].Y + leftCars1[i].Height, 5, 5);
                }
            }
            
            for (int i = 0; i < leftCars2.Count(); i++)
            {
                if (leftColour2[i] == "dark red")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(redPen, leftCars2[i].X, leftCars2[i].Y, leftCars2[i].X + leftCars2[i].Width, leftCars2[i].Y);
                    e.Graphics.DrawLine(redPen, leftCars2[i].X + leftCars2[i].Width, leftCars2[i].Y, leftCars2[i].X + leftCars2[i].Width, leftCars2[i].Y + leftCars2[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars2[i].X, leftCars2[i].Y, leftCars2[i].X, leftCars2[i].Y + leftCars2[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars2[i].X + leftCars2[i].Width, leftCars2[i].Y + leftCars2[i].Height - 5, leftCars2[i].X + leftCars2[i].Width + 5, leftCars2[i].Y + leftCars2[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars2[i].X + leftCars2[i].Width + 5, leftCars2[i].Y + leftCars2[i].Height - 5, leftCars2[i].X + leftCars2[i].Width + 5, leftCars2[i].Y + leftCars2[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars2[i].X, leftCars2[i].Y + leftCars2[i].Height, leftCars2[i].X + leftCars2[i].Width + 5, leftCars2[i].Y + leftCars2[i].Height);
                    e.Graphics.DrawEllipse(blackPen, leftCars2[i].X + 3, leftCars2[i].Y + leftCars2[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, leftCars2[i].X + 15, leftCars2[i].Y + leftCars2[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < leftCars3.Count(); i++)
            {
                if (leftColour3[i] == "dark red")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(redPen, leftCars3[i].X, leftCars3[i].Y, leftCars3[i].X + leftCars3[i].Width, leftCars3[i].Y);
                    e.Graphics.DrawLine(redPen, leftCars3[i].X + leftCars3[i].Width, leftCars3[i].Y, leftCars3[i].X + leftCars3[i].Width, leftCars3[i].Y + leftCars3[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars3[i].X, leftCars3[i].Y, leftCars3[i].X, leftCars3[i].Y + leftCars3[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars3[i].X + leftCars3[i].Width, leftCars3[i].Y + leftCars3[i].Height - 5, leftCars3[i].X + leftCars3[i].Width + 5, leftCars3[i].Y + leftCars3[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars3[i].X + leftCars3[i].Width + 5, leftCars3[i].Y + leftCars3[i].Height - 5, leftCars3[i].X + leftCars3[i].Width + 5, leftCars3[i].Y + leftCars3[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars3[i].X, leftCars3[i].Y + leftCars3[i].Height, leftCars3[i].X + leftCars3[i].Width + 5, leftCars3[i].Y + leftCars3[i].Height);
                    e.Graphics.DrawEllipse(blackPen, leftCars3[i].X + 3, leftCars3[i].Y + leftCars3[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, leftCars3[i].X + 15, leftCars3[i].Y + leftCars3[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < leftCars4.Count(); i++)
            {
                if (leftColour4[i] == "dark red")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(redPen, leftCars4[i].X, leftCars4[i].Y, leftCars4[i].X + leftCars4[i].Width, leftCars4[i].Y);
                    e.Graphics.DrawLine(redPen, leftCars4[i].X + leftCars4[i].Width, leftCars4[i].Y, leftCars4[i].X + leftCars4[i].Width, leftCars4[i].Y + leftCars4[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars4[i].X, leftCars4[i].Y, leftCars4[i].X, leftCars4[i].Y + leftCars4[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars4[i].X + leftCars4[i].Width, leftCars4[i].Y + leftCars4[i].Height - 5, leftCars4[i].X + leftCars4[i].Width + 5, leftCars4[i].Y + leftCars4[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars4[i].X + leftCars4[i].Width + 5, leftCars4[i].Y + leftCars4[i].Height - 5, leftCars4[i].X + leftCars4[i].Width + 5, leftCars4[i].Y + leftCars4[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars4[i].X, leftCars4[i].Y + leftCars4[i].Height, leftCars4[i].X + leftCars4[i].Width + 5, leftCars4[i].Y + leftCars4[i].Height);
                    e.Graphics.DrawEllipse(blackPen, leftCars4[i].X + 3, leftCars4[i].Y + leftCars4[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, leftCars4[i].X + 15, leftCars4[i].Y + leftCars4[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < leftCars5.Count(); i++)
            {
                if (leftColour5[i] == "dark red")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(redPen, leftCars5[i].X, leftCars5[i].Y, leftCars5[i].X + leftCars5[i].Width, leftCars5[i].Y);
                    e.Graphics.DrawLine(redPen, leftCars5[i].X + leftCars5[i].Width, leftCars5[i].Y, leftCars5[i].X + leftCars5[i].Width, leftCars5[i].Y + leftCars5[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars5[i].X, leftCars5[i].Y, leftCars5[i].X, leftCars5[i].Y + leftCars5[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars5[i].X + leftCars5[i].Width, leftCars5[i].Y + leftCars5[i].Height - 5, leftCars5[i].X + leftCars5[i].Width + 5, leftCars5[i].Y + leftCars5[i].Height - 5);
                    e.Graphics.DrawLine(redPen, leftCars5[i].X + leftCars5[i].Width + 5, leftCars5[i].Y + leftCars5[i].Height - 5, leftCars5[i].X + leftCars5[i].Width + 5, leftCars5[i].Y + leftCars5[i].Height);
                    e.Graphics.DrawLine(redPen, leftCars5[i].X, leftCars5[i].Y + leftCars5[i].Height, leftCars5[i].X + leftCars5[i].Width + 5, leftCars5[i].Y + leftCars5[i].Height);
                    e.Graphics.DrawEllipse(blackPen, leftCars5[i].X + 3, leftCars5[i].Y + leftCars5[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, leftCars5[i].X + 15, leftCars5[i].Y + leftCars5[i].Height, 5, 5);
                }
            }

            //draw cars from RIGHT
            for (int i = 0; i < rightCars1.Count(); i++)
            {
                if (rightColour1[i] == "dark blue")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(bluePen, rightCars1[i].X, rightCars1[i].Y, rightCars1[i].X + rightCars1[i].Width, rightCars1[i].Y);
                    e.Graphics.DrawLine(bluePen, rightCars1[i].X, rightCars1[i].Y, rightCars1[i].X, rightCars1[i].Y + rightCars1[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars1[i].X, rightCars1[i].Y + rightCars1[i].Height - 5, rightCars1[i].X - 5, rightCars1[i].Y + rightCars1[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars1[i].X - 5, rightCars1[i].Y + rightCars1[i].Height - 5, rightCars1[i].X - 5, rightCars1[i].Y + rightCars1[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars1[i].X - 5, rightCars1[i].Y + rightCars1[i].Height, rightCars1[i].X + rightCars1[i].Width, rightCars1[i].Y + rightCars1[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars1[i].X + rightCars1[i].Width, rightCars1[i].Y, rightCars1[i].X + rightCars1[i].Width, rightCars1[i].Y + rightCars1[i].Height);
                    e.Graphics.DrawEllipse(blackPen, rightCars1[i].X, rightCars1[i].Y + rightCars1[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, rightCars1[i].X + 12, rightCars1[i].Y + rightCars1[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < rightCars2.Count(); i++)
            {
                if (rightColour2[i] == "dark blue")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(bluePen, rightCars2[i].X, rightCars2[i].Y, rightCars2[i].X + rightCars2[i].Width, rightCars2[i].Y);
                    e.Graphics.DrawLine(bluePen, rightCars2[i].X, rightCars2[i].Y, rightCars2[i].X, rightCars2[i].Y + rightCars2[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars2[i].X, rightCars2[i].Y + rightCars2[i].Height - 5, rightCars2[i].X - 5, rightCars2[i].Y + rightCars2[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars2[i].X - 5, rightCars2[i].Y + rightCars2[i].Height - 5, rightCars2[i].X - 5, rightCars2[i].Y + rightCars2[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars2[i].X - 5, rightCars2[i].Y + rightCars2[i].Height, rightCars2[i].X + rightCars2[i].Width, rightCars2[i].Y + rightCars2[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars2[i].X + rightCars2[i].Width, rightCars2[i].Y, rightCars2[i].X + rightCars2[i].Width, rightCars2[i].Y + rightCars2[i].Height);
                    e.Graphics.DrawEllipse(blackPen, rightCars2[i].X, rightCars2[i].Y + rightCars2[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, rightCars2[i].X + 12, rightCars2[i].Y + rightCars2[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < rightCars3.Count(); i++)
            {
                if (rightColour3[i] == "dark blue")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(bluePen, rightCars3[i].X, rightCars3[i].Y, rightCars3[i].X + rightCars3[i].Width, rightCars3[i].Y);
                    e.Graphics.DrawLine(bluePen, rightCars3[i].X, rightCars3[i].Y, rightCars3[i].X, rightCars3[i].Y + rightCars3[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars3[i].X, rightCars3[i].Y + rightCars3[i].Height - 5, rightCars3[i].X - 5, rightCars3[i].Y + rightCars3[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars3[i].X - 5, rightCars3[i].Y + rightCars3[i].Height - 5, rightCars3[i].X - 5, rightCars3[i].Y + rightCars3[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars3[i].X - 5, rightCars3[i].Y + rightCars3[i].Height, rightCars3[i].X + rightCars3[i].Width, rightCars3[i].Y + rightCars3[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars3[i].X + rightCars3[i].Width, rightCars3[i].Y, rightCars3[i].X + rightCars3[i].Width, rightCars3[i].Y + rightCars3[i].Height);
                    e.Graphics.DrawEllipse(blackPen, rightCars3[i].X, rightCars3[i].Y + rightCars3[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, rightCars3[i].X + 12, rightCars3[i].Y + rightCars3[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < rightCars4.Count(); i++)
            {
                if (rightColour4[i] == "dark blue")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(bluePen, rightCars4[i].X, rightCars4[i].Y, rightCars4[i].X + rightCars4[i].Width, rightCars4[i].Y);
                    e.Graphics.DrawLine(bluePen, rightCars4[i].X, rightCars4[i].Y, rightCars4[i].X, rightCars4[i].Y + rightCars4[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars4[i].X, rightCars4[i].Y + rightCars4[i].Height - 5, rightCars4[i].X - 5, rightCars4[i].Y + rightCars4[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars4[i].X - 5, rightCars4[i].Y + rightCars4[i].Height - 5, rightCars4[i].X - 5, rightCars4[i].Y + rightCars4[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars4[i].X - 5, rightCars4[i].Y + rightCars4[i].Height, rightCars4[i].X + rightCars4[i].Width, rightCars4[i].Y + rightCars4[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars4[i].X + rightCars4[i].Width, rightCars4[i].Y, rightCars4[i].X + rightCars4[i].Width, rightCars4[i].Y + rightCars4[i].Height);
                    e.Graphics.DrawEllipse(blackPen, rightCars4[i].X, rightCars4[i].Y + rightCars4[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, rightCars4[i].X + 12, rightCars4[i].Y + rightCars4[i].Height, 5, 5);
                }
            }

            for (int i = 0; i < rightCars5.Count(); i++)
            {
                if (rightColour5[i] == "dark blue")
                {
                    // e.Graphics.DrawRectangle(redPen, leftCars1[i]);

                    e.Graphics.DrawLine(bluePen, rightCars5[i].X, rightCars5[i].Y, rightCars5[i].X + rightCars5[i].Width, rightCars5[i].Y);
                    e.Graphics.DrawLine(bluePen, rightCars5[i].X, rightCars5[i].Y, rightCars5[i].X, rightCars5[i].Y + rightCars5[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars5[i].X, rightCars5[i].Y + rightCars5[i].Height - 5, rightCars5[i].X - 5, rightCars5[i].Y + rightCars5[i].Height - 5);
                    e.Graphics.DrawLine(bluePen, rightCars5[i].X - 5, rightCars5[i].Y + rightCars5[i].Height - 5, rightCars5[i].X - 5, rightCars5[i].Y + rightCars5[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars5[i].X - 5, rightCars5[i].Y + rightCars5[i].Height, rightCars5[i].X + rightCars5[i].Width, rightCars5[i].Y + rightCars5[i].Height);
                    e.Graphics.DrawLine(bluePen, rightCars5[i].X + rightCars5[i].Width, rightCars5[i].Y, rightCars5[i].X + rightCars5[i].Width, rightCars5[i].Y + rightCars5[i].Height);
                    e.Graphics.DrawEllipse(blackPen, rightCars5[i].X, rightCars5[i].Y + rightCars5[i].Height, 5, 5);
                    e.Graphics.DrawEllipse(blackPen, rightCars5[i].X + 12, rightCars5[i].Y + rightCars5[i].Height, 5, 5);
                }
            }

        }
    }
}


