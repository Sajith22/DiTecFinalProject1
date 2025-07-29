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
    public partial class Frmpay : Form
    {
        public Frmpay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmcop cop = new Frmcop();
            cop.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Frmpay_Load(object sender, EventArgs e)
        {

        }
    }
}
