using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione1Branch
{
    public class Produttore
    {
        private string nomeEtichetta;
        private int annoFondazione;

        public Produttore(string nomeEtichetta, int annoFondazione)
        {
            this.nomeEtichetta = nomeEtichetta;
            this.annoFondazione = annoFondazione;
        }

        public string GetInfoProduttore()
        {
            return $"Etichetta: {nomeEtichetta} (Fondata nel {annoFondazione})";
        }
    }
}