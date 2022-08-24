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
        private void solKuyruk() //listeyi siralacayak..
        {
            if (kuyruk1[0] == kuyruk1[1]) //eşitse son verileri sil..
            { 
                kuyruk1.RemoveAt(0);
            }
            solkat();
        }

        private void sagKuyruk()
        {
            if (kuyruk2[0] == kuyruk2[1])
            {
                kuyruk2.RemoveAt(0);
            }
            sagkat();
        }
    }
}