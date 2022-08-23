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
        private void task()  //katlardaki düğmelere basıldıında gelen sıralama metotu.
        {
            int k = sira[0];

            if (k % 2 == 0) //çift sayı ise 1. asansörü çağır
            {
                kuyruk1.Add(k);
            }
            else //tek sayı ise 2. asansörü çağır
            {
                kuyruk2.Add(k);
            }

            kuyruk();
        }
    }
}