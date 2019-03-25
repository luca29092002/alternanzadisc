using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Item
    {
        public string elementoRicerca;
        public string primoUrl;
        public string secondoUrl;
        public string terzoUrl;
        public string quartoUrl;
        public string quintoUrl;
        public bool connessione;

        public static bool controlloConnessione()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
    

}
