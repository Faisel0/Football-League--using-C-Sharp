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
    public partial class Fixtures : Form
    {
        public Fixtures()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Fixtures(HomeTeam,AwayTeam,Gameweek) VALUES (@HomeTeam,@AwayTeam,@Gameweek)", con);
            cmd.Parameters.AddWithValue("@HomeTeam", textBox1.Text);
            cmd.Parameters.AddWithValue("@AwayTeam", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gameweek", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";


            MessageBox.Show("Fixture saved Successfully!");
        }
    }
}
