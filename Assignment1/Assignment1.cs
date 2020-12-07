using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Assignment1 : Form
    {
        Game_logic_form Class_obj = new Game_logic_form();
        public Assignment1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Spin.Enabled = false;//disabling spin button
            button_Shoot.Enabled = false;//disabling shoot button
            button_Shoot_Away.Enabled = false;//disabling shoot_away button
        }




        private void button_Shoot_Click(object sender, EventArgs e)
        {
            button_Shoot_Away.Enabled = true;//Enabling Shoot_Away button
            //code to display image in picture box on button click
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Assignment1.Resources.shoot self.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            Picbox.Image = bmp_Object;

            //Sound code
            System.Media.SoundPlayer Sound_object = new System.Media.SoundPlayer(global::Assignment1.Properties.Resources.gunem);
            Sound_object.Play();

            Class_obj.shoot_data = Class_obj.shoot_method();
            if (Class_obj.shoot_data == 1)
            { 
                MessageBox.Show("Bullet shoot on your head. You are dead ");
               
                button_Shoot.Enabled = false;//disabling Shoot button
                button_Shoot_Away.Enabled = false;//Enabling Shoot_Away button
            }
             else
            {
                MessageBox.Show("empty shoot");
            }
        }

        private void button_PlayAgain_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Button_GameRules_Click_1(object sender, EventArgs e)
        {
            Game_Rules rules_obj = new Game_Rules();
            rules_obj.Show();
            this.Hide();
        }

        private void Button_ShootAway_Click_1(object sender, EventArgs e)
        {
            button_Shoot.Enabled = true;//Enabling Shoot button
            button_Shoot_Away.Enabled = false;//Disabling Shoot_Away button
            //code to display image in picture box on button click
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Assignment1.Resources.away.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            Picbox.Image = bmp_Object;

            //Sound code
            System.Media.SoundPlayer Sound_object = new System.Media.SoundPlayer(global::Assignment1.Properties.Resources.shootso);
            Sound_object.Play();
            if (Class_obj.chances <= 2)
            {
                Class_obj.shoot_data = Class_obj.shoot_method();
                if (Class_obj.shoot_data == 1)
                {
                    
                    
                    MessageBox.Show("Wow!! you are safe. you win the game");
                    button_Shoot.Enabled = false;
                    button_Shoot_Away.Enabled = false;
                }
                else
                {
                    Class_obj.chances++;
                    if (Class_obj.chances == 2)
                    {
                        MessageBox.Show("Your 2 chances are finished. you lose the game");
                    }
                    else
                    {
                        MessageBox.Show("emply shoot");
                    }
                }

            }
        }
    
        private void Button_Spin_Click(object sender, EventArgs e)
        {
            button_Shoot.Enabled = true;//Enabling Shoot button
            button_Shoot_Away.Enabled = true;
            button_Spin.Enabled = false;//Disabling Spin button
            //code to display image in picture box on button click
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Assignment1.Resources.spin.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            Picbox.Image = bmp_Object;

            Random Rnd_obj = new Random();
            Class_obj.spin_data = Rnd_obj.Next(1, 7);

            MessageBox.Show("Bullet Position After spinning the chamber is" + Class_obj.shoot_data.ToString());

        }

        private void Button_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            button_Spin.Enabled = true;//enabling spin button
            button_Shoot.Enabled = false;//disabling shoot button
            //code to display image in picture box on button click
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Assignment1.Resources.bullet.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Picbox.Image = bmp_Object;

            Class_obj.load_data = 1;



            //Sound code
            System.Media.SoundPlayer Sound_object = new System.Media.SoundPlayer(global::Assignment1.Properties.Resources.load);
            Sound_object.Play();



        }
    }
}
    

   

       