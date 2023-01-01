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
    public partial class Match_result : Form
    {
        public Match_result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Matchresult(Matchweek,Goalscorers,RefID,Result,HomeTeam,AwayTeam,TeamID) VALUES (@Matchweek,@Goalscorers,@RefID,@Result,@HomeTeam,@AwayTeam,@TeamID)", con);
            cmd.Parameters.AddWithValue("@Matchweek", textBox1.Text);
            cmd.Parameters.AddWithValue("@Goalscorers", textBox2.Text);
            cmd.Parameters.AddWithValue("@RefID", textBox3.Text);
            cmd.Parameters.AddWithValue("@Result", textBox4.Text);
            cmd.Parameters.AddWithValue("@HomeTeam",textBox5.Text);
            cmd.Parameters.AddWithValue("@AwayTeam", textBox6.Text);
            cmd.Parameters.AddWithValue("@TeamID", textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";



            MessageBox.Show("Match Recorded Successfully!");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Matchresult SET Goalscorers=@Goalscorers, RefID=@RefID, Result=@Result , HomeTeam=@HomeTeam, AwayTeam=@AwayTeam ,TeamID=@TeamID WHERE Matchweek=@Matchweek", con);
            cmd.Parameters.AddWithValue("@Matchweek", textBox1.Text);
            cmd.Parameters.AddWithValue("@Goalscorers", textBox2.Text);
            cmd.Parameters.AddWithValue("@RefID", textBox3.Text);
            cmd.Parameters.AddWithValue("@Result", textBox4.Text);
            cmd.Parameters.AddWithValue("@HomeTeam", textBox5.Text);
            cmd.Parameters.AddWithValue("@AwayTeam", textBox6.Text);
            cmd.Parameters.AddWithValue("@TeamID", textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            MessageBox.Show("Match Recorded Updated Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE dbo.Matchresult WHERE Matchweek=@Matchweek", con);
            cmd.Parameters.AddWithValue("@Matchweek", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            MessageBox.Show("Matchresult Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Matchresult WHERE Matchweek=@Matchweek", con);
            cmd.Parameters.AddWithValue("@Matchweek", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Match_result_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Matchresult", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Opening_form f3 = new Opening_form();
            f3.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
