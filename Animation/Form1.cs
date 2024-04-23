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

namespace Animation
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
           
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Font font = new Font("Arial", 30, FontStyle.Bold);

            for(int i = 0; i <= 250; i++)
            {
                g.Clear(Color.Blue);
                g.DrawString("Good job Ewan", font, redBrush, 250, i);

                Thread.Sleep(10);
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 10);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Font font = new Font("Arial", 30, FontStyle.Bold);
            SoundPlayer cheer = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
            int x1 = 0;
            int x2 = 35;
            int x3 = 110; 
            int x4 = 65;

            cheer.Play();
            for (int i = 0; i <= 250; i++)
            {
                g.Clear(Color.Yellow);
                g.DrawString("Happy 1 year sober", font, blueBrush, 250, i);
                g.DrawEllipse(redPen, x1, 50, 200, 200);
                g.DrawEllipse(redPen, x2, 90, 50, 50);
                g.DrawEllipse(redPen, x3, 90, 50, 50);
                g.DrawArc(redPen, x4, 160, 50, 50, 0, 180);
                Thread.Sleep(2);
                x1++;
                x2++;
                x3++;
                x4++;
            }

        }

        private void Button_Load(object sender, EventArgs e)
        {

        }
    }
}
