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
        private void task()  //ara katlardaki düğmelere basıldığında çalışacak metot
        {
            int k = sira[0];

            if (k % 2 == 0) //çift sayı ise 1. asansörü çağır
            {
                kuyruk1.Insert(0, k);

                if (kuyruk1[0] == kuyruk1[1]) //eşitse son verileri sil..
                {
                    kuyruk1.RemoveAt(0);
                }

                string slkt = "solkat".ToString() + k;
                converter(slkt);
            }

            else //tek sayı ise 2. asansörü çağır
            {
                kuyruk2.Insert(0, k);

                if (kuyruk2[0] == kuyruk2[1])
                {
                    kuyruk2.RemoveAt(0);
                }

                string sgkt = "sagkat".ToString() + k;
                converter(sgkt);
            }
        }
    }
}