using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_for_player
{
    public partial class Opening_form : Form
    {
        public Opening_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Match_result f2 = new Match_result();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queries f10 = new queries();
            f10.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Managers f45 = new Managers();
            f45.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Captain f88 = new Captain();
            f88.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Stadium f91 = new Stadium();
            f91.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Teams f11 = new Teams();
            f11.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            refs f35 = new refs();
            f35.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Table f12 = new Table();
            f12.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            League f14 = new League();
            f14.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coaches f17 = new Coaches();
            f17.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fixtures f76 = new Fixtures();
            f76.ShowDialog();
        }
    }
}
