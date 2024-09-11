using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace wfwf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0.0;
            double b = 1;
            int count = 0;
            double.TryParse(textBox1.Text, out a);
            textBox1.Text = a.ToString();
            for(int i = 0;i<a;i++)
            {
                a -= b;
                count++;
                b += 2;
                if(a<=0)
                {
                    textBox2.Text =count.ToString();
                }
            }

        }
    }
}

