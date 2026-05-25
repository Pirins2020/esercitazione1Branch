using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione1Branch
{
    public class Brano
    {
        
        private string titolo;
        private string autore;
        private int durata;
        public Brano(string titolo, string autore, int durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

       
        public string GetTitolo() { return titolo; }
        public string GetAutore() { return autore; }
        public int GetDurata() { return durata; }

        
        public void SetTitolo(string titolo) { this.titolo = titolo; }
        public void SetAutore(string autore) { this.autore = autore; }
        public void SetDurata(int durata) { this.durata = durata; }

        
        public override string ToString()
        {
            return $"[Brano] Titolo: {titolo} | Autore: {autore} | Durata: {durata} secondi";
        }

        
        public bool ShortSong(int durataLimite)
        {
            return this.durata < durataLimite;
        }
    }
}
