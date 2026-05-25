using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione1Branch
{
    public class Custodia
    {
        private string materiale;
        private string colore;

        public Custodia(string materiale, string colore)
        {
            this.materiale = materiale;
            this.colore = colore;
        }

        public string GetDettagliCustodia()
        {
            return $"Custodia in {materiale}, Colore: {colore}";
        }
    }
}
