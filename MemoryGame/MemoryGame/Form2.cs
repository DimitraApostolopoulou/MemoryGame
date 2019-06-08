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
    public partial class Form2 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Form2()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Database1.mdb";
            InitializeComponent();
        }
        //gia na kleiso thn forma 2
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            //to *1 einai sindiasmos xarakthrwn pu metatrepun tn sthlh apo string se int
            string query = "SELECT * from Table1 ORDER BY highscores *1 ASC";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader rdr = cmd.ExecuteReader();
            int a = 0;
            while (rdr.Read())
            {
                //diavazw to username kai to score kai ta vazw se string
                string[] r = { rdr.GetString(1), rdr.GetString(2) };
                //antikeimeno pu ta grafei sto listview kathe grammh pu diavazei apo tn vash
                ListViewItem n = new ListViewItem(r);
                listView1.Items.Add(n);
                a++;
                //thelw ta 10 prwta highscore
                if (a == 10)
                {
                    break;
                }
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
