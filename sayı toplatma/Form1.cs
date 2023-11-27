using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayı_toplatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayac = 0;
            for(int i= sayac; i < 20;i++)
            {
                
                listBox1.Items.Add(i);
                sayac++;
                MessageBox.Show(sayac.ToString());
            }
        }
    }
}
