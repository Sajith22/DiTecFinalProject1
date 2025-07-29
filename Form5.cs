using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiTecFinalProject1
{
    public partial class Frmtech : Form
    {
        public Frmtech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmcop cop = new Frmcop();
            cop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logistic Management Teacher", "Teacher1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCor Cor = new FrmCor();
            Cor.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auto-Mobile Teacher","Teacher2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Healthcare Teacher", "Teacher4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CAD Teacher", "Teacher6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soft Skills and Information Technology Teacher", "Teacher3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTERPRENEUR and Management Teacher", "Teacher5");
        }

        private void Frmtech_Load(object sender, EventArgs e)
        {

        }
    }
}
