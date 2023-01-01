using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud_for_player
{
    public partial class Stadium : Form
    {
        public Stadium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Stadium(StadiumID,StadiumName,Capacity,City) VALUES (@StadiumID,@StadiumName,@Capacity,@City)", con);
            cmd.Parameters.AddWithValue("@StadiumID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@StadiumName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Capacity", textBox3.Text);
            cmd.Parameters.AddWithValue("@City", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Stadium Registered Successfully!");
        }
    }
}
