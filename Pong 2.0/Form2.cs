using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongV2
{
    public partial class SettingsForm : Form
    {
        new PongForm Parent;
        public Color SetColor;
        public int BallSize, BallSpeedIndex, PaddleSize, PaddleSpeedIndex;       

        public SettingsForm(PongForm parentForm)
        {
            InitializeComponent();
            Parent = parentForm;
            //Display previous settings
            cmbPaddleSpeed.SelectedIndex = Parent.PaddleSpeedIndex;
            cmbBallSpeed.SelectedIndex = Parent.BallSpeedIndex;
            numPaddleSize.Value = Parent.P1.Length; //P1 and P2 always have the same length
            numBallSize.Value = Parent.balls[0].Radius;
            SetColor = Parent.P1.CLR; //Saves the previous colour 
            numSetBalls.Value = Parent.balls.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SetColor == Color.Black)
            {
                MessageBox.Show("Invalid Color");
                return;
            }
            else
            {                              
                Parent.P1.CLR = SetColor;
                Parent.P2.CLR = SetColor;               
                Close();
            }          

            if(cBoxNormal.Checked == true) //Normal mode resets everything back to the original settings
            {
                Parent.PaddleSpeedIndex = 1;
                Parent.BallSpeedIndex = 1;
                Parent.P1.CLR = Color.White;
                Parent.P2.CLR = Color.White;
                Parent.P1.Length = 50;
                Parent.P2.Length = 50;
                Parent.P1.Speed = 10;
                Parent.P2.Speed = 10;                
                Parent.SetBalls(1);
                Parent.balls[0].Interval = 20;
                Parent.balls[0].Radius = 5;
                Parent.balls[0].CLR = Color.White;
                Parent.SettingsSave();
                return;                           
            }
            else
            {
                Parent.SetBalls(Convert.ToInt32(numSetBalls.Value));
                //Changes the number of balls 
            }
         
            for(int i = 0; i < Parent.balls.Count; i++)
            {
                //Ball Speeds
                BallSpeedIndex = cmbBallSpeed.SelectedIndex;
                Parent.BallSpeedIndex = BallSpeedIndex;
                Ball a = Parent.balls[i];
                if (BallSpeedIndex == 0) //Fast
                {                 
                    a.Interval = 1;                   
                }
                else if (BallSpeedIndex == 1) //Medium
                {                  
                    a.Interval = 20;
                }
                else if (BallSpeedIndex == 2) //Slow
                {                  
                    a.Interval = 40;
                }

                a.CLR = SetColor;
            }           
               
            //Paddle Speeds
            PaddleSpeedIndex = cmbPaddleSpeed.SelectedIndex;
            Parent.PaddleSpeedIndex = PaddleSpeedIndex;
            if (PaddleSpeedIndex == 0) //Fast
            {
                Parent.P1.Speed = 20;
                Parent.P2.Speed = 20;
            }
            else if (PaddleSpeedIndex == 1) //Medium
            {
                Parent.P1.Speed = 10;
                Parent.P2.Speed = 10;
            }
            else if (PaddleSpeedIndex == 2) //Slow
            {
                Parent.P1.Speed = 5;
                Parent.P2.Speed = 5;
            }

            //Change paddle sizes
            if (Parent.P1.Position.Y + Convert.ToInt32(numPaddleSize.Value) >= 400)
            {
                Parent.P1.Position.Y = 400 - Convert.ToInt32(numPaddleSize.Value);
            }
                
            Parent.P1.Length = Convert.ToInt32(numPaddleSize.Value);
            Parent.P2.Length = Convert.ToInt32(numPaddleSize.Value);

            //Change ball sizes
            for (int i = 0; i < Parent.balls.Count; i++)
            {
                Ball a = Parent.balls[i];
                a.Radius = Convert.ToInt32(numBallSize.Value);
                if (2*a.Radius > ((400 / (Parent.balls.Count + 1)) * (i + 1))) //Cannot have a larger radius than the number of balls
                {
                    MessageBox.Show("Please choose a smaller size or use less balls!");
                    return;
                }
            }
          
            Parent.SettingsSave();
        }

        private void btnSelectColour_Click_1(object sender, EventArgs e)
        {
            //Change colour
            ColorDialog clrDialog = new ColorDialog();
            clrDialog.Color = Parent.balls[0].CLR;
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {              
                SetColor = clrDialog.Color;
            }
            else
            {
                SetColor = Color.White;
            }
        }
    }
}
