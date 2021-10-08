using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class Produit
    {
        public int Id { get; set; }
        public string Designation { get; set; }

        public  ICollection<LigneCommande> LignesCommandes { get; set; }

        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

    }
}
