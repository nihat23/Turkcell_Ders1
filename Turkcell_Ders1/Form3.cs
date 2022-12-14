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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string kullanici; // p izin verecez..
        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = kullanici;
        }
    }
}
