using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (kuyruk1[kuyruk1.Count - 1] == kuyruk1[kuyruk1.Count-2]) //eşitse son verileri sil..
            {
               kuyruk1.RemoveAt(kuyruk1.Count - 1);
            }
        }

        private void sagKuyruk()
        {
            if (kuyruk2[kuyruk2.Count - 1] == kuyruk2[kuyruk2.Count - 2])
            {
                kuyruk2.RemoveAt(kuyruk2.Count - 1);
            }
        }
    }
}