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

            if (kuyruk1.Count > 1)
            {
                int k1 = kuyruk1[kuyruk1.Count - 2]; //ilk eleman
                int k2 = kuyruk1[kuyruk1.Count - 1]; //son eleman

                if (k1 < k2) //yukari çıktığı durumda
                {
                    kuyruk1.Add(k);
                    solKuyruk();
                }
                else if (k2 < k1)
                {
                    kuyruk2.Add(k);
                    sagKuyruk();
                }
            }
        }
    }
}