using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class AssocAdresseClient
    {
        public int Id { get; set; }


        public int AdresseId { get; set; }
        public Adresse Adresse{ get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
