using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione1Branch
{
    public class Genere
    {
        private string nomeGenere;
        private string descrizione;

        public Genere(string nomeGenere, string descrizione)
        {
            this.nomeGenere = nomeGenere;
            this.descrizione = descrizione;
        }

        public string GetInfoGenere()
        {
            return $"Genere: {nomeGenere} - Info: {descrizione}";
        }
    }
}
