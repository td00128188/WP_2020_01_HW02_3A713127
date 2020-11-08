using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713127.Properties;

namespace WP_2020_01_HW02_3A713127
{
    public partial class formGame : Form
    {
        List<Image> list = new List<Image>();
        int[] Poker = new int[52];
        int aa = 0;
        int overaa = 0;
        string t = "";
        string x = "沒牌是要抽三小\r\n";
        public formGame()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            rtb1.Text = null;
            aa = 0;
            overaa = 0;
            t = "";
            pb2.Image = list[52];
            pb1.Image = list[53];
            Random deck = new Random();
            for (int i = 0; i < 52; i++)
            { 
                Poker[i] = deck.Next(0, 52);
                for (int j= 0; j < i; j++)
                {
                    while(Poker[j] == Poker[i])
                    {
                        j = 0;
                        Poker[i] = deck.Next(0, 52);
                    }
                }
            }          
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            int a = aa + 1;
            int b = (Poker[aa] + 1) % 13;
            int c = (Poker[aa] + 1) / 13;
            pb1.Image = list[Poker[aa]];
            if(overaa == 0)
            {
                if (c == 0)
                {
                    t = t + a + ". 黑桃 " + b + "\r\n";
                    rtb1.Text = t;
                }
                else if (c == 1)
                {
                    if (b == 0)
                    {
                        t = t + a + ". 黑桃 13\r\n";
                        rtb1.Text = t;
                    }

                    else
                    {
                        t = t + a + ". 愛心 " + b + "\r\n";
                        rtb1.Text = t;
                    }
                }
                else if (c == 2)
                {
                    if (b == 0)
                    {
                        t = t + a + ". 愛心 13\r\n";
                        rtb1.Text = t;
                    }
                    else
                    {
                        t = t + a + ". 方塊 " + b + "\r\n";
                        rtb1.Text = t;
                    }
                }
                else if (c == 3)
                {
                    if (b == 0)
                    {
                        t = t + a + ". 方塊 13 \r\n";
                        rtb1.Text = t;
                    }
                    else
                    {
                        t = t + a + ". 梅花 " + b + "\r\n";
                        rtb1.Text = t;
                    }
                }
                else if (c == 4)
                {
                    t = t + a + ". 梅花 13\r\n";
                    rtb1.Text = t;
                }
                if (aa + 1 < 52)
                {
                    Poker[aa] = Poker[aa + 1];
                    aa = aa + 1;
                }
                else if (aa + 1 == 52)
                {
                    rtb1.Text = t;
                    pb2.Image = list[53];
                    overaa = 1;
                }                
            }
            else
            {
                t = x;
                x = x+"沒牌是要抽三小\r\n";
                rtb1.Text = t;
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
            list.Add(Resources._00);
            list.Add(Resources.NO);
            list.Add(Resources.設計稿);

            Random deck = new Random();
            for (int i = 0; i < 52; i++)
            {
                Poker[i] = deck.Next(0, 52);
                for (int j = 0; j < i; j++)
                {
                    while (Poker[j] == Poker[i])
                    {
                        j = 0;
                        Poker[i] = deck.Next(0, 52);
                    }
                }
            }
            pb2.Image = list[52];
            pb1.Image = list[53];
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb3.Image = list[54];
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            pb3.Image = null;
        }
    }
}
