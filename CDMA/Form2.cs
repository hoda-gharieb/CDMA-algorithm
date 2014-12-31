using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CDMA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Sen_clicked(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.ShowDialog();
        }

        private void Rec_clicked(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.ShowDialog();
        }
    }
}
