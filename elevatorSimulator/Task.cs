using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSimulator
{
    public partial class Form1
    {
        private void task() //ara katlardaki düğmelere basıldığında çalışacak metot
        {
            int k = sira[0];

            if (k % 2 == 0) //çift sayı ise 1. asansörü çağır
            {
                kuyruk1.Add(k);

                if (kuyruk1[kuyruk1.Count - 1] == kuyruk1[kuyruk1.Count - 2]) //eşitse son verileri sil..
                {
                    kuyruk1.RemoveAt(kuyruk1.Count - 1);
                }
            }

            else //tek sayı ise 2. asansörü çağır
            {
                kuyruk2.Add(k);

                if (kuyruk2[kuyruk2.Count - 1] == kuyruk2[kuyruk2.Count - 2])
                {
                    kuyruk2.RemoveAt(kuyruk2.Count - 1);
                }
            }
        }
    }
}