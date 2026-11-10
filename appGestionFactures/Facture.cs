using System;
namespace GestiondeFactures
{
    internal class Facture
    {
        public string NUM_DATA { get; set; }
        public decimal MNT_DATA { get; set; }

        public Facture(string NUM_DATA, decimal MNT_DATA)
        {
            this.MNT_DATA = MNT_DATA;
            this.NUM_DATA = NUM_DATA;
        }

    }
}

