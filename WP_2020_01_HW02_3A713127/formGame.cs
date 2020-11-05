using System;
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

        private void lab1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Random deck =new Random();
            int index = deck.Next(0, 10);
            pb1.Image = list[index];
            pb2.Image = list[index];
            pb3.Image = list[index];
            pb4.Image = list[index];
            pb5.Image = list[index];
            while (pb1.Image == pb2.Image)
            {
                pb2.Image = list[index];
            }
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
        }
    }
}
