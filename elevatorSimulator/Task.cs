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
        private void converter(string yazi)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType
                .GetMethod(yazi, BindingFlags.NonPublic | BindingFlags.Instance);
            theMethod.Invoke(this, null);
        }

        private void task()  //katlardaki düğmelere basıldığında gelen sıralama metodu.
        {
            int k = sira[0];

            if (k % 2 == 0) //çift sayı ise 1. asansörü çağır
            {
                kuyruk1.Add(k);

                string kk = "solkat".ToString() + k;
                converter(kk);
            }
            else //tek sayı ise 2. asansörü çağır
            {
                kuyruk2.Add(k);

                string kk = "sagkat".ToString() + k;
                converter(kk);
            }

            kuyruk();
        }
    }
}