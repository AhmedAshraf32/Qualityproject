﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int x=0;
        int y=0;
        int z=0;
        int f3 = 0;
        int flag = 0;
        int f2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 2;
                }
                else
                {
                    x = x * 10;
                    x = x + 2;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x); 
            }
           

            else

            {
                if (y == 0)
                {
                    y = 2;
                }
                else
                {
                   y = y * 10;
                    y = y + 2;
                }

                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 1;
                }
                else
                {
                    x = x * 10;
                    x = x + 1;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 1;
                }
                else
                {
                    y = y * 10;
                    y = y + 1;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 3;
                }
                else
                {
                    x = x * 10;
                    x = x + 3;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 3;
                }
                else
                {
                    y = y * 10;
                    y = y + 3;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 4;
                }
                else
                {
                    x = x * 10;
                    x = x + 4;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 4;
                }
                else
                {
                    y = y * 10;
                    y = y + 4;
                }

                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 5;
                }
                else
                {
                    x = x * 10;
                    x = x + 5;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 5;
                }
                else
                {
                    y = y * 10;
                    y = y + 5;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 6;
                }
                else
                {
                    x = x * 10;
                    x = x + 6;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 6;
                }
                else
                {
                    y = y * 10;
                    y = y + 6;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 7;
                }
                else
                {
                    x = x * 10;
                    x = x + 7;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 7;
                }
                else
                {
                    y = y * 10;
                    y = y + 7;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 8;
                }
                else
                {
                    x = x * 10;
                    x = x + 8;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 8;
                }
                else
                {
                    y = y * 10;
                    y = y + 8;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 9;
                }
                else
                {
                    x = x * 10;
                    x = x + 9;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 9;
                }
                else
                {
                    y = y * 10;
                    y = y + 9;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(f3==0)
            {
                f2 = 1;
                flag = 1;
                textBox1.Clear();
                textBox1.Text = "+";
            }
            else
            {
                f2 = 1;
                
               textBox1.Clear();
                textBox1.Text = "+";
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                f2 = 2;
                flag = 1;
                textBox1.Clear();
                textBox1.Text = "-";
            }
            else
            {
                f2 = 2;

                textBox1.Clear();
                textBox1.Text = "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                f2 = 3;
                flag = 1;
                textBox1.Clear();
                textBox1.Text = "X";
            }
            else
            {
                f2 = 3;

                textBox1.Clear();
                textBox1.Text = "X";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                f2 = 4;
                flag = 1;
                textBox1.Clear();
                textBox1.Text = "/";
            }
            else
            {
                f2 = 4;

                textBox1.Clear();
                textBox1.Text = "/";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                if (f2 == 1)
                {
                    z = x + y;
                }
                if (f2 == 2)
                {
                    z = x - y;

                }
                if (f2 == 3)
                {
                    z = x * y;
                }
                if (f2 == 4)
                {
                    z = x / y;
                }
                
                f3 = 1;
            }
           

            else
            {
                
                if (f2 == 1)
                {
                    z += x;
                }
                if (f2 == 2)
                {
                    z -= x;

                }
                if (f2 == 3)
                {
                    z *=x;
                }
                if (f2 == 4)
                {
                    z /=  x;
                }
            }
          
            textBox1.Clear();
            flag = 0;
            x = 0;
          textBox1.Text = Convert.ToString(z);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            z = 0;
            flag = 0;
            f2 = 0;
            f3 = 0;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                x = x / 10;
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
                    
            }
            else
            {
                y = y / 10;
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (x == 0)
                {
                    x = 0;
                }
                else
                {
                    x = x * 10;
                    x = x + 0;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(x);
            }

            else

            {
                if (y == 0)
                {
                    y = 0;
                }
                else
                {
                    y = y * 10;
                    y = y + 0;
                }
                textBox1.Clear();
                textBox1.Text = Convert.ToString(y);


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
