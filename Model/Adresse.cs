using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class Adresse
    {
        public int Id { get; set; }
        public string AdresseDetail { get; set; }

        public ICollection<AssocAdresseClient> AssocAdresseClients { get; set; }
    }
}
