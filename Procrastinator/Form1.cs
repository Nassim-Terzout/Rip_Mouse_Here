using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procrastinator
{
    public partial class TheForm : System.Windows.Forms.Form
    {
        // setting up all integers for image speed and box dimensions.
        int s = 5;
        int Topu = 0;
        int Topd = 193;
        int Leftl = 0;
        int Leftr = 334;
        public TheForm()
        {
            InitializeComponent();
        }

        // Below i decided to include 4 buttons that quickly jolt the image in desired direction (30 pixels)
        // i also didn't put restrictions on these buttons so the user can send the image out of the box and wait for it to reappear
        private void Up_Click(object sender, EventArgs e)
        {
            face.Top -= 30;
        }

        private void Down_Click(object sender, EventArgs e)
        {
            face.Top += 30;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            face.Left -= 30;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            face.Left += 30;
        }

        private void face_Click(object sender, EventArgs e)
            //square numbers; width -27 - 185 height -24 - 223
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //NOTE THIS IS JUST SCRAP CODE DO NOT MARK!
            //  Single a = face.Top;
            //   Single b = face.Left;
            //   
            //  do
            //  {
            //    b--;
            //   a--;
            //    Refresh();
            //     System.Threading.Thread.Sleep(30);
            //  } while (a >= -24 && b >= -27 && a <= 223 && b <= 96);
            // }
            // else if (a == -24)
            //{
            //    a++;

            //  }
            //else if (b == 96)
            // {
            //  b--;
            //}
            //else if (a == 223)
            //{
            //  a--;
            // }
            /// else if (b == -27)
            // {
            //   b++;
            // }
            //------------------------------------------------------------------------------------
            // if (face.Top != -24 && face.Left != -27 && face.Top != 223 && face.Left != 96)
            // {

            // do
            // {
            //   face.Top--;
            //    face.Left--;
            //     Refresh();
            //     System.Threading.Thread.Sleep(30);
            // } while (face.Top > -24 && face.Left > -27 && face.Top < 223 && face.Top < 96);
            //}
            //   else if (face.Top == -24)
            // {
            // face.Top++;

            //  }
            // else if (face.Left == 96)
            //  {
            //   face.Left--;
            // }
            // else if (face.Top == 223)
            // {
            // face.Top--;
            // }
            //  else if (face.Left == -27)
            //{
            //    face.Left++;
            // }
            //----------------------------------------------------------------------------------------
            //

            //square numbers; width -27 - 222 height -24 - 223
            // CODE STARTS HERE
            // setting up timers using "if" statements and box dimensions (previous public variables)
            // always have two timers active - up or down - left or right
            // That creates diagonal motion of image at all times based on side touched.
            //lines 124-183 i use this process
            if (face.Top <= Topu)
            {
                topup.Enabled = false;
                topdown.Enabled = true;
            }
            else
            {
                face.Top-=s;
                Refresh();
                System.Threading.Thread.Sleep(0);
            }
        }

        private void topdown_Tick(object sender, EventArgs e)
        {
            if (face.Top >= Topd)
            {
                topup.Enabled = true;
                topdown.Enabled = false;
            }
            else
            {
                face.Top+=s;
                Refresh();
                System.Threading.Thread.Sleep(0);
            }
        }

        private void leftright_Tick(object sender, EventArgs e)
        {
            {
                if (face.Left >= Leftr)
                {
                    leftright.Enabled = false;
                    leftleft.Enabled = true;
                }
                else
                {
                    face.Left+=s;
                    Refresh();
                    System.Threading.Thread.Sleep(0);
                }
            }
        }

        private void leftleft_Tick(object sender, EventArgs e)
        {
            if (face.Left <= Leftl)
            {
                leftright.Enabled = true;
                leftleft.Enabled = false;
            }
            else
            {
                face.Left-=s;
                Refresh();
                System.Threading.Thread.Sleep(0);
            }
        }

        private void Fast_Click(object sender, EventArgs e)
        {
            //   face.Top+=20;
            //  face.Left+=20;
            //if statements used to cap speeds and 30, also adding +1 to speed on every click.
            if (s < 30)
            {
                s = s + 1;
            }
            
        }

        private void Slow_Click(object sender, EventArgs e)
        {
            // using if statements to limit slowing so the image won't stop or go opposite direction. Substract 1 every click from speed to slow.
            if (s > 1)
            {
                s = s - 1;
            }
        }

        private void Big_Click(object sender, EventArgs e)
            // Below is cap max size at 200 x 200 pixels to make image fit box
            // I add by 5 to width & height
            // i decrease box dimension variables to accomodate for change in size of image and make it appear as if the image is always hitting the sides of the box regardless of size change
            //^^ i do this for both bigger and smaller buttons.
        {
            if (face.Height <= 200 && face.Width <= 200)
            {
                face.Height += 5;
                face.Width += 5;
                Topd -= 5;
                Leftr -= 5;
            }
            // face.Top -= 5;
           // face.Left -= 5;
           


        }
        // did same as bigger button however i substracted by 5 and capped in at 10 x 10 pixels.
        private void Small_Click(object sender, EventArgs e)
        {
            if (face.Height >= 10 && face.Width >=10)
            {
                face.Height -= 5;
                face.Width -= 5;
                Topd += 5;
                Leftr += 5;

            }
            //face.Top -= 5;
           // face.Left -= 5;
        }

        private void play_Click(object sender, EventArgs e)
         // Game button... hide current form show game form. Reshow this form once game form closed.
        {
            this.Hide();
            GameClass.Gameplay.ShowDialog();
            this.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            // Help button... hide current form show help form. Reshow this form once help form closed.
            this.Hide();        
            helpClass.help.ShowDialog();
            this.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //exit button
            this.Close();
        }

        private void SashSergeant_Click(object sender, EventArgs e)
            // all 9 images that can be set as the background image for the face are coded here
            //Once each image is clicked a single line of code makes the face background image equal to the image retrieved from the procrastinator program.
            // repeat this 9 times for every image
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.Sash_Sergeant;
        }

        private void Roblox_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.roblox_face_copy;
        }

        private void Raptor_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.T_Soldier_HID_031_Athena_Commando_M_Retro_L;
        }

        private void Fizzface_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.Fizz;
        }

        private void Skeleton_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.Skull_trooper_jonesy_legendary_epic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.T_Soldier_HID_050_Athena_Commando_M_HolidayNutcracker_L;
        }

        private void TomatoHead_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.T_Soldier_HID_109_Athena_Commando_M_Pizza_L;
        }

        private void AlpineAce_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.T_Soldier_HID_055_Athena_Commando_M_SkiDude_CAN_L;
        }

        private void Wukong_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.T_Soldier_HID_071_Athena_Commando_M_Wukong_L;
        }

        private void JohnWick_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.JohnWick;
        }

        private void Nutcracker_Click(object sender, EventArgs e)
        {
            face.BackgroundImage = Procrastinator.Properties.Resources.T_Soldier_HID_050_Athena_Commando_M_HolidayNutcracker_L;
        }

        private void Moveup_Click(object sender, EventArgs e)
            // coded the different movement possibilities here
            // instead of being a sudden jolt like the other 4 buttons this changes the actual direction by enabling or disabling the timers.
            // i do this for all 4 buttons of this sort.
        {
            if (topup.Enabled == false)
            {
                topup.Enabled = true;
                topdown.Enabled = false;
            }
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (topdown.Enabled == false)
            {
                topdown.Enabled = true;
                topup.Enabled = false;
            }
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            if (leftleft.Enabled == false)
            {
                leftleft.Enabled = true;
                leftright.Enabled = false;
            }
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            if (leftright.Enabled == false)
            {
                leftright.Enabled = true;
                leftleft.Enabled = false;
            }
        }

        private void Border_Paint(object sender, PaintEventArgs e)
        {
           //MORE EXTRA USELESS TEST CODE DON'T MARK!!
            // if (Border.BackColor == Color.Red)
            //{
              //  Border.BackColor = Color.Aqua;
                //System.Threading.Thread.Sleep(1250);
                //Refresh();
            
            //}
            //if (Border.BackColor == Color.Aqua)
            //{
              //  Border.BackColor = Color.Coral;
                //System.Threading.Thread.Sleep(1250);
                //Refresh();

            //}
            //if (Border.BackColor == Color.Coral)
            //{
              //  Border.BackColor = Color.Red;
                //System.Threading.Thread.Sleep(1250);
                //Refresh();

            //}

        }

        private void Backcolor_Tick(object sender, EventArgs e)
        {
            // if (Border.BackColor == Color.Red)
            //{
             // Border.BackColor = Color.Aqua;
            //System.Threading.Thread.Sleep(1250);
           // Refresh();

            //}
           // if (Border.BackColor == Color.Aqua)
            //{
            //  Border.BackColor = Color.Coral;
           // System.Threading.Thread.Sleep(1250);
           // Refresh();

            //}
            //if (Border.BackColor == Color.Coral)
           // {
              //Border.BackColor = Color.Red;
            
                //System.Threading.Thread.Sleep(1250);
            //Refresh();
            //
            //}

        }

        private void Spinr_Click(object sender, EventArgs e)
         // Begin Marking here!!
         //This code is used to spin the face left or right
         // put in a certain command to rotate the current face image right or left based on degrees (90 = right, 270 = left)
        {
            Image img = face.BackgroundImage;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            face.BackgroundImage = img;
        }

        private void Spinl_Click(object sender, EventArgs e)
        {
            Image img = face.BackgroundImage;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            face.BackgroundImage = img;
        }
    }
    
    
}
