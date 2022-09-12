using Biblio_Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Biblio_Clients.ClientManager cm = new ClientManager();
            cm.peuplerParDefaut();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) &&
                !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int i = lstNames.SelectedIndex;
            lstNames.Items.RemoveAt(i);
                MessageBox.Show("Bien Supprimé");
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstNames.FindString(txtName.Text);
            lstNames.SelectedIndex = index;
        }

        
        private void editer_Click(object sender, EventArgs e)
        {
            Form2 editer = new Form2();
            editer.Show(); 
        }
    }

}
