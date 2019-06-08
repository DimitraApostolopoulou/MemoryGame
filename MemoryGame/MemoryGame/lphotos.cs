using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class lphotos
    {
        OleDbConnection conn = new OleDbConnection();
        string[] array = new string[8]; //o pinakas gia apothikeuso tis foto pou fortono apo ton upologisti

        //gia to load photos
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        bool n = false;//metavliti gia na katalavume an fortonoume photos 'h an paizoume kanonika

        public string[] load_photos(bool l)
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Database5.mdb";
            MessageBox.Show("Please select 8 photos");
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileNameAndPath = openFileDialog1.FileNames;
                //an oi fwtografies pu mu exeis fortwsei einai 8 tote vale ston pinaka to onoma kai to path ton photo
                if (fileNameAndPath.Length == 8)
                {
                    array = fileNameAndPath;
                    l = true;
                }
                else
                {
                    //an to plithos ton epilegmenon einai mikrotero 'h megalutero tou 8
                    MessageBox.Show("Please select 8 photos");
                }
                n = l;
            }

            return array;
        }

        public bool return_bool()
        {
            //gia na guriso thn metavliti bool kai na ksero an tha kano load 'h oxi
            return n;
        }
    }
}
