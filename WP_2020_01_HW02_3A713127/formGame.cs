﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713127.Properties;

namespace WP_2020_01_HW02_3A713127
{
    public partial class formGame : Form
    {
        List<Image> list = new List<Image>();
        
        public formGame()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Random deck = new Random();
            pb1.Image = list[deck.Next(0,52)];
        }

        private void formGame_Load(object sender, EventArgs e)
        {
            list.Add(Resources._1);
            list.Add(Resources._2);
            list.Add(Resources._3);
            list.Add(Resources._4);
            list.Add(Resources._5);
            list.Add(Resources._6);
            list.Add(Resources._7);
            list.Add(Resources._8);
            list.Add(Resources._9);
            list.Add(Resources._10);
            list.Add(Resources._11);
            list.Add(Resources._12);
            list.Add(Resources._13);
            list.Add(Resources._14);
            list.Add(Resources._15);
            list.Add(Resources._16);
            list.Add(Resources._17);
            list.Add(Resources._18);
            list.Add(Resources._19);
            list.Add(Resources._20);
            list.Add(Resources._21);
            list.Add(Resources._22);
            list.Add(Resources._23);
            list.Add(Resources._24);
            list.Add(Resources._25);
            list.Add(Resources._26);
            list.Add(Resources._27);
            list.Add(Resources._28);
            list.Add(Resources._29);
            list.Add(Resources._30);
            list.Add(Resources._31);
            list.Add(Resources._32);
            list.Add(Resources._33);
            list.Add(Resources._34);
            list.Add(Resources._35);
            list.Add(Resources._36);
            list.Add(Resources._37);
            list.Add(Resources._38);
            list.Add(Resources._39);
            list.Add(Resources._40);
            list.Add(Resources._41);
            list.Add(Resources._42);
            list.Add(Resources._43);
            list.Add(Resources._44);
            list.Add(Resources._45);
            list.Add(Resources._46);
            list.Add(Resources._47);
            list.Add(Resources._48);
            list.Add(Resources._49);
            list.Add(Resources._50);
            list.Add(Resources._51);
            list.Add(Resources._52);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
