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
        private void controller() //asansöre istek gelmezse:00000
        {
            if (!(sira.Count == 0)) //katlardaki düğmelere basıldığında
            {
                task();
            }
            else
            {
                if (kuyruk1.Count == 0) //asansör1 boşa çıktığında olacaklar
                {
                    kuyruk1.Add(araKat);
                }
                if (kuyruk2.Count == 0) //asansör2 boşa çıktığında olacaklar
                {
                    kuyruk2.Add(anaKat);
                }
            }
        }
    }
}