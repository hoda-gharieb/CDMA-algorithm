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
    public partial class Form1 : Form
    {
        private List<string> Keys = new List<string>();
        private List<string> Datas = new List<string>();
        private List< List<int> > Signals = new List< List<int> >();
        private List<int> Sum = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void NewClicked(object sender, EventArgs e)
        {
            this.KeyS.Text = "";
            this.Data.Text = "";
            this.signal.Text = "";
            this.summation.Text = "";
            Signals.Clear();
            Datas.Clear();
            Signals.Clear();
            Sum.Clear();
        }

        private void add_clicked(object sender, EventArgs e)
        {
            if (bit_0.Text == "" || bit_1.Text == "" || this.KeyS.Text == "" || this.Data.Text == "")
            {
                MessageBox.Show("Error! Some boxes are empty");
                return;
            }
            string K = this.KeyS.Text, D = this.Data.Text;
            int Z = Int32.Parse(bit_0.Text), O = Int32.Parse(bit_1.Text);
            List<int> L = new List<int>();
            for (int i = 0; i < D.Length; i++)
            {
                int b = (D[i] == '0' ? Z : O);
                for (int j = 0; j < K.Length; j++)
                {
                    int a = (K[j] == '0' ? Z : O);
                    L.Add(a * b);
                }
            }
            for (int i = 0; i < Math.Min(L.Count, Sum.Count); i++)
            {
                Sum[i] += L[i];
            }
            if (L.Count > Sum.Count)
            {
                for (int i = Sum.Count; i < L.Count; i++)
                    Sum.Add(L[i]);
            }
            Signals.Add(L);
            signal.Text = string.Join(", ", L);
            summation.Text = string.Join(", ", Sum);
        }

    }
}
