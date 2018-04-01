using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubik
{
    public partial class Form1 : Form
    {
        string k = "";
        string k1 = "";
        string k2 = "";
        string k3 = "";
        string k4 = "";
        string k5 = "";
        string k6 = "";
        string k7 = "";
        string k8 = "";
        string k9 = "";
        string k10 = "";
        string k11 = "";
        string k12 = "";
        string k13 = "";
        string k14 = "";
        string k15 = "";
        string k16 = "";
        string k17 = "";
        string k18 = "";
        string k19 = "";
        public Form1()
        {
            InitializeComponent();
            Col();
        }

        private void Ub2_Click(object sender, EventArgs e)
        {
            k = P2.Text;
            k1 = P5.Text;
            k2 = P8.Text;
            k3 = D2.Text;
            k4 = D5.Text;
            k5 = D8.Text;
            k6 = Z2.Text;
            k7 = Z5.Text;
            k8 = Z8.Text;
            k9 = U2.Text;
            k10 = U5.Text;
            k11 = U8.Text;

            U2.Text = k;
            U5.Text = k1;
            U8.Text = k2;
            P2.Text = k3;
            P5.Text = k4;
            P8.Text = k5;
            D2.Text = k6;
            D5.Text = k7;
            D8.Text = k8;
            Z2.Text = k9;
            Z5.Text = k10;
            Z8.Text = k11;
            Col();
            Ochistka();
        }
        public void Ochistka()
        {
            k = "";
            k1 = "";
            k2 = "";
            k3 = "";
            k4 = "";
            k5 = "";
            k6 = "";
            k7 = "";
            k8 = "";
            k9 = "";
            k10 = "";
            k11 = "";
            k12 = "";
            k13 = "";
            k14 = "";
            k15 = "";
            k16 = "";
            k17 = "";
            k18 = "";
            k19 = "";
        }
        public void Col()
        {
            if (D1.Text == "Y")
            {
                D1.BackColor = Color.Yellow;
                D1.ForeColor = Color.Yellow;
            }
            if (D2.Text == "Y")
            {
                D2.BackColor = Color.Yellow;
                D2.ForeColor = Color.Yellow;
            }
            if (D3.Text == "Y")
            {
                D3.BackColor = Color.Yellow;
                D3.ForeColor = Color.Yellow;
            }
            if (D4.Text == "Y")
            {
                D4.BackColor = Color.Yellow;
                D4.ForeColor = Color.Yellow;
            }
            if (D5.Text == "Y")
            {
                D5.BackColor = Color.Yellow;
                D5.ForeColor = Color.Yellow;
            }
            if (D6.Text == "Y")
            {
                D6.BackColor = Color.Yellow;
                D6.ForeColor = Color.Yellow;
            }
            if (D7.Text == "Y")
            {
                D7.BackColor = Color.Yellow;
                D7.ForeColor = Color.Yellow;
            }
            if (D8.Text == "Y")
            {
                D8.BackColor = Color.Yellow;
                D8.ForeColor = Color.Yellow;
            }
            if (D9.Text == "Y")
            {
                D9.BackColor = Color.Yellow;
                D9.ForeColor = Color.Yellow;
            }

            if (D1.Text == "W")
            {
                D1.BackColor = Color.White;
                D1.ForeColor = Color.White;
            }
            if (D2.Text == "W")
            {
                D2.BackColor = Color.White;
                D2.ForeColor = Color.White;
            }
            if (D3.Text == "W")
            {
                D3.BackColor = Color.White;
                D3.ForeColor = Color.White;
            }
            if (D4.Text == "W")
            {
                D4.BackColor = Color.White;
                D4.ForeColor = Color.White;
            }
            if (D5.Text == "W")
            {
                D5.BackColor = Color.White;
                D5.ForeColor = Color.White;
            }
            if (D6.Text == "W")
            {
                D6.BackColor = Color.White;
                D6.ForeColor = Color.White;
            }
            if (D7.Text == "W")
            {
                D7.BackColor = Color.White;
                D7.ForeColor = Color.White;
            }
            if (D8.Text == "W")
            {
                D8.BackColor = Color.White;
                D8.ForeColor = Color.White;
            }
            if (D9.Text == "W")
            {
                D9.BackColor = Color.White;
                D9.ForeColor = Color.White;
            }

            if (D1.Text == "R")
            {
                D1.BackColor = Color.Red;
                D1.ForeColor = Color.Red;
            }
            if (D2.Text == "R")
            {
                D2.BackColor = Color.Red;
                D2.ForeColor = Color.Red;
            }
            if (D3.Text == "R")
            {
                D3.BackColor = Color.Red;
                D3.ForeColor = Color.Red;
            }
            if (D4.Text == "R")
            {
                D4.BackColor = Color.Red;
                D4.ForeColor = Color.Red;
            }
            if (D5.Text == "R")
            {
                D5.BackColor = Color.Red;
                D5.ForeColor = Color.Red;
            }
            if (D6.Text == "R")
            {
                D6.BackColor = Color.Red;
                D6.ForeColor = Color.Red;
            }
            if (D7.Text == "R")
            {
                D7.BackColor = Color.Red;
                D7.ForeColor = Color.Red;
            }
            if (D8.Text == "R")
            {
                D8.BackColor = Color.Red;
                D8.ForeColor = Color.Red;
            }
            if (D9.Text == "R")
            {
                D9.BackColor = Color.Red;
                D9.ForeColor = Color.Red;
            }

            if (D1.Text == "B")
            {
                D1.BackColor = Color.Blue;
                D1.ForeColor = Color.Blue;
            }
            if (D2.Text == "B")
            {
                D2.BackColor = Color.Blue;
                D2.ForeColor = Color.Blue;
            }
            if (D3.Text == "B")
            {
                D3.BackColor = Color.Blue;
                D3.ForeColor = Color.Blue;
            }
            if (D4.Text == "B")
            {
                D4.BackColor = Color.Blue;
                D4.ForeColor = Color.Blue;
            }
            if (D5.Text == "B")
            {
                D5.BackColor = Color.Blue;
                D5.ForeColor = Color.Blue;
            }
            if (D6.Text == "B")
            {
                D6.BackColor = Color.Blue;
                D6.ForeColor = Color.Blue;
            }
            if (D7.Text == "B")
            {
                D7.BackColor = Color.Blue;
                D7.ForeColor = Color.Blue;
            }
            if (D8.Text == "B")
            {
                D8.BackColor = Color.Blue;
                D8.ForeColor = Color.Blue;
            }
            if (D9.Text == "B")
            {
                D9.BackColor = Color.Blue;
                D9.ForeColor = Color.Blue;
            }

            if (D1.Text == "G")
            {
                D1.BackColor = Color.Green;
                D1.ForeColor = Color.Green;
            }
            if (D2.Text == "G")
            {
                D2.BackColor = Color.Green;
                D2.ForeColor = Color.Green;
            }
            if (D3.Text == "G")
            {
                D3.BackColor = Color.Green;
                D3.ForeColor = Color.Green;
            }
            if (D4.Text == "G")
            {
                D4.BackColor = Color.Green;
                D4.ForeColor = Color.Green;
            }
            if (D5.Text == "G")
            {
                D5.BackColor = Color.Green;
                D5.ForeColor = Color.Green;
            }
            if (D6.Text == "G")
            {
                D6.BackColor = Color.Green;
                D6.ForeColor = Color.Green;
            }
            if (D7.Text == "G")
            {
                D7.BackColor = Color.Green;
                D7.ForeColor = Color.Green;
            }
            if (D8.Text == "G")
            {
                D8.BackColor = Color.Green;
                D8.ForeColor = Color.Green;
            }
            if (D9.Text == "G")
            {
                D9.BackColor = Color.Green;
                D9.ForeColor = Color.Green;
            }

            if (D1.Text == "O")
            {
                D1.BackColor = Color.Orange;
                D1.ForeColor = Color.Orange;
            }
            if (D2.Text == "O")
            {
                D2.BackColor = Color.Orange;
                D2.ForeColor = Color.Orange;
            }
            if (D3.Text == "O")
            {
                D3.BackColor = Color.Orange;
                D3.ForeColor = Color.Orange;
            }
            if (D4.Text == "O")
            {
                D4.BackColor = Color.Orange;
                D4.ForeColor = Color.Orange;
            }
            if (D5.Text == "O")
            {
                D5.BackColor = Color.Orange;
                D5.ForeColor = Color.Orange;
            }
            if (D6.Text == "O")
            {
                D6.BackColor = Color.Orange;
                D6.ForeColor = Color.Orange;
            }
            if (D7.Text == "O")
            {
                D7.BackColor = Color.Orange;
                D7.ForeColor = Color.Orange;
            }
            if (D8.Text == "O")
            {
                D8.BackColor = Color.Orange;
                D8.ForeColor = Color.Orange;
            }
            if (D9.Text == "O")
            {
                D9.BackColor = Color.Orange;
                D9.ForeColor = Color.Orange;
            }


            if (P1.Text == "Y")
            {
                P1.BackColor = Color.Yellow;
                P1.ForeColor = Color.Yellow;
            }
            if (P2.Text == "Y")
            {
                P2.BackColor = Color.Yellow;
                P2.ForeColor = Color.Yellow;
            }
            if (P3.Text == "Y")
            {   
                P3.BackColor = Color.Yellow;
                P3.ForeColor = Color.Yellow;
            }
            if (P4.Text == "Y")
            {   
                P4.BackColor = Color.Yellow;
                P4.ForeColor = Color.Yellow;
            }
            if (P5.Text == "Y")
            {
                P5.BackColor = Color.Yellow;
                P5.ForeColor = Color.Yellow;
            }
            if (P6.Text == "Y")
            {
                P6.BackColor = Color.Yellow;
                P6.ForeColor = Color.Yellow;
            }
            if (P7.Text == "Y")
            {
                P7.BackColor = Color.Yellow;
                P7.ForeColor = Color.Yellow;
            }
            if (P8.Text == "Y")
            {
                P8.BackColor = Color.Yellow;
                P8.ForeColor = Color.Yellow;
            }
            if (P9.Text == "Y")
            {
                P9.BackColor = Color.Yellow;
                P9.ForeColor = Color.Yellow;
            }

            if (P1.Text == "W")
            {
                P1.BackColor = Color.White;
                P1.ForeColor = Color.White;
            }
            if (P2.Text == "W")
            {
                P2.BackColor = Color.White;
                P2.ForeColor = Color.White;
            }
            if (P3.Text == "W")
            {
                P3.BackColor = Color.White;
                P3.ForeColor = Color.White;
            }
            if (P4.Text == "W")
            {   
                P4.BackColor = Color.White;
                P4.ForeColor = Color.White;
            }   
            if (P5.Text == "W")
            {   
                P5.BackColor = Color.White;
                P5.ForeColor = Color.White;
            }   
            if (P6.Text == "W")
            {   
                P6.BackColor = Color.White;
                P6.ForeColor = Color.White;
            }   
            if (P7.Text == "W")
            {   
                P7.BackColor = Color.White;
                P7.ForeColor = Color.White;
            }   
            if (P8.Text == "W")
            {   
                P8.BackColor = Color.White;
                P8.ForeColor = Color.White;
            }   
            if (P9.Text == "W")
            {   
                P9.BackColor = Color.White;
                P9.ForeColor = Color.White;
            }   
                
            if (P1.Text == "R")
            {   
                P1.BackColor = Color.Red;
                P1.ForeColor = Color.Red;
            }   
            if (P2.Text == "R")
            {   
                P2.BackColor = Color.Red;
                P2.ForeColor = Color.Red;
            }   
            if (P3.Text == "R")
            {   
                P3.BackColor = Color.Red;
                P3.ForeColor = Color.Red;
            }   
            if (P4.Text == "R")
            {   
                P4.BackColor = Color.Red;
                P4.ForeColor = Color.Red;
            }   
            if (P5.Text == "R")
            {   
                P5.BackColor = Color.Red;
                P5.ForeColor = Color.Red;
            }   
            if (P6.Text == "R")
            {   
                P6.BackColor = Color.Red;
                P6.ForeColor = Color.Red;
            }   
            if (P7.Text == "R")
            {   
                P7.BackColor = Color.Red;
                P7.ForeColor = Color.Red;
            }   
            if (P8.Text == "R")
            {   
                P8.BackColor = Color.Red;
                P8.ForeColor = Color.Red;
            }   
            if (P9.Text == "R")
            {   
                P9.BackColor = Color.Red;
                P9.ForeColor = Color.Red;
            }   
                
            if (P1.Text == "B")
            {   
                P1.BackColor = Color.Blue;
                P1.ForeColor = Color.Blue;
            }   
            if (P2.Text == "B")
            {   
                P2.BackColor = Color.Blue;
                P2.ForeColor = Color.Blue;
            }   
            if (P3.Text == "B")
            {   
                P3.BackColor = Color.Blue;
                P3.ForeColor = Color.Blue;
            }   
            if (P4.Text == "B")
            {   
                P4.BackColor = Color.Blue;
                P4.ForeColor = Color.Blue;
            }   
            if (P5.Text == "B")
            {   
                P5.BackColor = Color.Blue;
                P5.ForeColor = Color.Blue;
            }   
            if (P6.Text == "B")
            {   
                P6.BackColor = Color.Blue;
                P6.ForeColor = Color.Blue;
            }   
            if (P7.Text == "B")
            {   
                P7.BackColor = Color.Blue;
                P7.ForeColor = Color.Blue;
            }   
            if (P8.Text == "B")
            {   
                P8.BackColor = Color.Blue;
                P8.ForeColor = Color.Blue;
            }   
            if (P9.Text == "B")
            {   
                P9.BackColor = Color.Blue;
                P9.ForeColor = Color.Blue;
            }   
                
            if (P1.Text == "G")
            {   
                P1.BackColor = Color.Green;
                P1.ForeColor = Color.Green;
            }   
            if (P2.Text == "G")
            {   
                P2.BackColor = Color.Green;
                P2.ForeColor = Color.Green;
            }   
            if (P3.Text == "G")
            {   
                P3.BackColor = Color.Green;
                P3.ForeColor = Color.Green;
            }   
            if (P4.Text == "G")
            {   
                P4.BackColor = Color.Green;
                P4.ForeColor = Color.Green;
            }   
            if (P5.Text == "G")
            {   
                P5.BackColor = Color.Green;
                P5.ForeColor = Color.Green;
            }   
            if (P6.Text == "G")
            {   
                P6.BackColor = Color.Green;
                P6.ForeColor = Color.Green;
            }   
            if (P7.Text == "G")
            {   
                P7.BackColor = Color.Green;
                P7.ForeColor = Color.Green;
            }   
            if (P8.Text == "G")
            {   
                P8.BackColor = Color.Green;
                P8.ForeColor = Color.Green;
            }   
            if (P9.Text == "G")
            {   
                P9.BackColor = Color.Green;
                P9.ForeColor = Color.Green;
            }   
                
            if (P1.Text == "O")
            {   
                P1.BackColor = Color.Orange;
                P1.ForeColor = Color.Orange;
            }   
            if (P2.Text == "O")
            {   
                P2.BackColor = Color.Orange;
                P2.ForeColor = Color.Orange;
            }   
            if (P3.Text == "O")
            {   
                P3.BackColor = Color.Orange;
                P3.ForeColor = Color.Orange;
            }   
            if (P4.Text == "O")
            {   
                P4.BackColor = Color.Orange;
                P4.ForeColor = Color.Orange;
            }   
            if (P5.Text == "O")
            {   
                P5.BackColor = Color.Orange;
                P5.ForeColor = Color.Orange;
            }   
            if (P6.Text == "O")
            {   
                P6.BackColor = Color.Orange;
                P6.ForeColor = Color.Orange;
            }   
            if (P7.Text == "O")
            {   
                P7.BackColor = Color.Orange;
                P7.ForeColor = Color.Orange;
            }   
            if (P8.Text == "O")
            {   
                P8.BackColor = Color.Orange;
                P8.ForeColor = Color.Orange;
            }   
            if (P9.Text == "O")
            {   
                P9.BackColor = Color.Orange;
                P9.ForeColor = Color.Orange;
            }


            if (U1.Text == "Y")
            {   
                U1.BackColor = Color.Yellow;
                U1.ForeColor = Color.Yellow;
            }   
            if (U2.Text == "Y")
            {   
                U2.BackColor = Color.Yellow;
                U2.ForeColor = Color.Yellow;
            }   
            if (U3.Text == "Y")
            {   
                U3.BackColor = Color.Yellow;
                U3.ForeColor = Color.Yellow;
            }   
            if (U4.Text == "Y")
            {   
                U4.BackColor = Color.Yellow;
                U4.ForeColor = Color.Yellow;
            }   
            if (U5.Text == "Y")
            {   
                U5.BackColor = Color.Yellow;
                U5.ForeColor = Color.Yellow;
            }   
            if (U6.Text == "Y")
            {   
                U6.BackColor = Color.Yellow;
                U6.ForeColor = Color.Yellow;
            }   
            if (U7.Text == "Y")
            {   
                U7.BackColor = Color.Yellow;
                U7.ForeColor = Color.Yellow;
            }   
            if (U8.Text == "Y")
            {   
                U8.BackColor = Color.Yellow;
                U8.ForeColor = Color.Yellow;
            }   
            if (U9.Text == "Y")
            {   
                U9.BackColor = Color.Yellow;
                U9.ForeColor = Color.Yellow;
            }   
                
            if (U1.Text == "W")
            {   
                U1.BackColor = Color.White;
                U1.ForeColor = Color.White;
            }   
            if (U2.Text == "W")
            {   
                U2.BackColor = Color.White;
                U2.ForeColor = Color.White;
            }   
            if (U3.Text == "W")
            {   
                U3.BackColor = Color.White;
                U3.ForeColor = Color.White;
            }   
            if (U4.Text == "W")
            {   
                U4.BackColor = Color.White;
                U4.ForeColor = Color.White;
            }   
            if (U5.Text == "W")
            {   
                U5.BackColor = Color.White;
                U5.ForeColor = Color.White;
            }   
            if (U6.Text == "W")
            {   
                U6.BackColor = Color.White;
                U6.ForeColor = Color.White;
            }   
            if (U7.Text == "W")
            {   
                U7.BackColor = Color.White;
                U7.ForeColor = Color.White;
            }   
            if (U8.Text == "W")
            {   
                U8.BackColor = Color.White;
                U8.ForeColor = Color.White;
            }   
            if (U9.Text == "W")
            {   
                U9.BackColor = Color.White;
                U9.ForeColor = Color.White;
            }   
                
            if (U1.Text == "R")
            {   
                U1.BackColor = Color.Red;
                U1.ForeColor = Color.Red;
            }   
            if (U2.Text == "R")
            {   
                U2.BackColor = Color.Red;
                U2.ForeColor = Color.Red;
            }   
            if (U3.Text == "R")
            {   
                U3.BackColor = Color.Red;
                U3.ForeColor = Color.Red;
            }   
            if (U4.Text == "R")
            {   
                U4.BackColor = Color.Red;
                U4.ForeColor = Color.Red;
            }   
            if (U5.Text == "R")
            {   
                U5.BackColor = Color.Red;
                U5.ForeColor = Color.Red;
            }   
            if (U6.Text == "R")
            {   
                U6.BackColor = Color.Red;
                U6.ForeColor = Color.Red;
            }   
            if (U7.Text == "R")
            {   
                U7.BackColor = Color.Red;
                U7.ForeColor = Color.Red;
            }   
            if (U8.Text == "R")
            {   
                U8.BackColor = Color.Red;
                U8.ForeColor = Color.Red;
            }   
            if (U9.Text == "R")
            {   
                U9.BackColor = Color.Red;
                U9.ForeColor = Color.Red;
            }   
                
            if (U1.Text == "B")
            {   
                U1.BackColor = Color.Blue;
                U1.ForeColor = Color.Blue;
            }   
            if (U2.Text == "B")
            {   
                U2.BackColor = Color.Blue;
                U2.ForeColor = Color.Blue;
            }   
            if (U3.Text == "B")
            {   
                U3.BackColor = Color.Blue;
                U3.ForeColor = Color.Blue;
            }   
            if (U4.Text == "B")
            {   
                U4.BackColor = Color.Blue;
                U4.ForeColor = Color.Blue;
            }   
            if (U5.Text == "B")
            {   
                U5.BackColor = Color.Blue;
                U5.ForeColor = Color.Blue;
            }   
            if (U6.Text == "B")
            {   
                U6.BackColor = Color.Blue;
                U6.ForeColor = Color.Blue;
            }   
            if (U7.Text == "B")
            {   
                U7.BackColor = Color.Blue;
                U7.ForeColor = Color.Blue;
            }   
            if (U8.Text == "B")
            {   
                U8.BackColor = Color.Blue;
                U8.ForeColor = Color.Blue;
            }   
            if (U9.Text == "B")
            {   
                U9.BackColor = Color.Blue;
                U9.ForeColor = Color.Blue;
            }   
                
            if (U1.Text == "G")
            {   
                U1.BackColor = Color.Green;
                U1.ForeColor = Color.Green;
            }   
            if (U2.Text == "G")
            {   
                U2.BackColor = Color.Green;
                U2.ForeColor = Color.Green;
            }   
            if (U3.Text == "G")
            {   
                U3.BackColor = Color.Green;
                U3.ForeColor = Color.Green;
            }   
            if (U4.Text == "G")
            {   
                U4.BackColor = Color.Green;
                U4.ForeColor = Color.Green;
            }   
            if (U5.Text == "G")
            {   
                U5.BackColor = Color.Green;
                U5.ForeColor = Color.Green;
            }   
            if (U6.Text == "G")
            {   
                U6.BackColor = Color.Green;
                U6.ForeColor = Color.Green;
            }   
            if (U7.Text == "G")
            {   
                U7.BackColor = Color.Green;
                U7.ForeColor = Color.Green;
            }   
            if (U8.Text == "G")
            {   
                U8.BackColor = Color.Green;
                U8.ForeColor = Color.Green;
            }   
            if (U9.Text == "G")
            {   
                U9.BackColor = Color.Green;
                U9.ForeColor = Color.Green;
            }   
                
            if (U1.Text == "O")
            {   
                U1.BackColor = Color.Orange;
                U1.ForeColor = Color.Orange;
            }   
            if (U2.Text == "O")
            {   
                U2.BackColor = Color.Orange;
                U2.ForeColor = Color.Orange;
            }   
            if (U3.Text == "O")
            {   
                U3.BackColor = Color.Orange;
                U3.ForeColor = Color.Orange;
            }   
            if (U4.Text == "O")
            {   
                U4.BackColor = Color.Orange;
                U4.ForeColor = Color.Orange;
            }   
            if (U5.Text == "O")
            {   
                U5.BackColor = Color.Orange;
                U5.ForeColor = Color.Orange;
            }   
            if (U6.Text == "O")
            {   
                U6.BackColor = Color.Orange;
                U6.ForeColor = Color.Orange;
            }   
            if (U7.Text == "O")
            {   
                U7.BackColor = Color.Orange;
                U7.ForeColor = Color.Orange;
            }   
            if (U8.Text == "O")
            {   
                U8.BackColor = Color.Orange;
                U8.ForeColor = Color.Orange;
            }   
            if (U9.Text == "O")
            {   
                U9.BackColor = Color.Orange;
                U9.ForeColor = Color.Orange;
            }



            if (Z1.Text == "Y")
            {   
                Z1.BackColor = Color.Yellow;
                Z1.ForeColor = Color.Yellow;
            }   
            if (Z2.Text == "Y")
            {   
                Z2.BackColor = Color.Yellow;
                Z2.ForeColor = Color.Yellow;
            }   
            if (Z3.Text == "Y")
            {   
                Z3.BackColor = Color.Yellow;
                Z3.ForeColor = Color.Yellow;
            }   
            if (Z4.Text == "Y")
            {   
                Z4.BackColor = Color.Yellow;
                Z4.ForeColor = Color.Yellow;
            }   
            if (Z5.Text == "Y")
            {   
                Z5.BackColor = Color.Yellow;
                Z5.ForeColor = Color.Yellow;
            }   
            if (Z6.Text == "Y")
            {   
                Z6.BackColor = Color.Yellow;
                Z6.ForeColor = Color.Yellow;
            }   
            if (Z7.Text == "Y")
            {   
                Z7.BackColor = Color.Yellow;
                Z7.ForeColor = Color.Yellow;
            }   
            if (Z8.Text == "Y")
            {   
                Z8.BackColor = Color.Yellow;
                Z8.ForeColor = Color.Yellow;
            }   
            if (Z9.Text == "Y")
            {   
                Z9.BackColor = Color.Yellow;
                Z9.ForeColor = Color.Yellow;
            }   
                
            if (Z1.Text == "W")
            {   
                Z1.BackColor = Color.White;
                Z1.ForeColor = Color.White;
            }   
            if (Z2.Text == "W")
            {   
                Z2.BackColor = Color.White;
                Z2.ForeColor = Color.White;
            }   
            if (Z3.Text == "W")
            {   
                Z3.BackColor = Color.White;
                Z3.ForeColor = Color.White;
            }   
            if (Z4.Text == "W")
            {   
                Z4.BackColor = Color.White;
                Z4.ForeColor = Color.White;
            }   
            if (Z5.Text == "W")
            {   
                Z5.BackColor = Color.White;
                Z5.ForeColor = Color.White;
            }   
            if (Z6.Text == "W")
            {   
                Z6.BackColor = Color.White;
                Z6.ForeColor = Color.White;
            }   
            if (Z7.Text == "W")
            {   
                Z7.BackColor = Color.White;
                Z7.ForeColor = Color.White;
            }   
            if (Z8.Text == "W")
            {   
                Z8.BackColor = Color.White;
                Z8.ForeColor = Color.White;
            }   
            if (Z9.Text == "W")
            {   
                Z9.BackColor = Color.White;
                Z9.ForeColor = Color.White;
            }   
                
            if (Z1.Text == "R")
            {   
                Z1.BackColor = Color.Red;
                Z1.ForeColor = Color.Red;
            }   
            if (Z2.Text == "R")
            {   
                Z2.BackColor = Color.Red;
                Z2.ForeColor = Color.Red;
            }   
            if (Z3.Text == "R")
            {   
                Z3.BackColor = Color.Red;
                Z3.ForeColor = Color.Red;
            }   
            if (Z4.Text == "R")
            {   
                Z4.BackColor = Color.Red;
                Z4.ForeColor = Color.Red;
            }   
            if (Z5.Text == "R")
            {   
                Z5.BackColor = Color.Red;
                Z5.ForeColor = Color.Red;
            }   
            if (Z6.Text == "R")
            {   
                Z6.BackColor = Color.Red;
                Z6.ForeColor = Color.Red;
            }   
            if (Z7.Text == "R")
            {   
                Z7.BackColor = Color.Red;
                Z7.ForeColor = Color.Red;
            }   
            if (Z8.Text == "R")
            {   
                Z8.BackColor = Color.Red;
                Z8.ForeColor = Color.Red;
            }   
            if (Z9.Text == "R")
            {   
                Z9.BackColor = Color.Red;
                Z9.ForeColor = Color.Red;
            }   
                
            if (Z1.Text == "B")
            {   
                Z1.BackColor = Color.Blue;
                Z1.ForeColor = Color.Blue;
            }   
            if (Z2.Text == "B")
            {   
                Z2.BackColor = Color.Blue;
                Z2.ForeColor = Color.Blue;
            }   
            if (Z3.Text == "B")
            {   
                Z3.BackColor = Color.Blue;
                Z3.ForeColor = Color.Blue;
            }   
            if (Z4.Text == "B")
            {   
                Z4.BackColor = Color.Blue;
                Z4.ForeColor = Color.Blue;
            }   
            if (Z5.Text == "B")
            {   
                Z5.BackColor = Color.Blue;
                Z5.ForeColor = Color.Blue;
            }   
            if (Z6.Text == "B")
            {   
                Z6.BackColor = Color.Blue;
                Z6.ForeColor = Color.Blue;
            }   
            if (Z7.Text == "B")
            {   
                Z7.BackColor = Color.Blue;
                Z7.ForeColor = Color.Blue;
            }   
            if (Z8.Text == "B")
            {   
                Z8.BackColor = Color.Blue;
                Z8.ForeColor = Color.Blue;
            }   
            if (Z9.Text == "B")
            {   
                Z9.BackColor = Color.Blue;
                Z9.ForeColor = Color.Blue;
            }   
                
            if (Z1.Text == "G")
            {   
                Z1.BackColor = Color.Green;
                Z1.ForeColor = Color.Green;
            }   
            if (Z2.Text == "G")
            {   
                Z2.BackColor = Color.Green;
                Z2.ForeColor = Color.Green;
            }   
            if (Z3.Text == "G")
            {   
                Z3.BackColor = Color.Green;
                Z3.ForeColor = Color.Green;
            }   
            if (Z4.Text == "G")
            {   
                Z4.BackColor = Color.Green;
                Z4.ForeColor = Color.Green;
            }   
            if (Z5.Text == "G")
            {   
                Z5.BackColor = Color.Green;
                Z5.ForeColor = Color.Green;
            }   
            if (Z6.Text == "G")
            {   
                Z6.BackColor = Color.Green;
                Z6.ForeColor = Color.Green;
            }   
            if (Z7.Text == "G")
            {   
                Z7.BackColor = Color.Green;
                Z7.ForeColor = Color.Green;
            }   
            if (Z8.Text == "G")
            {   
                Z8.BackColor = Color.Green;
                Z8.ForeColor = Color.Green;
            }   
            if (Z9.Text == "G")
            {   
                Z9.BackColor = Color.Green;
                Z9.ForeColor = Color.Green;
            }   
                
            if (Z1.Text == "O")
            {   
                Z1.BackColor = Color.Orange;
                Z1.ForeColor = Color.Orange;
            }   
            if (Z2.Text == "O")
            {   
                Z2.BackColor = Color.Orange;
                Z2.ForeColor = Color.Orange;
            }   
            if (Z3.Text == "O")
            {   
                Z3.BackColor = Color.Orange;
                Z3.ForeColor = Color.Orange;
            }   
            if (Z4.Text == "O")
            {
                Z4.BackColor = Color.Orange;
                Z4.ForeColor = Color.Orange;
            }   
            if (Z5.Text == "O")
            {   
                Z5.BackColor = Color.Orange;
                Z5.ForeColor = Color.Orange;
            }   
            if (Z6.Text == "O")
            {   
                Z6.BackColor = Color.Orange;
                Z6.ForeColor = Color.Orange;
            }   
            if (Z7.Text == "O")
            {   
                Z7.BackColor = Color.Orange;
                Z7.ForeColor = Color.Orange;
            }   
            if (Z8.Text == "O")
            {   
                Z8.BackColor = Color.Orange;
                Z8.ForeColor = Color.Orange;
            }   
            if (Z9.Text == "O")
            {   
                Z9.BackColor = Color.Orange;
                Z9.ForeColor = Color.Orange;
            }


            if (L1.Text == "Y")
            {   
                L1.BackColor = Color.Yellow;
                L1.ForeColor = Color.Yellow;
            }   
            if (L2.Text == "Y")
            {   
                L2.BackColor = Color.Yellow;
                L2.ForeColor = Color.Yellow;
            }   
            if (L3.Text == "Y")
            {   
                L3.BackColor = Color.Yellow;
                L3.ForeColor = Color.Yellow;
            }   
            if (L4.Text == "Y")
            {   
                L4.BackColor = Color.Yellow;
                L4.ForeColor = Color.Yellow;
            }   
            if (L5.Text == "Y")
            {   
                L5.BackColor = Color.Yellow;
                L5.ForeColor = Color.Yellow;
            }   
            if (L6.Text == "Y")
            {   
                L6.BackColor = Color.Yellow;
                L6.ForeColor = Color.Yellow;
            }   
            if (L7.Text == "Y")
            {   
                L7.BackColor = Color.Yellow;
                L7.ForeColor = Color.Yellow;
            }   
            if (L8.Text == "Y")
            {   
                L8.BackColor = Color.Yellow;
                L8.ForeColor = Color.Yellow;
            }   
            if (L9.Text == "Y")
            {   
                L9.BackColor = Color.Yellow;
                L9.ForeColor = Color.Yellow;
            }   
                
            if (L1.Text == "W")
            {   
                L1.BackColor = Color.White;
                L1.ForeColor = Color.White;
            }   
            if (L2.Text == "W")
            {   
                L2.BackColor = Color.White;
                L2.ForeColor = Color.White;
            }   
            if (L3.Text == "W")
            {   
                L3.BackColor = Color.White;
                L3.ForeColor = Color.White;
            }   
            if (L4.Text == "W")
            {   
                L4.BackColor = Color.White;
                L4.ForeColor = Color.White;
            }   
            if (L5.Text == "W")
            {   
                L5.BackColor = Color.White;
                L5.ForeColor = Color.White;
            }   
            if (L6.Text == "W")
            {   
                L6.BackColor = Color.White;
                L6.ForeColor = Color.White;
            }   
            if (L7.Text == "W")
            {   
                L7.BackColor = Color.White;
                L7.ForeColor = Color.White;
            }   
            if (L8.Text == "W")
            {   
                L8.BackColor = Color.White;
                L8.ForeColor = Color.White;
            }   
            if (L9.Text == "W")
            {   
                L9.BackColor = Color.White;
                L9.ForeColor = Color.White;
            }   
                
            if (L1.Text == "R")
            {   
                L1.BackColor = Color.Red;
                L1.ForeColor = Color.Red;
            }   
            if (L2.Text == "R")
            {   
                L2.BackColor = Color.Red;
                L2.ForeColor = Color.Red;
            }   
            if (L3.Text == "R")
            {   
                L3.BackColor = Color.Red;
                L3.ForeColor = Color.Red;
            }   
            if (L4.Text == "R")
            {   
                L4.BackColor = Color.Red;
                L4.ForeColor = Color.Red;
            }   
            if (L5.Text == "R")
            {   
                L5.BackColor = Color.Red;
                L5.ForeColor = Color.Red;
            }   
            if (L6.Text == "R")
            {   
                L6.BackColor = Color.Red;
                L6.ForeColor = Color.Red;
            }   
            if (L7.Text == "R")
            {   
                L7.BackColor = Color.Red;
                L7.ForeColor = Color.Red;
            }   
            if (L8.Text == "R")
            {   
                L8.BackColor = Color.Red;
                L8.ForeColor = Color.Red;
            }   
            if (L9.Text == "R")
            {   
                L9.BackColor = Color.Red;
                L9.ForeColor = Color.Red;
            }   
                
            if (L1.Text == "B")
            {   
                L1.BackColor = Color.Blue;
                L1.ForeColor = Color.Blue;
            }   
            if (L2.Text == "B")
            {   
                L2.BackColor = Color.Blue;
                L2.ForeColor = Color.Blue;
            }   
            if (L3.Text == "B")
            {   
                L3.BackColor = Color.Blue;
                L3.ForeColor = Color.Blue;
            }   
            if (L4.Text == "B")
            {   
                L4.BackColor = Color.Blue;
                L4.ForeColor = Color.Blue;
            }   
            if (L5.Text == "B")
            {   
                L5.BackColor = Color.Blue;
                L5.ForeColor = Color.Blue;
            }   
            if (L6.Text == "B")
            {   
                L6.BackColor = Color.Blue;
                L6.ForeColor = Color.Blue;
            }   
            if (L7.Text == "B")
            {   
                L7.BackColor = Color.Blue;
                L7.ForeColor = Color.Blue;
            }   
            if (L8.Text == "B")
            {   
                L8.BackColor = Color.Blue;
                L8.ForeColor = Color.Blue;
            }   
            if (L9.Text == "B")
            {   
                L9.BackColor = Color.Blue;
                L9.ForeColor = Color.Blue;
            }   
                
            if (L1.Text == "G")
            {   
                L1.BackColor = Color.Green;
                L1.ForeColor = Color.Green;
            }   
            if (L2.Text == "G")
            {   
                L2.BackColor = Color.Green;
                L2.ForeColor = Color.Green;
            }   
            if (L3.Text == "G")
            {   
                L3.BackColor = Color.Green;
                L3.ForeColor = Color.Green;
            }   
            if (L4.Text == "G")
            {   
                L4.BackColor = Color.Green;
                L4.ForeColor = Color.Green;
            }   
            if (L5.Text == "G")
            {   
                L5.BackColor = Color.Green;
                L5.ForeColor = Color.Green;
            }   
            if (L6.Text == "G")
            {   
                L6.BackColor = Color.Green;
                L6.ForeColor = Color.Green;
            }   
            if (L7.Text == "G")
            {   
                L7.BackColor = Color.Green;
                L7.ForeColor = Color.Green;
            }   
            if (L8.Text == "G")
            {   
                L8.BackColor = Color.Green;
                L8.ForeColor = Color.Green;
            }   
            if (L9.Text == "G")
            {   
                L9.BackColor = Color.Green;
                L9.ForeColor = Color.Green;
            }   
                
            if (L1.Text == "O")
            {   
                L1.BackColor = Color.Orange;
                L1.ForeColor = Color.Orange;
            }   
            if (L2.Text == "O")
            {   
                L2.BackColor = Color.Orange;
                L2.ForeColor = Color.Orange;
            }   
            if (L3.Text == "O")
            {   
                L3.BackColor = Color.Orange;
                L3.ForeColor = Color.Orange;
            }   
            if (L4.Text == "O")
            {   
                L4.BackColor = Color.Orange;
                L4.ForeColor = Color.Orange;
            }   
            if (L5.Text == "O")
            {   
                L5.BackColor = Color.Orange;
                L5.ForeColor = Color.Orange;
            }   
            if (L6.Text == "O")
            {   
                L6.BackColor = Color.Orange;
                L6.ForeColor = Color.Orange;
            }   
            if (L7.Text == "O")
            {   
                L7.BackColor = Color.Orange;
                L7.ForeColor = Color.Orange;
            }   
            if (L8.Text == "O")
            {   
                L8.BackColor = Color.Orange;
                L8.ForeColor = Color.Orange;
            }   
            if (L9.Text == "O")
            {   
                L9.BackColor = Color.Orange;
                L9.ForeColor = Color.Orange;
            }


            if (R1.Text == "Y")
            {   
                R1.BackColor = Color.Yellow;
                R1.ForeColor = Color.Yellow;
            }   
            if (R2.Text == "Y")
            {   
                R2.BackColor = Color.Yellow;
                R2.ForeColor = Color.Yellow;
            }   
            if (R3.Text == "Y")
            {   
                R3.BackColor = Color.Yellow;
                R3.ForeColor = Color.Yellow;
            }   
            if (R4.Text == "Y")
            {   
                R4.BackColor = Color.Yellow;
                R4.ForeColor = Color.Yellow;
            }   
            if (R5.Text == "Y")
            {   
                R5.BackColor = Color.Yellow;
                R5.ForeColor = Color.Yellow;
            }   
            if (R6.Text == "Y")
            {   
                R6.BackColor = Color.Yellow;
                R6.ForeColor = Color.Yellow;
            }   
            if (R7.Text == "Y")
            {   
                R7.BackColor = Color.Yellow;
                R7.ForeColor = Color.Yellow;
            }   
            if (R8.Text == "Y")
            {   
                R8.BackColor = Color.Yellow;
                R8.ForeColor = Color.Yellow;
            }   
            if (R9.Text == "Y")
            {   
                R9.BackColor = Color.Yellow;
                R9.ForeColor = Color.Yellow;
            }   
                
            if (R1.Text == "W")
            {   
                R1.BackColor = Color.White;
                R1.ForeColor = Color.White;
            }   
            if (R2.Text == "W")
            {   
                R2.BackColor = Color.White;
                R2.ForeColor = Color.White;
            }   
            if (R3.Text == "W")
            {   
                R3.BackColor = Color.White;
                R3.ForeColor = Color.White;
            }   
            if (R4.Text == "W")
            {   
                R4.BackColor = Color.White;
                R4.ForeColor = Color.White;
            }   
            if (R5.Text == "W")
            {   
                R5.BackColor = Color.White;
                R5.ForeColor = Color.White;
            }   
            if (R6.Text == "W")
            {   
                R6.BackColor = Color.White;
                R6.ForeColor = Color.White;
            }   
            if (R7.Text == "W")
            {   
                R7.BackColor = Color.White;
                R7.ForeColor = Color.White;
            }   
            if (R8.Text == "W")
            {   
                R8.BackColor = Color.White;
                R8.ForeColor = Color.White;
            }   
            if (R9.Text == "W")
            {   
                R9.BackColor = Color.White;
                R9.ForeColor = Color.White;
            }   
                
            if (R1.Text == "R")
            {   
                R1.BackColor = Color.Red;
                R1.ForeColor = Color.Red;
            }   
            if (R2.Text == "R")
            {   
                R2.BackColor = Color.Red;
                R2.ForeColor = Color.Red;
            }   
            if (R3.Text == "R")
            {   
                R3.BackColor = Color.Red;
                R3.ForeColor = Color.Red;
            }   
            if (R4.Text == "R")
            {   
                R4.BackColor = Color.Red;
                R4.ForeColor = Color.Red;
            }   
            if (R5.Text == "R")
            {   
                R5.BackColor = Color.Red;
                R5.ForeColor = Color.Red;
            }   
            if (R6.Text == "R")
            {   
                R6.BackColor = Color.Red;
                R6.ForeColor = Color.Red;
            }   
            if (R7.Text == "R")
            {   
                R7.BackColor = Color.Red;
                R7.ForeColor = Color.Red;
            }   
            if (R8.Text == "R")
            {   
                R8.BackColor = Color.Red;
                R8.ForeColor = Color.Red;
            }   
            if (R9.Text == "R")
            {   
                R9.BackColor = Color.Red;
                R9.ForeColor = Color.Red;
            }   
                
            if (R1.Text == "B")
            {   
                R1.BackColor = Color.Blue;
                R1.ForeColor = Color.Blue;
            }   
            if (R2.Text == "B")
            {   
                R2.BackColor = Color.Blue;
                R2.ForeColor = Color.Blue;
            }   
            if (R3.Text == "B")
            {   
                R3.BackColor = Color.Blue;
                R3.ForeColor = Color.Blue;
            }   
            if (R4.Text == "B")
            {   
                R4.BackColor = Color.Blue;
                R4.ForeColor = Color.Blue;
            }   
            if (R5.Text == "B")
            {   
                R5.BackColor = Color.Blue;
                R5.ForeColor = Color.Blue;
            }   
            if (R6.Text == "B")
            {   
                R6.BackColor = Color.Blue;
                R6.ForeColor = Color.Blue;
            }   
            if (R7.Text == "B")
            {   
                R7.BackColor = Color.Blue;
                R7.ForeColor = Color.Blue;
            }   
            if (R8.Text == "B")
            {   
                R8.BackColor = Color.Blue;
                R8.ForeColor = Color.Blue;
            }   
            if (R9.Text == "B")
            {   
                R9.BackColor = Color.Blue;
                R9.ForeColor = Color.Blue;
            }   
                
            if (R1.Text == "G")
            {   
                R1.BackColor = Color.Green;
                R1.ForeColor = Color.Green;
            }   
            if (R2.Text == "G")
            {   
                R2.BackColor = Color.Green;
                R2.ForeColor = Color.Green;
            }   
            if (R3.Text == "G")
            {   
                R3.BackColor = Color.Green;
                R3.ForeColor = Color.Green;
            }   
            if (R4.Text == "G")
            {   
                R4.BackColor = Color.Green;
                R4.ForeColor = Color.Green;
            }   
            if (R5.Text == "G")
            {   
                R5.BackColor = Color.Green;
                R5.ForeColor = Color.Green;
            }   
            if (R6.Text == "G")
            {   
                R6.BackColor = Color.Green;
                R6.ForeColor = Color.Green;
            }   
            if (R7.Text == "G")
            {   
                R7.BackColor = Color.Green;
                R7.ForeColor = Color.Green;
            }   
            if (R8.Text == "G")
            {   
                R8.BackColor = Color.Green;
                R8.ForeColor = Color.Green;
            }   
            if (R9.Text == "G")
            {   
                R9.BackColor = Color.Green;
                R9.ForeColor = Color.Green;
            }   
                
            if (R1.Text == "O")
            {   
                R1.BackColor = Color.Orange;
                R1.ForeColor = Color.Orange;
            }   
            if (R2.Text == "O")
            {   
                R2.BackColor = Color.Orange;
                R2.ForeColor = Color.Orange;
            }   
            if (R3.Text == "O")
            {   
                R3.BackColor = Color.Orange;
                R3.ForeColor = Color.Orange;
            }   
            if (R4.Text == "O")
            {   
                R4.BackColor = Color.Orange;
                R4.ForeColor = Color.Orange;
            }   
            if (R5.Text == "O")
            {   
                R5.BackColor = Color.Orange;
                R5.ForeColor = Color.Orange;
            }   
            if (R6.Text == "O")
            {   
                R6.BackColor = Color.Orange;
                R6.ForeColor = Color.Orange;
            }   
            if (R7.Text == "O")
            {   
                R7.BackColor = Color.Orange;
                R7.ForeColor = Color.Orange;
            }   
            if (R8.Text == "O")
            {   
                R8.BackColor = Color.Orange;
                R8.ForeColor = Color.Orange;
            }   
            if (R9.Text == "O")
            {   
                R9.BackColor = Color.Orange;
                R9.ForeColor = Color.Orange;
            }            
        }

        private void Db2_Click(object sender, EventArgs e)
        {
            k = P2.Text;
            k1 = P5.Text;
            k2 = P8.Text;
            k3 = D2.Text;
            k4 = D5.Text;
            k5 = D8.Text;
            k6 = Z2.Text;
            k7 = Z5.Text;
            k8 = Z8.Text;
            k9 = U2.Text;
            k10 = U5.Text;
            k11 = U8.Text;

            D2.Text = k;
            D5.Text = k1;
            D8.Text = k2;
            Z2.Text = k3;
            Z5.Text = k4;
            Z8.Text = k5;
            U2.Text = k6;
            U5.Text = k7;
            U8.Text = k8;
            P2.Text = k9;
            P5.Text = k10;
            P8.Text = k11;
            Col();
            

            Ochistka();
        }

        private void Lb2_Click(object sender, EventArgs e)
        {
            k = P4.Text;
            k1 = P5.Text;
            k2 = P6.Text;
            k3 = R4.Text;
            k4 = R5.Text;
            k5 = R6.Text;
            k6 = Z4.Text;
            k7 = Z5.Text;
            k8 = Z6.Text;
            k9 = L4.Text;
            k10 = L5.Text;
            k11 = L6.Text;

            L4.Text = k;
            L5.Text = k1;
            L6.Text = k2;
            P4.Text = k3;
            P5.Text = k4;
            P6.Text = k5;
            R4.Text = k6;
            R5.Text = k7;
            R6.Text = k8;
            Z4.Text = k9;
            Z5.Text = k10;
            Z6.Text = k11;
            Col();
            Ochistka();
        }

        private void Rb2_Click(object sender, EventArgs e)
        {
            k = P4.Text;
            k1 = P5.Text;
            k2 = P6.Text;
            k3 = R4.Text;
            k4 = R5.Text;
            k5 = R6.Text;
            k6 = Z4.Text;
            k7 = Z5.Text;
            k8 = Z6.Text;
            k9 = L4.Text;
            k10 = L5.Text;
            k11 = L6.Text;

            R4.Text = k;
            R5.Text = k1;
            R6.Text = k2;
            Z4.Text = k3;
            Z5.Text = k4;
            Z6.Text = k5;
            L4.Text = k6;
            L5.Text = k7;
            L6.Text = k8;
            P4.Text = k9;
            P5.Text = k10;
            P6.Text = k11;
            Col();
            Ochistka();
        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            k = P1.Text;
            k1 = P2.Text;
            k2 = P3.Text;
            k3 = L1.Text;
            k4 = L2.Text;
            k5 = L3.Text;
            k6 = Z1.Text;
            k7 = Z2.Text;
            k8 = Z3.Text;
            k9 = R1.Text;
            k10 = R2.Text;
            k11 = R3.Text;
            k12 = U1.Text;
            k13 = U2.Text;
            k14 = U3.Text;
            k15 = U4.Text;
            k16 = U6.Text;
            k17 = U7.Text;
            k18 = U8.Text;
            k19 = U9.Text;

            R1.Text = k;
            R2.Text = k1;
            R3.Text = k2;
            P1.Text = k3;
            P2.Text = k4;
            P3.Text = k5;
            L1.Text = k6;
            L2.Text = k7;
            L3.Text = k8;
            Z1.Text = k9;
            Z2.Text = k10;
            Z3.Text = k11;

            U3.Text = k19;
            U6.Text = k18;
            U9.Text = k17;
            U1.Text = k14;
            U2.Text = k16;
            U4.Text = k13;
            U7.Text = k12;
            U8.Text = k15;

            Col();
            Ochistka();
        }

        private void Lb1_Click(object sender, EventArgs e)
        {
            k = P1.Text;
            k1 = P2.Text;
            k2 = P3.Text;
            k3 = L1.Text;
            k4 = L2.Text;
            k5 = L3.Text;
            k6 = Z1.Text;
            k7 = Z2.Text;
            k8 = Z3.Text;
            k9 = R1.Text;
            k10 = R2.Text;
            k11 = R3.Text;
            k12 = U1.Text;
            k13 = U2.Text;
            k14 = U3.Text;
            k15 = U4.Text;
            k16 = U6.Text;
            k17 = U7.Text;
            k18 = U8.Text;
            k19 = U9.Text;

            L1.Text = k;
            L2.Text = k1;
            L3.Text = k2;
            Z1.Text = k3;
            Z2.Text = k4;
            Z3.Text = k5;
            R1.Text = k6;
            R2.Text = k7;
            R3.Text = k8;
            P1.Text = k9;
            P2.Text = k10;
            P3.Text = k11;

            U3.Text = k12;
            U6.Text = k13;
            U9.Text = k14;
            U2.Text = k15;
            U8.Text = k16;
            U1.Text = k17;
            U4.Text = k18;
            U7.Text = k19;

            Col();
            Ochistka();
        }

        private void Lb3_Click(object sender, EventArgs e)
        {
            k = P7.Text;
            k1 = P8.Text;
            k2 = P9.Text;
            k3 = L7.Text;
            k4 = L8.Text;
            k5 = L9.Text;
            k6 = Z7.Text;
            k7 = Z8.Text;
            k8 = Z9.Text;
            k9 = R7.Text;
            k10 = R8.Text;
            k11 = R9.Text;
            k12 = D1.Text;
            k13 = D2.Text;
            k14 = D3.Text;
            k15 = D4.Text;
            k16 = D6.Text;
            k17 = D7.Text;
            k18 = D8.Text;
            k19 = D9.Text;

            L7.Text = k;
            L8.Text = k1;
            L9.Text = k2;
            Z7.Text = k3;
            Z8.Text = k4;
            Z9.Text = k5;
            R7.Text = k6;
            R8.Text = k7;
            R9.Text = k8;
            P7.Text = k9;
            P8.Text = k10;
            P9.Text = k11;

            D1.Text = k17;
            D2.Text = k15;
            D3.Text = k12;
            D4.Text = k18;
            D6.Text = k13;
            D9.Text = k14;
            D8.Text = k16;
            D7.Text = k19;

            Col();
            Ochistka();
        }

        private void Rb3_Click(object sender, EventArgs e)
        {
            k = P7.Text;
            k1 = P8.Text;
            k2 = P9.Text;
            k3 = R7.Text;
            k4 = R8.Text;
            k5 = R9.Text;
            k6 = Z7.Text;
            k7 = Z8.Text;
            k8 = Z9.Text;
            k9 = L7.Text;
            k10 = L8.Text;
            k11 = L9.Text;

            k12 = D1.Text;
            k13 = D2.Text;
            k14 = D3.Text;
            k15 = D4.Text;
            k16 = D6.Text;
            k17 = D7.Text;
            k18 = D8.Text;
            k19 = D9.Text;

            R7.Text = k;
            R8.Text = k1;
            R9.Text = k2;
            Z7.Text = k3;
            Z8.Text = k4;
            Z9.Text = k5;
            L7.Text = k6;
            L8.Text = k7;
            L9.Text = k8;
            P7.Text = k9;
            P8.Text = k10;
            P9.Text = k11;

            D1.Text = k14;
            D4.Text = k13;
            D7.Text = k12;
            D8.Text = k15;
            D9.Text = k17;
            D6.Text = k18;
            D3.Text = k19;
            D2.Text = k16;

            Col();
            Ochistka();
        }

        private void Ub1_Click(object sender, EventArgs e)
        {
            k = P1.Text;
            k1 = P4.Text;
            k2 = P7.Text;
            k3 = D1.Text;
            k4 = D4.Text;
            k5 = D7.Text;
            k6 = Z1.Text;
            k7 = Z4.Text;
            k8 = Z7.Text;
            k9 = U1.Text;
            k10 = U4.Text;
            k11 = U7.Text;

            k12 = L1.Text;
            k13 = L2.Text;
            k14 = L3.Text;
            k15 = L4.Text;
            k16 = L6.Text;
            k17 = L7.Text;
            k18 = L8.Text;
            k19 = L9.Text;

            U1.Text = k;
            U4.Text = k1;
            U7.Text = k2;
            P1.Text = k3;
            P4.Text = k4;
            P7.Text = k5;
            D1.Text = k6;
            D4.Text = k7;
            D7.Text = k8;
            Z1.Text = k9;
            Z4.Text = k10;
            Z7.Text = k11;

            L3.Text = k19;
            L2.Text = k16;
            L1.Text = k14;
            L4.Text = k13;
            L7.Text = k12;
            L8.Text = k15;
            L9.Text = k17;
            L6.Text = k18;

            Col();
            Ochistka();
        }

        private void Db1_Click(object sender, EventArgs e)
        {
            k = P1.Text;
            k1 = P4.Text;
            k2 = P7.Text;
            k3 = D1.Text;
            k4 = D4.Text;
            k5 = D7.Text;
            k6 = Z1.Text;
            k7 = Z4.Text;
            k8 = Z7.Text;
            k9 = U1.Text;
            k10 = U4.Text;
            k11 = U7.Text;

            k12 = L1.Text;
            k13 = L2.Text;
            k14 = L3.Text;
            k15 = L4.Text;
            k16 = L6.Text;
            k17 = L7.Text;
            k18 = L8.Text;
            k19 = L9.Text;

            D1.Text = k;
            D4.Text = k1;
            D7.Text = k2;
            Z1.Text = k3;
            Z4.Text = k4;
            Z7.Text = k5;
            U1.Text = k6;
            U4.Text = k7;
            U7.Text = k8;
            P1.Text = k9;
            P4.Text = k10;
            P7.Text = k11;

            L1.Text = k17;
            L2.Text = k15;
            L3.Text = k12;
            L6.Text = k13;
            L9.Text = k14;
            L8.Text = k16;
            L7.Text = k19;
            L4.Text = k18;

            Col();
            Ochistka();
        }

        private void Ub3_Click(object sender, EventArgs e)
        {
            k = P3.Text;
            k1 = P6.Text;
            k2 = P9.Text;
            k3 = U3.Text;
            k4 = U6.Text;
            k5 = U9.Text;
            k6 = Z3.Text;
            k7 = Z6.Text;
            k8 = Z9.Text;
            k9 = D3.Text;
            k10 = D6.Text;
            k11 = D9.Text;

            k12 = R1.Text;
            k13 = R2.Text;
            k14 = R3.Text;
            k15 = R4.Text;
            k16 = R6.Text;
            k17 = R7.Text;
            k18 = R8.Text;
            k19 = R9.Text;

            U3.Text = k;
            U6.Text = k1;
            U9.Text = k2;
            Z3.Text = k3;
            Z6.Text = k4;
            Z9.Text = k5;
            D3.Text = k6;
            D6.Text = k7;
            D9.Text = k8;
            P3.Text = k9;
            P6.Text = k10;
            P9.Text = k11;

            R1.Text = k17;
            R2.Text = k15;
            R3.Text = k12;
            R6.Text = k13;
            R9.Text = k14;
            R8.Text = k16;
            R7.Text = k19;
            R4.Text = k18;

            Col();
            Ochistka();
        }

        private void Db3_Click(object sender, EventArgs e)
        {
            k = P3.Text;
            k1 = P6.Text;
            k2 = P9.Text;
            k3 = D3.Text;
            k4 = D6.Text;
            k5 = D9.Text;
            k6 = Z3.Text;
            k7 = Z6.Text;
            k8 = Z9.Text;
            k9 = U3.Text;
            k10 = U6.Text;
            k11 = U9.Text;

            k12 = R1.Text;
            k13 = R4.Text;
            k14 = R7.Text;
            k15 = R8.Text;
            k16 = R9.Text;
            k17 = R6.Text;
            k18 = R3.Text;
            k19 = R2.Text;

            D3.Text = k;
            D6.Text = k1;
            D9.Text = k2;
            Z3.Text = k3;
            Z6.Text = k4;
            Z9.Text = k5;
            U3.Text = k6;
            U6.Text = k7;
            U9.Text = k8;
            P3.Text = k9;
            P6.Text = k10;
            P9.Text = k11;

            R1.Text = k18;
            R4.Text = k19;
            R7.Text = k12;
            R8.Text = k13;
            R9.Text = k14;
            R6.Text = k15;
            R3.Text = k16;
            R2.Text = k17;

            Col();
            Ochistka();

        }
    }
}
