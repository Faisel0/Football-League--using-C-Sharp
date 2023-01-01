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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Opening_form f19 = new Opening_form();
            f19.ShowDialog();
        }
    }
}
