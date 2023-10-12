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
        int MaxArrayLength = 10, d = -1;
        public Form1()
        {
            InitializeComponent();
            if (button1.Enabled == true) button2.Enabled = false;

            dataGridView1.RowCount = MaxArrayLength;
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].HeaderText = "Первый игрок";
            dataGridView1.Columns[1].HeaderText = "Второй игрок";
            button4.Enabled = false;
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Pl1BtnClick(object sender, EventArgs e)
        {
            Random random = new Random();
            int player1Roll = random.Next(1, 7);
            switch (player1Roll)
            {
                case 6:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\6.gif");
                    label4.Text = "6";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\5.gif");
                    label4.Text = "5";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\4.gif");
                    label4.Text = "4";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\3.gif");
                    label4.Text = "3";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\2.gif");
                    label4.Text = "2";
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\1.gif");
                    label4.Text = "1";
                    break;
            }
            if (label4.Text.Length != 0) button1.Enabled = false;
            else button1.Enabled = true;
            button2.Enabled = true;
        }
        public void Pl2BtnClick(object sender, EventArgs e)
        {
            Random random = new Random();
            int player2Roll = random.Next(1, 7);
            switch (player2Roll)
            {
                case 6:
                    pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\6.gif");
                    label2.Text = "6";
                    break;
                case 5:
                    pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\5.gif");
                    label2.Text = "5";
                    break;
                case 4:
                    pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\4.gif");
                    label2.Text = "4";
                    break;
                case 3:
                    pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\3.gif");
                    label2.Text = "3";
                    break;
                case 2:
                    pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\2.gif");
                    label2.Text = "2";
                    break;
                case 1:
                    pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\Кубики\\1.gif");
                    label2.Text = "1";
                    break;

            }

            dataGridView1.RowCount = MaxArrayLength;
            d++;
            if (d == MaxArrayLength)
            {
                d = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = MaxArrayLength;
                dataGridView1.ColumnCount = 2;
            }

            int a = int.Parse(label2.Text);
            int b = int.Parse(label4.Text);

            if (a > b)
            {
                label5.Text = "победил игрок номер 2";
                    dataGridView1.Rows[d].Cells[1].Value = "победа";
            }
            if (a < b)
            {
                label5.Text = "победил игрок номер 1";
                    dataGridView1.Rows[d].Cells[0].Value = "победа";
            }
            if (a == b)
            {
                label5.Text = "ничья";
                for (int i = 0; i < 2; i++)
                {
                    dataGridView1.Rows[d].Cells[i].Value = "ничья";
                }
            }
            {
                if (label2.Text.Length != 0) button2.Enabled = false;
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
            if (button3.Text == "Скрыть")
            {
                dataGridView1.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Text = "Сбросить счёт";
            }
            label4.Text = "";
            label2.Text = "";
            label5.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = true;
        }
        private void HistoryBtnClick(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Text = "Скрыть";

            //array's numbering
            for (int i = 1; i < MaxArrayLength + 1; i++)
                dataGridView1.Rows[i - 1].HeaderCell.Value = i + "";
        }
    }
}