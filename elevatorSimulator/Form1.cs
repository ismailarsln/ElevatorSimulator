using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            siraguncelle(); //listelerin güncel tutulmasını sağlayan method:
        }

        // kabin hareketini yönetiyor: //animasyonlu geçişler gelecek
        private void solkat1()
        {
            kabinsol.Location = new Point(solkapi1.Location.X - 45, 450);
            acikkapisol.Location = new Point(solkapi1.Location.X, solkapi1.Location.Y);
            acikkapisol.Visible = true;
        }
        private void solkat2()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi2.Location.X - 45, 400);
            acikkapisol.Location = new Point(solkapi2.Location.X, solkapi2.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat3()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi3.Location.X - 45, 350);
            acikkapisol.Location = new Point(solkapi3.Location.X, solkapi3.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat4()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi4.Location.X - 45, 300);
            acikkapisol.Location = new Point(solkapi4.Location.X, solkapi4.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat5()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi5.Location.X - 45, 250);
            acikkapisol.Location = new Point(solkapi5.Location.X, solkapi5.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat6()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi6.Location.X - 45, 200);
            acikkapisol.Location = new Point(solkapi6.Location.X, solkapi6.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat7()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi7.Location.X - 45, 150);
            acikkapisol.Location = new Point(solkapi7.Location.X, solkapi7.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat8()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi8.Location.X - 45, 100);
            acikkapisol.Location = new Point(solkapi8.Location.X, solkapi8.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat9()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi9.Location.X - 45, 50);
            acikkapisol.Location = new Point(solkapi9.Location.X, solkapi9.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat10()
        {
            acikkapisol.Visible = false;
            kabinsol.Location = new Point(solkapi10.Location.X - 45, 0);
            acikkapisol.Location = new Point(solkapi10.Location.X, solkapi10.Location.Y);
            acikkapisol.Visible = true;
        }

        private void sagkat1()
        {
            kabinsag.Location = new Point(sagkapi1.Location.X - 45, 450);
            acikkapisag.Location = new Point(sagkapi1.Location.X, sagkapi1.Location.Y);
            acikkapisag.Visible = true;
        }
        private void sagkat2()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi2.Location.X - 45, 400);
            acikkapisag.Location = new Point(sagkapi2.Location.X, sagkapi2.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat3()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi3.Location.X - 45, 350);
            acikkapisag.Location = new Point(sagkapi3.Location.X, sagkapi3.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat4()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi4.Location.X - 45, 300);
            acikkapisag.Location = new Point(sagkapi4.Location.X, sagkapi4.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat5()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi5.Location.X - 45, 250);
            acikkapisag.Location = new Point(sagkapi5.Location.X, sagkapi5.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat6()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi6.Location.X - 45, 200);
            acikkapisag.Location = new Point(sagkapi6.Location.X, sagkapi6.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat7()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi7.Location.X - 45, 150);
            acikkapisag.Location = new Point(sagkapi7.Location.X, sagkapi7.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat8()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi8.Location.X - 45, 100);
            acikkapisag.Location = new Point(sagkapi8.Location.X, sagkapi8.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat9()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi9.Location.X - 45, 50);
            acikkapisag.Location = new Point(sagkapi9.Location.X, sagkapi9.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat10()
        {
            acikkapisag.Visible = false;
            kabinsag.Location = new Point(sagkapi10.Location.X - 45, 0);
            acikkapisag.Location = new Point(sagkapi10.Location.X, sagkapi10.Location.Y);
            acikkapisag.Visible = true;
        }
    }
}