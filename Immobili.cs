using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImmobili
{
    public class Immobili
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public int Prezzo { get; set; }
        public int Iva { get; set; }
        public Immobili(string nome, string descrizione , int prezzo , int iva)
        {
            this.Nome = nome;
            this.Descrizione = descrizione; 
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

    }
}
