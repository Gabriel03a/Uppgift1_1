using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            //Skapad av Gabriel
            //Omvandla till int.
            int tal1 = ParseToInt(tbxTal1.Text);
            int tal2 = ParseToInt(tbxTal2.Text);

            //Addera
            int summa = tal1 + tal2;

            //Omvandla summan till sträng och visa svaret
            tbxSumma.Text = summa.ToString();
        }
        private int ParseToInt(string text)
        {
            int tal = 0;

            //Börja med värdet av entalet
            int positionsVärde = 1;

            //"Parsa" texten och beräkna tal
            for (int i = text.Length - 1; i >= 0; i--)
            {
                int teckenVärde = text[i] - 48;
                tal += teckenVärde * positionsVärde;
                positionsVärde *= 10;
            }

            return tal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
