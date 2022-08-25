using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSimulator
{
    public partial class Form1 : Form
    {
        private void converter(string yazi)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType
                .GetMethod(yazi, BindingFlags.NonPublic | BindingFlags.Instance);
            theMethod.Invoke(this, null);
        }
        private Timer t = new Timer(); //solkat arası geçiş için geçen 5 saniye
        private Timer t2 = new Timer(); //sagkat arası geçiş için geçen 5 saniye
        private Timer t3 = new Timer(); //30 saniye
        private Timer t4 = new Timer(); //30 saniye

        public Form1()
        {
            InitializeComponent();
            kuyruk1.Add(araKat);
            kuyruk2.Add(anaKat);
            t.Interval = 5000;
            t.Tick += new EventHandler(t_Tick);

            t2.Interval = 5000;
            t2.Tick += new EventHandler(t2_Tick);

            t3.Interval = 5000;
            t3.Tick += new EventHandler(t3_Tick);

            t4.Interval = 5000;
            t4.Tick += new EventHandler(t4_Tick);
            t2.Enabled = true;
            t.Enabled = true;     //5 saniye ve sonrasında konum güncelleniyor.
            siraguncelle();
        }

        void t_Tick(object sender, EventArgs e)
        {
            solkat();
            kuyruk1.RemoveAt(0);
            siraguncelle();
        }

        void t2_Tick(object sender, EventArgs e)
        {
            sagkat();
            kuyruk2.RemoveAt(0);
            siraguncelle();
        }

        void t3_Tick(object sender, EventArgs e)
        {
            solkat();
        }

        void t4_Tick(object sender, EventArgs e)
        {
            sagkat();
        }

        private void solkat1()
        {
            acikkapisol.Location = new Point(solkapi1.Location.X, solkapi1.Location.Y);
            acikkapisol.Visible = true;
        }
        private void solkat2()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi2.Location.X, solkapi2.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat3()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi3.Location.X, solkapi3.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat4()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi4.Location.X, solkapi4.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat5()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi5.Location.X, solkapi5.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat6()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi6.Location.X, solkapi6.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat7()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi7.Location.X, solkapi7.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat8()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi8.Location.X, solkapi8.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat9()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi9.Location.X, solkapi9.Location.Y);
            acikkapisol.Visible = true;
        }

        private void solkat10()
        {
            acikkapisol.Visible = false;
            acikkapisol.Location = new Point(solkapi10.Location.X, solkapi10.Location.Y);
            acikkapisol.Visible = true;
        }

        private void sagkat1()
        {
            acikkapisag.Location = new Point(sagkapi1.Location.X, sagkapi1.Location.Y);
            acikkapisag.Visible = true;
        }
        private void sagkat2()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi2.Location.X, sagkapi2.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat3()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi3.Location.X, sagkapi3.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat4()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi4.Location.X, sagkapi4.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat5()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi5.Location.X, sagkapi5.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat6()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi6.Location.X, sagkapi6.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat7()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi7.Location.X, sagkapi7.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat8()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi8.Location.X, sagkapi8.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat9()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi9.Location.X, sagkapi9.Location.Y);
            acikkapisag.Visible = true;
        }

        private void sagkat10()
        {
            acikkapisag.Visible = false;
            acikkapisag.Location = new Point(sagkapi10.Location.X, sagkapi10.Location.Y);
            acikkapisag.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}