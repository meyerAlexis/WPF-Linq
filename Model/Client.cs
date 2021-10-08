using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Mail { get; set; }

        public ICollection<AssocAdresseClient> AssocAdresseClients { get; set; }
       
    }
}
