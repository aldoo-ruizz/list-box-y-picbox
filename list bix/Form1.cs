using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_bix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbanimales.Items.Add("Perro");
            lbanimales.Items.Add("Gato");
            lbanimales.Items.Add("Conejo");
            lbanimales.Items.Add("Pez");

        }

        private void lbanimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string animal = lbanimales.SelectedItem.ToString();
            switch (animal)
            {
                case "Perro":
                    pbanimales.Image = Image.FromFile("C:\\Users\\MiniLab-ing04\\source\\repos\\list bix\\list bix\\perros2_56d11542_800x800.jpg");
                    break;
                case "Gato":
                    pbanimales.Image = Image.FromFile("C:\\Users\\MiniLab-ing04\\source\\repos\\list bix\\list bix\\image.jpg");
                    break;
                case "Conejo":
                    pbanimales.Image = Image.FromFile("C:\\Users\\MiniLab-ing04\\source\\repos\\list bix\\list bix\\conejo.jpg");
                    break;
                case "Pez":
                    pbanimales.Image = Image.FromFile("C:\\Users\\MiniLab-ing04\\source\\repos\\list bix\\list bix\\pez.jpg");
                    break;
            }
        }
    }
}
