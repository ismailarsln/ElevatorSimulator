using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorSimulator
{
    public partial class Form1
    {
        private int ilk = 1;

        private void solkat()
        {
            ilk = kuyruk1[0]; //hep son indexteki rakamı çalıştırır.

            string kk = "solkat".ToString() + ilk;
            converter(kk);
        }
        private void sagkat()
        {
            ilk = kuyruk2[0];

            string kk = "sagkat".ToString() + ilk;
            converter(kk);
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            i = 1;
            sol();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            i = 2;
            sol();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            i = 3;
            sol();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            i = 4;
            sol();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            i = 5;
            sol();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            i = 6;
            sol();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            i = 7;
            sol();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            i = 8;
            sol();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            i = 9;
            sol();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            i = 10;
            sol();
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            i = 1;
            sag();
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            i = 2;
            sag();
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            i = 3;
            sag();
        }

        private void btn4_1_Click(object sender, EventArgs e)
        {
            i = 4;
            sag();
        }

        private void btn5_1_Click(object sender, EventArgs e)
        {
            i = 5;
            sag();
        }

        private void btn6_1_Click(object sender, EventArgs e)
        {
            i = 6;
            sag();
        }

        private void btn7_1_Click(object sender, EventArgs e)
        {
            i = 7;
            sag();
        }

        private void btn8_1_Click(object sender, EventArgs e)
        {
            i = 8;
            sag();
        }

        private void btn9_1_Click(object sender, EventArgs e)
        {
            i = 9;
            sag();
        }

        private void btn10_1_Click(object sender, EventArgs e)
        {
            i = 10;
            sag();
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            i = 1;
            btn();
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            i = 2;
            btn();
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            i = 3;
            btn();
        }

        private void btn4_2_Click(object sender, EventArgs e)
        {
            i = 4;
            btn();
        }

        private void btn5_2_Click(object sender, EventArgs e)
        {
            i = 5;
            btn();
        }

        private void btn6_2_Click(object sender, EventArgs e)
        {
            i = 6;
            btn();
        }

        private void btn7_2_Click(object sender, EventArgs e)
        {
            i = 7;
            btn();
        }

        private void btn8_2_Click(object sender, EventArgs e)
        {
            i = 8;
            btn();
        }

        private void btn9_2_Click(object sender, EventArgs e)
        {
            i = 9;
            btn();
        }

        private void btn10_2_Click(object sender, EventArgs e)
        {
            i = 10;
            btn();
        }
    }
}