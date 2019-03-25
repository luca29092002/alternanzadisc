using System;
using System.Net;
using System.Net.Cache;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;



namespace WindowsFormsApp1
{
 


    public partial class Disk_Helper : Form
    {
        public Disk_Helper()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Ricerca();
          

        }

        private void searchItem_TextChanged(object sender, EventArgs e)
        {

        }
        public void Ricerca()
        {
            Item ricercaItem = new Item();
            ricercaItem.elementoRicerca = searchItem.Text;
            if(ricercaItem.elementoRicerca.Contains("<<zz<<"))
            {
                MessageBox.Show("Ricerca non disponibile, linguaggio non adeguato");
            }
            if(Item.controlloConnessione() == false)
            {
                MessageBox.Show("Connessione assente, utilizzare funzionalità offline ");
            }
            else
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create("http://www.google.com/");
                request.Credentials = CredentialCache.DefaultCredentials ;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                MessageBox.Show(((HttpWebResponse)response).StatusDescription);
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                MessageBox.Show(responseFromServer);

            }
        }
      
    }

}
