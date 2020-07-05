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
    public partial class Game : Form
    {
        //NOTE: DO NOT MARK THIS. EXTRA FEATURE... NOT ENOUGH TIME TO INCLUDE IN THE PROJECT!!
        float t = 30;
        int s = 5;
        public Game()
            
        {
            InitializeComponent();
        }


        private void Skeleton_Click(object sender, EventArgs e)
        {
            Skeletonup.Visible = true;
            Wukongup.Visible = false;
            raptorup.Visible = false;
            Nutcrackerup.Visible = false;
            AlpineSkiup.Visible = false;
            dummyup.Visible = false;

            if (Skeleton.Top < 326)
            {
                Skeleton.Top -= s;
            }

        }

        private void Wukong_Click(object sender, EventArgs e)
        {
            Skeletonup.Visible = false;
            Wukongup.Visible = true;
            raptorup.Visible = false;
            Nutcrackerup.Visible = false;
            AlpineSkiup.Visible = false;
            dummyup.Visible = false;

           
           
        }

        private void Nutcracker_Click(object sender, EventArgs e)
        {
            Skeletonup.Visible = false;
            Wukongup.Visible = false;
            raptorup.Visible = false;
            Nutcrackerup.Visible = true;
            AlpineSkiup.Visible = false;
            dummyup.Visible = false;

            
        }

        private void Raptor_Click(object sender, EventArgs e)
        {
            Skeletonup.Visible = false;
            Wukongup.Visible = false;
            raptorup.Visible = true;
            Nutcrackerup.Visible = false;
            AlpineSkiup.Visible = false;
            dummyup.Visible = false;

           
        }

        private void AplineSki_Click(object sender, EventArgs e)
        {
            Skeletonup.Visible = false;
            Wukongup.Visible = false;
            raptorup.Visible = false;
            Nutcrackerup.Visible = false;
            AlpineSkiup.Visible = true;
            dummyup.Visible = false;

            
        }

        private void Nutcrackerup_Click(object sender, EventArgs e)
        {
            Nutcracker.Top -= 30;
        }

        private void Skeletonup_Click(object sender, EventArgs e)
        {
            Skeleton.Top -= 30;
        }
        

        private void Wukongup_Click(object sender, EventArgs e)
        {
            Wukong.Top -= 30;
        }

        private void raptorup_Click(object sender, EventArgs e)
        {
            Raptor.Top -= 30;
        }

        private void AlpineSkiup_Click(object sender, EventArgs e)
        {
            AlpineSki.Top -= 30;
        }

        private void skeletonu_Tick(object sender, EventArgs e)
            // top 0 , down 352, right 648, left 0
        {
            //if (Skeleton.Top <= 0)
            //  {
            //    skeletonu.Enabled = false;
            //    Wukongu.Enabled = true;
            // }
            // else
            //  {
            //      Skeleton.Top -= s;
            //      Refresh();
            //      System.Threading.Thread.Sleep(0);
            //   }
            // if (Skeleton.Location == Wukong.Location)
            // {
            //      Skeleton.BackgroundImageLayout = Wukong;
            // }
            //-----------------------------------------------------

            if (Skeleton.Top > -100 && Skeleton.Top < 326)
            {
                Skeleton.Top += s-4;
            }
            
        }

    

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Alpineu_Tick(object sender, EventArgs e)
        {
            if (AlpineSki.Top > -100 && AlpineSki.Top < 326)
            {
                AlpineSki.Top += s-4;
            }
            
        }

        private void Raptoru_Tick(object sender, EventArgs e)
        {
            if (Raptor.Top > -100 && Raptor.Top < 326)
            {
                Raptor.Top += s-4;
            }
        }

        private void Nutcracker_Tick(object sender, EventArgs e)
        {
            if (Nutcracker.Top > -100 && Nutcracker.Top < 326)
            {
                Nutcracker.Top += s-4;
            }
        }

        private void Wukong_Tick(object sender, EventArgs e)
        {
            if (Wukong.Top > -100 && Wukong.Top < 326)
            {
                Wukong.Top += s-4;
            }
        }

        private void dummyup_Click(object sender, EventArgs e)
        {

        }

        private void Victory_Tick(object sender, EventArgs e)
        {
            if (Skeleton.Top <= -100 && Wukong.Top <= -100 && Raptor.Top <= -100 && Nutcracker.Top <= -100 && AlpineSki.Top <= -100)
            {
                VictoryBanner.Visible = true;
                exit.Visible = true;
            }
            else if (t == 0)
            {

            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            exit.Visible = false;
            Timer.Visible = true;
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            String v = Convert.ToString(t);
            Timer.Text = v;
            System.Threading.Thread.Sleep(1000);
            t = t - 1;
        
        }

        private void VictoryBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
