using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione1Branch
{
    public class CD
    {
        
        private string titolo;
        private string autore;
        private List<Brano> listaBrani;
        
        public CD(string titolo, string autore)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.listaBrani = new List<Brano>(); 
        }

        public string GetTitolo() { return titolo; }
        public string GetAutore() { return autore; }
        public List<Brano> GetListaBrani() { return listaBrani; }

       
        public void SetTitolo(string titolo) { this.titolo = titolo; }
        public void SetAutore(string autore) { this.autore = autore; }


        public void AggiungiBrano(Brano brano)
        {
            listaBrani.Add(brano);
        }

    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"--- CD: {titolo} di {autore} ---");
            sb.AppendLine("Elenco dei brani:");
            if (listaBrani.Count == 0)
            {
                sb.AppendLine("(Nessun brano presente nel CD)");
            }
            else
            {
                foreach (Brano b in listaBrani)
                {
                    sb.AppendLine($"- {b.GetTitolo()}");
                }
            }
            return sb.ToString();
        }

       
        public int Durata()
        {
            int durataTotale = 0;
            foreach (Brano b in listaBrani)
            {
                durataTotale += b.GetDurata();
            }
            return durataTotale;
        }
    }
}
