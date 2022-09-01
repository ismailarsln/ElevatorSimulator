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
        List<int> sira = new List<int>(); //Ana kuyruk

        List<int> kuyruk1 = new List<int>(); //1. asansör için kuyruk.
        List<int> kuyruk2 = new List<int>(); //2. asansör için kuyruk.

        List<int> yedek1 = new List<int>(); //1. asansör için yedek kuyruk.
        List<int> yedek2 = new List<int>(); //2. asansör için yedek kuyruk.

        private int i = 1;  //Butonların değeri.

        public int anaKat = 1;
        public int araKat = 5;

        private void btn() //Katlardaki düğmelere basılınca..
        {
            sira.Add(i);
            siraguncelle();
        }

        private void sol() //1. asansör içerisindeki düğmeler basılınca..
        {
            kuyruk1.Add(i); //liste 1'e ekleme yapıyor.
            solKuyruk();    //liste 1 sıralaması yapılıyor.

            siraguncelle();       
        }

        private void sag() //2. asansör içerisindeki düğmeler basılınca..
        {
            kuyruk2.Add(i);
            sagKuyruk();

            siraguncelle();
        }

        private void siraguncelle()
        {
            controller();

            listBox1.Items.Clear(); //Listelerin güncel tutulması sağlanıyor.
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            foreach (int siradaki in sira)
            {
                listBox1.Items.Add(siradaki);
            }
            foreach (int siradaki in kuyruk1)
            {
                listBox2.Items.Add(siradaki);
            }
            foreach (int siradaki in kuyruk2)
            {
                listBox3.Items.Add(siradaki);
            }

            sira.Remove(i);
        }
    }
}