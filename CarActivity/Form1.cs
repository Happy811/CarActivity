using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarActivity
{
    
    public partial class Form1 : Form
    { 
         Lexus Lux;
    BMW Bim;
    Toyota Toy;
    Mercedes  Mera;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lux = new Lexus("LexusName", LexusPicture);
           Bim = new BMW("BMWName", BMWPicture);
            Toy  = new Toyota("ToyotaName", ToyotaPicture);
            Mera = new Mercedes("MercedesName", MercedesPicture);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (Lux.Picture.Location.Y < 600 &&
               Bim.Picture.Location.Y < 600 &&
               Toy.Picture.Location.Y < 600 &&
               Mera.Picture.Location.Y < 600)
            {
                Lux.Move(rand.Next(2, 20));
                Bim.Move(rand.Next(2, 20));
                Toy.Move(rand.Next(2, 20));
                Mera.Move(rand.Next(2, 20));
            }
            else
            {
                string winner = "";
                for (int i = 0; i < 4; i++)
                {
                    if (Lux.Picture.Location.Y >= 600)
                    {
                        winner = Lux.Name;
                    }
                    else if (Bim.Picture.Location.Y >= 600)
                    {
                        winner = Bim.Name;
                    }
                    else if (Toy.Picture.Location.Y >= 600)
                    {
                        winner = Toy.Name;
                    }
                    else if (Mera.Picture.Location.Y >= 600)
                    {
                        winner = Mera.Name;
                    }
                    else
                    {
                        winner = "Something wents wrong!";
                    }

                }
                MessageBox.Show("The race is finished and the winner is " + winner);
            }
           
        }
    }
}

