using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            int[] ints = new int[3];
         
            ints[0] = (int)numericUpDown1.Value;
            ints[1] = (int)numericUpDown2.Value;
            ints[2] = (int)numericUpDown3.Value;
         
            MessageBox.Show("Summan är " + sum(ints));
           
        }

        private int sum(int[] intarray)
        {
            
            int sum = 0;
            for ( int i = 0; i < intarray.Length; i++)
            {
               sum = sum + intarray[i];
            
            }
          
    
            return sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_huj1(object sender, EventArgs e)
        {

        }
    }
}
