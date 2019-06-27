using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace PongV2
{
    public partial class PongForm : Form
    {
        public Paddle P1, P2;
        public int BallSpeedIndex = 1, PaddleSpeedIndex = 1;
        int Score1 = 0, Score2 = 0;
        int Wins1 = 0, Wins2 = 0;
        bool W;
        bool S;
        bool I;
        bool K;
        public List<Ball> balls; 

        public PongForm()
        {
            InitializeComponent();
            P1 = new Paddle(10, 150, 10, 50, 3, Color.White);
            P2 = new Paddle(650, 150, 10, 50, 3, Color.White);

            balls = new List<Ball>();
            balls.Add(new Ball());
            ResetAll();

            W = false;
            S = false;
            I = false;
            K = false;

            btnPause.Enabled = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            string keyinfo;
            keyinfo = e.KeyCode.ToString();
            //stops beeping on keypress
            e.SuppressKeyPress = true;

            if (keyinfo == "W")
                //player 1 paddle move up
                W = true;

            if (keyinfo == "S")
                //player 1 paddle move down
                S = true;

            if (keyinfo == "I")
                //player 2 paddle move up
                I = true;

            if (keyinfo == "K")
                //player 2 paddle move down
                K = true;
        }

        private void ResetAll()
        {
            Random AngleRandom, xDirectionRandom;
            AngleRandom = new Random();
            xDirectionRandom = new Random();

            int r;
            r = AngleRandom.Next(0, 3);

            //Balls are all evenly spaced
            for (int i = 0; i < balls.Count; i++)
            {
                Ball a = balls[i];
                a.Reset((400 / (balls.Count + 1)) * (i + 1));
                //velocity magnitudes are assigned randomly based on the three possible angles
                //Randomizes the movement of the balls
                if (r == 0)
                {
                    a.xVelocity = 4 * Math.Sqrt(2);
                    a.yVelocity = 4 * Math.Sqrt(2);
                }
                else if (r == 1)
                {
                    a.xVelocity = 4 * Math.Sqrt(3);
                    a.yVelocity = 4;
                }
                else if (r == 2)
                {
                    a.xVelocity = 8;
                    a.yVelocity = 0;
                }
                //the direction of velocity components is randomized (multiplied by 1 or -1)
                a.xVelocity = a.xVelocity * (xDirectionRandom.Next(0, 2) * 2 - 1);
                a.yVelocity = a.yVelocity * (xDirectionRandom.Next(0, 2) * 2 - 1);

                a.xPosition = 330;
            }
        }

        public void SetBalls(int ballNumber)
        {
            balls.Clear(); //Clears the previous list
            for (int i = 0; i < ballNumber; i++)
            {
                balls.Add(new Ball());
            }
            ResetAll();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                int j;
                Ball b = balls[i];
                for (int k = i + 1; k < balls.Count; k++)
                {
                    Ball a = balls[k];
                    b.Collide(a);
                }
                j = b.Move(P1, P2);
                //Checks to see if any ball has collided 

                if (j == 1) //Score a point for player 2 
                {
                    Score2 += 1;
                    lblScore2.Text = Score2.ToString();
                    if (Score2 >= 11)
                    {
                        //player 2 wins game
                        Timer.Stop();
                        MessageBox.Show("Player 2 Wins!");
                        Wins2 += 1;
                        lblWins2.Text = "Wins:" + Wins2.ToString();
                        Score1 = 0;
                        lblScore1.Text = Score1.ToString();
                        Score2 = 0;
                        lblScore2.Text = Score2.ToString();
                        btnStart.Enabled = true;
                    }
                    ResetAll();
                }
                else if (j == 2) //Score a point for player 1
                {
                    Score1 += 1;
                    lblScore1.Text = Score1.ToString();
                    if (Score1 >= 11)
                    {
                        //player 1 wins game
                        Timer.Stop();
                        MessageBox.Show("Player 1 Wins!");
                        Wins1 += 1;
                        lblWins1.Text = "Wins:" + Wins1.ToString();
                        Score1 = 0;
                        lblScore1.Text = Score1.ToString();
                        Score2 = 0;
                        lblScore2.Text = Score2.ToString();
                        btnStart.Enabled = true;
                    }
                    ResetAll();
                }
            }
            //moving on keydown, stopping on key up
            if (W == true)
                P1.Move(1);

            if (S == true)
                P1.Move(-1);

            if (I == true)
                P2.Move(1);

            if (K == true)
                P2.Move(-1);

            pbGame.Invalidate();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFile = new SaveFileDialog();
                SaveFile.Filter = "Player Scores|*.bin|All Files|*.*";
                SaveFile.Title = "Save Scores";

                //Saves the number of wins to a binary file
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(SaveFile.FileName, FileMode.Create);
                    BinaryWriter ScoreWriter = new BinaryWriter(fs);

                    ScoreWriter.Write(Wins1);
                    ScoreWriter.Write(Wins2);

                    ScoreWriter.Flush();
                    ScoreWriter.Close();
                }
            }
            catch
            {
                MessageBox.Show("File Error");
            }
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = "Score File|*.bin|All Files|*.*";
                OpenFile.Title = "Open Scores";

                //Opens the binary file
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(OpenFile.FileName, FileMode.Open);
                    BinaryReader ScoreReader = new BinaryReader(fs);

                    Wins1 = ScoreReader.ReadInt32();
                    Wins2 = ScoreReader.ReadInt32();

                    lblWins1.Text = "Wins: " + Wins1.ToString();
                    lblWins2.Text = "Wins: " + Wins2.ToString();

                    ScoreReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("File Error");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            SettingsForm SettingsForm = new SettingsForm(this);
            SettingsForm.Show();
        }

        //called after Save button is clicked in SettingsForm
        public void SettingsSave()
        {
            pbGame.Invalidate();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            string keyinfo;
            keyinfo = e.KeyCode.ToString();

            if (keyinfo == "W")
            {
                //player 1 paddle stop moving up
                W = false;
            }

            if (keyinfo == "S")
            {
                //player 1 paddle stop moving down
                S = false;
            }

            if (keyinfo == "I")
            {
                //player 2 paddle stop moving up
                I = false;
            }
            if (keyinfo == "K")
            {
                //player 2 paddle stop moving down
                K = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Timer.Start();
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            Timer.Interval = balls[0].Interval;
        }

        private void pbGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Draws the dashed white line in the middle
            Pen myPen = new Pen(Color.White, 2);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(myPen, 330, 0, 330, 400);

            P1.Draw(g);
            P2.Draw(g);

            for (int i = 0; i < balls.Count; ++i)
            {
                Ball b = balls[i];
                b.Draw(g);
            }
        }
    }

    public class Paddle
    {
        public Point Position;
        public int Speed;
        public int Length;
        public int Width;
        public Color CLR;

        public Paddle()
        {
            Position.X = 0;
            Position.Y = 330;
            Speed = 10;
            Length = 50;
            CLR = Color.White;
        }

        public Paddle(int x, int y, int speed, int length, int width, Color clr)
        {
            if (x < 0 || x > 660)
            {
                throw new Exception(); //Out of bounds
            }
            else
            {
                Position.X = x;
            }            
            if (y < 0 || y > 400)
            {
                throw new Exception(); //Out of bounds
            }
            else
            {
                Position.Y = y;
            }             
            if (speed <= 0)
            {
                throw new Exception(); //No negative speed
            }               
            else
            {
                Speed = speed;
            }             
            if (length <= 0)
            {
                throw new Exception(); //No negative size
            }
            else
            {
                Length = length;
            }            
            if (width < 0)
            {
                throw new Exception(); //No negative width
            }
            else
            {
                Width = width;
            }            
            CLR = clr;
        }
        public void Move(int dir)
        {
            if (dir == 1)  //Up
            {
                Position.Y -= Speed;
            }
            else //Down
            {
                Position.Y += Speed;
            }

            if (Position.Y < 0)
            {
                //Prevents it from going above game space
                Position.Y = 0;
            }
            else if (Position.Y > 400 - Length)
            {
                //Prevents it from going below game space
                Position.Y = 400 - Length;
            }
        }

        public void Draw(Graphics g)
        {
            Pen myPen = new Pen(CLR, Width);
            //Draws rectangle starting from location point with length size
            g.DrawRectangle(myPen, Position.X, Position.Y, Width, Length);
        }
    }

    public class Ball
    {
        public double xPosition; //xPosiiton is relative to the centre of the ball
        public double yPosition;
        public double xVelocity;
        public double yVelocity;
        public int Interval;
        public int Radius;
        public Random AngleRandom;
        public Random xDirectionRandom;
        public Random yPositionRandom;
        public Color CLR;
        public Ball()
        {
            AngleRandom = new Random();
            xDirectionRandom = new Random();
            yPositionRandom = new Random();

            int r;
            r = AngleRandom.Next(0, 3);

            //Velocity magnitudes are assigned randomly based on the three possible angles
            if (r == 0)
            {
                xVelocity = 4 * Math.Sqrt(2);
                yVelocity = 4 * Math.Sqrt(2);
            }
            else if (r == 1)
            {
                xVelocity = 4 * Math.Sqrt(3);
                yVelocity = 4;
            }
            else if (r == 2)
            {
                xVelocity = 8;
                yVelocity = 0;
            }
            //The direction of velocity components is randomized (multiplied by 1 or -1)
            xVelocity = xVelocity * (xDirectionRandom.Next(0, 2) * 2 - 1);
            yVelocity = yVelocity * (xDirectionRandom.Next(0, 2) * 2 - 1);

            //Random y position, x is always the middle of picturebox
            yPosition = yPositionRandom.Next(Radius + 10, 390 - Radius);
            xPosition = 330;

            //Standard speed and size and colour
            Interval = 20;
            Radius = 5;
            CLR = Color.White;
        }

        public bool IsTouchingPaddle(Paddle P)
        {
            double nearX, nearY;
            nearX = Math.Max(P.Position.X, Math.Min(this.xPosition, P.Position.X + P.Width)); //Finds the nearest x coordinate of the rectangle to the ball's centre
            nearY = Math.Max(P.Position.Y, Math.Min(this.yPosition, P.Position.Y + P.Length)); //Finds the nearest y coordinate of the rectangle to the ball's centre

            return Math.Pow((xPosition - nearX), 2) + Math.Pow((yPosition - nearY), 2) < Radius * Radius; //A collision is detected if this is true
        }

        public int Move(Paddle P1, Paddle P2)
        {
            double xd = xPosition - (P1.Position.X - (P1.Width / 2)); //X displacement for paddle 1
            double xd2 = P2.Position.X + (P2.Width / 2) - xPosition; //X displacement for paddle 2

            //Bounce off Paddle 1
            if (IsTouchingPaddle(P1) && xVelocity < 0.0) //Checks xVelocity to see if the ball is moving towards the paddle
            {
                //Top of the paddle, 60 degree angle
                if (yPosition + Radius == P1.Position.Y && xPosition > P1.Position.X && xPosition < P1.Position.X + P1.Width)
                {
                    xVelocity = -4;
                    yVelocity = -1 * Math.Sign(yVelocity) * 4 * Math.Sqrt(3);
                }
                //Top edge, 45 degree angle
                else if (yPosition <= (P1.Position.Y + (P1.Length / 5)) && yPosition >= P1.Position.Y)
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(2);
                    yVelocity = -4 * Math.Sqrt(2);
                    if (yPosition <= (P1.Position.Y + 3) && yPosition >= P1.Position.Y)
                    {
                        Stream str = Properties.Resources.Kung_Fu_Panda_Skadoosh;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();
                    }
                }
                //Top middle edge, 30 degree angle
                else if (yPosition <= (P1.Position.Y + (2 * P1.Length / 5)) && yPosition >= (P1.Position.Y + (P1.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(3);
                    yVelocity = -4;
                }
                //Middle, straight line motion
                else if (yPosition <= (P1.Position.Y + (3 * P1.Length / 5)) && yPosition >= (P1.Position.Y + (2 * P1.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 8;
                    yVelocity = 0;
                }
                //Bottom middle edge, 30 degree angle
                else if (yPosition <= (P1.Position.Y + (4 * P1.Length / 5)) && yPosition >= (P1.Position.Y + (3 * P1.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(3);
                    yVelocity = 4;
                }
                //Bottom edge, 45 degree angle
                else if (yPosition <= (P1.Position.Y + P1.Length) && yPosition >= (P1.Position.Y + (4 * P1.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(2);
                    yVelocity = 4 * Math.Sqrt(2);
                    if (yPosition <= (P1.Position.Y + P1.Length) && yPosition >= (P1.Position.Y + P1.Length - 3))
                    {
                        Stream str = Properties.Resources.Kung_Fu_Panda_Skadoosh;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();
                    }
                }
                //Bottom of the paddle, 60 degree angle
                else if (yPosition - Radius == P1.Position.Y && xPosition > P1.Position.X && xPosition < P1.Position.X + P1.Width)
                {
                    xVelocity = 4;
                    yVelocity = -1 * Math.Sign(yVelocity) * 4 * Math.Sqrt(3);
                }
            }
            //Bounce off Paddle 2
            else if (IsTouchingPaddle(P2) && xVelocity > 0.0) //Checks xVelocity to see if the ball is moving towards the paddle
            {
                //Top edge
                if (yPosition <= (P2.Position.Y + (P2.Length / 5)) && yPosition >= P2.Position.Y)
                {                  
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(2);
                    yVelocity = -4 * Math.Sqrt(2);
                    if (yPosition <= (P2.Position.Y + 3) && yPosition >= P2.Position.Y)
                    {
                        Stream str = Properties.Resources.Kung_Fu_Panda_Skadoosh;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();
                    }
                }
                //Top middle edge
                else if (yPosition <= (P2.Position.Y + (2 * P2.Length / 5)) && yPosition >= (P2.Position.Y + (P2.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(3);
                    yVelocity = -4;
                }
                //Middle
                else if (yPosition <= (P2.Position.Y + (3 * P2.Length / 5)) && yPosition >= (P2.Position.Y + (2 * P2.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 8;
                    yVelocity = 0;
                }
                //Bottom middle edge
                else if (yPosition <= (P2.Position.Y + (4 * P2.Length / 5)) && yPosition >= (P2.Position.Y + (3 * P2.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(3);
                    yVelocity = 4;
                }
                //Bottom edge
                else if (yPosition <= (P2.Position.Y + P2.Length) && yPosition >= (P2.Position.Y + (4 * P2.Length / 5)))
                {
                    xVelocity = -1 * Math.Sign(xVelocity) * 4 * Math.Sqrt(2);
                    yVelocity = 4 * Math.Sqrt(2);
                    //play sound marker when hitting the very edge
                    if (yPosition <= (P2.Position.Y + P2.Length) && yPosition >= (P2.Position.Y + P2.Length - 3))
                    {
                        Stream str = Properties.Resources.Kung_Fu_Panda_Skadoosh;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();
                    }
                }
            }
            else if (yPosition <= Radius || yPosition >= 400 - Radius)
            {
                //If out of vertical bounds
                yVelocity = -1 * yVelocity;
                if (yPosition < Radius)
                {
                    yPosition = Radius;
                }
                else if (yPosition > 400 - Radius) //Prevents ball from being trapped in wall
                {
                    yPosition = 400 - Radius;
                }
            }

            //Score out of bounds
            if (xPosition <= P1.Position.X - Radius)
            {
                //A point is scored on paddle 1
                return 1;
            }
            else if (xPosition >= P2.Position.X + Radius)
            {
                //A point is scored on paddle 2
                return 2;
            }

            //If no special condition, just move ball
            xPosition += xVelocity;
            yPosition += yVelocity;
            return 0;
        }

        public void Collide(Ball other)
        {
            //If two balls, hit elastic collision
            double xd = this.xPosition - other.xPosition;
            double yd = this.yPosition - other.yPosition;

            double R2 = this.Radius + other.Radius;

            if ((xd * xd) + (yd * yd) <= (R2 * R2))
            {
                double xtemp, ytemp; //Switches the velocities as masses are the same
                xtemp = this.xVelocity;
                ytemp = this.yVelocity;

                this.yVelocity = other.yVelocity;
                this.xVelocity = other.xVelocity;
                other.yVelocity = xtemp;
                other.xVelocity = ytemp;
            }
        }

        public void Reset(double yCoord)
        {
            int r;
            r = AngleRandom.Next(0, 3);

            //Velocity magnitudes are assigned randomly based on the three possible angles
            if (r == 0)
            {
                xVelocity = 4 * Math.Sqrt(2);
                yVelocity = 4 * Math.Sqrt(2);
            }
            else if (r == 1)
            {
                xVelocity = 4 * Math.Sqrt(3);
                yVelocity = 4;
            }
            else if (r == 2)
            {
                xVelocity = 8;
                yVelocity = 0;
            }
            //The direction of velocity components is randomized (multiplied by 1 or -1)
            xVelocity = xVelocity * (xDirectionRandom.Next(0, 2) * 2 - 1);
            yVelocity = yVelocity * (xDirectionRandom.Next(0, 2) * 2 - 1);
            //Random y position, x is always the middle of picturebox         
            yPosition = yCoord;
            xPosition = 330;
        }

        public void Draw(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(CLR);
            g.FillEllipse(myBrush, Convert.ToSingle(xPosition - Radius), Convert.ToSingle(yPosition - Radius), 2 * Radius, 2 * Radius);
        }
    }
}
