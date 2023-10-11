using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        SoundPlayer sp;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            outputLabel.Text = "yoiu are lost in a forest";
            option1Label.Text = "Go north";
            option2Label.Text = "Go south";

            sp = new SoundPlayer(Properties.Resources.jungle);
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            {
                page = 2;  
            }
            else if (page == 2) 
            {
                page = 4;
            }
            else if (page == 3) 
            {
                page = 1; 
            }
            else if (page == 4) 
            {
                page = 1;
            }
            else if (page == 5) 
            {
                page = 6;        
            }
            else if (page == 6) 
            {
                page = 1;
            }
            else if (page == 7) 
            {
                page = 1;
            }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you are lost in a forest";
                    option1Label.Text = "Go north";
                    option2Label.Text = "Go south";

                    sp = new SoundPlayer(Properties.Resources.jungle);
                    sp.Play();

                    imageBox.Image = Properties.Resources.deepBrush;
                    break;

                case 2:
                    outputLabel.Text = "you come to a lake do you want to take a drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.forestLake;
                    break;
                case 3:
                    outputLabel.Text = "you fall in a pit and die!.Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "The water is stagnent you die of cholera. play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    outputLabel.Text = "youA horse swims by. Do you want to ride it?";
                    option1Label.Text = "yes";
                    option2Label.Text = "NO";
                    break;
                case 6:
                    outputLabel.Text = "you tame the horse and ride to safty. want to play again";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 7:
                    outputLabel.Text = "the horse wlaks past you die of lonliness. play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 99:
                    outputLabel.Text = "thank you for playing";
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            ///if (page == 1) 
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 99;
            }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you are lost in a forest";
                    option1Label.Text = "Go north";
                    option2Label.Text = "Go south";

                    imageBox.Image = Properties.Resources.deepBrush

                    break;
                case 2:
                    outputLabel.Text = "you come to a lake do you want to take a drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.forestLake;

                     sp = new SoundPlayer(Properties.Resources.brook);
                    sp.Play();
                    break;
                case 3:
                    outputLabel.Text = "you fall in a pit and die!.Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "The water is stagnent you die of cholera. play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    outputLabel.Text = "youA horse swims by. Do you want to ride it?";
                    option1Label.Text = "yes";
                    option2Label.Text = "NO";
                    break;
                case 6:
                    outputLabel.Text = "you tame the horse and ride to safty. want to play again";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 7:
                    outputLabel.Text = "the horse wlaks past you die of lonliness. play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 99:
                    outputLabel.Text = "thank you for playing";
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;
            }

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
