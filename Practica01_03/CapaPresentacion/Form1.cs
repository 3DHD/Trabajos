using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            textBox.Text = "0";
            textBox2.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a =int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
            label3.Text = r.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox2.Text = "";
            label3.Text = "Resultado";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            label3.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            label3.Text = r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox.Text);
            b = int.Parse(textBox2.Text);
            r = a / b;
            label3.Text = r.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
