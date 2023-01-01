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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;

            user = txtuser.Text;
            pass = txtpass.Text;
            if (user == "Faisel" && pass == "123")
             
                {
                MessageBox.Show("Successful logged in!");
                this.Hide();
                Message f19 = new Message();
                f19.Show();
            }
            }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }

