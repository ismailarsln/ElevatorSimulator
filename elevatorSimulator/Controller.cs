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
        private void controller()
        {
            if (!(sira.Count == 0))
            {
                int k = sira[0];

                kuyruk1.Add(k);

                task();
            }
            if (kuyruk1.Count == 0) //asansör1 boşa çıktığında uyarı gelecek.
            {
                kuyruk1.Add(araKat);
            }
            if (kuyruk2.Count == 0) //asansör2 boşa çıktığında uyarı gelecek.
            {
                kuyruk2.Add(anaKat);
            }
        }
    }
}