using AutomatizationDocs.Data.Entity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizationDocs.Logic.DTOModels.Clients
{
    public class DTOClient
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DTOAdress Adress { get; set; }

        public DTOPassport Passport { get; set; }

        public DTOIdNumber? IdNumber { get; set; }

        public Dictionary<string, string> OtherConnections { get; set; }

        public Guid IdentityUser { get; set; }
    }
}
