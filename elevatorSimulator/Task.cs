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

            if (kuyruk1.Count > 1 && kuyruk2.Count < 2) //4. durum, 7. durum
            {
                int k1 = kuyruk1[kuyruk1.Count - 2]; //ilk eleman
                int k2 = kuyruk1[kuyruk1.Count - 1]; //son eleman

                if (k1 < k2) //1.asansör yukari çıktığı durumda
                {
                    if (kuyruk1[0] < k) 
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                    else
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                }
                else if(k1 > k2)
                {
                    if (kuyruk1[0] > k)
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                    else
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                }
            }

            if (kuyruk1.Count < 2 && kuyruk2.Count > 1) //2. durum, 3. durum
            {
                int k1 = kuyruk2[kuyruk2.Count - 2]; //ilk eleman
                int k2 = kuyruk2[kuyruk2.Count - 1]; //son eleman

                if (k1 < k2) //2.asansör yukari çıktığı durumda
                {
                    if (kuyruk2[0] < k)
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                    else
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                }
                else if (k1 > k2) //aşağı indiğinde
                {
                    if (kuyruk2[0] > k)
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                    else
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                }
            }

            if (kuyruk1.Count < 2 && kuyruk2.Count < 2) //2 asansör de bekleme konumunundaysa yakın olanın çağrılması
            {
                int k1 = kuyruk1[kuyruk1.Count - 1]; //1. son elemanı
                int k2 = kuyruk2[kuyruk2.Count - 1]; //2. son elemanı

                if(k < k1 && k < k2)
                {
                    if(k2 < k1)
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                    else
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                }
                if (k > k1 && k > k2)
                {
                    if (k2 < k1)
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                    else
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                }
                if (k < k1 && k > k2)
                {
                    int k3 = k1 - k;
                    int k4 = k - k2;

                    if(k3 < k4)
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                    else
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                }
                if (k > k1 && k < k2)
                {
                    int k3 = k - k1;
                    int k4 = k2 - k;

                    if (k3 < k4)
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                    else
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                }

            }

            if (kuyruk1.Count > 1 && kuyruk2.Count > 1)
            {
                int k1 = kuyruk1[0]; //ilk eleman
                int k2 = kuyruk1[1]; //son eleman

                int k3 = kuyruk2[0]; //ilk eleman
                int k4 = kuyruk2[1]; //son eleman

                int k5 = kuyruk1[kuyruk1.Count - 1]; //son eleman
                int k6 = kuyruk2[kuyruk2.Count - 1]; //son eleman

                if (k1 < k2 && k3 < k4) //2 asansör de yukari çıktığı durumda (5. durum)
                {
                    if(k1 < k && k3 < k) //1. durum
                    {
                        if(k1 < k3)
                        {
                            kuyruk2.Add(k);
                            sagKuyruk();
                        }
                        else
                        {
                            kuyruk1.Add(k);
                            solKuyruk();
                        }
                    }
                    if (k1 > k && k3 > k) //2. durum
                    {
                        if (k5 < k6)
                        {
                            kuyruk1.Add(k);
                            solKuyruk();
                        }
                        else
                        {
                            kuyruk2.Add(k);
                            sagKuyruk();
                        }
                    }
                    if (k1 < k && k < k3) //3. durum
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                    if (k1 > k && k > k3) //4. durum
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                }


                if (k1 > k2 && k3 > k4) //2 asansör de aşağı indiği durumda (9. durum)
                {
                    if (k1 < k && k3 < k) //1. durum
                    {
                        if (k5 < k6)
                        {
                            kuyruk2.Add(k);
                            sagKuyruk();
                        }
                        else
                        {
                            kuyruk1.Add(k);
                            solKuyruk();
                        }
                    }
                    if (k1 > k && k3 > k) //2. durum
                    {
                        if (k1 < k3)
                        {
                            kuyruk1.Add(k);
                            solKuyruk();
                        }
                        else
                        {
                            kuyruk2.Add(k);
                            sagKuyruk();
                        }
                    }
                    if (k1 < k && k < k3) //3. durum
                    {
                        kuyruk2.Add(k);
                        sagKuyruk();
                    }
                    if (k1 > k && k > k3) //4. durum
                    {
                        kuyruk1.Add(k);
                        solKuyruk();
                    }
                }

                if (k1 < k2 && k3 > k4)
                {

                }
            }
        }
    }
}