using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace кубик
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int player1Roll = random.Next(1, 7);
            switch (player1Roll)
            {
                case 6:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice.gif");
                    label4.Text = "6";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (1).gif");
                    label4.Text = "5";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (4).gif");
                    label4.Text = "4";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (2).gif");
                    label4.Text = "3";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice2-dice.gif");
                    label4.Text = "2";
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (3).gif");
                    label4.Text = "1";
                    break;
            }
            
                if (label4.Text.Length != 0) button1.Enabled = false;
                else button1.Enabled = true;
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
           
         
            Random random = new Random();
            int player2Roll = random.Next(1, 7);
            switch (player2Roll)
            {
                case 6:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice.gif");
                    label2.Text = "6";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (1).gif");
                    label2.Text = "5";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (4).gif");
                    label2.Text = "4";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (2).gif");
                    label2.Text = "3";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice2-dice.gif");
                    label2.Text = "2";
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\dice-roll-dice (3).gif");
                    label2.Text = "1";
                    break;

            }
            
            int a = int .Parse(label2.Text);
            int b = int .Parse(label4.Text);
            if(a > b)
            {
                label5.Text = "победил игрок номер 2";
            }
            if (a < b)
            {
                label5.Text = "победил игрок номер 1";
            }
            if (a == b)
            {
                label5.Text = "ничья";
            }
            {
                if (label2.Text.Length != 0 ) button2.Enabled = false;
                else button1.Enabled = true;
            }
           


        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label2.Text = "";
            label5.Text = "";
            pictureBox1.Image = null;
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}

