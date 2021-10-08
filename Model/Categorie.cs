using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public ICollection<Produit> Produits { get; set; }
    }
}
