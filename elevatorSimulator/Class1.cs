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
        //listeleri oluşturuyoruz:
        List<int> sira = new List<int>(); //tüm kuyruklar
        List<int> kuyruk1 = new List<int>(); //1. asansör için kuyruk
        List<int> kuyruk2 = new List<int>(); //2. asansör için kuyruk

        //ilk değerleri veriyoruz:
        private int i = 0;      //butonların değeri
        public int anaKat = 0;
        public int araKat = 5;

        private void btn() //arakat düğmelerine basılınca calisacak
        {
            sira.Add(i); //sira listesine basılan buton değerini alır

            listBox1.Items.Clear(); // temizleme işlemi:

            foreach (int siradaki in sira) //ara kat listesine sirayı yazdırmak:
            {
                listBox1.Items.Add(siradaki);
            }
            siraguncelle(); //listelerin güncel tutulmasını sağlayan fonksiyonu çağırıyoruzki liste dolmasın:
        }

        private void sol() //1. asansor içerisindeki düğmeler basılınca
        {
            kuyruk1.Insert(0, i); //kuyruk1e i değerini ekle
            siraguncelle(); //sırayı güncelle
            solKuyruk(); //iki kez aynı işlemi almayacak:
        }

        private void sag() //2. asansör içerisindeki düğmeler basılınca
        {
            kuyruk2.Insert(0, i); //kuyruktaki i değerini ikinci asansöre atacak:
            siraguncelle();
            sagKuyruk(); // iki kez aynı değişkeni almayacak:
        }

        private void siraguncelle() //listelerin güncelleme işlemi:
        {
            controller(); //asansöre istek gelme ve gelmeme durumu:

            listBox2.Items.Clear(); //güncel tutulması sağlanıyor..
            listBox3.Items.Clear();

            //kuyruklara siradaki değerleri yazdırıyoruz:
            foreach (int siradaki in kuyruk1)
            {
                listBox2.Items.Add(siradaki);
            }
            foreach (int siradaki in kuyruk2)
            {
                listBox3.Items.Add(siradaki);
            }

            sira.Remove(i); //sira kuyruğunu temizliyoruz:
        }
    }
}