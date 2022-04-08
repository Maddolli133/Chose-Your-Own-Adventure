using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

//Maddox, Friday April 8, 2022
//This program is a chose your own adventure game

namespace Chose_Your_Own_Adventure
{
    public partial class Form1 : Form
    {
        int page = 1;//This is the starting page

        Random randGen = new Random();//This generates a random number

        SoundPlayer Click = new SoundPlayer(Properties.Resources.buttonClickBeep);//This is the click sound when you click a button
        SoundPlayer Dead = new SoundPlayer(Properties.Resources.lose);//This is the sound you hear when you die
        SoundPlayer Win = new SoundPlayer(Properties.Resources.win);//This is the sound you hear when you win
        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void optionOneButton_Click(object sender, EventArgs e)//This is the pages you're brought to when you click the button on the left
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 98;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 98;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 98;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 98;
            }
            else if (page == 11)
            {
                int randValue = randGen.Next(1, 101);//This random number generator will decide if you live or die

                if (randValue < 25)
                {
                    page = 14;
                }
                else
                {
                    page = 98;
                }
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 98)
            {
                page = 1;
            }
          
            DisplayPage();
        }

        private void optionTwoButton_Click(object sender, EventArgs e)//This is the pages you're brought to when you click the button on the right
        {
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                int randValue = randGen.Next(1, 101);//This random number generator will decide if you live or die

                if (randValue < 30)
                {
                    page = 9;
                }
                else
                {
                    page = 98;
                }
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                int randValue = randGen.Next(1, 101);//This random number generator will decide if you live or die

                if (randValue < 60)
                {
                    page = 7;
                }
                else
                {
                    page = 98;
                }
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 98;
            }
            else if (page == 13)
            {
                page = 98;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 98)
            {
                Application.Exit();
            }
            else if (page == 99)
            {
                Application.Exit();
            }

            DisplayPage();
        }

        public void DisplayPage()//These codes are what will be on each page starting from the first to last page
        {
            switch (page)
            {
                case 1:
                    textLabel.Text = "You must defeat the Demon King!!";
                    optionOneButton.Text = "Go Left";
                    optionTwoButton.Text = "Go Right";

                    storyImages.Image = Properties.Resources.Village;

                    Click.Play();
                    break;

                case 2:
                    textLabel.Text = "You entered a forest";
                    optionOneButton.Text = "Go towards the temple?";
                    optionTwoButton.Text = "Go to a cave entrance";

                    storyImages.Image = Properties.Resources.Forest;

                    Click.Play();
                    break;
                case 3:
                    textLabel.Text = "You found a huge door, and there was spear";
                    optionOneButton.Text = "Enter and get the amulet of immense strength";
                    optionTwoButton.Text = "Go through the secret path";

                    storyImages.Image = Properties.Resources.Temple_door;

                    Click.Play();
                    break;

                case 4:
                    textLabel.Text = "You come up to a cave";
                    optionOneButton.Text = "Go around the cave";
                    optionTwoButton.Text = "Jump down the hole in the cave";

                    storyImages.Image = Properties.Resources.Cave_entrence;

                    Click.Play();
                    break;

                case 5:
                    textLabel.Text = "You're outside of a cave and found a knife.";
                    optionOneButton.Text = "Go down a deep tunnel?";
                    optionTwoButton.Text = "Use knife to cut wall of vines?";

                    storyImages.Image = Properties.Resources.Cave_entrence;

                    Click.Play();
                    break;

                case 6:
                    textLabel.Text = "You're in a deep and dark tunnel with some torches on the wall";
                    optionOneButton.Text = "Go down further?";
                    optionTwoButton.Text = "Jump down a hole?";

                    storyImages.Image = Properties.Resources.Tunnel;

                    Click.Play();
                    break;

                case 7:
                    textLabel.Text = "You lived! And found a corpse with chainmail armor";
                    optionOneButton.Text = "!Fight the Demon King!";
                    optionTwoButton.Text = "";

                    storyImages.Image = Properties.Resources.skeleton_in_cave;

                    Click.Play();
                    break;

                case 8:
                    textLabel.Text = "You're in front of the vines";
                    optionOneButton.Text = "Go left down a long path?";
                    optionTwoButton.Text = "Use knife on vines?";

                    storyImages.Image = Properties.Resources.vines;

                    Click.Play();
                    break;

                case 9:
                    textLabel.Text = "You found the holy sword and armor on a pedastal!";
                    optionOneButton.Text = "Fight the Demon King";
                    optionTwoButton.Text = "";

                    storyImages.Image = Properties.Resources.holy_sword;

                    Click.Play();
                    break;

                case 10:
                    textLabel.Text = "You here and fighting him!";
                    optionOneButton.Text = "Get his leg with your weapon?";
                    optionTwoButton.Text = "Back up?";

                    storyImages.Image = Properties.Resources.demon_lord;

                    Click.Play();
                    break;

                case 11:
                    textLabel.Text = "You backed up and see an opening";
                    optionOneButton.Text = "Get his head with your weapon?";
                    optionTwoButton.Text = "Slide under his legs?";

                    storyImages.Image = Properties.Resources.demon_lord;

                    Click.Play();
                    break;

                case 12:
                    textLabel.Text = "You slid under his legs and slashed his back";
                    optionOneButton.Text = "Throw your weapon at him?";
                    optionTwoButton.Text = "Charge back in?";

                    storyImages.Image = Properties.Resources.demon_lord2;

                    Click.Play();
                    break;

                case 13:
                    textLabel.Text = "You hit him! He is about to die!";
                    optionOneButton.Text = "Finish the job?";
                    optionTwoButton.Text = "Help him?";

                    storyImages.Image = Properties.Resources.demon_lord2;

                    Click.Play();
                    break;

                case 14://This is the Win page
                    textLabel.Text = "You Win! You killed the Demon King!";
                    optionOneButton.Text = "Restart?";
                    optionTwoButton.Text = "Exit?";

                    storyImages.Image = Properties.Resources.you_win;

                    Click.Play();
                    Win.Play();
                    break;
               
                case 98://This is the Lose page
                    textLabel.Text = "You died. Would you like to play again?";
                    optionOneButton.Text = "Yes";
                    optionTwoButton.Text = "No";

                    storyImages.Image = Properties.Resources.Dead;   
                    
                    Dead.Play();
                    break;

                case 99://This exits the program
                    Application.Exit();
                    break;


            }


        }
    }
}
