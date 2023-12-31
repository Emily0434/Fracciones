﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraccionesContinuas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int a, b, i = 1, r=0, es=0;
            a = int.Parse(Dato1.Text);
            b = int.Parse(Dato2.Text);
            int mcd = CalcularMCDRecursivo(a, b);
            dGW1.Rows.Add(i.ToString(), a.ToString() + " Dividido entre " + b.ToString() + " es " + es.ToString() + " y sobran " + r.ToString(), a.ToString() + "/" + b.ToString() + " = " + es.ToString() + " + 1/" + b.ToString() + "/" + r.ToString());
            
            i++;

            MessageBox.Show("El MCD de " + a + " y " + b + " es " + mcd);
        }

        private int CalcularMCDRecursivo(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return CalcularMCDRecursivo(b, a % b);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dato1.Text = "";
            Dato2.Text = "";
            Dato1.Focus();
            dGW1.Rows.Clear();
        }

     

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 500;
        }

       
    }
}
