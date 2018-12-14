using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameOf21
{
    public partial class Game21 : Form
    {       
        public Game21()
        {
            InitializeComponent();                        
        }

        public int DealCards(int Cards)
        {
            Random RNDCard = new Random();

            

            return Cards;
        }

        //moving the vaule form intro from to this form
        private void button1_Click(object sender, EventArgs e)
        {
            int totalbet = introGame21.totalbet;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int totalbet = introGame21.totalbet;
            label1.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        public void Game21_Load(object sender, EventArgs e)
        {
            //create an empty list of card images
            List<Image> listCardImages = new List<Image>();
            List<int> listCardValues = new List<int>();

            //card image to the list

            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);

            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);

            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);

            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);

            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);

            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);

            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);

            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);

            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);

            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);

            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JH);

            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);

            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);

            //list of card values

            listCardValues.Add(1);
            listCardValues.Add(1);
            listCardValues.Add(1);
            listCardValues.Add(1);

            listCardValues.Add(2);
            listCardValues.Add(2);
            listCardValues.Add(2);
            listCardValues.Add(2);

            listCardValues.Add(3);
            listCardValues.Add(3);
            listCardValues.Add(3);
            listCardValues.Add(3);

            listCardValues.Add(4);
            listCardValues.Add(4);
            listCardValues.Add(4);
            listCardValues.Add(4);

            listCardValues.Add(5);
            listCardValues.Add(5);
            listCardValues.Add(5);
            listCardValues.Add(5);

            listCardValues.Add(6);
            listCardValues.Add(6);
            listCardValues.Add(6);
            listCardValues.Add(6);

            listCardValues.Add(7);
            listCardValues.Add(7);
            listCardValues.Add(7);
            listCardValues.Add(7);

            listCardValues.Add(8);
            listCardValues.Add(8);
            listCardValues.Add(8);
            listCardValues.Add(8);

            listCardValues.Add(9);
            listCardValues.Add(9);
            listCardValues.Add(9);
            listCardValues.Add(9);
           
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
        }

        private void btnhit_Click(object sender, EventArgs e)
        {
            int hit = 0;


            hit = DealCards(hit);
        }
    }
}
