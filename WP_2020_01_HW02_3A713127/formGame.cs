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
            Random deck = new Random;
            int index;
        }

        private void formGame_Load(object sender, EventArgs e)
        {
            
        }
    }
}
