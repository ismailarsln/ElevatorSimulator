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
        int degismez = 0;

        private void solKuyruk() //listeyi siralacayak.
        {
            t3.Stop();

            if (kuyruk1.Count > 1)
            {

                if (kuyruk1[kuyruk1.Count - 1] == kuyruk1[kuyruk1.Count - 2]) //eşitse son verileri sil.
                {
                    kuyruk1.RemoveAt(kuyruk1.Count - 1);
                }
            }

            if (kuyruk1.Count > 2)
            {
                if (kuyruk1[0] < kuyruk1[1])
                {

                    if (degismez == 0)
                    {
                        degismez = kuyruk1[0];
                        if (kuyruk1[kuyruk1.Count - 1] < degismez)
                        {
                            yedek1.Add(i);
                            kuyruk1.RemoveAt(kuyruk1.Count - 1);
                        }
                    }
                    else
                    {
                        if (kuyruk1[kuyruk1.Count - 1] < degismez)
                        {
                            yedek1.Add(i);
                            kuyruk1.RemoveAt(kuyruk1.Count - 1);
                        }
                        else
                        {
                            degismez = 0;
                        }
                    }
                    kuyruk1.Sort();
                }

                else if (kuyruk1[0] > kuyruk1[1])
                {
                    if (degismez == 0)
                    {
                        degismez = kuyruk1[0];
                        if (kuyruk1[kuyruk1.Count - 1] > degismez)
                        {
                            yedek1.Add(i);
                            kuyruk1.RemoveAt(kuyruk1.Count - 1);
                        }
                    }
                    else
                    {
                        if (kuyruk1[kuyruk1.Count - 1] > degismez)
                        {
                            yedek1.Add(i);
                            kuyruk1.RemoveAt(kuyruk1.Count - 1);
                        }
                        else
                        {
                            degismez = 0;
                        }
                    }
                    
                    kuyruk1.Sort();
                    kuyruk1.Reverse();
                }

                kuyruk1 = kuyruk1.Distinct().ToList();
            }

            yedek1 = yedek1.Distinct().ToList();
            yedek1.Sort();

            yedekBox1.Items.Clear();
            foreach (int siradaki in yedek1)
            {
                yedekBox1.Items.Add(siradaki);
            }
        }


        private void sagKuyruk()
        {
            t4.Stop();

            if (kuyruk2.Count > 1)
            {
                if (kuyruk2[kuyruk2.Count - 1] == kuyruk2[kuyruk2.Count - 2]) //eşitse son verileri sil..
                {
                    kuyruk2.RemoveAt(kuyruk2.Count - 1);
                }
            }

            if (kuyruk2.Count > 2)
            {
                if (kuyruk2[0] < kuyruk2[1])
                {

                    if (degismez == 0)
                    {
                        degismez = kuyruk2[0];
                        if (kuyruk2[kuyruk2.Count - 1] < degismez)
                        {
                            yedek2.Add(i);
                            kuyruk2.RemoveAt(kuyruk2.Count - 1);
                        }
                    }
                    else
                    {
                        if (kuyruk2[kuyruk2.Count - 1] < degismez)
                        {
                            yedek2.Add(i);
                            kuyruk2.RemoveAt(kuyruk2.Count - 1);
                        }
                        else
                        {
                            degismez = 0;
                        }
                    }
                    kuyruk2.Sort();
                }

                else if (kuyruk2[0] > kuyruk2[1])
                {
                    if (degismez == 0)
                    {
                        degismez = kuyruk2[1];
                        if (kuyruk2[kuyruk2.Count - 1] > degismez)
                        {
                            yedek2.Add(i);
                            kuyruk2.RemoveAt(kuyruk2.Count - 1);
                        }
                    }
                    else
                    {
                        if (kuyruk2[kuyruk2.Count - 1] > degismez)
                        {
                            yedek2.Add(i);
                            kuyruk2.RemoveAt(kuyruk2.Count - 1);
                        }
                        else
                        {
                            degismez = 0;
                        }
                    }

                    kuyruk2.Sort();
                    kuyruk2.Reverse();
                }

                kuyruk2 = kuyruk2.Distinct().ToList();
            }

            yedek2 = yedek2.Distinct().ToList();
            yedek2.Sort();

            yedekBox2.Items.Clear();
            foreach (int siradaki in yedek2)
            {
                yedekBox2.Items.Add(siradaki);
            }
        }
    }
}