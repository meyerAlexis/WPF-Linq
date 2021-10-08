using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class LigneCommande
    {
        public int Id { get; set; }
        public int Qte { get; set; }

        public int ProduitId { get; set; }
        public Produit Produit { get; set; }

        public int CommandeId { get; set; }
        public Commande Commande { get; set; }


    }
}
