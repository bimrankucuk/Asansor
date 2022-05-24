using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kat,i;
        public int katkontrol(int x)
        {
            if (asansör.Top < x )
            {
                asansör.Top++;
                if (asansör.Top == x)
                {
                    kat = 10;
                }
            }
            else if (asansör.Top > x)
            {
                asansör.Top--;
                if (asansör.Top == x)
                {
                    kat = 10;
                }
            }
            return kat;
        }
        void kapıaç()
        {
            if (i <= 100)
            {
                solkapı.Left--;
                sağkapı.Left++;
                i++;

                if (i == 100)
                {
                    ac.Enabled = false;
                    kapat.Enabled = true;
                    timer1.Enabled = false;
                    i = 0;                  
                }
            }            
        }
        void kapıkapat()
        {            
             if(solkapı.Location.X !=120)
            {
                sağkapı.Left--;
                solkapı.Left++;
            }
            else if (solkapı.Location.X == 120)
            {
                timer2.Enabled = false;
                if(kat==0||kat==1 || kat == 2 || kat == 3 || kat == 4 || kat == 5)
                timer1.Enabled = true;
                ac.Enabled = true;
                kapat.Enabled = false;
            }
        }
        void katrenk()
        {
            kat0.BackColor = Color.DarkRed;
            kat1.BackColor = Color.DarkRed;
            kat2.BackColor = Color.DarkRed;
            kat3.BackColor = Color.DarkRed;
            kat4.BackColor = Color.DarkRed;
            kat5.BackColor = Color.DarkRed;
            if (kat == 0)
            {
              kat0.BackColor = Color.Green;
            }
            else if (kat == 1)
            {
                kat1.BackColor = Color.Green;
            }
            else if (kat == 2)
            {
                 kat2.BackColor = Color.Green;
            }
            else if (kat == 3)
            {
               kat3.BackColor = Color.Green;
            }
            else if (kat == 4)
            {
                kat4.BackColor = Color.Green;
            }
            else if (kat == 5)
            {
              kat5.BackColor = Color.Green;
            }
        }
        void kattami()
        {
            if (asansör.Top == kat0.Top)
                label1.Text = "0";
            else if (asansör.Top == kat1.Top)
                label1.Text = "1";
            else if (asansör.Top == kat2.Top)
                label1.Text = "2";
            else if (asansör.Top == kat3.Top)
                label1.Text = "3";
            else if (asansör.Top == kat4.Top)
                label1.Text = "4";
            else if (asansör.Top == kat5.Top)
                label1.Text = "5";
        }
        private void kat0_Click(object sender, EventArgs e)
        {
            kat = 0;
            katrenk();
            timer2.Enabled = true;           
        }
        private void kat1_Click(object sender, EventArgs e)
        {
            kat = 1;
            katrenk();
            timer2.Enabled = true;
        }
        private void kat2_Click(object sender, EventArgs e)
        {
            kat = 2;
            katrenk();
            timer2.Enabled = true;
        }
        private void kat3_Click(object sender, EventArgs e)
        {
            kat = 3;
            katrenk();
            timer2.Enabled = true;
        }
        private void kat4_Click(object sender, EventArgs e)
        {
            kat = 4;
            katrenk();
            timer2.Enabled = true;
        }
        private void kat5_Click(object sender, EventArgs e)
        {
            kat = 5;
            katrenk();
            timer2.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kat == 0)
            {
                katkontrol(kat0.Top);
            }
            else if (kat == 1)
            {
                katkontrol(kat1.Top);
            }
            else if (kat == 2)
            {
                katkontrol(kat2.Top);
            }
            else if (kat == 3)
            {
                katkontrol(kat3.Top);
            }
            else if (kat == 4)
            {
                katkontrol(kat4.Top);
            }
            else if (kat == 5)
            {
                katkontrol(kat5.Top);
            }
            else if (kat == 10)
            {
                kapıaç();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            kapıkapat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
           
        }

        

        private void timer3_Tick(object sender, EventArgs e)
        {
            kattami();
        }
    }
}
