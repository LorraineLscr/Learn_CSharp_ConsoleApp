using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nom, string adresse, int telephone)
        {
            InitializeComponent();
            name.Text = nom;
            adress.Text = adresse;
            //tel.ToString(telephone);
        }

        public class Client
        {
            public Client() { }
            public Client(string nom, string adresse, int telephone)
            {
                Nom = nom;
                Adresse = adresse;
                Telephone = telephone;
            }

            public string Nom { get; set; }
            public string Adresse { get; set; }

            public int Telephone { get; set; }
        }

        class ListClients
        {
            public static void ListeClients()
            {
                List<Form2.Client> clients = new List<Form2.Client>();

                clients.Add(new Form2.Client()
                {
                    Nom = "ELSYLOG",
                    Adresse = "1 RTE SAINT MARTIN 76590 DENESTANVILLE",
                    Telephone = 0232140200,
                });
                clients.Add(new Form2.Client()
                {
                    Nom = "INTERMARCHE",
                    Adresse = "975 RUE ROBERT LEFRANC 76510 SAINT NICOLAS D'ALIERMONT",
                    Telephone = 0235040444,
                });
                clients.Add(new Form2.Client()
                {
                    Nom = "E.LECLERC",
                    Adresse = "RUE DE LA GRANDE FLANDRE 76270 NEUFCHATEL EN BRAY",
                    Telephone = 0232975360,
                });
            }
        }

        private void telephone_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

    }
}


