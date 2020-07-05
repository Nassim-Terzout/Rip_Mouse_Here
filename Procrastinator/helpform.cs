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
    public partial class helpform : Form
    {
        public helpform()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            LoadingPicTimer.Enabled = false;
            LoadingTextTimer.Enabled = false;
            this.Close();
            //Program.TheForm.Show();
            //close program using this 
            
        }

        private void Loadingpic_Click(object sender, EventArgs e)
        {
            //-7,-35
        }

        private void LoadingText_Click(object sender, EventArgs e)
        {
            //0,389
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

       

        private void LoadingTextTimer_Tick(object sender, EventArgs e)
        {
            // i use system sleep to make a cool loading effect before displaying help text.
            // every second a new text appears to make an allusion as if the form is loading something.
            LoadingText.Text = "Loading";
            System.Threading.Thread.Sleep(100);
            Refresh();
            LoadingText.Text = "Loading .";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Text = "Loading . .";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Text = "Loading . . .";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Text = "Loading";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Text = "Loading .";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Text = "Loading . .";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Text = "Loading . . .";
            System.Threading.Thread.Sleep(1000);
            Refresh();
            System.Threading.Thread.Sleep(1000);
            Refresh();
            LoadingText.Visible = false;
            LoadingTextTimer.Enabled = false;
        }
        private void LoadingPicTimer_Tick(object sender, EventArgs e)
        {
            // System.Threading.Thread.Sleep(4000);
            // i set this timer after the loading effects are finished
            // i did this because it is system threading therefore the entire program is put to sleep
            // Having this after the time allows this to disappear right after the loading effects are complete.
            // used visibilty to hide the help image.
            if (LoadingText.Visible == false)
            {
                Loadingpic.Visible = false;
            }
        }
    }
}
