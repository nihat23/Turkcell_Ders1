using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turkcell_Ders1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDizi1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 25, 36, 25, 96, 48, 75, 36, 95, 458, 321, 256, 385, 74, 11, 20, 369 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void btnDizi2_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Adana", "mersin", "istanbul", "ankara", "malatya", "diyarbakır","Elazıg" };
            foreach (var item in sehirler)
            {
               
                listBox1.Items.Add(item);
            }
        }
    }
}
