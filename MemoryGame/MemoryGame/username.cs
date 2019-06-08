using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class username : Form
    {
        string score;
        OleDbConnection conn = new OleDbConnection();
        public username(string s)
        {
            score = s; //to s to exoume parei apo thn form1 os label2.Text
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Database1.mdb";
            InitializeComponent();
        }
        //h times pernane sthn basi mono otan patame new game
        private void button1_Click(object sender, EventArgs e)
        {
            //an to textbox1 den einai keno
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT into table1 (usernames,highscores) values('" + textBox1.Text + "','" + score + "')";
                //gia na kanw save sthn vash
                cmd.ExecuteNonQuery();

                //me to pu pathsw to new game kleinei h forma 
                this.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("please enter a username");
            }
        }
        //gia na mas paei sthn form2 pou exei ta highscore
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 highscores = new Form2();
            highscores.Show();
        }
    }
}
