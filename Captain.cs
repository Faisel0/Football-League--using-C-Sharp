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
    public partial class Captain : Form
    {
        public Captain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Captaincy(Playername,Squadnumber,DurationOfService,PlayerID) VALUES (@Playername,@Squadnumber,@DurationOfService,@PlayerID)", con);
            cmd.Parameters.AddWithValue("@Playername",textBox1.Text);
            cmd.Parameters.AddWithValue("@Squadnumber", textBox2.Text);
            cmd.Parameters.AddWithValue("@DurationOfService", textBox3.Text);
            cmd.Parameters.AddWithValue("@PlayerID", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Captain Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Captaincy SET PlayerName=@PlayerName, Squadnumber=@Squadnumber, DurationOfService=@DurationOfService ,PlayerID=@PlayerID WHERE PlayerID=@PlayerID", con);
            cmd.Parameters.AddWithValue("@Playername", textBox1.Text);
            cmd.Parameters.AddWithValue("@Squadnumber", textBox2.Text);
            cmd.Parameters.AddWithValue("@DurationOfService", textBox3.Text);
            cmd.Parameters.AddWithValue("@PlayerID", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Captain Updated Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE dbo.Captaincy WHERE PlayerID=@PlayerID", con);
            cmd.Parameters.AddWithValue("@PlayerID", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Captain_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Captaincy", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
