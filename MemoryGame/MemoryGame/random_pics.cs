using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class random_pics
    {
        Random r = new Random();
        //lista gia na vazw mesa ta location tu picturebox kai na ta anakateyei
        List<Point> picturebox_locations = new List<Point>();

        public void rand(Panel panel1)
        {
            foreach (PictureBox pic in panel1.Controls)
            {
                pic.Enabled = true;
                pic.Cursor = Cursors.Hand;
                pic.Image = Properties.Resources.cover;
                picturebox_locations.Add(pic.Location);//vazw stn lista kathe topothesia picturebox gia na ta anakatepsw meta
            }

            //gia to anakatema twn picturebox
            //(exw diaforetika for epeidh thelw prwta na mpun ola ta location kai ystera na kanw random)
            foreach (PictureBox pic in panel1.Controls)
            {
                int n = r.Next(picturebox_locations.Count); //to location einai h random metavliti r 
                Point p = picturebox_locations[n];
                pic.Location = p;
                picturebox_locations.Remove(p);//me to remove vgazw apo tn lista to location pu mphke random gia na meinei stn thesh pu anakateythke tn 1h fora random to picturebox
            }
        }
    }
}
