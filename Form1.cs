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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool invalid = this.Controls.OfType<TextBox>()
    .Where(t => t.Visible)
    .Any(t => string.IsNullOrWhiteSpace(textBox1.Text));
            if (invalid)
                MessageBox.Show("Please Fill in all Fields");

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Player(PlayerID,PlayerName,Position,Age,Salary,TeamID) VALUES (@PlayerID,@PlayerName,@Position,@Age,@Salary,@TeamID)", con);
            cmd.Parameters.AddWithValue("@PlayerID",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PlayerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Position", textBox3.Text);
            cmd.Parameters.AddWithValue("@Age", textBox4.Text);
            cmd.Parameters.AddWithValue("@Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@TeamID", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Player Registered Successfully!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Player SET PlayerName=@PlayerName, Position=@Position, Age=@Age , Salary=@Salary ,TeamID=@TeamID WHERE PlayerID=@PlayerID", con);
            cmd.Parameters.AddWithValue("@PlayerID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PlayerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Position", textBox3.Text);
            cmd.Parameters.AddWithValue("@Age", textBox4.Text);
            cmd.Parameters.AddWithValue("@Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@TeamID", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


            MessageBox.Show("Player Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE dbo.Player WHERE PlayerID=@PlayerID", con);
            cmd.Parameters.AddWithValue("@PlayerID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Player Deleted");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Player", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4U86HTD\SQLEXPRESS;Initial Catalog=PLAYER_TABLE;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Player WHERE PlayerID=@PlayerID", con);
            cmd.Parameters.AddWithValue("@PlayerID", int.Parse(textBox1.Text));
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Opening_form f4 = new Opening_form();
            f4.ShowDialog();
        }

      
  
            
        
    }
}
