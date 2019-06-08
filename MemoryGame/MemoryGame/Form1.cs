using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        PictureBox card1;
        PictureBox card2;
        string[] a = new string[8]; //string gia na peraso tis loaded eikones mesa
        int tries; //gia na metriso tis prospathies
        int t;
        //metavliti gia na katalavume an paizei me tis arxikes 'h me loaded eikones
        bool p = false;

        //ftiaxno antikeimena ton klasewn random_pics kai lphotos
        random_pics object_random = new random_pics(); 
        lphotos object_load = new lphotos();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //gia tis prospatheies
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me tis eikones tou sistimatos
            if (p == false)
            {
                pictureBox1.Image = Properties.Resources.dolphin;
            }
            //an to paixnidi paizetai me loaded eikones
            else
            {
                pictureBox1.Image = Image.FromFile(a[0]);
            }
            if (card1 == null)
            {
                card1 = pictureBox1;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox1;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            if (p == false)
            {
                pictureBox2.Image = Properties.Resources.dolphin;
            }
            else
            {
                pictureBox2.Image = Image.FromFile(a[0]);
            }
            if (card1 == null)
            {
                card1 = pictureBox2;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox2;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox2.Enabled = false;
                    pictureBox1.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox3.Image = Properties.Resources.fish;
            }
            else
            {
                pictureBox3.Image = Image.FromFile(a[1]);
            }
            if (card1 == null)
            {
                card1 = pictureBox3;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox3;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox4.Image = Properties.Resources.fish;
            }
            else
            {
                pictureBox4.Image = Image.FromFile(a[1]);
            }
            if (card1 == null)
            {
                card1 = pictureBox4;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox4;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox4.Enabled = false;
                    pictureBox3.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox6.Image = Properties.Resources.fish1;
            }
            else
            {
                pictureBox6.Image = Image.FromFile(a[2]);
            }
            if (card1 == null)
            {
                card1 = pictureBox6;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox6;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox6.Enabled = false;
                    pictureBox5.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox5.Image = Properties.Resources.fish1;
            }
            else
            {
                pictureBox5.Image = Image.FromFile(a[2]);
            }
            if (card1 == null)
            {
                card1 = pictureBox5;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox5;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox7.Image = Properties.Resources.penguin;
            }
            else
            {
                pictureBox7.Image = Image.FromFile(a[3]);
            }
            if (card1 == null)
            {
                card1 = pictureBox7;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox7;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox8.Image = Properties.Resources.penguin;
            }
            else
            {
                pictureBox8.Image = Image.FromFile(a[3]);
            }
            if (card1 == null)
            {
                card1 = pictureBox8;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox8;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox8.Enabled = false;
                    pictureBox7.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox9.Image = Properties.Resources.seahorse;
            }
            else
            {
                pictureBox9.Image = Image.FromFile(a[4]);
            }
            if (card1 == null)
            {
                card1 = pictureBox9;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox9;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox10.Image = Properties.Resources.seahorse;
            }
            else
            {
                pictureBox10.Image = Image.FromFile(a[4]);
            }
            if (card1 == null)
            {
                card1 = pictureBox10;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox10;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox10.Enabled = false;
                    pictureBox9.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox11.Image = Properties.Resources.seal;
            }
            else
            {
                pictureBox11.Image = Image.FromFile(a[5]);
            }
            if (card1 == null)
            {
                card1 = pictureBox11;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox11;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox12.Image = Properties.Resources.seal; 
            }
            else
            {
                pictureBox12.Image = Image.FromFile(a[5]);
            }
            if (card1 == null)
            {
                card1 = pictureBox12;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox12;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox12.Enabled = false;
                    pictureBox11.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox13.Image = Properties.Resources.whale;
            }
            else
            {
                pictureBox13.Image = Image.FromFile(a[6]);
            }
            if (card1 == null)
            {
                card1 = pictureBox13;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox13;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox14.Image = Properties.Resources.whale;
            }
            else
            {
                pictureBox14.Image = Image.FromFile(a[6]);
            }
            if (card1 == null)
            {
                card1 = pictureBox14;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox14;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox14.Enabled = false;
                    pictureBox13.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox15.Image = Properties.Resources.shark;
            }
            else
            {
                pictureBox15.Image = Image.FromFile(a[7]);
            }
            if (card1 == null)
            {
                card1 = pictureBox15;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox15;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            tries++;
            label6.Text = tries.ToString();
            //an to paixnidi paizetai me ton klassiko tropo
            if (p == false)
            {
                pictureBox16.Image = Properties.Resources.shark;
            }
            else
            {
                pictureBox16.Image = Image.FromFile(a[7]);
            }
            if (card1 == null)
            {
                card1 = pictureBox16;
            }
            if (card1 != null && card2 == null)
            {
                card2 = pictureBox16;
            }
            //gia to diplo click sto picturebox
            if (card1 == card2)
            {
                card2 = null;
            }
            if (card1 != null && card2 != null)
            {
                //skor
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
                if (card1.Tag == card2.Tag)
                {
                    card1 = null;
                    card2 = null;
                    pictureBox16.Enabled = false;
                    pictureBox15.Enabled = false;
                }
                else
                {
                    //afairo 1 apo to skor logo lathous
                    label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                    //o timer 2 afhnei anoixta ta picturebox gia poly ligo mexri na ksanakleisun
                    timer2.Start();
                }
            }
        }
        //gia na meinoun anoikta ta picturebox gia poly ligo kai meta na ksanakleisoun se periptosi lathous
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            card1.Image = Properties.Resources.cover;
            card2.Image = Properties.Resources.cover;
            card1 = null;
            card2 = null;
        }
        //to play koumpi
        private void button1_Click(object sender, EventArgs e)
        {
            t = 0;
            label2.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
            //h synarthsh pu anakateyei thn seira twn picturebox
            object_random.rand(panel1);  //kalo thn sunartisi rand tou random_pics gia na anakatepso tis eikones 
            timer1.Enabled = true;
        }
        //o xronos
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            label4.Text = t.ToString();
            //ta picturebox pu einai anoixta
            int b = 0;
            //kanw elegxo kathe deyterolepto gia to posa picturebox einai anoixta etsi wste na kserw pote tha teleiwsei to paixnidi
            foreach (PictureBox picture in panel1.Controls)
            {
                if (picture.Enabled == false)
                {
                    b++;
                }
            }
            //an teleiwsei to paixnidi simainei oti ta anoixta picturebox einai 16 ara stamata to paixnidi
            if (b == 16) //teleiose to paixnidi
            {
                timer1.Stop();
                //deixno poso xrono kai poses prospatheies ekane
                MessageBox.Show("Time:   " + label4.Text + "\n" + "Tries:   " + tries);
                //anoigw tn forma gameover kai pernao to score pou edo einai to label2 sto gameover kai apo ekei tha paei sthn bash
                username u = new username(label2.Text);
                u.ShowDialog();   
                t = 0;
                label6.Text = "0";
                label2.Text = "0";
                label4.Text = "0";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //gia na fortoso eikones
        private void loadPhotosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t = 0;
            label6.Text = "0";
            label2.Text = "0";
            timer1.Stop();
            a = object_load.load_photos(p); //kalo antikeimena pou eftiaksa noritera 
            p = object_load.return_bool();
        }
        //gia na figoun oi loaded eikones apo to paixnidi
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You haven't loaded any photos,play Start if you want to play again");
            timer1.Stop();
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
                picture.Cursor = Cursors.Hand;//gia to pote tha energopoieitai to xeraki ston kersora.diladi twra energopoieitai otan stamata na metra o timer antistrofa
                picture.Image = Properties.Resources.cover;
            }
            p = false;
            Array.Clear(a, 0, a.Length);
            t = 0;
            label2.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
        }
        //gia na anoiksei h form2 me ta highscore
        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
