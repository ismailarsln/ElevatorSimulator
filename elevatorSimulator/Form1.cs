﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            siraguncelle();
        }

        List<int> sira = new List<int>(); //tüm kuyruklar
        List<int> kuyruk1 = new List<int>(); //1. asansör için kuyruk
        List<int> kuyruk2 = new List<int>(); //2. asansör için kuyruk

        private int i = 0;
        private int anaKat = 0;
        private int araKat = 5;

        private void btn() //katlardaki düğmelere basılınca
        {
            sira.Add(i);

            listBox1.Items.Clear();

            foreach (int siradaki in sira)
            {
                listBox1.Items.Add(siradaki);
            }
            siraguncelle();
        }

        private void sol() //1. asansor içerisindeki düğmeler basılınca
        {
            kuyruk1.Add(i);

            siraguncelle();
        }

        private void sag() //2. asansör içerisindeki düğmeler basılınca
        {
            kuyruk2.Add(i);

            siraguncelle();
        }

        private void siraguncelle()
        {
            controller();

            listBox2.Items.Clear();
            listBox3.Items.Clear();

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