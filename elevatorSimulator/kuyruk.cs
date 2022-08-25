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
            solkat(); //hareketi devam ettirecek:
        }
        private void sagKuyruk() //listeyi siralacayak..
        {
            if (kuyruk2[0] == kuyruk2[1]) //eşitse son verileri sil..
            {
                kuyruk2.RemoveAt(0);
            }

            //kuyruk2.Sort();
            sagkat();
        }
    }
}