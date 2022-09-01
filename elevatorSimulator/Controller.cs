using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSimulator
{
    public partial class Form1
    {
        private void controller() //asansöre istek ile ilgili
        {
            if (!(sira.Count == 0)) //katlardaki düğmelere basıldığında
            {
                task();
            }
            else
            {
                if (kuyruk1.Count == 0) 
                { 
                    kuyruk1 = yedek1.ToList();
                    yedek1.Clear();
                    yedekBox1.Items.Clear();
                }

                if (kuyruk2.Count == 0)
                {
                    kuyruk2 = yedek2.ToList();
                    yedek2.Clear();
                    yedekBox2.Items.Clear();
                }

                if (kuyruk1.Count == 0) //asansör1 boşa çıktığında olacaklar
                {
                    t3.Start();
                }

                if (kuyruk2.Count == 0) //asansör2 boşa çıktığında olacaklar
                {
                    t4.Start();
                }
            }
        }
    }
}