using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_GUI
{
    
    public partial class gamename : Form
    {
        int count = 0; int pxwin = 0; int powin = 0;
      
        public gamename()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void gamename2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (a1.Text == "A1")
            {


                count++;
                if (count % 2 == 0)
                {
                    a1.Text = "X";
                }
                else
                    a1.Text = "O";
                if (a1.Text == a2.Text && a2.Text == a3.Text || a1.Text == b1.Text && b1.Text == c1.Text || a1.Text == b2.Text && b2.Text == c3.Text)
                {
                    if (a1.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }

                if (count >= 8&& win.Text==" ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }
        private void a2_Click(object sender, EventArgs e)
        {
            if (a2.Text == "A2")
            {


                count++;
                if (count % 2 == 0)
                {
                    a2.Text = "X";
                }
                else
                    a2.Text = "O";
                if (a1.Text == a2.Text && a2.Text == a3.Text || a2.Text == b2.Text && b2.Text == c2.Text)
                {
                    if (a2.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;

                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }
        private void a3_Click(object sender, EventArgs e)
        {
            if (a3.Text == "A3")
            {
                count++;
                if (count % 2 == 0)
                {
                    a3.Text = "X";
                }
                else
                    a3.Text = "O";
                if (a1.Text == a2.Text && a2.Text == a3.Text || a3.Text == b3.Text && b3.Text == c3.Text || a3.Text == b2.Text && b2.Text == c1.Text)
                {
                    if (a3.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;

                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "B1")
            {
                count++;
                if (count % 2 == 0)
                {
                    b1.Text = "X";

                }
                else
                    b1.Text = "O";
                if (b1.Text == b2.Text && b2.Text == b3.Text || a1.Text == b1.Text && b1.Text == c1.Text)
                {
                    if (b1.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Text == "B2")
            {

                count++;
                if (count % 2 == 0)
                {
                    b2.Text = "X";

                }
                else
                    b2.Text = "O";
                if (b1.Text == b2.Text && b2.Text == b3.Text || a2.Text == b2.Text && b2.Text == c2.Text || a1.Text == b2.Text && b2.Text == c3.Text || a3.Text == b2.Text && b2.Text == c1.Text)
                {
                    if (b2.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
          
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "B3")
            {

                count++;
                if (count % 2 == 0)
                {
                    b3.Text = "X";

                }
                else
                    b3.Text = "O";
                if (b1.Text == b2.Text && b2.Text == b3.Text || a3.Text == b3.Text && b3.Text == c3.Text)
                {
                    if (b3.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }
        private void c3_Click(object sender, EventArgs e)
        {
            if (c3.Text == "C3")
            {

                count++;
                if (count % 2 == 0)
                {
                    c3.Text = "X";

                }
                else
                    c3.Text = "O";

                if (c1.Text == c2.Text && c2.Text == c3.Text || a3.Text == b3.Text && b3.Text == c3.Text || a1.Text == b2.Text && b2.Text == c3.Text)
                {
                    if (c3.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (c2.Text == "C2")
            {

                count++;
                if (count % 2 == 0)
                {
                    c2.Text = "X";

                }
                else
                    c2.Text = "O";

                if (c1.Text == c2.Text && c2.Text == c3.Text || a2.Text == b2.Text && b2.Text == c2.Text)
                {
                    if (c2.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
           
        }
        private void c1_Click(object sender, EventArgs e)
        {
            if (c1.Text == "C1")
            {

                count++;
                if (count % 2 == 0)
                {
                    c1.Text = "X";

                }
                else
                {
                    c1.Text = "O";
                }

                if (c1.Text == c2.Text && c2.Text == c3.Text || a1.Text == b1.Text && b1.Text == c1.Text || a3.Text == b2.Text && b2.Text == c1.Text)
                {
                    if (c1.Text == "X")
                    {
                        win.Text = " Player X";
                        pxwin++;
                        pxwins.Text = Convert.ToString(pxwin);
                    }
                    else
                    {
                        win.Text = "Player O";
                        powin++;
                        powins.Text = Convert.ToString(powin);
                    }
                }
                if (count >= 8 && win.Text == " ")
                {
                    win.Text = " Draw ";


                }
            }
        }
       
        private void powins_Click(object sender, EventArgs e)
        {
            
        }

        private void pxwins_Click(object sender, EventArgs e)
        {
            
        }

        private void restart_Click(object sender, EventArgs e)
        {
            

            a1.Text = "A1";
            a2.Text = "A2";
            a3.Text = "A3";
            b1.Text = "B1"; 
            b2.Text = "B2";
            b3.Text = "B3";
            c1.Text = "C1";
            c2.Text = "C2";
            c3.Text = "C3";
            count = 0;
            win.Text = " ";
        }

        private void win_Click(object sender, EventArgs e)
        {

        }

        private void gamewinner_Click(object sender, EventArgs e)
        {
            
        }

    }
}
