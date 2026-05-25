using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione1Branch
{
    public class Artista
    {
        private string nomeDArte;
        private string nazionalita;

        public Artista(string nomeDArte, string nazionalita)
        {
            this.nomeDArte = nomeDArte;
            this.nazionalita = nazionalita;
        }

        public string GetDettagli()
        {
            return $"Artista: {nomeDArte} ({nazionalita})";
        }
    }
}
