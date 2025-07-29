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
    public partial class Frmcop : Form
    {
        public Frmcop()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHelp Help = new FrmHelp();
            Help.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmlog log = new Frmlog();
            log.ShowDialog();
        }

        private void Frmcop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCor cor = new FrmCor();
            cor.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmtech tech = new Frmtech();
            tech.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmpay pay = new Frmpay();
            pay.ShowDialog();
        }
    }
}
