using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_30_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            do
            {
               richTextBox1.Text=richTextBox1.Text+sayi.ToString();
                sayi++;
                while (sayi > 30) ;
            } 
        }
    }
}
