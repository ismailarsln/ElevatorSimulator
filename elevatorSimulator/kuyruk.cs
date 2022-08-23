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
        private void kuyruk() //burada hareket ettireceğiz...
        {
            if (kuyruk1[i] == i)
            {
                kuyruk1.Remove(i);

                siraguncelle();
            }
        }
    }
}