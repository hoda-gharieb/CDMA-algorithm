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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Gen_CLicked(object sender, EventArgs e)
        {
            if (bit_0.Text == "" || bit_1.Text == "" || this.Key.Text == "" || this.DataS.Text == "" || this.Signal.Text == "" )
            {
                MessageBox.Show("Error! Some boxes are empty");
                return;
            }
            string K = this.Key.Text;
            int Z = Int32.Parse(bit_0.Text), O = Int32.Parse(bit_1.Text), Ds = Int32.Parse(DataS.Text);
            List<string> S = Signal.Text.Split(',').ToList<string>();
            string sig = "";
            for (int i = 0; i < Ds; i++)
            {
                int idx = i * K.Length, sum = 0;
                for (int j = 0; j < K.Length; j++)
                {
                    int a = (K[j] == '0' ? Z : O);
                    a *= Int32.Parse(S[idx + j]);
                    sum += a;
                }
                if (sum < 0)
                    sig += (Z < 0 ? "0" : "1");
                else
                    sig += (Z > 0 ? "0" : "1");
            }
            this.OrSig.Text = sig;
        }
    }
}
