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
        private int _KatTop1 = 0;
        private int _KatTop2 = 0;

        private void converter(string yazi) //Stringi metoda çevirme için metot.
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType
                .GetMethod(yazi, BindingFlags.NonPublic | BindingFlags.Instance);
            theMethod.Invoke(this, null);
        }

        private Timer t = new Timer();  //1. asansör için geçişlerde kullanılan süre.
        private Timer t2 = new Timer(); //2. asansör için geçişlerde kullanılan süre.
        private Timer t3 = new Timer(); //Asansör boşa çıktığında aradan geçen süre.
        private Timer t4 = new Timer(); //Asansör boşa çıktığında aradan geçen süre.

        public Form1()
        {
            InitializeComponent();

            kuyruk1.Add(araKat);
            kuyruk2.Add(anaKat);

            acikkapisol.Location = new Point(solkapi5.Location.X, solkapi5.Location.Y);
            acikkapisag.Location = new Point(sagkapi1.Location.X, sagkapi1.Location.Y);

            acikkapisol.Visible = true;
            acikkapisag.Visible = true;

            t.Interval = 5000;
            t.Tick += new EventHandler(t_Tick);

            t2.Interval = 5000;
            t2.Tick += new EventHandler(t2_Tick);

            t3.Interval = 15000;
            t3.Tick += new EventHandler(t3_Tick);

            t4.Interval = 15000;
            t4.Tick += new EventHandler(t4_Tick);
            
            t.Enabled = true;
            t2.Enabled = true;

            siraguncelle();
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (kuyruk1.Count > 0)
            {
                solkat();
                kuyruk1.RemoveAt(0);
                siraguncelle();
            }
        }

        void t2_Tick(object sender, EventArgs e)
        {
            if (kuyruk2.Count > 0)
            {
                sagkat();
                kuyruk2.RemoveAt(0);
                siraguncelle();
            }
        }

        void t3_Tick(object sender, EventArgs e)
        {
            kuyruk1.Add(araKat);
            t3.Stop();
        }

        void t4_Tick(object sender, EventArgs e)
        {
            kuyruk2.Add(anaKat);
            t4.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move1();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Move2();
        }

        private void Move1()
        {
            int yon = 0;

            if (acikkapisol.Top > _KatTop1)
                yon = -1;
            else if (acikkapisol.Top < _KatTop1)
                yon = 1;

            if (yon != 0)
            {
                if (yon == -1)
                {
                    if (acikkapisol.Top + 10 * yon <= _KatTop1)
                    {
                        acikkapisol.Top = _KatTop1;
                        timer1.Enabled = false;
                    }
                    else
                    {
                        timer1.Enabled = true;
                        acikkapisol.Top = acikkapisol.Top + 10 * yon;
                    }
                }
                else if (yon == 1)
                {
                    if (acikkapisol.Top + 10 * yon >= _KatTop1)
                    {
                        acikkapisol.Top = _KatTop1;
                        timer1.Enabled = false;
                    }
                    else
                    {
                        timer1.Enabled = true;
                        acikkapisol.Top = acikkapisol.Top + 10 * yon;
                    }
                }
            }
        }
        private void Move2()
        {
            int yon = 0;

            if (acikkapisag.Top > _KatTop2)
                yon = -1;
            else if (acikkapisag.Top < _KatTop2)
                yon = 1;

            if (yon != 0)
            {
                if (yon == -1)
                {
                    if (acikkapisag.Top + 10 * yon <= _KatTop2)
                    {
                        acikkapisag.Top = _KatTop2;
                        timer2.Enabled = false;
                    }
                    else
                    {
                        timer2.Enabled = true;
                        acikkapisag.Top = acikkapisag.Top + 10 * yon;
                    }
                }
                else if (yon == 1)
                {
                    if (acikkapisag.Top + 10 * yon >= _KatTop2)
                    {
                        acikkapisag.Top = _KatTop2;
                        timer2.Enabled = false;
                    }
                    else
                    {
                        timer2.Enabled = true;
                        acikkapisag.Top = acikkapisag.Top + 10 * yon;
                    }
                }
            }
        }

        private void solkat0()
        {
            _KatTop1 = solkapi0.Top;
            Move1();
        }
        private void solkat1()
        {
            _KatTop1 = solkapi1.Top;
            Move1();
        }
        private void solkat2()
        {
            _KatTop1 = solkapi2.Top;
            Move1();
        }

        private void solkat3()
        {
            _KatTop1 = solkapi3.Top;
            Move1();
        }

        private void solkat4()
        {
            _KatTop1 = solkapi4.Top;
            Move1();
        }

        private void solkat5()
        {
            _KatTop1 = solkapi5.Top;
            Move1();
        }

        private void solkat6()
        {
            _KatTop1 = solkapi6.Top;
            Move1();
        }

        private void solkat7()
        {
            _KatTop1 = solkapi7.Top;
            Move1();
        }

        private void solkat8()
        {
            _KatTop1 = solkapi8.Top;
            Move1();
        }

        private void solkat9()
        {
            _KatTop1 = solkapi9.Top;
            Move1();
        }

        private void solkat10()
        {
            _KatTop1 = solkapi10.Top;
            Move1();
        }

        private void sagkat0()
        {
            _KatTop2 = sagkapi0.Top;
            Move2();
        }
        private void sagkat1()
        {
            _KatTop2 = sagkapi1.Top;
            Move2();
        }
        private void sagkat2()
        {
            _KatTop2 = sagkapi2.Top;
            Move2();
        }

        private void sagkat3()
        {
            _KatTop2 = sagkapi3.Top;
            Move2();
        }

        private void sagkat4()
        {
            _KatTop2 = sagkapi4.Top;
            Move2();
        }

        private void sagkat5()
        {
            _KatTop2 = sagkapi5.Top;
            Move2();
        }

        private void sagkat6()
        {
            _KatTop2 = sagkapi6.Top;
            Move2();
        }

        private void sagkat7()
        {
            _KatTop2 = sagkapi7.Top;
            Move2();
        }

        private void sagkat8()
        {
            _KatTop2 = sagkapi8.Top;
            Move2();
        }

        private void sagkat9()
        {
            _KatTop2 = sagkapi9.Top;
            Move2();
        }

        private void sagkat10()
        {
            _KatTop2 = sagkapi10.Top;
            Move2();
        }
    }
}