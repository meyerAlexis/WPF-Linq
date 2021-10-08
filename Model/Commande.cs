using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class Commande
    {
        public int Id { get; set; }


        public ICollection<LigneCommande> LignesCommandes { get; set; }

    }
}
