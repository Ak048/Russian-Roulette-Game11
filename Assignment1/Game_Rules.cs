using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Game_Rules : Form
    {
        public Game_Rules()
        {
            InitializeComponent();
        }

      
        private void button_back_Click(object sender, EventArgs e)
        {
            Assignment1 game_obj = new Assignment1();
            game_obj.Show();
            this.Hide();

        }

    }
}
