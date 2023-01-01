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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Table(Teamname,Pointspergame) VALUES (@Teamname,@Pointspergam)", con);
            cmd.Parameters.AddWithValue("@Teamname", textBox1.Text);
            cmd.Parameters.AddWithValue("@Pointspergame", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
           

            MessageBox.Show("Points saved  Successfully!");
        }
    }
}
